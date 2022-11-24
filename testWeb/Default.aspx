<%@ Page Language="C#" Inherits="testWeb.Default" MasterPageFile="Home.master" AutoEventWireup="true"%>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1">
    <h1>This is default page..</h1>
    
    <div>
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
    </div>
    <a href="AdminLogin">Admin page</a>
   
</asp:Content>