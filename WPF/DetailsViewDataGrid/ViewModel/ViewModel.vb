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
	Public Class ViewModel
		''' <summary>
		''' Initializes a new instance of the <see cref="ViewModel"/> class.
		''' </summary>
		Public Sub New()
			Dim order As New OrderInfoRepository()
			OrdersDetails = order.GetOrdersDetails(100)
		End Sub

		Public _ordersDetails As List(Of OrderInfo)

		''' <summary>
		''' Gets or sets the orders details.
		''' </summary>
		''' <value>The orders details.</value>
		Public Property OrdersDetails() As List(Of OrderInfo)
			Get
				Return _ordersDetails
			End Get
			Set(ByVal value As List(Of OrderInfo))
				_ordersDetails = value
			End Set
		End Property
	End Class
End Namespace
