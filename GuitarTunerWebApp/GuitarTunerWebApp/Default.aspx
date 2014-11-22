<%@ Page Title="Guitar Tuner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GuitarTunerWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Online Guitar Tuner</h1>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" Text="Click here!" OnClick="Button1_Click" /><br>
            <asp:Label ID="Label1" runat="server" Text="Look here!"></asp:Label>
        </p>
        <p></p>
    </div>

</asp:Content>
