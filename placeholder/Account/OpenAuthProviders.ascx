<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpenAuthProviders.ascx.cs" Inherits="placeholder.Account.OpenAuthProviders" %>

<fieldset class="open-auth-providers">
    <legend>Mit einem anderen Dienst anmelden</legend>
    
    <asp:ListView runat="server" ID="providerDetails" ItemType="Microsoft.AspNet.Membership.OpenAuth.ProviderDetails"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <button type="submit" name="provider" value="<%#: Item.ProviderName %>"
                title="Anmelden mithilfe Ihres <%#: Item.ProviderDisplayName %> Kontos.">
                <%#: Item.ProviderDisplayName %>
            </button>
        </ItemTemplate>
    
        <EmptyDataTemplate>
            <div class="message-info">
                <p>Es sind keine externen Authentifizierungsdienste konfiguriert. In <a href="http://go.microsoft.com/fwlink/?LinkId=252803">diesem Artikel</a> finden Sie weitere Informationen zum Einrichten dieser ASP.NET-Anwendung für die Unterstützung der Anmeldung über externe Dienste.</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</fieldset>