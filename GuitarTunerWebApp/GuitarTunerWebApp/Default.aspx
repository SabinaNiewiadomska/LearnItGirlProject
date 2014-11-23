<%@ Page Title="Guitar Tuner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GuitarTunerWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Online Guitar Tuner</h1>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" Text="Click here!" OnClick="Button1_Click" /><br>
            <asp:Label ID="Label1" runat="server" Text="Look here!"></asp:Label><br>
        </p>
        <h2>Wave File:</h2>
          <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
          <asp:Button ID="ButtonOpenWaveFile" runat="server" Text="Open Wave File" OnClick="ButtonOpenWaveFile_Click" /><br />
        <asp:Button ID="ButtonPlayPause" runat="server" Text="Play/Pause" OnClick="ButtonPlayPause_Click" Width="227px" />

        <p>&nbsp;</p>
    </div>

</asp:Content>
