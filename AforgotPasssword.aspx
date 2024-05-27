<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="AforgotPasssword.aspx.cs" Inherits="PG_Project.AforgotPasssword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-left: 500px; padding-left:20px;">
        <h3>User Password Recovery</h3>

    <p>
        <br />
<asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
<br />

        <asp:TextBox ID="Txtemail" runat="server" TextMode="Email"></asp:TextBox>
    </p><br />

    <p>
        <asp:Button ID="Btnsubmit" runat="server" CausesValidation="False" Text="Submit" OnClick="Btnsubmit_Click" />
      &nbsp;&nbsp;
        <asp:Button ID="Btnreset" runat="server" CausesValidation="False" OnClick="Btnreset_Click" Text="Reset" />
    </p>
            </div><br /><Br />
</asp:Content>
