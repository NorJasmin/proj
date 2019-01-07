<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feesreport.aspx.cs" Inherits="proj.feesreport" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 327px">
    <form id="form1" runat="server">
        <div style="height: 297px">
            <h3>Sales Comparison Report with Chart using ASP.NET.</h3>
    <table>
        <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Width="95%">
                    <Columns>
                        <asp:BoundField HeaderText="Age" DataField="Age" />
                        <asp:BoundField HeaderText="Attendance" DataField="StatusAttend" />
                   
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Chart ID="Chart1" runat="server" BorderlineWidth="0" Width="800px" DataSourceID="SqlDataSource1">
                    <Series>
                        <asp:Series Name="Series1" XValueMember="Class" YValueMembers="Absent"
                            LegendText="Absent" IsValueShownAsLabel="false" ChartArea="ChartArea1"
                            MarkerBorderColor="#DBDBDB">
                        </asp:Series>
 
                        <asp:Series Name="Series2"
                            LegendText="Attend" IsValueShownAsLabel="false" ChartArea="ChartArea1"
                            MarkerBorderColor="#DBDBDB">
                        </asp:Series>
 
                       
                    </Series>
                    <Legends>
                        <asp:Legend Title="Quarter" />
                    </Legends>
                    <Titles>
                        <asp:Title Docking="Bottom" Text="Sales Report Quarterly" />
                    </Titles>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Class], [Attend], [Absent] FROM [Att]"></asp:SqlDataSource>
            </td>
        </tr>
    </table>            
        </div>
    </form>
</body>
</html>
