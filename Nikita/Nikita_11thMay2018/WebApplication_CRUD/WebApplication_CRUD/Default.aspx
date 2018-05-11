<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication_CRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <%--<h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>--%>

        <p>Welcome to the App</p>
        <div>
        <textbox>New address</textbox>
            </br>
            <label>Name</label>
             <asp:TextBox ID="txt_Name" runat="server" ></asp:TextBox>
            </br>
            <label>Contact Number</label>
                 <asp:TextBox ID="txt_No" runat="server"></asp:TextBox>
            </br>
            <label>Adrress</label>
                 <asp:TextBox ID="txt_Add" runat="server"></asp:TextBox>
            </br>
            <label>City</label>
                 <asp:TextBox ID="txt_City" runat="server"></asp:TextBox>
            </br>
            </div>
        <div>
        <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Save"/>
            </div>
        <div></div>
        <div>
 <textbox>View address</textbox>
            <br />
             <label>Name</label>
             <asp:TextBox ID="txt_FindName" runat="server" ></asp:TextBox>
             <asp:Button ID="btn_Search" runat="server" Text="Search" onclick="Button1_Search"/>
            <asp:Button ID="btn_Delete" runat="server" Text="Delete" onclick="Button1_Delete"/>
            <asp:GridView ID="GridView1" runat="server" Enabled="false"></asp:GridView>
            </br>

        </div>
    </div>

</asp:Content>
