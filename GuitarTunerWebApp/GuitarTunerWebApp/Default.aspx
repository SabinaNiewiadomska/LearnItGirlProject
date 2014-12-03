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

        <br />

        <p>
            <asp:Label ID="Label3" runat="server" Text="Check you microphone!"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button2_mic" runat="server" OnClick="Button2_mic_Click" Text="Check name of using device" />
            <asp:TextBox ID="TextBox1" runat="server" Height="174px" OnTextChanged="TextBox1_TextChanged" Width="415px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4_microphone" runat="server" Text="no microfone checked"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Check the volumne level of your device"></asp:Label>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Check" />
        </p>
        <p>Record wavefile
            <asp:Button ID="Button3_record" runat="server" Height="43px" OnClick="Button3_record_Click" Text="Record" />
        </p>
    </div>

</asp:Content>
