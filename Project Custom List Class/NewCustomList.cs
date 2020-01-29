using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Custom_List_Class
{
    public class NewCustomList<T> :  IEnumerable
    {
     //Memeber Variable   
        public T[] items;
        public int capacity;
        int count;
        
        //Constructor
        public NewCustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            
        }

        //Methods
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
                if (items[i].Equals(itemToRemove) &&foundvalue == false)
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

        public override string ToString()
        {
            StringBuilder convertstring;
            convertstring = new StringBuilder();

            for(int i = 0; i < count; i++)
            {
                convertstring.Append(items[i].ToString());
                 
            }
            return convertstring.ToString();
        }

        
        

        public static NewCustomList<T> operator+ (NewCustomList<T> alpha, NewCustomList<T> bravo)
        {

            NewCustomList<T> List = new NewCustomList<T>();
            for (int i = 0; i < alpha.count; i++)
            {
                List.Add(alpha[i]);
                
            }

            for(int i = 0; i < bravo.count; i++)
            {
                List.Add(bravo[i]);
            }

            return List;
        }

        public static NewCustomList<T> operator- (NewCustomList<T> alpha, NewCustomList<T> bravo)
        {
            NewCustomList<T> List = new NewCustomList<T>();
            //mkae lokgic to move values from alpha into List
            for (int i = 0; i < alpha.count; i++)
            {
                List.Add(alpha[i]);
            }
            //if item in alpha list equals bravo then add to list
            //else do nothing 
           for (int i = 0; i < bravo.count; i++)
           {
               
                    List.Remove(bravo[i]);
                  
           }

     
            return List;
        }

        public static NewCustomList<T> zip(NewCustomList<T> alpha, NewCustomList<T> bravo)
        {
            NewCustomList<T> List = new NewCustomList<T>();

            if (alpha.count >= bravo.count)
            {



                for (int i = 0; i < alpha.count; i++)
                {
                    List.Add(alpha[i]);
                    if (bravo.count > i)
                    {
                        List.Add(bravo[i]);
                    }



                }
            }
            else
            {
                for (int i = 0; i < bravo.count; i++)
                {
          
                    if (alpha.count > i)
                    {
                        List.Add(alpha[i]);
                    }

                    List.Add(bravo[i]);

                }


            }


            return List;
        }
        
        
      
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];


            }

            
        }
    }




}
