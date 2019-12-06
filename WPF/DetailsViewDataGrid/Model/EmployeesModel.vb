Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2015"
' Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.ComponentModel

Namespace MasterDetailsExportingDemo
	Public Class Employees
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

		Private _EmployeeID As Integer

		''' <summary>
		''' Gets or sets the employee ID.
		''' </summary>
		''' <value>The employee ID.</value>
		Public Property EmployeeID() As Integer
			Get
				Return Me._EmployeeID
			End Get
			Set(ByVal value As Integer)
				Me._EmployeeID = value
				RaisePropertyChanged("EmployeeID")
			End Set
		End Property

		Private _Name As String

		''' <summary>
		''' Gets or sets the name.
		''' </summary>
		''' <value>The name.</value>
		Public Property Name() As String
			Get
				Return Me._Name
			End Get
			Set(ByVal value As String)
				Me._Name = value
				RaisePropertyChanged("Name")
			End Set
		End Property

		''' <summary>
		''' Initializes a new instance of the <see cref="Employees"/> class.
		''' </summary>
		''' <param name="or">The or.</param>
		''' <param name="emp">The emp.</param>
		''' <param name="nam">The nam.</param>
		Public Sub New(ByVal [or] As Integer, ByVal emp As Integer, ByVal nam As String)
			Me.EmployeeID = emp
			Me.OrderID = [or]
			Me.Name = nam
		End Sub


		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub RaisePropertyChanged(ByVal name As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
		End Sub
	End Class
End Namespace
