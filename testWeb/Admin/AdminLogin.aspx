<%@ Page Title="Title" Language="C#" MasterPageFile="../Home.master" CodeBehind="AdminLogin.aspx.cs" Inherits="testWeb.Admin.AdminLogin" EnableEventValidation="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <div class="form-floating mb-3">
        <asp:TextBox runat="server" ID="TxtAdminLogin" CssClass="form-control" OnTextChanged="TxtAdminLogin_TextChanged" ToolTip="Enter Username"></asp:TextBox>
        <label for="floatingInput">Username</label>
    </div>
    <div class="form-floating">
        <asp:TextBox runat="server" ID="TxtPassword" TextMode="Password" CssClass="form-control" Visible="true" OnTextChanged="TxtPassword_OnTextChanged"></asp:TextBox>
        <label for="floatingPassword">Password</label>
    </div>
    <br/>
    <asp:Button ID="ButtonLogin" OnClick="ButtonLogin_Click" runat="server" Text="Login" class="btn btn-primary"></asp:Button>
</asp:Content>