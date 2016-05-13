<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="AetherPal.Control.Presentation.AnchorSite.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label runat="server" ID="lblHelloWorld" Text="Hello, world!" />
        
       <%--<Label runat="server" ID="Label1" Text="<%: AetherPal.Control.Presentation.AnchorSite.LocalizationModule.GetPropertyValue("UnableClient")%>" />--%>
        <p><%:AetherPal.Control.Presentation.AnchorSite.LocalizationModule.GetPropertyValue("UnableClient")%></p>
       <input type="submit" name="accept" value="<%: AetherPal.Control.Presentation.AnchorSite.LocalizationModule.GetPropertyValue("Accept")%>" style="margin-top: 15px" />

        <br /><br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/subpage.aspx">Page 1</asp:HyperLink>
    </div>
    </form>
</body>
</html>
