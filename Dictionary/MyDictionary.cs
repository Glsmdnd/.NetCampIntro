using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class MyDictionary<A, Y>
    {
        KeyValuePair<A, Y>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<A, Y>[0];
        }

        public int Length { get { return items.Length; } }
        public void Add(A ad, Y yas)
        {
            KeyValuePair<A, Y>[] tempArray = items;
            items = new KeyValuePair<A, Y>[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = new KeyValuePair<A, Y>(ad, yas);
           
        }

        public void List()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Adı:"+item.Key + "-" +"Yaşı:"+ item.Value);
            }
        }

    }
}
