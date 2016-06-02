<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        blackborder {
            background-color: #000000;
        }
        #form1 {
            width: 182px;
            height: 366px;
        }
    </style>
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</head>
   
<body>
    <form id="form1" runat="server">
       <asp:Label ID="Label3" runat="server" Text="Welcome to the Happy Homes Application, Please Login Here"></asp:Label>

        <br />

        &nbsp;<br />
        <asp:Label ID="Label4" runat="server" Text="ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="id" runat="server"></asp:TextBox>

        <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Admin:"></asp:Label>
        <asp:CheckBox ID="Admin" runat="server" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log In" />
          
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
          
        
          
        <br />
        <br />
          
        
          
    </form>
        </body>
</html>
