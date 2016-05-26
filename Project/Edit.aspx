<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Job:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Info:"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Height="205px" Width="278px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Wellington</asp:ListItem>
        <asp:ListItem>Auckland</asp:ListItem>
        <asp:ListItem>Hamilton</asp:ListItem>
        <asp:ListItem>Otaki</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Accept Changes" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Label" Visible ="false"></asp:Label>
    <br />
    <br />
    <br />
</asp:Content>

