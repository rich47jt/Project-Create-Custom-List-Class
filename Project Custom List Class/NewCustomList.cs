using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Custom_List_Class
{
    public class NewCustomList<T>  /*IEnumerable*/
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
                T[] tempArray = items;
                capacity *= 2;
                items = new T[capacity];
                for(int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
                

                  
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

        public void Remove(T itemToRemove)
        {
           bool foundvalue = false;
           for (int i = 0; i < count;i++)
           {
                if (items[i].Equals(items[i]) &&foundvalue == false)
                {

                    foundvalue = true;
                    count--;
                } 

               
                if (foundvalue == true)
                {
                    items[i] = items[i+1];
                }

                
           }

            
      
        }

        //public IEnumerator GetEnumerator()
        //{

        //    for(int i = 0; i < count;i++)
        //    {
        //        return items[i];
        //    }
        //}
    }




}
