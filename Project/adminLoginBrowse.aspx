<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.master" AutoEventWireup="true" CodeFile="adminLoginBrowse.aspx.cs" Inherits="adminLoginBrowse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show All" />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" Width="94px" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Height="247px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="264px"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
</asp:Content>

