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
            List.Add(8);
        }
    }
}
