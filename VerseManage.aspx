<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VerseManage.aspx.cs" Inherits="VerseManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                
                <div><span style="font-size: 25px">Manage Verses</span></div>

                <asp:Panel ID="Panel1" runat="server">
                    <asp:GridView ID="GridView1" runat="server" Width="550px"
                        AutoGenerateColumns="false" Font-Names="Arial"
                        Font-Size="11pt" AlternatingRowStyle-BackColor="#C2D69B" DataKeyNames="verseID"
                        HeaderStyle-BackColor="green" AllowPaging="False" ShowFooter="true"
                        OnPageIndexChanging="OnPaging" OnRowEditing="EditRow"
                        OnRowUpdating="UpdateRow" OnRowCancelingEdit="CancelEdit">
                        <Columns>
                            <asp:TemplateField ItemStyle-Width="30px" HeaderText="Date">
                                <ItemTemplate>
                                    <asp:Label ID="verseDate" runat="server"
                                        Text='<%# Eval("verseDate")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="editVerseDate" runat="server"
                                        Text='<%# Eval("verseDate")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="txtVerseDate" Width="40px"
                                        MaxLength="5" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ItemStyle-Width="250px" HeaderText="English Verse">
                                <ItemTemplate>
                                    <asp:Label ID="verseEnglish" runat="server"
                                        Text='<%# Eval("verseEnglish")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="editVerseEnglish" runat="server" Width="250px" TextMode="MultiLine"
                                        Rows="5"
                                        Text='<%# Eval("verseEnglish")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="txtverseEnglish" Width="250px" TextMode="MultiLine"
                                        Rows="5" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ItemStyle-Width="250px" HeaderText="Arabic Verse">
                                <ItemTemplate>
                                    <asp:Label ID="verseArabic" runat="server"
                                        Text='<%# Eval("verseArabic")%>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="editVerseArabic" runat="server" Width="250px" TextMode="MultiLine"
                                        Rows="5"
                                        Text='<%# Eval("verseArabic")%>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="txtverseArabic" Width="250px" TextMode="MultiLine"
                                        Rows="5" runat="server"></asp:TextBox>
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lnkRemove" runat="server"
                                        CommandArgument='<%# Eval("verseID")%>'
                                        Text="Delete" OnClick="DeleteRow"></asp:LinkButton>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:Button ID="btnAdd" runat="server" Text="Add"
                                        OnClick="AddNewRow" />
                                </FooterTemplate>
                            </asp:TemplateField>

                            <asp:CommandField ShowEditButton="True" />

                        </Columns>

                        <EmptyDataTemplate>No Data</EmptyDataTemplate>
                    </asp:GridView>
                </asp:Panel>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="GridView1" />
            </Triggers>
        </asp:UpdatePanel>

    </form>
</body>
</html>
