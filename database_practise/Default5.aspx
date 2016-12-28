<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" DataKeyField="Id" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" GridLines="Both" OnCancelCommand="DataList1_CancelCommand" OnDeleteCommand="DataList1_DeleteCommand" OnEditCommand="DataList1_EditCommand" OnUpdateCommand="DataList1_UpdateCommand">
           
            
             <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="White" />
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("country_name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("isactive") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lbedit" runat="server" CommandName="edit">Edit</asp:LinkButton>
                            <asp:LinkButton ID="lbdelete" runat="server" CommandName="delete">Delete</asp:LinkButton>
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
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="isactive" />
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
            
        </asp:DataList>
    </div>
    </form>
</body>
</html>
