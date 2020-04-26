using System;
using System.Collections.Generic;
using System.Text;
using XE_Programming_Exercise.Model;

namespace XE_Programming_Exercise.Services
{
    public interface ITerminalService
    {
        void SetPrice();
        void Scan(string items);
        double CalculateTotal();
    }

    public class TerminalService : ITerminalService
    {
        ProductList productList = null;
        IEnumerable<ScannedProducts> scannedProducts;
        IScanService _scanService;
        IPriceService _priceService;
        ITotalCalculatorService _totalCalculatorService;

        public TerminalService(IScanService scanService, IPriceService priceService, ITotalCalculatorService TotalCalculatorService)
        {
            _scanService = scanService;
            _priceService = priceService;
            _totalCalculatorService = TotalCalculatorService;
        }

        public double CalculateTotal()
        {
            var ProductListandScanCount = new ProductListandScanCount(scannedProducts, productList);
            return _totalCalculatorService.CalculateTotal(ProductListandScanCount);
        }

        public void Scan(string item) => scannedProducts = _scanService.Scan(new ItemstoScan(item));

        public void SetPrice() => productList = _priceService.SetPrice();
    }
}
