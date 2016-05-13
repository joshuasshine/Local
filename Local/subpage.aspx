<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="subpage.aspx.cs" Inherits="AnchorSite.subpage" %>

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
      

        <button id="Button1" OnServerClick="Button1_OnClick" runat="server"><%: AetherPal.Control.Presentation.AnchorSite.LocalizationModule.GetPropertyValue("ClickHere")%></button>
       
    </div>
       
    </form>


</body>
</html>
