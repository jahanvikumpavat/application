<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default8.aspx.cs" Inherits="Default8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id"  OnItemCanceling="ListView1_ItemCanceling" OnItemDeleting="ListView1_ItemDeleting" OnItemEditing="ListView1_ItemEditing" OnItemInserted="ListView1_ItemInserted" OnItemUpdating="ListView1_ItemUpdating">
            <ItemTemplate>
                <table>
                    <tr>
                        <td>
                        Country_name :    <asp:Label ID="Label1" runat="server" Text='<%# Bind("country_name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                         Is Active :   <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Bind("isactive") %>' text="Is active?" />
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
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="isactive ?" />
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
            

        </asp:ListView>
    </div>
    </form>
</body>
</html>
