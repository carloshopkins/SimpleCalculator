<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
    </div>
        <h1>Simple Calculator</h1>
        <p>
            First Value:
            <asp:TextBox ID="firstField" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value:
            <asp:TextBox ID="secondField" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="minusButton" runat="server" OnClick="minusButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" style="width: 20px" Text="/" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
