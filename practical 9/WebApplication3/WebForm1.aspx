<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="btnmul">
            <asp:TextBox ID="txtA" runat="server" Height="25px" OnTextChanged="TextBox1_TextChanged" Width="211px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtA" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="txtB" runat="server" Height="25px" Width="211px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtB" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="BtnAdd" runat="server" Text="+" OnClick="BtnAdd_Click" />
&nbsp;
            <asp:Button ID="btnsub" runat="server" Text="-" OnClick="btnsub_Click" />
&nbsp;&nbsp;
            <asp:Button ID="btnmul" runat="server" OnClick="btnmul_Click" Text="*" />
&nbsp;&nbsp;
            <asp:Button ID="btndiv" runat="server" Text="/" OnClick="btndiv_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="label"></asp:Label>
        </div>
    </form>
</body>
</html>
