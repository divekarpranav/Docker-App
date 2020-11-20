<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>My New Application</h1>
        <p class="lead">Input 1:
            <input type="text" />
        </p>
         <p class="lead">Input 2:
            <input type="text" />
        </p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Submit</a></p>
         <p class="lead">Output:
            <input type="text" />
        </p>
        

    </div>

</asp:Content>
