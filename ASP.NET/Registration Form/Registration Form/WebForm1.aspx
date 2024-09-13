<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registration_Form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Registration Form </h2>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: " AssociatedControlID="txtFirstName"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblLastName" runat="server" Text="Last Name: " AssociatedControlID="txtLastName"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblEmail" runat="server" Text="Email: " AssociatedControlID="txtEmail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblGender" runat="server" Text="Gender: " AssociatedControlID="rblGender"></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Text="Male" Value=""></asp:ListItem>
                <asp:ListItem Text="Female" Value=""></asp:ListItem>
                <asp:ListItem Text="Others" Value=""></asp:ListItem>
            </asp:RadioButtonList>
            <br /><br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblRegisterName1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblRegisterName2" runat="server" Text=""></asp:Label>
            
            
        </div>
    </form>
</body>
</html>
