# DataGrid export to excel in VB.NET
## About the sample
This example illustrates how to export the WPF DataGrid to excel
DataGrid provides support to export data to excel. It provides exporting support for grouping, filtering, sorting, paging, unbound rows, stacked headers, merged cells and details view.

The following assemblies needs to be added for exporting to excel.

•	Syncfusion.SfGridConverter.WPF
•	Syncfusion.XlsIO.Base

Exporting the DataGrid to excel can be performed by using [ExportToExcel](http://help.syncfusion.com/cr/cref_files/wpf/Syncfusion.SfGridConverter.WPF~Syncfusion.UI.Xaml.Grid.Converter.GridExcelExportExtension~ExportToExcel.html) extension method present in [Syncfusion.UI.Xaml.Grid.Converter](http://help.syncfusion.com/cr/cref_files/wpf/webtoc.html) namespace.

```c#
Imports Syncfusion.UI.Xaml.Grid.Converter
Imports Syncfusion.XlsIO

Dim options = New ExcelExportingOptions()
options.ExcelVersion = ExcelVersion.Excel2013
Dim excelEngine = dataGrid.ExportToExcel(dataGrid.View, options)
Dim workBook = excelEngine.Excel.Workbooks(0)
workBook.SaveAs("Sample.xlsx")
```
