Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace FilterCriteriaSample
    Public Class FilterViewModel
        Private privateCategories As List(Of Category)
        Public Property Categories() As List(Of Category)
            Get
                Return privateCategories
            End Get
            Private Set(ByVal value As List(Of Category))
                privateCategories = value
            End Set
        End Property

        Private privateUnitPriceMinValue As Decimal
        Public Property UnitPriceMinValue() As Decimal
            Get
                Return privateUnitPriceMinValue
            End Get
            Private Set(ByVal value As Decimal)
                privateUnitPriceMinValue = value
            End Set
        End Property
        Private privateUnitPriceMaxValue As Decimal
        Public Property UnitPriceMaxValue() As Decimal
            Get
                Return privateUnitPriceMaxValue
            End Get
            Private Set(ByVal value As Decimal)
                privateUnitPriceMaxValue = value
            End Set
        End Property

        Private privateUnitsOnOrderMinValue As Short
        Public Property UnitsOnOrderMinValue() As Short
            Get
                Return privateUnitsOnOrderMinValue
            End Get
            Private Set(ByVal value As Short)
                privateUnitsOnOrderMinValue = value
            End Set
        End Property
        Private privateUnitsOnOrderMaxValue As Short
        Public Property UnitsOnOrderMaxValue() As Short
            Get
                Return privateUnitsOnOrderMaxValue
            End Get
            Private Set(ByVal value As Short)
                privateUnitsOnOrderMaxValue = value
            End Set
        End Property

        Private privateUnitsInStockMinValue As Short
        Public Property UnitsInStockMinValue() As Short
            Get
                Return privateUnitsInStockMinValue
            End Get
            Private Set(ByVal value As Short)
                privateUnitsInStockMinValue = value
            End Set
        End Property
        Private privateUnitsInStockMaxValue As Short
        Public Property UnitsInStockMaxValue() As Short
            Get
                Return privateUnitsInStockMaxValue
            End Get
            Private Set(ByVal value As Short)
                privateUnitsInStockMaxValue = value
            End Set
        End Property


        Public Sub New(ByVal context As NwindDbContext)
            Categories = context.Categories.ToList()

            UnitPriceMinValue = context.Products.Min(Function(p) p.UnitPrice).Value
            UnitPriceMaxValue = context.Products.Max(Function(p) p.UnitPrice).Value

            UnitsInStockMinValue = context.Products.Min(Function(p) p.UnitsInStock).Value
            UnitsInStockMaxValue = context.Products.Max(Function(p) p.UnitsInStock).Value

            UnitsOnOrderMinValue = context.Products.Min(Function(p) p.UnitsOnOrder).Value
            UnitsOnOrderMaxValue = context.Products.Max(Function(p) p.UnitsOnOrder).Value
        End Sub


    End Class
End Namespace
