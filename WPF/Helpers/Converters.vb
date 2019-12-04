Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports Syncfusion.UI.Xaml.Grid.Converter
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Data
Imports System.Windows.Media

Namespace ExportingDemo
	Public Class EccelOptionsConverter
		Implements IMultiValueConverter
		Private Shared _isCustomize As Boolean=False
		Public Property isCustomized() As Boolean
			Get
				Return _isCustomize
			End Get
			Set(ByVal value As Boolean)
				_isCustomize = value

			End Set
		End Property

		Private Shared _isCustomizeRow As Boolean=False
		Public Property IsCustomizeRow() As Boolean
			Get
				Return _isCustomizeRow
			End Get
			Set(ByVal value As Boolean)
				_isCustomizeRow = value

			End Set
		End Property
		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			Dim options = New ExcelExportingOptions()
			If Not CBool(values(0)) Then
				options.AllowOutlining = False
			End If
			If CBool(values(1)) Then
				isCustomized = True
			Else
				isCustomized = False
			End If

			If CBool(values(2)) Then
				IsCustomizeRow = True
			Else
				IsCustomizeRow = False
			End If

			Return options
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Return Nothing
		End Function
	End Class
End Namespace
