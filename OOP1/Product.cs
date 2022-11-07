using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product//veya Entity
    {
        public int ID { get; set; }
        public int  CategoryID { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice{ get; set; }
        public int UnitInStock { get; set; }

        //CRUD
        //Create read uptadate delete gibi ürün operasyonları ...Manager sayfasında olur

    }
}
