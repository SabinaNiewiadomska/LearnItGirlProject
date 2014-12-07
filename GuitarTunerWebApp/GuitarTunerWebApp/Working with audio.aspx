<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Working with audio.aspx.cs" Inherits="GuitarTunerWebApp.Working_with_audio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Working with MP3 file<br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="ButtonPlayMP3" runat="server" OnClick="Button1_Click" Text="Play" />
        <asp:Button ID="ButtonPauseMP3" runat="server" Enabled="False" OnClick="ButtonPauseMP3_Click" Text="Pause" />
        <br />
        <asp:Label ID="LabelMP3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Working with WAV file<br />
    
    </div>
    </form>
</body>
</html>
