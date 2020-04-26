using System;
using System.Collections.Generic;
using System.Text;
using XE_Programming_Exercise.Model;

namespace XE_Programming_Exercise.Services
{
    public interface ICalculationService
    {
        double CalculateBundlePrice(ProductFactTable productFactTable);
        double CalculateItemPrice(ProductFactTable productFactTable);
    }

    public class CalculationService : ICalculationService
    {
        double price = 0;
        int remaining = 0, bundle = 0;
        public double CalculateBundlePrice(ProductFactTable productFactTable)
        {
            if (productFactTable == null || productFactTable.ScannedProduct == null || productFactTable.Product == null)
            {
                return price;
            }
            try
            {
                bundle = productFactTable.ScannedProduct.Count / productFactTable.Product.VolumePrice.Volume;
                remaining = productFactTable.ScannedProduct.Count % productFactTable.Product.VolumePrice.Volume;
                price = (bundle * productFactTable.Product.VolumePrice.Price) + (remaining) * productFactTable.Product.OriginalPrice;
            }
            catch
            {
                //Log Exception
            }
            return price;
        }

        public double CalculateItemPrice(ProductFactTable productFactTable)
        {
            if (productFactTable == null || productFactTable.ScannedProduct == null || productFactTable.Product == null)
            {
                return price;
            }
            try
            {
                price = productFactTable.ScannedProduct.Count * productFactTable.Product.OriginalPrice;
            }
            catch
            {
                //Log Exception
            }
            return price;
        }
    }
}
