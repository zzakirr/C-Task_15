using System;
using MyClasses;
using System.Collections.Generic;
using System.Collections;
namespace Practise_15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //or
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("name1");
            arrayList.Add(true);
            arrayList.Add(45.5);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------AddRange-----------------");
            ArrayList arrList1 = new ArrayList()
            {
                1, 12, "zakir", true, 31.1
            };
            var arrList2 = new ArrayList();
            string[] strArray = { "zakir1", "zakir2", "zakir3" };
            arrList2.AddRange(arrList1);
            arrList2.AddRange(strArray);
            foreach (var item in arrList2)
            {
                Console.Write(item+", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------AccessByValue---------------------");
            int firstElement = (int)arrList1[0];
            int secondElement = (int)arrList1[1];
            string thirdElement = (string)arrList1[2];

            firstElement = 2;
            secondElement = 23;
            thirdElement = "Kazekage";

            foreach (var item in arrList1)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            for (int i = 0; i < arrList1.Count; i++)
            {
                Console.Write(arrList1[i]+"-");
            }
            arrList1.Insert(1, 2);
            foreach (var item in arrList1)
            {
                Console.Write(item + ",");
            }
            arrList1.Remove(23);
            arrList1.RemoveAt(0);
            arrList1.RemoveRange(0, 2);
            Console.WriteLine();
            foreach (var item in arrList1)
            {
                Console.Write(item + ",");
            }
            #region List
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(12);
            primeNumbers.Add(15);
            primeNumbers.Add(21);
            primeNumbers.Add(23);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);

            #endregion


        }
    }
}
