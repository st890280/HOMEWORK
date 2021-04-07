<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Listpage.aspx.cs" Inherits="HW3.Listpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .list{
            width:100%;
            background-color: chartreuse;
        }
        table {
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="list">
        <table border="1">
            <tr>
                <th>ID</th>
                <th>FirstName</th>
                <th>LastName</th>
                <th>Account</th>
                <th>Password</th>
                <th>Birthday</th>
                <th>Email</th>
                <th>Cellphone</th>
                <th>Address</th>
            </tr>

            <asp:Repeater ID="Repeater1" runat="server"
                OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("ID") %></td>
                        <td><%# Eval("FirstName") %></td>
                        <td><%# Eval("LastName") %></td>
                        <td><%# Eval("Account") %></td>
                        <td><%# Eval("Password") %></td>
                        <td><%# Eval("Birthday", "{0: yyyy-MM-dd}") %></td>
                        <td><%# Eval("Email") %></td>
                        <td><%# Eval("Cellphone") %></td>
                        <td><%# Eval("Address") %></td>

                        <asp:Literal runat="server" ID="ltName" Visible="false"> - </asp:Literal>
                    </tr>


                </ItemTemplate>
            </asp:Repeater>


        </table>
    </div>
</asp:Content>
