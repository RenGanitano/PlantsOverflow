<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Content.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="ProjectPlantsOverflow.Pages.test" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="server">
     <table class="auto-style1">
                                <tr>
                                    <td colspan="3">
                                        <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>Image Row</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>Procedure</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <table class="auto-style1">
                                                    <tr>
                                                        <td class="auto-style2">
                                                            <asp:TextBox ID="txtuid" runat="server" Width="130px"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style2">
                                                            <asp:TextBox ID="txtcmnt" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td class="auto-style2">
                                                            <asp:Button ID="btnpost" runat="server" OnClick="btnpost_Click" Text="Post Comment" Width="130px" />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lblloadcomments" runat="server" Text="Label"></asp:Label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                </tr>
                            </table>
</asp:Content>