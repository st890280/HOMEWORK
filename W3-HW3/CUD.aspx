<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CUD.aspx.cs" Inherits="HW3.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:PlaceHolder runat="server" ID="plc1">
        <style type="text/css">
            .dataconsole {
                font-size: 22px;
                text-align: right;
                background-color: cadetblue;
                width: 23%;
                margin-left:auto;
                margin-right:45%;
                
            }

            .pusher {
                display:flex;
                background-color:coral;
                margin-left:auto;
                margin-right:auto;
                font-size:22px;
            }
            .cud{
                display:flex;
                flex-direction:column;
                height:100%;
                width:100%;
                align-items:center;
                background-color:aqua;
            }
        </style>
        <div class="cud">
            <div class="dataconsole">
                ID:<asp:TextBox ID="txtID" runat="server" TextMode="Number" style="width:200px;height:30px;"></asp:TextBox><br />
                FirstName:<asp:TextBox ID="txtfirstname" runat="server" style="width:200px;height:30px;"></asp:TextBox><br />
                LastName:<asp:TextBox ID="txtlastname" runat="server" style="width:200px;height:30px;"></asp:TextBox><br />
                Account:<asp:TextBox ID="txtaccount" runat="server" style="width:200px;height:30px;"></asp:TextBox><br />
                Password:<asp:TextBox ID="txtpassword" runat="server" TextMode="Password" style="width:200px;height:30px;"></asp:TextBox><br />
                Birthday:<asp:TextBox ID="txtBirthday" runat="server" TextMode="Date" style="width:200px;height:30px;"></asp:TextBox><br />
                Email:<asp:TextBox ID="txtemail" runat="server" TextMode="Email" style="width:200px;height:30px;"></asp:TextBox><br />
                Cellphone:<asp:TextBox ID="txtcellphone" runat="server" style="width:200px;height:30px;"></asp:TextBox><br />
                Address:<asp:TextBox ID="txtaddress" runat="server" style="width:200px;height:30px;"></asp:TextBox><br />

                <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" style="font-size:20px;"/>
                <asp:Button ID="Button3" runat="server" Text="查詢" OnClick="Button3_Click" style="font-size:20px;"/>
                <asp:Button ID="Button2" runat="server" Text="刪除" OnClick="Button2_Click" style="font-size:20px;"/>
                <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Button4_Click" style="font-size:20px;"/>
                <asp:Button ID="Button5" runat="server" Text="顯示所有資料" OnClick="Button5_Click" style="font-size:20px;"/>

            </div>
            <div class="pusher">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>

    </asp:PlaceHolder>
</asp:Content>

