<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T344546)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to Connect a Pivot Grid to an OLAP Datasource

This example demonstrates how to specify connection settings and create fields that are bound to measures and dimensions of the cube on the OLAP server (Microsoft Analysis Services) to display data in the [Pivot Grid](https://docs.devexpress.com/WindowsForms/3409/controls-and-libraries/pivot-grid). 

<!-- default file list -->
## Files to Look at

* [Form1.cs](./CS/WinOlapRetrieveFieldsExample/Form1.cs) (VB: [Form1.vb](./VB/WinOlapRetrieveFieldsExample/Form1.vb))
<!-- default file list end -->

## Example Overview

Follow the steps below to bind the Pivot Grid control to an OLAP cube:

1. Set the [PivotGridControl.OLAPDataProvider](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPDataProvider) property to  _ADOMD_.

2. Specify connection settings to the server in the [PivotGridControl.OLAPConnectionString](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.OLAPConnectionString) property. The following connection string is used in this example:

```
OlapConnectionString="Provider=MSOLAP;Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"
``` 

3. Create Pivot Grid fields for OLAP measures and dimensions in following ways: 

- Use the [PivotGridControl.RetrieveFields](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.RetrieveFields(DevExpress.XtraPivotGrid.PivotArea-System.Boolean)) method, which creates fields, moves them to the specified area, and hides them.

- Use [DataSourceColumnBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.DataSourceColumnBinding)) and [OLAPExpressionBinding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.OLAPExpressionBinding) to bind Pivot Grid fields to data.

4. Specify field settings. Use the field's [Area](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Area) property to place the fields within the Pivot Grid Control areas: [Data Header Area](https://docs.devexpress.com/WindowsForms/1688/controls-and-libraries/pivot-grid/ui-elements/data-header-area), [Column Header Area](https://docs.devexpress.com/WindowsForms/1686/controls-and-libraries/pivot-grid/ui-elements/column-header-area), [Row Header Area](https://docs.devexpress.com/WindowsForms/1685/controls-and-libraries/pivot-grid/ui-elements/row-header-area), or [Filter Header Area](https://docs.devexpress.com/WindowsForms/1684/controls-and-libraries/pivot-grid/ui-elements/filter-header-area). Set the field's [Visible](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridFieldBase.Visible) property to `visible`.

Use the invoked [Customization Form](https://docs.devexpress.com/WindowsForms/1805) to arrange fields.

![screenshot](images/screenshot.png)

## Documentation

- [Bind Pivot Grid Fields to Data Columns](https://docs.devexpress.com/WindowsForms/401376/controls-and-libraries/pivot-grid/binding-to-data/bind-pivot-grid-fields-to-data-columns?v=22.1)
- [Bind Pivot Grid Fields to Calculated Expressions](https://docs.devexpress.com/WindowsForms/1799/controls-and-libraries/pivot-grid/binding-to-data/bind-pivot-grid-fields-to-calculated-expressions?v=22.1)
- [OLAP Mode](https://docs.devexpress.com/CoreLibraries/403809/devexpress-pivot-grid-core-library/pivot-grid-modes/olap-mode?v=22.1)

