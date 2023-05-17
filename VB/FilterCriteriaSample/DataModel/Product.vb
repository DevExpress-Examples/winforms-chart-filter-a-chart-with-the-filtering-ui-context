Imports DevExpress.Utils.Filtering
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace FilterCriteriaSample

    Public Partial Class Product

        <Key>
        <Display(AutoGenerateFilter:=False)>
        Public Property ProductID As Integer

        <Required>
        <StringLength(40)>
        <Display(AutoGenerateFilter:=False)>
        Public Property ProductName As String

        <Display(AutoGenerateFilter:=False)>
        Public Property SupplierID As Integer?

        <Display(Name:="Category")>
        <FilterLookup(DataSourceMember:="Categories", DisplayMember:="CategoryName", ValueMember:="CategoryID", UseBlanks:=False)>
        Public Property CategoryID As Integer

        <StringLength(20)>
        <Display(AutoGenerateFilter:=False)>
        Public Property QuantityPerUnit As String

        <Display(Name:="Unit Price")>
        <FilterRange(EditorType:=RangeUIEditorType.Default, MinimumMember:="UnitPriceMinValue", MaximumMember:="UnitPriceMaxValue")>
        <Column(TypeName:="smallmoney")>
        Public Property UnitPrice As Decimal?

        <Display(Name:="Units in Stock")>
        <FilterRange(EditorType:=RangeUIEditorType.Range, MaximumMember:="UnitsInStockMaxValue", MinimumMember:="UnitsInStockMinValue")>
        Public Property UnitsInStock As Short?

        <Display(Name:="Units on Order")>
        <FilterRange(EditorType:=RangeUIEditorType.Range, MaximumMember:="UnitsOnOrderMaxValue", MinimumMember:="UnitsOnOrderMinValue")>
        Public Property UnitsOnOrder As Short?

        <Display(AutoGenerateFilter:=False)>
        Public Property ReorderLevel As Short?

        <Display(AutoGenerateFilter:=False)>
        Public Property Discontinued As Boolean

        <Column(TypeName:="text")>
        <Display(AutoGenerateFilter:=False)>
        Public Property EAN13 As String

        <Display(AutoGenerateFilter:=False)>
        Public ReadOnly Property OnOrderIncome As Decimal
            Get
                Dim unitsOnOrder As Short = If(Me.UnitsOnOrder.HasValue, Me.UnitsOnOrder.Value, CShort(0))
                Dim unitPrice As Decimal = If(Me.UnitPrice.HasValue, Me.UnitPrice.Value, 0)
                Return unitsOnOrder * unitPrice
            End Get
        End Property
    End Class
End Namespace
