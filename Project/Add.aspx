﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
    <asp:TextBox ID="addName" runat="server" Width="179px"></asp:TextBox>
    &nbsp;
    <p style="width: 298px">
        <asp:Label ID="Label2" runat="server" Text="Job:"></asp:Label>
        <asp:TextBox ID="addJob" runat="server" Width="201px"></asp:TextBox>
    </p>
    <asp:Label ID="Label3" runat="server" Text="Info:"></asp:Label>
    <asp:TextBox ID="addInfo" runat="server" Width="288px" Height="280px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="City:"></asp:Label>
    <asp:DropDownList ID="addCity" runat="server">
        <asp:ListItem>Wellington</asp:ListItem>
        <asp:ListItem>Auckland</asp:ListItem>
        <asp:ListItem>Hamilton</asp:ListItem>
        <asp:ListItem>Otaki</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    <br />
    <br />
    <asp:Label ID="Responce" runat="server" Text="Label" Visible ="False"></asp:Label>
    <br />
    <br />
    <asp:Label ID="number" runat="server" Text="Label" Visible="False"></asp:Label>
</asp:Content>

