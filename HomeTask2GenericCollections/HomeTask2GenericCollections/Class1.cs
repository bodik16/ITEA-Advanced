using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2GenericCollections
{
    public class Product<T> where T : class
    {
        private T _productType { get; set; }
        private T ProductType { get { return _productType; } set { _productType = value; } }

        public Product(T product)
        {
            _productType = product;
        }
    }


    public abstract class ProductType
    {
        protected string _productName { get; set; }
        public string ProductName { get { return _productName; } set { _productName = value; } }
        protected int _productPrice { get; set; }
        public int ProductPrice { get { return _productPrice; } set { _productPrice = value; } }

        protected DateTime _date_of_manufacture { get; set; }
        public DateTime DateOfManufacture { get { return _date_of_manufacture; } set { _date_of_manufacture = value; } }

        protected int _expiration_date_by_days { get; set; }
        public int Expiration_date_by_days { get { return _expiration_date_by_days; } set { _expiration_date_by_days = value; } }
        public ProductType(string name, int price, DateTime date, int term)
        {
            _productName = name;
            _productPrice = price;
            _date_of_manufacture = date;
            _expiration_date_by_days = term;
        }
    }
    public class Dairy_Products : ProductType
    {
        private int _mass_of_milk { get; set; }
        public int Mass_of_Milk { get { return _mass_of_milk; } set { _mass_of_milk = value; } }
        public Dairy_Products(string name, int price, DateTime date, int term, int mass) : base(name, price, date, term)
        {
            _mass_of_milk = mass;
        }

        public override string ToString()
        {
            return $"Name:{_productName} | Price:{_productPrice} | DateOfManufacture:{_date_of_manufacture} | Expiration date:{_expiration_date_by_days} | Mass:{_mass_of_milk}";
        }

    }
    public enum FromWhat { Buckwheat, Wheat }
    public class Baking : ProductType
    {
        private FromWhat _fromWhat { get; set; }
        public FromWhat GetFromWhat { get { return _fromWhat; } set { _fromWhat = value; } }

        public Baking(string name, int price, DateTime date, int term, FromWhat from) : base(name, price, date, term)
        {
            _fromWhat = from;
        }

        public override string ToString()
        {
            return $"Name:{_productName} | Price:{_productPrice} | DateOfManufacture:{_date_of_manufacture} | Expiration date:{_expiration_date_by_days} | From what: {_fromWhat}";
        }
    }

    public enum Meat { Pork, Chicken, Veal, Fish }
    public class MeatProducts:ProductType
    {
        private Meat _meat { get; set;}
        public Meat GetMeat { get { return _meat;  } set { _meat = value; } }

        public MeatProducts(string name, int price, DateTime date, int term, Meat meat):base(name, price, date, term)
        {
            _meat = meat; ;
        }

        public override string ToString()
        {
            return $"Name:{_productName} | Price:{_productPrice} | DateOfManufacture:{_date_of_manufacture} | Expiration date:{_expiration_date_by_days} | Meat: {_meat}";
        }
    }
}
