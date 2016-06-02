<%@ Page Title="" Language="C#" MasterPageFile="~/Menubar.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="StyleSheet3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="addId" runat="server" ReadOnly ="true"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="addName" runat="server" Width="159px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Address:"></asp:Label>
    <asp:TextBox ID="addAddress" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Company:"></asp:Label>
    <asp:TextBox ID="addBuilding" runat="server"></asp:TextBox>
    <p style="width: 391px">
        <asp:Label ID="Label5" runat="server" Text="Job:"></asp:Label>
        &nbsp;<asp:TextBox ID="addJob" runat="server" Width="256px" OnTextChanged="addJob_TextChanged" style="margin-left: 50px"></asp:TextBox>
    </p>
    <p style="width: 391px">
        <asp:Label ID="Label8" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="FuUpload" runat="server" />
    </p>
    <p style="width: 391px">
        <asp:Label ID="Warning" runat="server" Text="Warning"></asp:Label>
    </p>
    <asp:Label ID="Label6" runat="server" Text="Info:"></asp:Label>
    <asp:TextBox ID="addInfo" runat="server" Width="288px" Height="280px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="City:"></asp:Label>
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
    <asp:Label ID="Response" runat="server" Text="Label" Visible ="False"></asp:Label>
</asp:Content>

