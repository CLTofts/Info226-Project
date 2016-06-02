<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="adminMain.aspx.cs" Inherits="adminMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Happy Homes Admin main page"></asp:Label>
    <p>
    </p>
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
</asp:Content>

