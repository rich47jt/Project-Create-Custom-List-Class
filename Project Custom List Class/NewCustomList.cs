using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Custom_List_Class
{
    public class NewCustomList<T>
    {
        
        public T[] items;
        public int capacity;
        public int count;

        public NewCustomList()
        {
            count = 0;
            items = new T[4];
        }
        public void Add(T item)
        {
            items[count] = item;
            if (count == capacity)
            {
                capacity *= 2; 
            }
            count++;
        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

    }

   
    

}
