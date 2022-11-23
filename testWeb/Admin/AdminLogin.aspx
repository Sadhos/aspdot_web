<%@ Page Title="Title" Language="C#" MasterPageFile="../Home.master" CodeBehind="AdminLogin.aspx.cs" Inherits="testWeb.Admin.AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is Admin Page.</h1>
    <hr/>
    <table>
        <tr>
            <td>Login</td>
            <td><asp:TextBox runat="server" ID="TxtAdminLogin" ></asp:TextBox> </td>
        </tr>
        <tr>
            <td>PassWord</td>
            <td><asp:TextBox runat="server" ID="TxtPassword" TextMode="Password"></asp:TextBox></td>
        </tr>
        <asp:Button ID="ButtonLogin" OnClick="ButtonLogin_Click" runat="server" Text="Login" class="btn btn-primary"></asp:Button>
    </table>
</asp:Content>