<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default7.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="true" DataKeyNames="Id" CellPadding="4" ForeColor="#333333" Height="138px" OnItemCommand="FormView1_ItemCommand" OnItemDeleting="FormView1_ItemDeleting" OnItemInserting="FormView1_ItemInserting" OnItemUpdating="FormView1_ItemUpdating" OnModeChanging="FormView1_ModeChanging" OnPageIndexChanging="FormView1_PageIndexChanging" Width="139px">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("country_name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("isactive") %>' Text="Is active ?"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit">Edit</asp:LinkButton>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="delete">Delete</asp:LinkButton>
                            <asp:LinkButton ID="lbnew" runat="server" CommandName="new">New</asp:LinkButton>
                        </td> 
                    </tr>
                </table>
            </ItemTemplate>
            <EditItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                   <tr>
                       <td>
                           <asp:CheckBox ID="CheckBox2" runat="server" />
                       </td>
                   </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbupdate" runat="server" CommandName="update">Update</asp:LinkButton>
                            <asp:LinkButton ID="lbcancel" runat="server" CommandName="cancel">Cancel</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </EditItemTemplate>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <InsertItemTemplate>
                 <table>
                    <tr>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                   <tr>
                       <td>
                           <asp:CheckBox ID="CheckBox3" runat="server" />
                       </td>
                   </tr>
                     <tr>
                         <td>
                             <asp:LinkButton ID="LinkButton3" runat="server" CommandName="insert">insert</asp:LinkButton>
                             <asp:LinkButton ID="LinkButton4" runat="server" CommandName="cancel">cancel</asp:LinkButton>
                         </td>
                     </tr>
                </table>
            </InsertItemTemplate>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
    </div>
    </form>
</body>
</html>
