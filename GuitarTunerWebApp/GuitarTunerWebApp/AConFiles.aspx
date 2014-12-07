<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AConFiles.aspx.cs" Inherits="GuitarTunerWebApp.A00ConvertFiles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <asp:FileUpload ID="FileUpload1_Convert" runat="server" />
    <br />
    <asp:Button ID="Button1_Con_Upload" runat="server" OnClick="Button1_Click" Text="Upload file" Height="29px" Width="124px" />
    <br />
    <br />
    <asp:Label ID="Label1_Convert" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
