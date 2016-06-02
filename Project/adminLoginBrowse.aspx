<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.master" AutoEventWireup="true" CodeFile="adminLoginBrowse.aspx.cs" Inherits="adminLoginBrowse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="ListBox1" runat="server" Height="247px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="213px"></asp:ListBox>
</asp:Content>

