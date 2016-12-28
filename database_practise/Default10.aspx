<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default10.aspx.cs" Inherits="Default10" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="Chart1" runat="server">
            <Series>
                <asp:Series Name="Series1">
                    <Points>
                        <asp:DataPoint AxisLabel="ProductA" YValues="345" />

                        <asp:DataPoint AxisLabel="ProductB" YValues="645" />
                        <asp:DataPoint AxisLabel="ProductC" YValues="545" />
                        <asp:DataPoint AxisLabel="ProductD" YValues="360" />

                    </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
            <Legends>
                <asp:Legend Name="legend1" Title="Product sales"></asp:Legend>
            </Legends>
        </asp:Chart>
        
    </div>
    </form>
</body>
</html>
