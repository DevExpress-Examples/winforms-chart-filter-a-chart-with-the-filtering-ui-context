using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterCriteriaSample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            using(NwindDbContext context = new NwindDbContext()) {
                Products = context.Products.ToList();
                FilterViewModel = new FilterViewModel(context);
            }
        }

        #region #FilterCriteria
        Series ProductSeries { get { return chartControl.Series["Products"]; } }
        List<Product> Products { get; set; }
        FilterViewModel FilterViewModel { get; set; }

        private void Form1_Load(object sender, EventArgs e) {
            ProductSeries.DataSource = Products;
            ProductSeries.ArgumentDataMember = "ProductName";
            ProductSeries.ValueDataMembers.AddRange("OnOrderIncome");

            filteringUIContext.ParentViewModel = FilterViewModel;
            filteringUIContext.ModelType = typeof(Product);
            filteringUIContext.SetFilterCriteriaBinding(ProductSeries, s => s.FilterCriteria);
            filteringUIContext.RetrieveFields();
        }
        #endregion #FilterCriteria
    }
}
