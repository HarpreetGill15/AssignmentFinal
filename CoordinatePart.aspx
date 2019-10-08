<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoordinatePart.aspx.cs" Inherits="BonusAssignment.CoordinatePart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <section>
                <asp:Label runat="server">X-axis</asp:Label>
                <asp:TextBox runat="server" ID="user_x_axis"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="user_x_axis" ErrorMessage="Please enter a numerical value"></asp:RequiredFieldValidator>
            </section>
            <section>
                <asp:Label runat="server">Y-axis</asp:Label>
                <asp:TextBox runat="server" ID="user_y_axis"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="user_y_axis" ErrorMessage="Please enter a numerical value"></asp:RequiredFieldValidator>
            </section>
            <section id="zero_box" runat="server">

            </section>
            <section id="output_box" runat="server" >

            </section>
            
            <asp:Button runat="server" Text="Submit"/>
        </section>
    </form>
</body>
</html>
