<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CityEntry.aspx.cs" Inherits="CountryInfoWebApp.UI.CityEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">
    

    <div align="center">

        <table cellpadding="0" cellspacing="0" class="ui-widget-content" width="600px">
            <tr class="ui-widget-header" style="height: 30px">
                <td align="center" colspan="3">
                    <strong>City Information</strong></td>
            </tr>
            <tr>
                <td>&nbsp; &nbsp;</td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>City Name</strong>&nbsp; :&nbsp;
                </td>
                <td align="left">
                    <asp:TextBox ID="txtCityName" runat="server" CssClass="input_text_box"
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
                <td align="right">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>No of Dwellers</strong>&nbsp; :&nbsp;
                </td>
                <td align="left">
                    <asp:TextBox ID="txtDwellers" runat="server" CssClass="input_text_box"
                        Width="212px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>Location</strong>&nbsp; :&nbsp;
                </td>
                <td align="left">
                    <asp:TextBox ID="txtLocation" runat="server" CssClass="input_text_box"
                        Width="212px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    <strong>Weather</strong>&nbsp; :&nbsp;
                </td>
                <td align="left">
                    <asp:TextBox ID="txtWeather" runat="server" CssClass="input_text_box"
                        Width="212px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                    &nbsp;</td>
                <td align="left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left">&nbsp;</td>
                <td align="right">
                     <strong>Country</strong>&nbsp; :&nbsp;</td>
                <td align="left">
                    <asp:DropDownList ID="ddlCountry" CssClass="input_combo" runat="server" Width="215px"></asp:DropDownList>  </td>
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
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="input_button" OnClick="btnSave_Click"/>
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
                    <asp:GridView ID="GrdCityList" runat="server" AutoGenerateColumns="False"
                        DataKeyNames="id">
                        <Columns>

                            <asp:BoundField DataField="id" HeaderText="SL No.">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Name" HeaderText="City Name">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Dwellers" HeaderText="No of Dwellers">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Country_id" HeaderText="Country ID" Visible="False">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20px" />
                            </asp:BoundField>
                           <asp:BoundField DataField="CountryName" HeaderText="Country Name">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                            </asp:BoundField>
                           
                        </Columns>
                        <%--<PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <HeaderStyle BackColor="#CEB497" Font-Bold="True" ForeColor="White" BorderStyle="Solid" BorderWidth="1px" />
                        <AlternatingRowStyle BackColor="White" />--%>
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
