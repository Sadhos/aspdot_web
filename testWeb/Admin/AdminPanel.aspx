<%@ Page Title="Title" Language="C#" MasterPageFile="../Home.master" CodeBehind="AdminPanel.aspx.cs" Inherits="testWeb.Admin.AdminPanel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Admin Panel</h1>
    <hr/>
     <asp:HiddenField ID="hfBID" runat="server"/>
    <table>
        <tr>
            <td>Blog Category</td>
            <td>
                <asp:DropDownList runat="server" ID="DDLBCat">
                    <asp:ListItem>Food</asp:ListItem>
                    <asp:ListItem>Sports</asp:ListItem>
                    <asp:ListItem>Movie</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Blog title</td>
            <td>
                <asp:TextBox runat="server" ID="TxtBlogTitle"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Blog Description</td>
            <td>
                <asp:TextBox runat="server" ID="TxtBDesc" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Blog Url(webpage name)</td>
            <td><asp:TextBox ID="Txturl" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Posted Date</td>
            <td><asp:Label runat="server" ID="LabBPostdate" Text=""></asp:Label></td>
        </tr>
        

    </table>
    <hr/>
    <asp:Button runat="server"  OnClick="ButtonSubmit_Click" ID="ButtonSubmit" Text="Save"/>
    <asp:Label runat="server" ID="lblSuccessMessage" ForeColor="Green"></asp:Label>
    <asp:Label runat="server" ID="lblErrorMessage" ForeColor="Red"></asp:Label> 
</asp:Content>