<%@ Page Title="Food Home page" AutoEventWireup="true" Language="C#" MasterPageFile="~/Home.master" CodeBehind="Home.aspx.cs" Inherits="testWeb.Food.Home" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <h3>Food articles ...</h3>
    <hr/>
    <asp:Repeater runat="server" ID="RepBlogDetails">
        <ItemTemplate>
            <b style="background-image: linear-gradient(#00000000,chocolate);"><%#Eval("BTitle") %></b>
            <p class="card-text">
                <%#Eval("BDesc") %>
            </p>
            <a style="background-image: linear-gradient(#00000000,chocolate);" href="<%#Eval("BCategory") %>/<%#Eval("BUrl") %>">Read the Complete article...</a>
            <div class="card-footer text-muted">
                Posted on : <%#Eval("BPostdate",
                                    "{0:MMMM dd,yyyy}") %>
                <a href="<%#Eval("BCategory") %>/Home.aspx"></a>
            </div>
        </ItemTemplate>
        
    </asp:Repeater>
    <hr/>
</asp:Content>
<asp:Label ID="lblErrorMsg" runat="server"></asp:Label>
<asp:Label ID="lblSuccessMsg" runat="server"></asp:Label>