using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();
            myDictionary.Add("a", 1);
            myDictionary.Add("b", 2);
            myDictionary.Add("c", 3);
            myDictionary.PrintAll();
            CizgiCek();
            myDictionary.Add("d", 4);
            myDictionary.Remove("a");
            myDictionary.PrintAll();
            CizgiCek();
            myDictionary["b"] = -1;
            myDictionary["c"] = 0;
            myDictionary.PrintAll();
            CizgiCek();
            myDictionary.Clear();
            myDictionary.PrintAll();
            CizgiCek();
            Console.ReadLine();
            
        }
        public static void CizgiCek()
        {
            Console.WriteLine("-------------------------------------");
        }
    }
}
