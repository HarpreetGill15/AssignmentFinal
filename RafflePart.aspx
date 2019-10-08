<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RafflePart.aspx.cs" Inherits="BonusAssignment.RafflePart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .line{
            display:block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <asp:Label runat="server">How many tickets:</asp:Label>
            <asp:TextBox runat="server" ID="user_amun_tickets"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter a value" ControlToValidate="user_amun_tickets"></asp:RequiredFieldValidator>
        </section>
        <section>
            <asp:Button Text="Submit" runat="server" />
        </section>
        <section id="output" runat="server">

        </section>
    </form>
</body>
</html>
