Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Customization

Namespace WinOlapRetrieveFieldsExample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            ' Specify the OLAP connection settings.
            pivotGridControl1.OLAPDataProvider = OLAPDataProvider.Adomd
            pivotGridControl1.OLAPConnectionString = "Provider=MSOLAP;
                Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll; 
                Initial catalog=Adventure Works DW Standard Edition;
                Cube name=Adventure Works;
                Query Timeout=100;"
            ' Set the Customization Forms style.
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007
            ' Invoke the Customization Form.
            pivotGridControl1.FieldsCustomization()
        End Sub

        Private Sub btnRetrieveFields_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            ' Retrieve fields.
            pivotGridControl1.RetrieveFields(PivotArea.ColumnArea, False)
            ' Add fields from the Field List to the specified area to create a report.
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.Fields("[Customer].[Country].[Country]").Area = PivotArea.RowArea
            pivotGridControl1.Fields("[Customer].[Country].[Country]").OLAPDimensionCaption = "TEST"
            pivotGridControl1.Fields("[Customer].[Country].[Country]").Visible = True
            pivotGridControl1.Fields("[Customer].[City].[City]").Area = PivotArea.RowArea
            pivotGridControl1.Fields("[Customer].[City].[City]").Visible = True
            pivotGridControl1.Fields("[Date].[Fiscal].[Fiscal Year]").Area = PivotArea.ColumnArea
            pivotGridControl1.Fields("[Date].[Fiscal].[Fiscal Year]").Visible = True
            pivotGridControl1.Fields("[Measures].[Internet Sales Amount]").Visible = True
            pivotGridControl1.EndUpdate()
            ' Resize columns automatically.
            pivotGridControl1.BestFit()
            ' Invoke the Customization Form.
            pivotGridControl1.FieldsCustomization()
        End Sub

        Private Sub btnCreateFields_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.Fields.Clear()
            ' Create a field, specify a query expression to obtain data and a caption to display it in the Customization form.
            Dim fieldCountry As PivotGridFieldBase = pivotGridControl1.Fields.Add("Country", PivotArea.RowArea)
            fieldCountry.OLAPExpression = "[Customer].[Country].[Country]"
            fieldCountry.OLAPDimensionCaption = "Location"
            Dim fieldCity As PivotGridFieldBase = pivotGridControl1.Fields.Add("City", PivotArea.RowArea)
            fieldCity.OLAPExpression = "[Customer].[City].[City]"
            fieldCity.OLAPDimensionCaption = "Location"
            Dim measureField As PivotGridField = New PivotGridField() With {.Caption = "Cleared Amount", .Area = PivotArea.DataArea}
            measureField.OLAPExpression = "[Measures].[Internet Sales Amount] * 0.87"
            measureField.OLAPDimensionCaption = "Sales"
            pivotGridControl1.Fields.Add(measureField)
            Dim fieldTop10 As PivotGridFieldBase = pivotGridControl1.Fields.Add("Top10", PivotArea.ColumnArea)
            fieldTop10.OLAPExpression = "TOPCOUNT([Date].[Date].[Date].MEMBERS, 10, [Measures].[Internet Sales Amount])"
            fieldTop10.OLAPDimensionCaption = "Top"
            fieldTop10.Visible = False
            pivotGridControl1.EndUpdate()
            ' Invoke the Customization Form.
            pivotGridControl1.FieldsCustomization()
        End Sub
    End Class
End Namespace
