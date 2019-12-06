Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports ExportingDemo.Model
Imports Syncfusion.Windows.Controls.Grid
Imports System.Collections.ObjectModel

Namespace ExportingDemo
	Public Class ViewModel
		Private northWind As Northwind
		Public Sub New()
			ProductInfo = Me.GetProductInfo()
		End Sub

		Private _productInfo As List(Of Products)

		''' <summary>
		''' Gets or sets the product info.
		''' </summary>
		''' <value>The product info.</value>
		Public Property ProductInfo() As List(Of Products)
			Get
				Return _productInfo
			End Get
			Set(ByVal value As List(Of Products))
				_productInfo = value

			End Set
		End Property

		''' <summary>
		''' Gets the product info.
		''' </summary>
		''' <returns></returns>
		Public Function GetProductInfo() As List(Of Products)
			Dim productInfo As New List(Of Products)()
			If Not LayoutControl.IsInDesignMode Then
				northWind = New Northwind(String.Format("Data Source= {0}", LayoutControl.FindFile("Northwind.sdf")))
				Dim ords = northWind.Products.Take(500)
				For Each em In ords
					productInfo.Add(em)
				Next em
			End If
			Return productInfo
		End Function
	End Class
End Namespace
