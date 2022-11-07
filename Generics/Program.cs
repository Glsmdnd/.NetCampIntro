using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);//count burada bir property dir //generic listler arka tarafta bir dizi tutarlar
           

            // MyList<string> sehirler2 = new MyList <string>(); bu kullanım yukarıdakine benzesede bir liste olmadığı için desteklemedi peki biz yukarıdaki
            //gibi bir listeyi nasıl oluşturabiliriz?
            //class MyList<T> yaparsak ancak yukarıdaki gibi bir kullanıma izin veriri
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Erzurum");//int de diyebilirdik
            Console.WriteLine(sehirler2.Count);
            //generic listler arka tarafta bir dizi tutarlar.Yukarıdakine benzetmek için array tanımlayalım

        }
    }
        class MyList<T>//generic class calışma tipi t üstteki <> içi ne verirsek onla çalışıyorya alttaki my listide bu şekilde benzetebiliyoruz
        {
        T[] _array;
        T[] _temparray;
        public MyList()
        {
            _array = new T[0];//yukarıdaki list new lenir newlenmez eleman sayısı 0 old için
        }
            public void Add(T item)
            {
            _temparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;
            }
        public int Count
        {
            get { return _array.Length; }//list in propertyi count ın yaptğınıyapacak
        }

        }

    }
    

   
