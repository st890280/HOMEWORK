<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFooter.ascx.cs" Inherits="HW3.WebUserControl11" %>

<style>
    .privacypage {
        display: flex;
        flex-direction:column;
        width: 20%;
        height:100%;
        font-size: 18px;
        line-height: 30px;
        text-align:center;


    }

    .info {
        margin: auto;
        color: white;
        width: 40%;
        height: 88%;
        line-height: 25px;
        display: flex;
    }

</style>



    <div class="info">
        <h2 style="font-family: Arial;">UBAY株式会社</h2>
        <ul>
            <li>
                <i class="icon-pointer c-theme-font"></i>〒110-0016
                <span class="c-font-14">東京都台東区台東4丁目31-6-3F SAKATA BLD.</span>
            </li>
            <li>
                <i class="icon-call-end c-theme-font"></i>03-6667-9380						
            </li>
            <li>
                <i class="fa fa-fax c-theme-font"></i>03-6667-9382						
            </li>
            <li>
                <i class="icon-envelope c-theme-font"></i>info@ubay.co.jp　　						
            </li>
            <li>
                <i class="icon-home c-theme-font"></i>www.ubay.co.jp						
            </li>
        </ul>
        <p>
            &nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;Copyright © UBAY Co., Ltd. All rights reserved.			
        </p>
    </div>
    <div class="privacypage">
        <asp:PlaceHolder ID="PlaceHolder3" runat="server">

            <a href="privacypage.aspx" style="color: white">隱私權保護宣告</a>

            <a href="PersonalInformationProtectionDeclaration.aspx" style="color: white">Personal-Information-Protection-Declaration</a>

        </asp:PlaceHolder>
    </div>


