<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581726/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T344546)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinOlapRetrieveFieldsExample/Form1.cs) (VB: [Form1.vb](./VB/WinOlapRetrieveFieldsExample/Form1.vb))
<!-- default file list end -->
# How to connect a Pivot Grid to an OLAP datasource


If you have a cube on the OLAP server (Microsoft Analysis Services), you can view its data using the <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument3409.aspx">Pivot Grid</a>. In this example, you will see how to specify connection settings to the server and create fields that represents specific measures and dimensions of the cube.<br><br>To bind the Pivot Grid control to an OLAP cube, follow the steps below.<br><br>1. Set <em>ADOMD</em> as a data provider using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraPivotGridPivotGridControl_OLAPDataProvidertopic.aspx">PivotGridControl.OLAPDataProvider</a> property.<br>2. Specify connection settings to the server using the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraPivotGridPivotGridControl_OLAPConnectionStringtopic.aspx">PivotGridControl.OLAPConnectionString</a> property. The connection string used in the example is shown below.<br><em>OlapConnectionString="Provider=MSOLAP;Data Source=<a href="http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial">http://demos.devexpress.com/Services/OLAP/msmdpump.dll;Initial</a> catalog=Adventure Works DW Standard Edition;Cube name=Adventure Works;Query Timeout=100;"</em><br>3. Create fields for all the measures and dimension in the bound OLAP cube, and moves these fields to the specified area, making them hidden. To do it, use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_RetrieveFieldstopic(w5D4CA)">PivotGridControl.RetrieveFields</a> method overload and set the field's visibility to <strong>false</strong>.<br>4. Place some of the created fields within corresponding Pivot Grid Control areas (<a href="https://documentation.devexpress.com/WindowsForms/CustomDocument1688.aspx">Data Header Area</a>, <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument1686.aspx">Column Header Area</a>, <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument1685.aspx">Row Header Area</a> or <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument1684.aspx">Filter Header Area</a>) and set the visibility of the fields to <strong>true </strong>using the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_Visibletopic">PivotGridFieldBase.Visible</a> property.<br><br>Use the invoked <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument1805">Customization Form</a> to specify the Pivot Grid control's layout.<br><br>To learn more about OLAP Datasources, see <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument11775">OLAP Datasources</a>.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-connect-to-an-olap-datasource&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivot-grid-connect-to-an-olap-datasource&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
