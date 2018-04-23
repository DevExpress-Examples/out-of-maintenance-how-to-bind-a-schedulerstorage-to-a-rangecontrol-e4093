Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerStorageRangeControl
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
			Me.components = New System.ComponentModel.Container()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStart = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEnd = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(0, 145)
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(931, 5)
			Me.splitterControl1.TabIndex = 2
			Me.splitterControl1.TabStop = False
			' 
			' rangeControl
			' 
			Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.rangeControl.Location = New System.Drawing.Point(0, 0)
			Me.rangeControl.MinimumSize = New System.Drawing.Size(100, 100)
			Me.rangeControl.Name = "rangeControl"
			Me.rangeControl.ShowToolTips = False
			Me.rangeControl.Size = New System.Drawing.Size(931, 145)
			Me.rangeControl.TabIndex = 13
'			Me.rangeControl.RangeChanged += New DevExpress.XtraEditors.RangeChangedEventHandler(Me.RangeControlRangeChanged);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 150)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.ShowOnlyPredefinedDetails = True
			Me.gridControl1.Size = New System.Drawing.Size(931, 429)
			Me.gridControl1.TabIndex = 14
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSubject, Me.colStart, Me.colEnd, Me.colDescription})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowFooter = True
			' 
			' colSubject
			' 
			Me.colSubject.Caption = "Subject"
			Me.colSubject.FieldName = "Subject"
			Me.colSubject.Name = "colSubject"
			Me.colSubject.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
			Me.colSubject.Visible = True
			Me.colSubject.VisibleIndex = 0
			Me.colSubject.Width = 150
			' 
			' colStart
			' 
			Me.colStart.Caption = "Start"
			Me.colStart.FieldName = "Start"
			Me.colStart.Name = "colStart"
			Me.colStart.Visible = True
			Me.colStart.VisibleIndex = 1
			Me.colStart.Width = 244
			' 
			' colEnd
			' 
			Me.colEnd.Caption = "End"
			Me.colEnd.FieldName = "End"
			Me.colEnd.Name = "colEnd"
			Me.colEnd.Visible = True
			Me.colEnd.VisibleIndex = 2
			Me.colEnd.Width = 244
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 3
			Me.colDescription.Width = 275
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(931, 579)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.splitterControl1)
			Me.Controls.Add(Me.rangeControl)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private WithEvents rangeControl As DevExpress.XtraEditors.RangeControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
		Private colStart As DevExpress.XtraGrid.Columns.GridColumn
		Private colEnd As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

