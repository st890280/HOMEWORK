<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HW3.WebForm1" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PlaceHolder runat="server" ID="plc1">
        <style type="text/css">
            .loginbody {
                font-size: 20px;
                text-align: right;
                background-color: cadetblue;
                height: 100%;
                width: 53%;
            }

            .loginpush {
                width: 47%;
                display: flex;
            }
        </style>
        <div class="loginbody">
            帳號:
            <asp:TextBox ID="txtAccount" runat="server"></asp:TextBox><br />
            密碼:
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Literal ID="ltMessage" runat="server"></asp:Literal><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
        <div class="loginpush"></div>
    </asp:PlaceHolder>
</asp:Content>
