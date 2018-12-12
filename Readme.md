<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinOlapRetrieveFieldsExample/Form1.cs) (VB: [Form1.vb](./VB/WinOlapRetrieveFieldsExample/Form1.vb))
<!-- default file list end -->
# How to connect a Pivot Grid to an OLAP datasource


If you have a cube on the OLAP server (Microsoft Analysis Services), you can view its data using the <a href="https://docs.devexpress.com/WindowsForms/CustomDocument3409.aspx">Pivot Grid</a>. This example demonstrates how to specify connection settings and create fields that represent OLAP measures and dimensions.

To bind the Pivot Grid control to an OLAP cube, follow the steps below.

1. Set **ADOMD** as a data provider using the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPDataProvider">PivotGridControl.OLAPDataProvider</a> property.
2. Specify connection settings to the server using the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPConnectionString">PivotGridControl.OLAPConnectionString</a> property. The connection string used in the example is shown below.

```
OlapConnectionString="Provider=MSOLAP;Data Source=<a href="http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial">http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial</a> catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"
``` 

3. Create fields for all the measures and dimension in the bound OLAP cube. Use the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RetrieveFields(DevExpress.XtraPivotGrid.PivotArea-System.Boolean)">PivotGridControl.RetrieveFields</a> method that creates fields, moves them to the specified area and makes them hidden. Another option is creating a new field and specifying its <a href="https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.OLAPExpression"/>OLAPExpression</a> property.
4. Place the fields within the Pivot Grid Control areas (<a href="https://docs.devexpress.com/WindowsForms/1688">Data Header Area</a>, <a href="https://docs.devexpress.com/WindowsForms/1686">Column Header Area</a>, <a href="https://docs.devexpress.com/WindowsForms/1685">Row Header Area</a> or <a href="https://docs.devexpress.com/WindowsForms/1684">Filter Header Area</a>) as required and make them visible.

Use the invoked <a href="https://docs.devexpress.com/WindowsForms/1805">Customization Form</a> to arrange fields.

For more information refer to the  <a href="https://docs.devexpress.com/WindowsForms/11775">OLAP Data Source</a> online help topic.

![screenshot](https://github.com/DevExpress-Examples/how-to-connect-a-pivot-grid-to-an-olap-datasource-t344546/blob/18.2.3%2B/images/screenshot.png)


