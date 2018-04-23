Imports Microsoft.VisualBasic
Imports System
Namespace E3239.Reports
	Partial Public Class TreeReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		''' 

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			'try { Dispose(base); }
			'    catch
			'{}
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colportfolioTable = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colcolCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colcolLabel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colcolWeight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colLabel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' colOid
			' 
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.Visible = True
			Me.colOid.VisibleIndex = 0
			' 
			' colportfolioTable
			' 
			Me.colportfolioTable.FieldName = "portfolioTable"
			Me.colportfolioTable.Name = "colportfolioTable"
			Me.colportfolioTable.Visible = True
			Me.colportfolioTable.VisibleIndex = 1
			' 
			' colcolCode
			' 
			Me.colcolCode.FieldName = "colCode"
			Me.colcolCode.Name = "colcolCode"
			Me.colcolCode.Visible = True
			Me.colcolCode.VisibleIndex = 2
			' 
			' colcolLabel
			' 
			Me.colcolLabel.FieldName = "colLabel"
			Me.colcolLabel.Name = "colcolLabel"
			Me.colcolLabel.Visible = True
			Me.colcolLabel.VisibleIndex = 3
			' 
			' colcolWeight
			' 
			Me.colcolWeight.FieldName = "colWeight"
			Me.colcolWeight.Name = "colcolWeight"
			Me.colcolWeight.Visible = True
			Me.colcolWeight.VisibleIndex = 4
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 5
			' 
			' colLabel
			' 
			Me.colLabel.FieldName = "Label"
			Me.colLabel.Name = "colLabel"
			Me.colLabel.Visible = True
			Me.colLabel.VisibleIndex = 6
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TreeReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.Detail, Me.BottomMargin})
			Me.PageHeight = 1169
			Me.PageWidth = 827
			Me.PaperKind = System.Drawing.Printing.PaperKind.A4
			Me.Version = "10.2"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.TreeReport_BeforePrint);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colportfolioTable As DevExpress.XtraGrid.Columns.GridColumn
		Private colcolCode As DevExpress.XtraGrid.Columns.GridColumn
		Private colcolLabel As DevExpress.XtraGrid.Columns.GridColumn
		Private colcolWeight As DevExpress.XtraGrid.Columns.GridColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLabel As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace
