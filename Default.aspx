<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  First  Name :<asp:TextBox ID="txtnm" runat="server"></asp:TextBox><br />
Last name <asp:TextBox ID="txtlnm" runat="server"></asp:TextBox>

        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="btnnm" runat="server" Text="givename" OnClick="btnnm_Click" />
    </div>
    </form>
</body>
</html>
