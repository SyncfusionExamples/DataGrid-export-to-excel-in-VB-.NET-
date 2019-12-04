Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.IO
Imports System.Windows.Media
Imports Syncfusion.UI.Xaml.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Input
Imports Syncfusion.UI.Xaml.Grid.Converter
Imports Syncfusion.XlsIO
Imports System.Windows
Imports Microsoft.Win32

Namespace ExportingDemo
	Public NotInheritable Class ExportSelectedCommand
		Private Sub New()
		End Sub
		Shared Sub New()
			CommandManager.RegisterClassCommandBinding(GetType(SfDataGrid), New CommandBinding(ExportToExcel, AddressOf OnExecuteExportToExcel, AddressOf OnCanExecuteExportToExcel))
		End Sub

		#Region "ExportToExcel Command"

		Public Shared ExportToExcel As New RoutedCommand("ExportToExcel", GetType(SfDataGrid))

		Private Shared Sub OnExecuteExportToExcel(ByVal sender As Object, ByVal args As ExecutedRoutedEventArgs)
			Dim dataGrid = TryCast(args.Source, SfDataGrid)
			Dim ExcelOption As New EccelOptionsConverter()
			If dataGrid Is Nothing Then
				Return
			End If

			Dim options = TryCast(args.Parameter, ExcelExportingOptions)
			options.ExcelVersion = ExcelVersion.Excel2010
			If Not ExcelOption.IsCustomizeRow Then
			   options.ExportingEventHandler = AddressOf ExportingHandler
			Else
			   options.ExportingEventHandler = AddressOf CustomizeExportingHandler
			End If

			options.CellsExportingEventHandler = AddressOf CellExportingHandler

			Dim excelEngine As New ExcelEngine()
			Dim workBook As IWorkbook = excelEngine.Excel.Workbooks.Create()
			workBook.Worksheets.Create()

			dataGrid.ExportToExcel(dataGrid.SelectedItems, options, workBook.Worksheets(0))
			'workBook.Save();

			Dim sfd As SaveFileDialog = New SaveFileDialog With {.FilterIndex = 2, .Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx", .FileName = "Book1"}

			If sfd.ShowDialog() = True Then
				Using stream As Stream = sfd.OpenFile()
					If sfd.FilterIndex = 1 Then
						workBook.Version = ExcelVersion.Excel97to2003
					Else
						workBook.Version = ExcelVersion.Excel2010
					End If
					workBook.SaveAs(stream)
				End Using

				'Message box confirmation to view the created spreadsheet.
				If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButton.YesNo, MessageBoxImage.Information) = MessageBoxResult.Yes Then
					'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
					System.Diagnostics.Process.Start(sfd.FileName)
				End If
			End If

		End Sub

		Private Shared Sub CustomizeExportingHandler(ByVal sender As Object, ByVal e As GridExcelExportingEventArgs)
            If (e.CellType = ExportCellType.RecordCell) Then
                e.CellStyle.BackGroundBrush = New SolidColorBrush(Colors.Violet)
                e.Handled = True
            End If
        End Sub

		Private Shared Sub CellExportingHandler(ByVal sender As Object, ByVal e As GridCellExcelExportingEventArgs)
			e.Range.CellStyle.Font.Size = 12
			e.Range.CellStyle.Font.FontName = "Segoe UI"

			If e.ColumnName = "UnitPrice" OrElse e.ColumnName = "UnitsInStock" Then
				Dim value As Double = 0
				If Double.TryParse(e.CellValue.ToString(), value) Then
					e.Range.Number = value
				End If
				e.Handled = True
			End If
		End Sub

		Private Shared Sub ExportingHandler(ByVal sender As Object, ByVal e As GridExcelExportingEventArgs)
            If e.CellType = ExportCellType.HeaderCell Then
                e.CellStyle.BackGroundBrush = New SolidColorBrush(Colors.LightSteelBlue)
                e.CellStyle.ForeGroundBrush = New SolidColorBrush(Colors.DarkRed)
                e.CellStyle.FontInfo.Bold = True
            End If
            e.CellStyle.FontInfo.Size = 12
			e.CellStyle.FontInfo.FontName = "Segoe UI"
			e.Handled = True
		End Sub

		Private Shared Sub OnCanExecuteExportToExcel(ByVal sender As Object, ByVal args As CanExecuteRoutedEventArgs)
			Dim grid = TryCast(args.Source, SfDataGrid)
			If grid.SelectedItems IsNot Nothing AndAlso grid.SelectedItems.Any() Then
				args.CanExecute = True
			Else
				args.CanExecute = False
			End If
		End Sub

		#End Region

	End Class
End Namespace
