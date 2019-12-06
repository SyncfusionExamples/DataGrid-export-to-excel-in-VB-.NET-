Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.Collections.Generic

Namespace MasterDetailsExportingDemo
	Public Class Customers
		Inherits List(Of String)
		''' <summary>
		''' Initializes a new instance of the <see cref="Customers"/> class.
		''' </summary>
		Public Sub New()
			Dim model = New OrderInfoRepository()
			Me.AddRange(model.Customers)
		End Sub
	End Class
End Namespace
