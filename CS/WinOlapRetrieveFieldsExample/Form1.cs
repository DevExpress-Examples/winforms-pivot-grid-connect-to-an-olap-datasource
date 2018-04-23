using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Customization;
using DevExpress.XtraPivotGrid;

namespace WinOlapRetrieveFieldsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Specifies the OLAP connection settings.
            pivotGridControl1.OLAPDataProvider = OLAPDataProvider.Adomd;
            pivotGridControl1.OLAPConnectionString =
                @"Provider=MSOLAP;
                Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll; 
                Initial catalog=Adventure Works DW Standard Edition;
                Cube name=Adventure Works;
                Query Timeout=100;";

            // Retrieves fields.
            pivotGridControl1.RetrieveFields(PivotArea.ColumnArea, false);

            // Adds some fields from the Field List to the specified area to create a report.
            pivotGridControl1.Fields["[Customer].[Country].[Country]"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["[Customer].[Country].[Country]"].Visible = true;
            pivotGridControl1.Fields["[Customer].[City].[City]"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["[Customer].[City].[City]"].Visible = true;
            pivotGridControl1.Fields["[Date].[Fiscal].[Fiscal Year]"].Area = PivotArea.ColumnArea;
            pivotGridControl1.Fields["[Date].[Fiscal].[Fiscal Year]"].Visible = true;
            pivotGridControl1.Fields["[Measures].[Internet Sales Amount]"].Visible = true;

            // Sets the Customization Forms style to Excel2007 with additional capabilities.
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007;

            // Invokes the Customization Form.
            pivotGridControl1.FieldsCustomization();
        }
    }
}
