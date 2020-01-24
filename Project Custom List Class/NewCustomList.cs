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
        int count;
        

        public NewCustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];

        }

        public void Add(T item) 
        {
            if (count == capacity)
            {
                
                items = new T[capacity * 2];
                  
            }

            items[count] = item;
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

        public int Count 
        {
            get
            {
                return count;
            }
        }

       public void Remove(T item)
       {

            
       }

    }

   
    

}
