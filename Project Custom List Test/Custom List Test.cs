using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Custom_List_Class;

namespace Project_Custom_List_Test
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_IndexZero_CheckifAddfillsIndexZero()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 4;
            int actual;

            //Act
            mylist.Add(4);
            actual = mylist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_IndexOne_CheckifAddCountiuestraisecount()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int zeroValue = 4;
            int expected = 5;
            int actual;

            //Act
            mylist.Add(5);
            actual = mylist[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_IndexTwo_CheckifAddfiilstheTwoIndex()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int zeroValue = 4;
            int oneValue = 5;
            int expected = 6;
            int actual;

            //Act
            mylist.Add(6);
            actual = mylist[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_IndexThree_CheckIfAddFiilstheThreeIndex()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int zeroValue = 4;
            int oneVealue = 5;
            int twoValue = 6;
            int expected = 7;
            int actual;

            //Act
            mylist.Add(7);
            actual = mylist[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_IndexFour_CheckifAddfiilstheFourIndex()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int zeroValue = 4;
            int oneVealue = 5;
            int twoValue = 6;
            int threeValue = 7;
            int expected = 8;
            int actual;

            //Act
            mylist.Add(8);
            actual = mylist[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Add_Capacitydoubling_AddShouldDoubleCapacityAfterArrayIsFilled()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int zerovalue= 4;
            int oneValue = 5;
            int twoalue = 6;
            int threeValue = 7;
            int fourValue = 8;
            int expected = 9;
            int actual;


            //Act
            mylist.Add(9);
            actual = mylist[0];

            //Assert
            Assert.AreEqual(expected, actual); 
        } 

    }
}
