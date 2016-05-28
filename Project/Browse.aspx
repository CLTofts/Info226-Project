<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="Browse.aspx.cs" Inherits="Browse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="browseButton" runat="server" Text="Browse" OnClick="browseButton_Click" />
    &nbsp;&nbsp;<br />
    &nbsp;
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="300px" Height="300" Font-Size="15pt"></asp:ListBox>
    <asp:Button ID="editButton" runat="server" OnClick="editButton_Click" Text="Edit" />
</asp:Content>

