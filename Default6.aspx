<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="true" DataKeyNames="Id" Height="200px" Width="197px" AutoGenerateRows="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemDeleting="DetailsView1_ItemDeleting" OnItemInserting="DetailsView1_ItemInserting" OnItemUpdating="DetailsView1_ItemUpdating" OnModeChanging="DetailsView1_ModeChanging" OnPageIndexChanging="DetailsView1_PageIndexChanging">

            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />

            <Fields>
                <asp:TemplateField HeaderText="Country_name">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("country_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Isactive or not?">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Isactive" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="isactive ?" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Eval("isactive") %>' Text="Isactive ?" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
    </div>
    </form>
</body>
</html>
