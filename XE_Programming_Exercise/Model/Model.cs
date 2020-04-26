using System;
using System.Collections.Generic;
using System.Text;

namespace XE_Programming_Exercise.Model
{
    public enum Item
    {
        A, B, C, D
    }

    public class VolumePrice
    {
        public int Volume { get; private set; }
        public double Price { get; private set; }

        public VolumePrice(int _Volume, double _Price)
        {
            Volume = _Volume;
            Price = _Price;
        }
    }

    public class Product
    {
        public Item Name { get; private set; }
        public double OriginalPrice { get; private set; }
        public VolumePrice VolumePrice { get; private set; }

        public Product(Item _Name, double _OriginalPrice, VolumePrice _VolumePrice)
        {
            Name = _Name;
            OriginalPrice = _OriginalPrice;
            VolumePrice = _VolumePrice;
        }
    }

    public class ProductList
    {
        public Dictionary<Item, Product> _ProductList { get; private set; }
        public ProductList(Dictionary<Item, Product> productList)
        {
            _ProductList = productList;
        }
    }

    public class ScannedProducts
    {
        public Item Name { get; private set; }
        public int Count { get; private set; }

        public ScannedProducts(Item _Name, int _Count)
        {
            Name = _Name;
            Count = _Count;
        }
    }

    public class ProductListandScanCount
    {
        public IEnumerable<ScannedProducts> ScannedProducts { get; private set; }
        public ProductList ProductList { get; private set; }
        public ProductListandScanCount(IEnumerable<ScannedProducts> _ScannedProducts, ProductList _ProductList)
        {
            ScannedProducts = _ScannedProducts;
            ProductList = _ProductList;
        }
    }

    public class ProductFactTable
    {
        public ScannedProducts ScannedProduct { get; set; }
        public Product Product { get; private set; }

        public ProductFactTable(ScannedProducts _scannedProduct, Product _product)
        {
            ScannedProduct = _scannedProduct;
            Product = _product;
        }
    }

    public class ItemstoScan
    {
        public string Items { get; private set; }

        public ItemstoScan(string _Items)
        {
            Items = _Items;
        }
    }
}
