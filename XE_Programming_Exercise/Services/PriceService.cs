using System;
using System.Collections.Generic;
using System.Text;
using XE_Programming_Exercise.Model;

namespace XE_Programming_Exercise.Services
{
    public interface IPriceService
    {
        ProductList SetPrice();
    }

    public class PriceService : IPriceService
    {
        Dictionary<Item, Product> productList = new Dictionary<Item, Product>();

        public ProductList SetPrice()
        {
            productList.Add(Item.A, new Product(Item.A, 1.25, new VolumePrice(3, 3)));
            productList.Add(Item.B, new Product(Item.B, 4.25, null));
            productList.Add(Item.C, new Product(Item.C, 1, new VolumePrice(6, 5)));
            productList.Add(Item.D, new Product(Item.D, 0.75, null));

            return new ProductList(productList);
        }
    }
}
