<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E6.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Excercise 6 
        </div>
        <p>
            Fill your informations:</p>
        <p>
            Your name<asp:TextBox ID="TextName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            Your email<asp:TextBox ID="TextEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Pg1" runat="server" OnClick="Pg1_Click" Text="Open Page 1" CausesValidation="False" />
        <p>
            <asp:Button ID="Pg2" runat="server" OnClick="Pg2_Click" Text="Open Page 2" />
        </p>
        <p>
            <asp:Button ID="Pg3" runat="server" OnClick="Pg3_Click" Text="Open Page 3" />
        </p>
    </form>
</body>
</html>
