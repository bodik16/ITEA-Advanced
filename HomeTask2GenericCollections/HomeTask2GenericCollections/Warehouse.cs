using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2GenericCollections
{
    public static class Warehouse
    {
        public static List<MeatProducts> ProductsFromMeat = new List<MeatProducts>()
        {
            new MeatProducts("Chop", 150, new DateTime(2019, 10, 5), 10, Meat.Pork),
            new MeatProducts("Fillet", 120, new DateTime(2019,10,5),15, Meat.Pork ),
            new MeatProducts("Minced", 130, new DateTime(2019, 10, 5), 10, Meat.Pork),
            new MeatProducts("Ribs", 80, new DateTime(2019,10,5),15, Meat.Pork ),
            new MeatProducts("Fat", 90, new DateTime(2019, 10, 5), 10, Meat.Pork),
            new MeatProducts("Baked ", 200, new DateTime(2019,10,5),15, Meat.Pork ),
            new MeatProducts("Chop", 90, new DateTime(2019, 10, 5), 10, Meat.Chicken),
            new MeatProducts("Fillet", 75, new DateTime(2019, 10, 5), 15, Meat.Chicken),
            new MeatProducts("Minced", 60, new DateTime(2019, 10, 5), 10, Meat.Chicken),
            new MeatProducts("Necks", 45, new DateTime(2019, 10, 5), 10, Meat.Chicken),
            new MeatProducts("Baked ", 120, new DateTime(2019, 10, 5), 15, Meat.Chicken),
            new MeatProducts("Chop", 130, new DateTime(2019, 10, 5), 10, Meat.Fish),
            new MeatProducts("Fillet", 115, new DateTime(2019, 10, 5), 15, Meat.Fish),
            new MeatProducts("Baked ", 170, new DateTime(2019, 10, 5), 15, Meat.Fish),
            new MeatProducts("Chop", 150, new DateTime(2019, 10, 5), 10, Meat.Veal),
            new MeatProducts("Fillet", 120, new DateTime(2019, 10, 5), 15, Meat.Veal),
            new MeatProducts("Minced", 145, new DateTime(2019, 10, 5), 10, Meat.Veal),
            new MeatProducts("Ribs", 95, new DateTime(2019, 10, 5), 15, Meat.Veal),
            new MeatProducts("Baked ", 95, new DateTime(2019, 10, 5), 15, Meat.Veal)
        };
        public static List<Baking> BakingProducts = new List<Baking>()
        {
            new Baking("Bread", 20, new DateTime(2019, 10, 8), 3, FromWhat.Buckwheat),
            new Baking("Bread", 15, new DateTime(2019, 10, 8), 4, FromWhat.Wheat),
            new Baking("Сake", 25, new DateTime(2019, 10, 8), 3, FromWhat.Buckwheat),
            new Baking("Сake", 25, new DateTime(2019, 10, 8), 3, FromWhat.Wheat)
        };
        public static List<Dairy_Products> ProductsFromMilk = new List<Dairy_Products>()
        {
            new Dairy_Products("Milk", 30, new DateTime(2019,10, 10), 5, 900),
            new Dairy_Products("Cheese", 28, new DateTime(2019,10, 10), 5, 250),
            new Dairy_Products("Sour cream", 40, new DateTime(2019,10, 10), 5, 500),
        };
    }
}
