Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.ComponentModel

Namespace MasterDetailsExportingDemo
	Public Class OrderDetails
		Implements INotifyPropertyChanged
		Private _OrderID? As Integer

		''' <summary>
		''' Gets or sets the order ID.
		''' </summary>
		''' <value>The order ID.</value>
		Public Property OrderID() As Integer?
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value? As Integer)
				Me._OrderID = value
				RaisePropertyChanged("OrderID")
			End Set
		End Property

		Private _ProductID As Integer

		''' <summary>
		''' Gets or sets the product ID.
		''' </summary>
		''' <value>The product ID.</value>
		Public Property ProductID() As Integer
			Get
				Return Me._ProductID
			End Get
			Set(ByVal value As Integer)
				Me._ProductID = value
				RaisePropertyChanged("ProductID")
			End Set
		End Property

		Private _UnitPrice As Decimal

		''' <summary>
		''' Gets or sets the unit price.
		''' </summary>
		''' <value>The unit price.</value>
		Public Property UnitPrice() As Decimal
			Get
				Return Me._UnitPrice
			End Get
			Set(ByVal value As Decimal)
				Me._UnitPrice = value
				RaisePropertyChanged("UnitPrice")
			End Set
		End Property
		Private _Quantity As Int16

		''' <summary>
		''' Gets or sets the quantity.
		''' </summary>
		''' <value>The quantity.</value>
		Public Property Quantity() As Int16
			Get
				Return Me._Quantity
			End Get
			Set(ByVal value As Int16)
				Me._Quantity = value
				RaisePropertyChanged("Quantity")
			End Set
		End Property
		Private _Discount As Double

		''' <summary>
		''' Gets or sets the discount.
		''' </summary>
		''' <value>The discount.</value>
		Public Property Discount() As Double
			Get
				Return Me._Discount
			End Get
			Set(ByVal value As Double)
				Me._Discount = value
				RaisePropertyChanged("Discount")
			End Set
		End Property

		Private _customerID As String

		''' <summary>
		''' Gets or sets the customer ID.
		''' </summary>
		''' <value>The customer ID.</value>
		Public Property CustomerID() As String
			Get
				Return _customerID
			End Get
			Set(ByVal value As String)
				_customerID = value
				RaisePropertyChanged("CustomerID")
			End Set
		End Property

		Private _orderDate As DateTime

		''' <summary>
		''' Gets or sets the order date.
		''' </summary>
		''' <value>The order date.</value>
		Public Property OrderDate() As DateTime
			Get
				Return _orderDate
			End Get
			Set(ByVal value As DateTime)
				_orderDate = value
				RaisePropertyChanged("OrderDate")
			End Set
		End Property

		''' <summary>
		''' Initializes a new instance of the <see cref="OrderDetails"/> class.
		''' </summary>
		''' <param name="ord">The ord.</param>
		''' <param name="prod">The prod.</param>
		''' <param name="unit">The unit.</param>
		''' <param name="quan">The quan.</param>
		''' <param name="disc">The disc.</param>
		Public Sub New(ByVal ord As Integer, ByVal prod As Integer, ByVal unit As Decimal, ByVal quan As Int16, ByVal disc As Double, ByVal cusid As String, ByVal ordDt As DateTime)
			Me._Discount = disc
			Me._OrderID = ord
			Me._ProductID = prod
			Me._Quantity = quan
			Me._UnitPrice = unit
			Me._customerID = cusid
			Me._orderDate = ordDt
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub RaisePropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
		End Sub
	End Class
End Namespace
