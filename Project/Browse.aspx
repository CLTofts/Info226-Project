﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="Browse.aspx.cs" Inherits="Browse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show All" />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="300px" Height="290px" Font-Size="15pt"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" style="margin-top: 0px" Text="Select" />
&nbsp;<asp:Button ID="editButton" runat="server" OnClick="editButton_Click" Text="Edit" Width="47px" Visible="False" />
    &nbsp;<asp:Button ID="deleteButton" runat="server" OnClick="DeleteButton_Click1" Text="Delete" Visible="False" Width="59px" />
</asp:Content>

