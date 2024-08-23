<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Myproject.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

 <asp:Button ID="BtnTestConnection" runat="server" Text="Test Connection" OnClick="BtnTestConnection_Click" />
<asp:Label ID="lblConnectionStatus" runat="server" Text="" ForeColor="Red" />

    </div>
    </form>
</body>
</html>
