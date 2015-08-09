<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CountryEntry.aspx.cs" Inherits="CountryInfoWebApp.UI.CountryEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">


    <div align="center">

        <table cellpadding="0" cellspacing="0" class="ui-widget-content" width="600px">
            <tr class="ui-widget-header" style="height: 30px">
                <td align="center" colspan="3">
                    <strong>Country Information</strong></td>
            </tr>
            <tr>
                <td>&nbsp; &nbsp;</td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>Contry Name</strong>&nbsp; :&nbsp;
                </td>
                <td align="left">
                    <asp:TextBox ID="txtCountryName" runat="server" CssClass="input_text_box"
                        Width="212px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">&nbsp;</td>
                <td align="left">
                    <asp:Label ID="lblInvalidMessage" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>About </strong>&nbsp; :&nbsp;</td>
                <td align="left">
                    <asp:TextBox ID="txtAbout" runat="server" CssClass="input_text_box"
                        Width="212px" Height="72px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="left">&nbsp;</td>
                <td align="left">
                    <asp:Label ID="msgLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td align="left" valign="top">
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="input_button" OnClick="btnsave_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td align="left" valign="top">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td align="center" colspan="2">
                    <asp:GridView ID="GrdCountryList" runat="server" AutoGenerateColumns="False"
                        DataKeyNames="id">
                        <Columns>

                            <asp:BoundField DataField="id" HeaderText="SL No.">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="Countrry Name">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="About" HeaderText="About">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                            </asp:BoundField>
                            
                        </Columns>
                      
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td align="center" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td align="left" valign="top">&nbsp;</td>
            </tr>
        </table>

    </div>


</asp:Content>
