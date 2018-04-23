Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports System.Data
Imports DevExpress.XtraTreeList
Imports System.Windows.Forms
Imports System.Drawing.Printing

Namespace E3239.Reports
	Partial Public Class TreeReport
		Inherits XtraReport

		Private dt As DataTable
		Private treeList As New TreeList()

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(ByVal dt As DataTable)
			Me.dt = dt
			InitializeComponent()
		End Sub

		Private Sub TreeReport_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles MyBase.BeforePrint
			UpdateTreeList(treeList)
		End Sub

		Private Sub UpdateTreeList(ByVal treeList As TreeList)
			If treeList IsNot Nothing Then
				Dim wcc As New WinControlContainer()
				treeList.Parent = New Form()
				Detail.Controls.Add(wcc)
				wcc.WinControl = treeList

				treeList.KeyFieldName = "uniqueID"
				treeList.ParentFieldName = "parentID"
				treeList.DataSource = dt
				treeList.ExpandAll()
				treeList.ForceInitialize()
			End If
		End Sub
	End Class
End Namespace
