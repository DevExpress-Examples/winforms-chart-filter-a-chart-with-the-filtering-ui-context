Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace FilterCriteriaSample

    Public Class FilterViewModel

        Private _Categories As List(Of FilterCriteriaSample.Category), _UnitPriceMinValue As Decimal, _UnitPriceMaxValue As Decimal, _UnitsOnOrderMinValue As Short, _UnitsOnOrderMaxValue As Short, _UnitsInStockMinValue As Short, _UnitsInStockMaxValue As Short

        Public Property Categories As List(Of Category)
            Get
                Return _Categories
            End Get

            Private Set(ByVal value As List(Of Category))
                _Categories = value
            End Set
        End Property

        Public Property UnitPriceMinValue As Decimal
            Get
                Return _UnitPriceMinValue
            End Get

            Private Set(ByVal value As Decimal)
                _UnitPriceMinValue = value
            End Set
        End Property

        Public Property UnitPriceMaxValue As Decimal
            Get
                Return _UnitPriceMaxValue
            End Get

            Private Set(ByVal value As Decimal)
                _UnitPriceMaxValue = value
            End Set
        End Property

        Public Property UnitsOnOrderMinValue As Short
            Get
                Return _UnitsOnOrderMinValue
            End Get

            Private Set(ByVal value As Short)
                _UnitsOnOrderMinValue = value
            End Set
        End Property

        Public Property UnitsOnOrderMaxValue As Short
            Get
                Return _UnitsOnOrderMaxValue
            End Get

            Private Set(ByVal value As Short)
                _UnitsOnOrderMaxValue = value
            End Set
        End Property

        Public Property UnitsInStockMinValue As Short
            Get
                Return _UnitsInStockMinValue
            End Get

            Private Set(ByVal value As Short)
                _UnitsInStockMinValue = value
            End Set
        End Property

        Public Property UnitsInStockMaxValue As Short
            Get
                Return _UnitsInStockMaxValue
            End Get

            Private Set(ByVal value As Short)
                _UnitsInStockMaxValue = value
            End Set
        End Property

        Public Sub New(ByVal context As NwindDbContext)
            Categories = context.Categories.ToList()
            UnitPriceMinValue = Queryable.Min(Of Product, Global.System.Nullable(Of Global.System.[Decimal]))(context.Products, CType(Function(p) CType(p.UnitPrice, Decimal?), Expressions.Expression(Of Func(Of Product, Decimal?)))).Value
            UnitPriceMaxValue = Queryable.Max(Of Product, Global.System.Nullable(Of Global.System.[Decimal]))(context.Products, CType(Function(p) CType(p.UnitPrice, Decimal?), Expressions.Expression(Of Func(Of Product, Decimal?)))).Value
            UnitsInStockMinValue = Queryable.Min(Of Product, Global.System.Nullable(Of Global.System.Int16))(context.Products, CType(Function(p) CType(p.UnitsInStock, Short?), Expressions.Expression(Of Func(Of Product, Short?)))).Value
            UnitsInStockMaxValue = Queryable.Max(Of Product, Global.System.Nullable(Of Global.System.Int16))(context.Products, CType(Function(p) CType(p.UnitsInStock, Short?), Expressions.Expression(Of Func(Of Product, Short?)))).Value
            UnitsOnOrderMinValue = Queryable.Min(Of Product, Global.System.Nullable(Of Global.System.Int16))(context.Products, CType(Function(p) CType(p.UnitsOnOrder, Short?), Expressions.Expression(Of Func(Of Product, Short?)))).Value
            UnitsOnOrderMaxValue = Queryable.Max(Of Product, Global.System.Nullable(Of Global.System.Int16))(context.Products, CType(Function(p) CType(p.UnitsOnOrder, Short?), Expressions.Expression(Of Func(Of Product, Short?)))).Value
        End Sub
    End Class
End Namespace
