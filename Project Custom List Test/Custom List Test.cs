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

           // Act
            mylist.Add(4);
            actual = mylist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_IndexOne_CheckifAddCountiuestraisecount()
        {
           // Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 5;
            int actual;

            // Act
            mylist.Add(4);
            mylist.Add(5);
            actual = mylist[1];

          //  Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_IndexTwo_CheckifAddfiilstheTwoIndex()
        {
          //  Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 6;
            int actual;

            // Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            actual = mylist[2];

           // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckingCount()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 4;
            int actual;

            //Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(7);
            actual = mylist.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CheckCountAfter()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 5;
            int actual;

            //Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(7);
            mylist.Add(8);
            actual = mylist.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddValuesToIncreaseCapacity_EnsureOriginalValuesPresent()
        {
            //Array
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 8;
            int actual;

            //Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Add(7);
            mylist.Add(8);
            actual = mylist[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // break
        [TestMethod]
        public void Removal_RemoveAtIndexZero()
        {
           // Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 5;
            int actual;

           // Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Remove(4);
            actual = mylist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removal_RemovAtIndexOne()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 6;
            int actual;

            //Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Remove(5);
            actual = mylist[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removal_CheckCountAfterRemove()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 2;
            int actual;

            //Act
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);
            mylist.Remove(5);
            actual = mylist.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removal_RemoveAtIndexZeroAndOne()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 4;
            int actual;

            //Act
            mylist.Add(6);
            mylist.Add(5);
            mylist.Add(4);
            mylist.Remove(6);
            mylist.Remove(5);
            actual = mylist[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removal_CheckCount()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>();
            int expected = 1;
            int actual;

            //Act
            mylist.Add(6);
            mylist.Add(5);
            mylist.Add(4);
            mylist.Remove(6);
            mylist.Remove(5);
            actual = mylist.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
