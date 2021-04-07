<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucHeader.ascx.cs" Inherits="HW3.ucHeader" %>

<style>
    .top {
        display: flex;
        flex-direction: row;
        background-color: #f0f0f0;
        width: 100%;
        height: 100%;
    }

    .lefttop {
        width: 15%;
        background-color: #f08bc3;
        margin: 5px;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .topcenter {
        width: 80%;
        background-color: #f08bc3;
        margin: 5px;
        display: flex;
        justify-content: center;
        align-items: center;
    }

    .login {
        width: 10%;
        height:90px;
        background-color: #f08bc3;
        margin: 5px;
        display: flex;
        justify-content: center;
        align-items: center;
    }
</style>

<div class="top">
    <div class="lefttop">
        <a href="HomePage.aspx">
            <img src="Utilityfile/news20171201_001.png" /></a>
    </div>

    <div class="topcenter">
        <a href="HomePage.aspx">
            <h1>宥倍實業股份有限公司</h1>
        </a>
    </div>
    <div class="login">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"><a href="Login.aspx">登入</a>
        </asp:PlaceHolder>
    </div>
</div>
