<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="heading">
                1-1-Hur-många-versaler
            </p>
            <h1>1-1-Hur-många-versaler
            </h1>
            <p>
                <asp:TextBox ID="InputTextBox" runat="server" TextMode="MultiLine" Height="229px" Width="589px" CssClass="MultiLineTextBox" ></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="SubmitButton" runat="server" Text="Bestäm antal versaler" OnClick="SubmitButton_Click" />
            </p>
            <p>
                <asp:Label ID="OutputLabel" runat="server" Text=""></asp:Label>
            </p>
            <p class="footer">
                Anton Ledström
            </p>
<%--            <h1>Validering</h1>
            <p>
                <asp:TextBox ID="ValidateTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Detta fält kan inte vara tomt" Text="*" ControlToValidate="ValidateTextBox"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Måste innehålla ett heltal" Operator="DataTypeCheck" Type="Integer" ControlToValidate="ValidateTextBox"></asp:CompareValidator>
            </p>
            <p>
                <asp:Button ID="ValidateButton" runat="server" Text="Validera" OnClick="ValidateButton_Click" />
            </p>--%>
        </div>
    </form>
</body>
</html>
