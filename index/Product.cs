using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Product
    {
        // Private fields to store product details
        private int productID;
        private string productName, category;
        private double price;
        private int stockQuantity;

        // Constructor to initialize the product details
        public Product(int productID, string productName, string category, double price, int stockQuantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }

        // Indexer for accessing properties using an integer index
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return productID;
                    case 1:
                        return productName;
                    case 2:
                        return category;
                    case 3:
                        return price;
                    case 4:
                        return stockQuantity;
                    default:
                        return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        productID = (int)value;
                        break;
                    case 1:
                        productName = (string)value;
                        break;
                    case 2:
                        category = (string)value;
                        break;
                    case 3:
                        price = (double)value;
                        break;
                    case 4:
                        stockQuantity = (int)value;
                        break;
                }
            }
        }

        // Indexer for accessing properties using a string attribute name
        public object this[string attrName]
        {
            get
            {
                if (attrName.Equals("productid", StringComparison.OrdinalIgnoreCase))
                    return productID;
                if (attrName.Equals("productname", StringComparison.OrdinalIgnoreCase))
                    return productName;
                if (attrName.Equals("category", StringComparison.OrdinalIgnoreCase))
                    return category;
                if (attrName.Equals("price", StringComparison.OrdinalIgnoreCase))
                    return price;
                if (attrName.Equals("stockquantity", StringComparison.OrdinalIgnoreCase))
                    return stockQuantity;

                return null;
            }
            set
            {
                if (attrName.Equals("productid", StringComparison.OrdinalIgnoreCase))
                    productID = (int)value;
                else if (attrName.Equals("productname", StringComparison.OrdinalIgnoreCase))
                    productName = (string)value;
                else if (attrName.Equals("category", StringComparison.OrdinalIgnoreCase))
                    category = (string)value;
                else if (attrName.Equals("price", StringComparison.OrdinalIgnoreCase))
                    price = (double)value;
                else if (attrName.Equals("stockquantity", StringComparison.OrdinalIgnoreCase))
                    stockQuantity = (int)value;
            }
        }
    }
}
