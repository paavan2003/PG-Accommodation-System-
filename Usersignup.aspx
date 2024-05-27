<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Usersignup.aspx.cs" Inherits="PG_Project.Usersignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <div style="margin-left: 500px; padding-left:20px;">
    <h3>Create New User </h3><br />
    <br />
    <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="txtname" runat="server" Width="284px"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="txtaddress" runat="server" Width="268px"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblcontact" runat="server" Text="Contact"></asp:Label>
    <asp:TextBox ID="txtcontact" runat="server" Width="144px"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="txtemail" runat="server" Width="223px"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblretypepssword" runat="server" Text="Retypepassword"></asp:Label>
    <asp:TextBox ID="txtretypepassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnsubmit" runat="server" Text="submit"  OnClick="btnsubmit_Click"/>
    <asp:Button ID="btnreset" runat="server" Text="reset" />
        </div>
    </asp:Content>




     


