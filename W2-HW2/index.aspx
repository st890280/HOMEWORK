<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplicationDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        ID:<asp:TextBox ID="txtID" runat="server" textmode="Number"></asp:TextBox><br/>
        FirstName:<asp:TextBox ID="txtfirstname" runat="server" ></asp:TextBox><br/>
        LastName:<asp:TextBox ID="txtlastname" runat="server" ></asp:TextBox><br/>
        Account:<asp:TextBox ID="txtaccount" runat="server" ></asp:TextBox><br/>
        Password:<asp:TextBox ID="txtpassword" runat="server" textmode="Password"></asp:TextBox><br/>
        Birthday:<asp:TextBox ID="txtBirthday" runat="server" textmode="Date"></asp:TextBox><br/>
        Email:<asp:TextBox ID="txtemail" runat="server" textmode="Email"></asp:TextBox><br/>
        Cellphone:<asp:TextBox ID="txtcellphone" runat="server" ></asp:TextBox><br/>
        Address:<asp:TextBox ID="txtaddress" runat="server" ></asp:TextBox><br/>


        

        <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click"/>
        <asp:Button ID="Button3" runat="server" Text="查詢" OnClick="Button3_Click"/>
        <asp:Button ID="Button2" runat="server" Text="刪除" OnClick="Button2_Click"/>
        <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="顯示所有資料" OnClick="Button5_Click" />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>
