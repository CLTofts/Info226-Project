<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registerNew.aspx.cs" Inherits="registerNew" %>
<link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Register Page"></asp:Label>
        <p>
            <asp:Label ID="Label4" runat="server" Text="ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id" runat="server" style="margin-left: 3px" Width="120px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 4px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 3px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Admin:"></asp:Label>
        <asp:CheckBox ID="Admin" runat="server" OnCheckedChanged="Admin_CheckedChanged" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
    
    </div>
    </form>
</body>
</html>
