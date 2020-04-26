using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XE_Programming_Exercise.Model;

namespace XE_Programming_Exercise.Services
{
    public interface ITotalCalculatorService
    {
        double CalculateTotal(ProductListandScanCount productListandScanCount);
    }

    public class TotalCalculatorService : ITotalCalculatorService
    {
        ICalculationService _calculateService;
        double totalprice = 0;

        public TotalCalculatorService(ICalculationService calculationService)
        {
            _calculateService = calculationService;
        }

        public double CalculateTotal(ProductListandScanCount productsListandCount)
        {
            if (productsListandCount == null)
            { return totalprice; }

            try
            {
                foreach (var scanneditems in productsListandCount.ScannedProducts.Where(a => a != null))
                {
                    var item = productsListandCount.ProductList._ProductList[scanneditems.Name];
                    var productfactdata = new ProductFactTable(scanneditems, item);
                    if (item.VolumePrice != null)
                        totalprice = totalprice + _calculateService.CalculateBundlePrice(productfactdata);
                    else
                        totalprice = totalprice + _calculateService.CalculateItemPrice(productfactdata);
                }
            }
            catch
            {
                //Log Exception
            }

            return totalprice;
        }
    }
}
