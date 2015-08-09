<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CitySearch.aspx.cs" Inherits="CountryInfoWebApp.UI.CitySearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph" runat="server">

      <div align="center">

            <table cellpadding="0" cellspacing="0" class="ui-widget-content" width="600px">
                <tr class="ui-widget-header" style="height:30px">
                    <td align="center" colspan="4" >
                        <strong>View Country</strong></td>
                </tr>
                <tr>
                    <td>
                        &nbsp; &nbsp;</td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
                    <td align="right">
                       
                        <asp:RadioButton ID="RdoCity" runat="server" AutoPostBack="True" OnCheckedChanged="RdoCity_CheckedChanged" Checked="True" GroupName="Abc" />
                       
                    </td>
                    <td align="right">
                        <strong>City Name</strong>&nbsp; :&nbsp;</td>
                    <td align="left" valign="top">
                        <asp:TextBox ID="txtCityName" runat="server" CssClass="input_text_box" 
                                Width="212px" Height="20px"></asp:TextBox>
                            <asp:Button ID="btnSearch" runat="server"  Text="Search" CssClass="input_button" OnClick="btnSearch_Click"/>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
                    <td align="right">
                       
                        <asp:RadioButton ID="RdoCountry" runat="server" AutoPostBack="True" OnCheckedChanged="RdoCountry_CheckedChanged" GroupName="Abc" />
                       
                    </td>
                    <td align="right">
                         <strong>Country Name</strong>&nbsp; :&nbsp;</td>
                    <td align="left" valign="top">
                         <asp:DropDownList ID="ddlCountry" CssClass="input_combo" runat="server" Width="215px"></asp:DropDownList> 
                    </td>
                </tr>
                <tr>
                    <td align="left">&nbsp;</td>
                    <td align="right" colspan="2">&nbsp;</td>
                    <td align="left">
                        <asp:Label ID="lblInvalidMessage" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                    <td align="left" valign="top">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center" colspan="3">
                        <asp:GridView ID="GrdCityList" runat="server" AutoGenerateColumns="False" 
                                                                DataKeyNames="id" BorderStyle="Solid" ShowHeaderWhenEmpty="True">
                                                                <Columns>

                                                                    <asp:BoundField DataField="id" HeaderText="SL No.">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="Name" HeaderText="City Name">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>
                                                                    <asp:BoundField DataField="About" HeaderText="About">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>
                                                                     <asp:BoundField DataField="Dwellers" HeaderText="Number of Dwellers">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>

                                                                      <asp:BoundField DataField="Location" HeaderText="Location">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>
                                                                    
                                                                      <asp:BoundField DataField="Weather" HeaderText="Weather">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>
                                                                    
                                                                      <asp:BoundField DataField="CountryName" HeaderText="Country">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>
                                                                    
                                                                      <asp:BoundField DataField="CountryAbout" HeaderText="Country About">
                                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                                                                    </asp:BoundField>

                                                                </Columns>
                                                              
                                                            </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center" colspan="3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                    <td align="left" valign="top">
                        &nbsp;</td>
                </tr>
            </table>
     
    </div>

</asp:Content>
