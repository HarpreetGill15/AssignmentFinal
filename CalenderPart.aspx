<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalenderPart.aspx.cs" Inherits="BonusAssignment.CalenderPart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <asp:Label runat="server">What days do you work?</asp:Label>
            <asp:CheckBoxList ID="user_days_working" runat="server">
                <asp:ListItem Text="Sunday" Value="sunday"></asp:ListItem>
                <asp:ListItem Text="Monday" Value="monday"></asp:ListItem>
                <asp:ListItem Text="Tuesday" Value="tuesday"></asp:ListItem>
                <asp:ListItem Text="Wednesday" Value="wednesday"></asp:ListItem>
                <asp:ListItem Text="Thursday" Value="thursday"></asp:ListItem>
                <asp:ListItem Text="Friday" Value="friday"></asp:ListItem>
                <asp:ListItem Text="Saturday" Value="saturday"></asp:ListItem>
            </asp:CheckBoxList>
        </section>
        <section>
            <asp:Button runat="server" Text="Submit"/>
        </section>
        <section id="output" runat="server">

        </section>
    </form>
</body>
</html>
