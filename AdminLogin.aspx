<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="PG_Project.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div style="margin-left: 500px; padding-left:20px;">
        <h3>Admin Login </h3><br />

    <p>
       

        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TxtEmail" runat="server" TextMode="Email"></asp:TextBox>
    </p>
    <p>
        
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
       <br />
        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:HyperLink ID="frgtpswrd" runat="server" NavigateUrl="~/AforgotPasssword.aspx">Forgot Password?</asp:HyperLink>
    </p>
        <br />

    <p>
        <asp:Button ID="BtnLogin" runat="server" CausesValidation="False" Text="Login" OnClick="BtnLogin_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="BtnReset" runat="server" CausesValidation="False" OnClick="BtnReset_Click" Text="Reset" />
    </p><br />
        <br />
            </div>

</asp:Content>
