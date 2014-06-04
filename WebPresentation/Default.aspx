<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AASDSearch.Web._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table style="width:100%;">
            <tr>
                <td align="center" bgcolor="#99CCFF" colspan="2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Georgia"
                        Text="SEARCH ENGINE"></asp:Label>
                </td>
            </tr>
            <tr>
                <td width="80px">
                    &nbsp;</td>
                <td height="40px">
                    <asp:TextBox ID="TextBoxSearch" runat="server" Height="30px" Width="639px"></asp:TextBox>
                    <asp:Button ID="ButtonSearch" runat="server" Font-Bold="True" Font-Names="Georgia"
                        Height="30px" Text="Search" Width="65px" onclick="ButtonSearch_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr />
                    </td>
            </tr>
            <tr>
                <td style="border-color: #999999">&nbsp;</td>
                <td style="border-color: #999999">
                    <asp:GridView ID="GridViewSearchResult" runat="server"
                        AutoGenerateColumns="false" ShowHeader="false" Width="712px"
                        BorderColor="White">
                    <Columns>
                    <asp:TemplateField>
 
                        <ItemTemplate>
                            <asp:Label ID="lblTitle" runat="server" Text='<%# Bind("Title") %>'
                                Font-Size="Large"></asp:Label>
                            <br />
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Bind("Url") %>'><%#Eval("Url") %></asp:HyperLink>
                            <br />
                            <asp:Label ID="lblDescription" runat="server" Text='<%# Bind("Description") %>'></asp:Label>
                            <br />
                            <br />
                        </ItemTemplate>
 
                    </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
   
    
    </div>
    </form>
</body>
</html>
