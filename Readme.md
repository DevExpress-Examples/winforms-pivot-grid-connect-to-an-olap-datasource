<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T344546)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinOlapRetrieveFieldsExample/Form1.cs) (VB: [Form1.vb](./VB/WinOlapRetrieveFieldsExample/Form1.vb))
<!-- default file list end -->
# How to Connect a Pivot Grid to an OLAP Datasource


This example demonstrates how to specify connection settings and create fields that are bound to measures and dimensions of the cube on the OLAP server (Microsoft Analysis Services) to display data in the [Pivot Grid](https://docs.devexpress.com/WindowsForms/3409/controls-and-libraries/pivot-grid). 

Follow the steps below to bind the Pivot Grid control to an OLAP cube:

1. Set the [PivotGridControl.OLAPDataProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPDataProvider) property to  _ADOMD_.

2. Specify connection settings to the server in the [PivotGridControl.OLAPConnectionString](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPConnectionString) property. TThe following connection string is used in this example:

```
OlapConnectionString="Provider=MSOLAP;Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"
``` 

3. Create fields for measures and dimension in the bound OLAP cube the in following ways: 

- Use the [PivotGridControl.RetrieveFields](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RetrieveFields(DevExpress.XtraPivotGrid.PivotArea-System.Boolean)) method that create fields, moves them to the specified area and makes them hidden. 

- Use [DataSourceColumnBinding]([xref:DevExpress.XtraPivotGrid.DataSourceColumnBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.DataSourceColumnBinding)) and [OLAPExpressionBinding]([xref:DevExpress.XtraPivotGrid.OLAPExpressionBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.OLAPExpressionBinding)).

4. Specify field settings. Use the field's [Area](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Area) property to place the fields within the Pivot Grid Control areas: [Data Header Area](https://docs.devexpress.com/WindowsForms/1688/controls-and-libraries/pivot-grid/ui-elements/data-header-area), [Column Header Area](https://docs.devexpress.com/WindowsForms/1686/controls-and-libraries/pivot-grid/ui-elements/column-header-area), [Row Header Area](https://docs.devexpress.com/WindowsForms/1685/controls-and-libraries/pivot-grid/ui-elements/row-header-area) or [Filter Header](https://docs.devexpress.com/WindowsForms/1684/controls-and-libraries/pivot-grid/ui-elements/filter-header-area). Set the field's [Visible](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Visible) property to `visible`.

Use the invoked [Customization Form](https://docs.devexpress.com/WindowsForms/1805) to arrange fields.

For more information refer to the [OLAP Data Source](https://docs.devexpress.com/WindowsForms/11775) online help topic.


![screenshot](images/screenshot.png)


