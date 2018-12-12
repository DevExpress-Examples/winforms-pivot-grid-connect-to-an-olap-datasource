namespace WinOlapRetrieveFieldsExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRetrieveFields = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateUnboundFields = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            pivotGridGroup2.Caption = "Date.Fiscal";
            pivotGridGroup2.Hierarchy = "[Date].[Fiscal]";
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup2});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 52);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OLAPConnectionString = "";
            this.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd;
            this.pivotGridControl1.Size = new System.Drawing.Size(755, 387);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCreateUnboundFields);
            this.panelControl1.Controls.Add(this.btnRetrieveFields);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(755, 52);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRetrieveFields
            // 
            this.btnRetrieveFields.AccessibleDescription = "            pivotGridControl1.Fields[\"[Customer].[Country].[Country]\"]";
            this.btnRetrieveFields.Location = new System.Drawing.Point(30, 12);
            this.btnRetrieveFields.Name = "btnRetrieveFields";
            this.btnRetrieveFields.Size = new System.Drawing.Size(107, 23);
            this.btnRetrieveFields.TabIndex = 0;
            this.btnRetrieveFields.Text = "Retrieve Fields";
            this.btnRetrieveFields.Click += new System.EventHandler(this.btnRetrieveFields_Click);
            // 
            // btnCreateUnboundFields
            // 
            this.btnCreateUnboundFields.AccessibleDescription = "";
            this.btnCreateUnboundFields.Location = new System.Drawing.Point(174, 12);
            this.btnCreateUnboundFields.Name = "btnCreateUnboundFields";
            this.btnCreateUnboundFields.Size = new System.Drawing.Size(107, 23);
            this.btnCreateUnboundFields.TabIndex = 1;
            this.btnCreateUnboundFields.Text = "Create Fields";
            this.btnCreateUnboundFields.Click += new System.EventHandler(this.btnCreateFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 439);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "WinForms Pivot Grid OLAP Example";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreateUnboundFields;
        private DevExpress.XtraEditors.SimpleButton btnRetrieveFields;
    }
}

