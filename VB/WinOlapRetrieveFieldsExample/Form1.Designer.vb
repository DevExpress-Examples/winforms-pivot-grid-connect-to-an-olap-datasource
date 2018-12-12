Namespace WinOlapRetrieveFieldsExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim pivotGridGroup2 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnRetrieveFields = New DevExpress.XtraEditors.SimpleButton()
			Me.btnCreateUnboundFields = New DevExpress.XtraEditors.SimpleButton()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			pivotGridGroup2.Caption = "Date.Fiscal"
			pivotGridGroup2.Hierarchy = "[Date].[Fiscal]"
			Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup2})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 52)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OLAPConnectionString = ""
			Me.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd
			Me.pivotGridControl1.Size = New System.Drawing.Size(755, 387)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnCreateUnboundFields)
			Me.panelControl1.Controls.Add(Me.btnRetrieveFields)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(755, 52)
			Me.panelControl1.TabIndex = 1
			' 
			' btnRetrieveFields
			' 
			Me.btnRetrieveFields.AccessibleDescription = "            pivotGridControl1.Fields[""[Customer].[Country].[Country]""]"
			Me.btnRetrieveFields.Location = New System.Drawing.Point(30, 12)
			Me.btnRetrieveFields.Name = "btnRetrieveFields"
			Me.btnRetrieveFields.Size = New System.Drawing.Size(107, 23)
			Me.btnRetrieveFields.TabIndex = 0
			Me.btnRetrieveFields.Text = "Retrieve Fields"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnRetrieveFields.Click += new System.EventHandler(this.btnRetrieveFields_Click);
			' 
			' btnCreateUnboundFields
			' 
			Me.btnCreateUnboundFields.AccessibleDescription = ""
			Me.btnCreateUnboundFields.Location = New System.Drawing.Point(174, 12)
			Me.btnCreateUnboundFields.Name = "btnCreateUnboundFields"
			Me.btnCreateUnboundFields.Size = New System.Drawing.Size(107, 23)
			Me.btnCreateUnboundFields.TabIndex = 1
			Me.btnCreateUnboundFields.Text = "Create Fields"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnCreateUnboundFields.Click += new System.EventHandler(this.btnCreateFields_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(755, 439)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "WinForms Pivot Grid OLAP Example"
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btnCreateUnboundFields As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnRetrieveFields As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

