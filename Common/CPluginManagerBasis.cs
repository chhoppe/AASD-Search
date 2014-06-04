﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASDSearch.Common
{
    public class CPluginManagerBasis<T>
    {
        /// <summary>
        /// internal plugin list
        /// </summary>
        private List<Type> _pluginList;
        /// <summary>
        /// internal lock state
        /// </summary>
        private bool _locked;

        /// <summary>
        /// basic contructor
        /// </summary>
        public CPluginManagerBasis ( )
        {
            _locked = false;
            _pluginList = new List<Type>();
            
        }

        /// <summary>
        /// lock the list of plugins, used after initialization
        /// </summary>
        public void Lock()
        {
            _locked = true;
        }
        /// <summary>
        /// register a Plugin for this Manager, can only be done before locking
        /// </summary>
        /// <param name="PluginType"></param>
        public void registerPlugin(Type PluginType)
        {
            if (!_locked)
            {
                if (! _pluginList.Exists( x => x == PluginType) )
                    _pluginList.Add(PluginType);
            }
        }

        /// <summary>
        /// process a Searchrequest through all plugins in this manager
        /// </summary>
        /// <param name="pSearchRequest">Searchrequest to  process</param>
        async public void processAsync(Common.CSearchRequest pSearchRequest)
        {
            await Task.Run(() =>
            {
                /// Error because the Manager should be locked before use
                if (!_locked)
                {
                    pSearchRequest.GotError = true;
                    pSearchRequest.ErrorMsg = String.Format("PluginManager {0} not yet locked.", this.GetType().Name);
                }
                else // Manager is locked and rdy for use
                {
                    // create handler
                    CPluginMngProcessHandler<T> handler = new CPluginMngProcessHandler<T>(pSearchRequest);
                    // create of plugin objects
                    foreach (Type plugin in _pluginList)
                    {
                        T pluginObj = (T)Activator.CreateInstance(plugin);
                        handler.plugins.Add(pluginObj);
                    }
                    startprocess(handler); // to start each plugin process
                    cleanupprocess(handler); // cleanup
	            }
            });
        }
        /// <summary>
        /// start the process of each plugin
        /// can be overwritten to add plugin type specific handling
        /// will be called within a thread from the Manager.process
        /// </summary>
        /// <param name="phandler"></param>
        private void startprocess(CPluginMngProcessHandler<T> phandler)
        {
            foreach (T plugin in phandler.plugins)
            {
                ((IPluginGeneralInfo)plugin).processAsync(phandler.request);     
            }
        }
        /// <summary>
        /// cleanup of each plugin
        /// can be overwritten to add plugin type specific handling
        /// will be called within a thread from the Manager.process
        /// </summary>
        /// <param name="phandler"></param>
        private void cleanupprocess(CPluginMngProcessHandler<T> phandler)
        {
            foreach (T plugin in phandler.plugins)
            {
                // cleanup stuff, for now let the GC do it
            }
        }
    }
}
