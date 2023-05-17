Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace FilterCriteriaSample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Using context As NwindDbContext = New NwindDbContext()
                Products = context.Products.ToList()
                FilterViewModel = New FilterViewModel(context)
            End Using
        End Sub

#Region "#FilterCriteria"
        Private ReadOnly Property ProductSeries As Series
            Get
                Return chartControl.Series("Products")
            End Get
        End Property

        Private Property Products As List(Of Product)

        Private Property FilterViewModel As FilterViewModel

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ProductSeries.DataSource = Products
            ProductSeries.ArgumentDataMember = "ProductName"
            ProductSeries.ValueDataMembers.AddRange("OnOrderIncome")
            filteringUIContext.ParentViewModel = FilterViewModel
            filteringUIContext.ModelType = GetType(Product)
            filteringUIContext.SetFilterCriteriaBinding(ProductSeries, Function(s) s.FilterCriteria)
            filteringUIContext.RetrieveFields()
        End Sub
#End Region  ' #FilterCriteria
    End Class
End Namespace
