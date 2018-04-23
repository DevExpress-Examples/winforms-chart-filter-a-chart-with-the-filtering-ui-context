using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterCriteriaSample {
    public class FilterViewModel {
        public List<Category> Categories { get; private set; }

        public decimal UnitPriceMinValue { get; private set; }
        public decimal UnitPriceMaxValue { get; private set; }

        public short UnitsOnOrderMinValue { get; private set; }
        public short UnitsOnOrderMaxValue { get; private set; }

        public short UnitsInStockMinValue { get; private set; }
        public short UnitsInStockMaxValue { get; private set; }


        public FilterViewModel(NwindDbContext context) {
            Categories = context.Categories.ToList();

            UnitPriceMinValue = context.Products.Min(p => p.UnitPrice).Value;
            UnitPriceMaxValue = context.Products.Max(p => p.UnitPrice).Value;

            UnitsInStockMinValue = context.Products.Min(p => p.UnitsInStock).Value;
            UnitsInStockMaxValue = context.Products.Max(p => p.UnitsInStock).Value;

            UnitsOnOrderMinValue = context.Products.Min(p => p.UnitsOnOrder).Value;
            UnitsOnOrderMaxValue = context.Products.Max(p => p.UnitsOnOrder).Value;
        }


    }
}
