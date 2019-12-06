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
Imports System.ComponentModel

Namespace MasterDetailsExportingDemo
	Public Class OrderInfo
		Implements INotifyPropertyChanged

		Private _OrderID As Integer

		Private _CustomerID As String

		Private _EmployeeID? As Integer

		Private _ShipCity As String

		Private _ShipCountry As String

		Private _Freight As Double

'INSTANT VB NOTE: The variable orderDetails was renamed since Visual Basic does not allow class members with the same name:
		Private orderDetails_Renamed As List(Of OrderDetails)
		Private _isClosed As Boolean

		Private _shippingDate As DateTime

		''' <summary>
		''' Initializes a new instance of the <see cref="OrderInfo"/> class.
		''' </summary>
		Public Sub New()

		End Sub

		''' <summary>
		''' Gets or sets the order details.
		''' </summary>
		''' <value>The order details.</value>
		Public Property OrderDetails() As List(Of OrderDetails)
			Get
				Return Me.orderDetails_Renamed
			End Get
			Set(ByVal value As List(Of OrderDetails))
				Me.orderDetails_Renamed = value
				RaisePropertyChanged("OrderDetails")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the order ID.
		''' </summary>
		''' <value>The order ID.</value>
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				Me._OrderID = value
				RaisePropertyChanged("OrderID")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the customer ID.
		''' </summary>
		''' <value>The customer ID.</value>
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				Me._CustomerID = value
				RaisePropertyChanged("CustomerID")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the shipping date.
		''' </summary>
		''' <value>The shipping date.</value>
		Public Property ShippingDate() As DateTime
			Get
				Return _shippingDate
			End Get
			Set(ByVal value As DateTime)
				_shippingDate = value
				RaisePropertyChanged("ShippingDate")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the employee ID.
		''' </summary>
		''' <value>The employee ID.</value>
		Public Property EmployeeID() As Integer?
			Get
				Return Me._EmployeeID
			End Get
			Set(ByVal value? As Integer)
				Me._EmployeeID = value
				RaisePropertyChanged("EmployeeID")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the ship city.
		''' </summary>
		''' <value>The ship city.</value>
		Public Property ShipCity() As String
			Get
				Return Me._ShipCity
			End Get
			Set(ByVal value As String)
				Me._ShipCity = value
				RaisePropertyChanged("ShipCity")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the ship country.
		''' </summary>
		''' <value>The ship country.</value>
		Public Property ShipCountry() As String
			Get
				Return Me._ShipCountry
			End Get
			Set(ByVal value As String)
				Me._ShipCountry = value
				RaisePropertyChanged("ShipCountry")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the freight.
		''' </summary>
		''' <value>The freight.</value>
		Public Property Freight() As Double
			Get
				Return Me._Freight
			End Get
			Set(ByVal value As Double)
				Me._Freight = value
				RaisePropertyChanged("Freight")
			End Set
		End Property

		''' <summary>
		''' Gets or sets a value indicating whether this instance is closed.
		''' </summary>
		''' <value><c>true</c> if this instance is closed; otherwise, <c>false</c>.</value>
		Public Property IsClosed() As Boolean
			Get
				Return Me._isClosed
			End Get

			Set(ByVal value As Boolean)
				Me._isClosed = value
				Me.RaisePropertyChanged("IsClosed")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub RaisePropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
		End Sub
	End Class
End Namespace
