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

Namespace MasterDetailsExportingDemo
	Public Class OrderInfoRepository

		''' <summary>
		''' Initializes a new instance of the <see cref="OrderInfoRepository"/> class.
		''' </summary>
		Public Sub New()

		End Sub

		''' <summary>
		''' Gets the orders details.
		''' </summary>
		''' <param name="count">The count.</param>
		''' <returns></returns>
		Public Function GetOrdersDetails(ByVal count As Integer) As List(Of OrderInfo)
			Dim ordersDetails As New List(Of OrderInfo)()
			Me.OrderedDates = GetDateBetween(2008, 2012, count)
			OrdersAdd(count)
			SetShipCity()
			For i As Integer = 10000 To count + 10000 - 1
				ordersDetails.Add(GetOrder_Renamed(i))
			Next i
			Return ordersDetails
		End Function

		''' <summary>
		''' Gets the customers.
		''' </summary>
		''' <value>The customers.</value>
		Public ReadOnly Property Customers() As List(Of String)
			Get
				Return Me.CustomerID.ToList()
			End Get
		End Property

		''' <summary>
		''' Gets the ship countries.
		''' </summary>
		''' <value>The ship countries.</value>
		Public ReadOnly Property ShipCountries() As List(Of String)
			Get
				Return Me.ShipCountry.ToList()
			End Get
		End Property

		''' <summary>
		''' Orderses the add.
		''' </summary>
		Private Sub OrdersAdd(ByVal count As Integer)
			ord.Add(New OrderDetails(10000, 12, 23, 5, 10, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count-1))))
			ord.Add(New OrderDetails(10000, 14, 59, 10, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10000, 18, 23, 5, 10, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10000, 34, 59, 10, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10000, 14, 59, 10, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10000, 18, 23, 5, 10, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10000, 34, 59, 10, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10001, 23, 45, 76, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10001, 45, 67, 23, 5, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10001, 45, 42, 16, 3, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10001, 23, 95, 15, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10002, 7, 70, 6, 4, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10002, 2, 30, 5, 2, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10003, 23, 73, 9, 3, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10003, 8, 11, 8, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10003, 1, 150, 1, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10009, 4, 35, 4, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10009, 2, 31, 7, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10010, 7, 23, 3, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10010, 5, 65, 4, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10010, 3, 15, 5, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10010, 2, 31, 1, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10011, 6, 46, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10011, 3, 45, 4, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10011, 2, 41, 7, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10013, 19, 80, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10013, 20, 111, 2, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10021, 54, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10021, 63, 46, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10021, 27, 99, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10022, 59, 80, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10022, 60, 111, 2, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10022, 47, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10032, 4, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10032, 6, 46, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10034, 17, 99, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10034, 19, 80, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10034, 20, 111, 2, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10042, 4, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10042, 4, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10045, 6, 46, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10045, 17, 99, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10045, 19, 80, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10045, 20, 111, 2, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10056, 4, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10056, 4, 35, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10056, 6, 46, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10067, 17, 99, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10067, 19, 80, 2, 0, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
			ord.Add(New OrderDetails(10067, 20, 111, 2, 7, CustomerID(r.Next(15)), Me.OrderedDates(r.Next(count - 1))))
		End Sub

		Private OrderedDates As List(Of DateTime)
		Private r As New Random()
		Private ord As New List(Of OrderDetails)()

		''' <summary>
		''' Gets the order.
		''' </summary>
		''' <param name="i">The i.</param>
		''' <returns></returns>
		Private Function GetOrder_Renamed(ByVal i As Integer) As OrderInfo
			Dim shipcountry = Me.ShipCountry(r.Next(5))
			Dim shipcitycoll = ShipCity(shipcountry)
			Return New OrderInfo() With {.OrderID = i, .CustomerID = CustomerID(r.Next(15)), .EmployeeID = r.Next(1,10), .Freight = Math.Round(r.Next(1000) + r.NextDouble(), 2), .ShipCountry = shipcountry, .ShippingDate=Me.OrderedDates(i - 10000), .IsClosed=True, .ShipCity = shipcitycoll(r.Next(shipcitycoll.Length - 1)), .OrderDetails = getorder(i)}
		End Function

		''' <summary>
		''' Getors the specified i.
		''' </summary>
		''' <param name="i">The i.</param>
		''' <returns></returns>
		Public Function getorder(ByVal i As Integer) As List(Of OrderDetails)
			Dim order As New List(Of OrderDetails)()
			For Each [or] In ord
				If [or].OrderID.Equals(i) Then
					order.Add([or])
				End If
			Next [or]
			Return order
		End Function

		Private ShipCountry() As String = { "Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", "UK", "USA", "Venezuela" }

		Private ShipCity As New Dictionary(Of String, String())()

		''' <summary>
		''' Sets the ship city.
		''' </summary>
		Private Sub SetShipCity()
			Dim argentina() As String = { "Buenos Aires" }

			Dim austria() As String = { "Graz", "Salzburg" }

			Dim belgium() As String = { "Bruxelles", "Charleroi" }

			Dim brazil() As String = { "Campinas", "Resende", "Rio de Janeiro", "São Paulo" }

			Dim canada() As String = { "Montréal", "Tsawassen", "Vancouver" }

			Dim denmark() As String = { "Århus", "København" }

			Dim finland() As String = { "Helsinki", "Oulu" }

			Dim france() As String = { "Lille", "Lyon", "Marseille", "Nantes", "Paris", "Reims", "Strasbourg", "Toulouse", "Versailles" }

			Dim germany() As String = { "Aachen", "Berlin", "Brandenburg", "Cunewalde", "Frankfurt a.M.", "Köln", "Leipzig", "Mannheim", "München", "Münster", "Stuttgart" }

			Dim ireland() As String = { "Cork" }

			Dim italy() As String = { "Bergamo", "Reggio Emilia", "Torino" }

			Dim mexico() As String = { "México D.F." }

			Dim norway() As String = { "Stavern" }

			Dim poland() As String = { "Warszawa" }

			Dim portugal() As String = { "Lisboa" }

			Dim spain() As String = { "Barcelona", "Madrid", "Sevilla" }

			Dim sweden() As String = { "Bräcke", "Luleå" }

			Dim switzerland() As String = { "Bern", "Genève" }

			Dim uk() As String = { "Colchester", "Hedge End", "London" }

			Dim usa() As String = { "Albuquerque", "Anchorage", "Boise", "Butte", "Elgin", "Eugene", "Kirkland", "Lander", "Portland", "San Francisco", "Seattle", "Walla Walla" }

			Dim venezuela() As String = { "Barquisimeto", "Caracas", "I. de Margarita", "San Cristóbal" }

			ShipCity.Add("Argentina", argentina)
			ShipCity.Add("Austria", austria)
			ShipCity.Add("Belgium", belgium)
			ShipCity.Add("Brazil", brazil)
			ShipCity.Add("Canada", canada)
			ShipCity.Add("Denmark", denmark)
			ShipCity.Add("Finland", finland)
			ShipCity.Add("France", france)
			ShipCity.Add("Germany", germany)
			ShipCity.Add("Ireland", ireland)
			ShipCity.Add("Italy", italy)
			ShipCity.Add("Mexico", mexico)
			ShipCity.Add("Norway", norway)
			ShipCity.Add("Poland", poland)
			ShipCity.Add("Portugal", portugal)
			ShipCity.Add("Spain", spain)
			ShipCity.Add("Sweden", sweden)
			ShipCity.Add("Switzerland", switzerland)
			ShipCity.Add("UK", uk)
			ShipCity.Add("USA", usa)
			ShipCity.Add("Venezuela", venezuela)

		End Sub

		Private CustomerID() As String = { "ALFKI", "FRANS", "MEREP", "FOLKO", "SIMOB", "WARTH", "VAFFE", "FURIB", "SEVES", "LINOD", "RISCU", "PICCO", "BLONP", "WELLI", "FOLIG" }

		''' <summary>
		''' Gets the date between.
		''' </summary>
		''' <param name="startYear">The start year.</param>
		''' <param name="EndYear">The end year.</param>
		''' <param name="Count">The count.</param>
		''' <returns></returns>
		Private Function GetDateBetween(ByVal startYear As Integer, ByVal EndYear As Integer, ByVal Count As Integer) As List(Of DateTime)
			Dim [date] As New List(Of DateTime)()
			Dim d As New Random(1)
			Dim m As New Random(2)
			Dim y As New Random(startYear)
			For i As Integer = 0 To Count - 1
				Dim year As Integer = y.Next(startYear, EndYear)
				Dim month As Integer = m.Next(3, 13)
				Dim day As Integer = d.Next(1, 31)

				[date].Add(New DateTime(year, month, day))
			Next i
			Return [date]
		End Function
	End Class
End Namespace
