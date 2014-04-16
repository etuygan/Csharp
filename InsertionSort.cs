using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertionSort
{
    public class Sort
    {
        public List<int> InsertSort(List<int> sayiListesi)
        {
            if (sayiListesi.Count == 0)
            {
                return sayiListesi;
            }
            else 
            {
                Insert(sayiListesi[0], InsertSort(sayiListesi.GetRange(1, sayiListesi.Count-1)));
                return sayiListesi;
            }        
        }

        public List<int> Insert(int n, List<int> sayiListesi)
        {
            List<int> sonucListesi = new List<int>();
            if (sayiListesi.Count == 0)
            {
                sonucListesi.Add(n);
            }
            else 
            {
                if (n <= sayiListesi[0])
                {
                    sonucListesi.Add(n);
                    sonucListesi.AddRange(sayiListesi);
                }
                else 
                {
                    sonucListesi.Add(sayiListesi[0]);
                    Insert(n, sayiListesi.GetRange(1, sayiListesi.Count-1));
                }
            }
            return sonucListesi;
        }
    }
}
