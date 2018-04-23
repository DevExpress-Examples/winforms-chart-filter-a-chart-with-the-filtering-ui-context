Imports System.Data.Entity.Spatial
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations
Imports System.Collections.Generic
Imports System
Imports DevExpress.Utils.Filtering

Namespace FilterCriteriaSample

    Partial Public Class Product
        <Key, Display(AutoGenerateFilter := False)> _
        Public Property ProductID() As Integer

        <Required, StringLength(40), Display(AutoGenerateFilter := False)> _
        Public Property ProductName() As String

        <Display(AutoGenerateFilter := False)> _
        Public Property SupplierID() As Integer?

        <Display(Name := "Category"), FilterLookup(DataSourceMember := "Categories", DisplayMember := "CategoryName", ValueMember := "CategoryID", UseBlanks := False)> _
        Public Property CategoryID() As Integer

        <StringLength(20), Display(AutoGenerateFilter := False)> _
        Public Property QuantityPerUnit() As String

        <Display(Name := "Unit Price"), FilterRange(EditorType := RangeUIEditorType.Default, MinimumMember := "UnitPriceMinValue", MaximumMember := "UnitPriceMaxValue"), Column(TypeName := "smallmoney")> _
        Public Property UnitPrice() As Decimal?

        <Display(Name := "Units in Stock"), FilterRange(EditorType := RangeUIEditorType.Range, MaximumMember := "UnitsInStockMaxValue", MinimumMember := "UnitsInStockMinValue")> _
        Public Property UnitsInStock() As Short?

        <Display(Name := "Units on Order"), FilterRange(EditorType := RangeUIEditorType.Range, MaximumMember := "UnitsOnOrderMaxValue", MinimumMember := "UnitsOnOrderMinValue")> _
        Public Property UnitsOnOrder() As Short?

        <Display(AutoGenerateFilter := False)> _
        Public Property ReorderLevel() As Short?

        <Display(AutoGenerateFilter := False)> _
        Public Property Discontinued() As Boolean

        <Column(TypeName := "text"), Display(AutoGenerateFilter := False)> _
        Public Property EAN13() As String

        <Display(AutoGenerateFilter := False)> _
        Public ReadOnly Property OnOrderIncome() As Decimal
            Get

                Dim unitsOnOrder_Renamed As Short = If(UnitsOnOrder.HasValue, UnitsOnOrder.Value, CShort(0))

                Dim unitPrice_Renamed As Decimal = If(UnitPrice.HasValue, UnitPrice.Value, 0)
                Return unitsOnOrder_Renamed * unitPrice_Renamed
            End Get
        End Property
    End Class
End Namespace
