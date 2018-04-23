namespace FilterCriteriaSample
{
    using DevExpress.Utils.Filtering;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [Key]
        [Display(AutoGenerateFilter = false)]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(AutoGenerateFilter = false)]
        public string ProductName { get; set; }

        [Display(AutoGenerateFilter = false)]
        public int? SupplierID { get; set; }

        [Display(Name = "Category")]
        [FilterLookup(
            DataSourceMember = "Categories", 
            DisplayMember = "CategoryName", 
            ValueMember = "CategoryID", 
            UseBlanks = false)]
        public int CategoryID { get; set; }

        [StringLength(20)]
        [Display(AutoGenerateFilter = false)]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price")]
        [FilterRange(
            EditorType = RangeUIEditorType.Default,
            MinimumMember = "UnitPriceMinValue",
            MaximumMember = "UnitPriceMaxValue")]
        [Column(TypeName = "smallmoney")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Units in Stock")]
        [FilterRange(
            EditorType = RangeUIEditorType.Range,
            MaximumMember = "UnitsInStockMaxValue",
            MinimumMember = "UnitsInStockMinValue")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Units on Order")]
        [FilterRange(
            EditorType = RangeUIEditorType.Range, 
            MaximumMember = "UnitsOnOrderMaxValue", 
            MinimumMember = "UnitsOnOrderMinValue")]
        public short? UnitsOnOrder { get; set; }

        [Display(AutoGenerateFilter = false)]
        public short? ReorderLevel { get; set; }

        [Display(AutoGenerateFilter = false)]
        public bool Discontinued { get; set; }

        [Column(TypeName = "text")]
        [Display(AutoGenerateFilter = false)]
        public string EAN13 { get; set; }

        [Display(AutoGenerateFilter = false)]
        public decimal OnOrderIncome {
            get {
                short unitsOnOrder = UnitsOnOrder.HasValue ? UnitsOnOrder.Value : (short)0;
                decimal unitPrice = UnitPrice.HasValue ? UnitPrice.Value : 0;
                return unitsOnOrder * unitPrice;
            }
        }
    }
}
