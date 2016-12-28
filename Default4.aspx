<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="form-control">
    COUNTRY NAME :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />

        Isactive :<asp:CheckBox ID="CheckBox1" runat="server" Text="ISACTIVE ?" CssClass="form-check-inline" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="SAVE" CssClass="btn-primary" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" DataKeyNames="Id" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowDeleted="GridView1_RowDeleted" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit">

            <Columns>
               
                <asp:BoundField HeaderText="Country_id" DataField="Id" ReadOnly="true" />
                <asp:BoundField HeaderText="Country_name" DataField="country_name" />
                <asp:CheckBoxField HeaderText="Isactive or not"  DataField="isactive" Text="Isacive" />
                <asp:CommandField ShowEditButton="True" >
                     <ControlStyle CssClass="btn btn-default" /></asp:CommandField>
           
                <asp:CommandField ShowDeleteButton="True" >
                     <ControlStyle CssClass="btn btn-default" />
               </asp:CommandField>
            </Columns>
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
