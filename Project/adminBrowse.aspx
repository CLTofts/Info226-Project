﻿<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.master" AutoEventWireup="true" CodeFile="adminBrowse.aspx.cs" Inherits="adminBrowse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;<br />&nbsp;
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="300px" Height="290px" Font-Size="15pt"></asp:ListBox>
    &nbsp;<asp:Button ID="editButton" runat="server" OnClick="editButton_Click" Text="Edit" />
<asp:Button ID="Button1" runat="server" OnClick="DeleteButton_Click1" Text="Delete" Visible="False" />
&nbsp;&nbsp; 
</asp:Content>
