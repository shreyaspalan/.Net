<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
    <asp:Button ID="Btnname" runat="server" Text="Set Header" onclick="Btnname_Click" />
</asp:Content>
