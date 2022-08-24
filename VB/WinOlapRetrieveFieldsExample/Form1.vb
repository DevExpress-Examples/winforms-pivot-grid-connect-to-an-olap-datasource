Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Customization
Imports DevExpress.XtraPivotGrid

Namespace WinOlapRetrieveFieldsExample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ' Specifies the OLAP connection settings.
            pivotGridControl1.OLAPDataProvider = OLAPDataProvider.Adomd
            pivotGridControl1.OLAPConnectionString = "Provider=MSOLAP;" & Microsoft.VisualBasic.Constants.vbCrLf & "                Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll; " & Microsoft.VisualBasic.Constants.vbCrLf & "                Initial catalog=Adventure Works DW Standard Edition;" & Microsoft.VisualBasic.Constants.vbCrLf & "                Cube name=Adventure Works;" & Microsoft.VisualBasic.Constants.vbCrLf & "                Query Timeout=100;"
            ' Retrieves fields.
            pivotGridControl1.RetrieveFields(PivotArea.ColumnArea, False)
            ' Adds some fields from the Field List to the specified area to create a report.
            pivotGridControl1.Fields("[Customer].[Country].[Country]").Area = PivotArea.RowArea
            pivotGridControl1.Fields("[Customer].[Country].[Country]").Visible = True
            pivotGridControl1.Fields("[Customer].[City].[City]").Area = PivotArea.RowArea
            pivotGridControl1.Fields("[Customer].[City].[City]").Visible = True
            pivotGridControl1.Fields("[Date].[Fiscal].[Fiscal Year]").Area = PivotArea.ColumnArea
            pivotGridControl1.Fields("[Date].[Fiscal].[Fiscal Year]").Visible = True
            pivotGridControl1.Fields("[Measures].[Internet Sales Amount]").Visible = True
            ' Sets the Customization Forms style to Excel2007 with additional capabilities.
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007
            ' Invokes the Customization Form.
            pivotGridControl1.FieldsCustomization()
        End Sub
    End Class
End Namespace
