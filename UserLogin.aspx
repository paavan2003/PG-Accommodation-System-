<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="PG_Project.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left: 500px; padding-left:20px;">
        <h3>User Login </h3><br />

    <p>
       
<asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
<Br />
        <asp:TextBox ID="Txtemail" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="Txtpassword" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UforgotPassword.aspx">Forgot Password?</asp:HyperLink>
    </p>
       <br />
    <p> <asp:Button ID="Btnlogin" runat="server" Text="Login" OnClick="Btnlogin_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btnreset" runat="server" CausesValidation="False"  Text="Reset" />
    </p>
        <p> <a href="Usersignup.aspx">New User ?</a></p>
         </div><br /><Br />
</asp:Content>
