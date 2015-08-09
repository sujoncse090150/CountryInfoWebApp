<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryEntryUI.aspx.cs" Inherits="CountryInfoWebApp.UI.CountryEntryUI" MasterPageFile="~/MasterPage.Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td> Name</td>
            <td> <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> About </td>
            <td> <asp:TextBox ID="aboutTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td> <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" /> &nbsp;
            <asp:Button ID="calcelButton" runat="server" Text="Calcel" /> </td>
            <td><asp:Label ID="msgLabel" runat="server" Text=""></asp:Label></td>
        </tr>
    </table>
        <asp:GridView ID="showCountryGridView" runat="server" OnSelectedIndexChanged="showCountryGridView_SelectedIndexChanged"></asp:GridView>
    </div>
    </form>
</body>
</html>
