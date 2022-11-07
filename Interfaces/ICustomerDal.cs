using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Veri Sql e kaydedildi");
        }

        public void Delete()
        {
            Console.WriteLine("Veri Sql den silindi");
        }

        public void Update()
        {
            Console.WriteLine("Veri Sql de güncellendi");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Veri Oracle e kaydedildi");
        }

        public void Delete()
        {
            Console.WriteLine("Veri Oracle dan silindi");
        }

        public void Update()
        {
            Console.WriteLine("Veri Oracle 'da güncellendi");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }


}