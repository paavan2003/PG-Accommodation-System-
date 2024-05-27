<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="UforgotPassword.aspx.cs" Inherits="PG_Project.UforgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-left: 500px; padding-left:20px;">
        <h3>User Password Recovery</h3><br />

    <p>
    <p>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>

        <asp:TextBox ID="Txtemail" runat="server" TextMode="Email"></asp:TextBox>
    </p>
         <p>
             &nbsp;</p>
    <p>
        <asp:Button ID="Btnsubmit" runat="server" CausesValidation="False" Text="Submit" OnClick="Btnsubmit_Click" />
      &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CausesValidation="False" OnClick="Button2_Click" Text="Reset" />
    </p>
         
         </div><br /><Br />
</asp:Content>
