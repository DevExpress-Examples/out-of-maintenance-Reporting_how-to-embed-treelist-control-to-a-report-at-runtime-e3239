Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList


Namespace E3239
	Partial Public Class Form1
		Inherits Form
		Private dt As New DataTable("TreeTable")
		Private treeList As New TreeList()

		Public Sub New()
			InitializeComponent()

			LoadData()
			InitializeTreeList()
		End Sub

		Private Sub LoadData()
			dt.Columns.Add("uniqueID", GetType(Integer))
			dt.Columns.Add("parentID", GetType(Integer))
			dt.Columns.Add("PositionNode", GetType(Object))
			dt.Columns.Add("Code", GetType(String))
			dt.Columns.Add("Level", GetType(Single))
			dt.Columns.Add("Position", GetType(Single))

			For i As Integer = 0 To 9
				Dim dr As DataRow = dt.NewRow()
				dr("uniqueID") = i
				dr("parentID") = i \ 3
				dr("Code") = "code" & i
				dr("Position") = i
				dr("Level") = dr("Position")
				dt.Rows.Add(dr)
			Next i
		End Sub

		Private Sub InitializeTreeList()
			Controls.Add(treeList)
			treeList.Dock = DockStyle.Fill
			treeList.DataSource = dt
			treeList.ParentFieldName = "parentID"
			treeList.KeyFieldName = "uniqueID"
			treeList.ExpandAll()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim rep As New Reports.TreeReport(TryCast(treeList.DataSource, DataTable))
			rep.ShowPreview()
		End Sub
	End Class
End Namespace