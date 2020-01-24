using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Custom_List_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCustomList<int> List = new NewCustomList<int>();
            List.Add(6);
            List.Add(7);
            List.Add(8);
            List.Add(9);
            List.Add(10);
            Console.ReadLine();
        }
    }
}
