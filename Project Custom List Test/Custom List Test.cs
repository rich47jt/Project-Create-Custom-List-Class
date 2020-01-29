using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Custom_List_Class;

namespace Project_Custom_List_Test
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_IndexZero_CheckIfAddFillsIndexZero()
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
        public void Add_IndexOne_CheckIfAddFillsIndexOne()
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
        public void Add_IndexTwo_CheckIfAddFiilsIndexTwo()
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
        public void Add_CheckingCount_CheckIfAddIncreasesCount()
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
        public void Add_CheckCount_CheckCountAfterAddToIndexFive()
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
        public void Add_CheckCapacity_CheckToSeeIfCapacityIsIncreased()
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
        public void Remove_CheckRemove_CheeckIfRemoveAtIndexZero()
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
        public void Remove_CheckRemov_CheckRemoveAtIndexOne()
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
        public void Remove_RemoveAtIndexZeroAndOne()
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
        public void Remove_CheckCount_AfterRemoveAtIndexZeroandOne()
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
        //break
        [TestMethod]

        public void ToString_CanIntCovert_InttoString()
        {
            //Arrange 
            NewCustomList<int> mylist = new NewCustomList<int>();
            string expected = "327645";
            string actual;

            //Act
            mylist.Add(32);
            mylist.Add(76);
            mylist.Add(45);
            actual = mylist.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_CanCombineString()
        {
            //Arrange
            NewCustomList<string> mylist = new NewCustomList<string>();
            string expected = "David Michel Brett Paul";
            string actual;

            //Act
            mylist.Add("David ");
            mylist.Add("Michel ");
            mylist.Add("Brett ");
            mylist.Add("Paul");
            actual = mylist.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_CanCovertDouble()
        {
            //Arrange
            NewCustomList<double> mylist = new NewCustomList<double>();
            string expected = "1.51.41.61.7";
            string actual;

            //Act
            mylist.Add( 1.5 );
            mylist.Add( 1.4 );
            mylist.Add( 1.6 );
            mylist.Add( 1.7);
            actual = mylist.ToString();

            //Asssert
            Assert.AreEqual(expected, actual);
        }


        //break
        [TestMethod]
        public void PlusOperator_CanAddListofInt()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>() { 123 };
            NewCustomList<int> mylist2 = new NewCustomList<int>() { 456 };
            NewCustomList<int> expected = new NewCustomList<int>() { 123456 };
            NewCustomList<int> actual;

            //Act
            actual = mylist + mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod]
        public void PlusOperator_CanAddListOfString()
        {
            //Arrange
            NewCustomList<string> mylist = new NewCustomList<string>() { "Bad,Bears,Live" };
            NewCustomList<string> mylist2 = new NewCustomList<string>() { ",In,Black,Woods" };
            NewCustomList<string> expected = new NewCustomList<string>() { "Bad,Bears,Live,In,Black,Woods" };
            NewCustomList<string> actual;

            //Act
            actual = mylist + mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void PlusOperator_CanAddListofDoublbe()
        {
            //Arrange
            NewCustomList<double> mylist = new NewCustomList<double>() { 1.2, 1.3, 1.4, 1.5 };
            NewCustomList<double> mylist2 = new NewCustomList<double>() { 1.6, 1.7, 1.8, 1.9 };
            NewCustomList<double> expected = new NewCustomList<double>() { 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9 };
            NewCustomList<double> actual;

            //Act

            actual = mylist + mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }


        //break
        [TestMethod]
        public void Minusoperator_CanSubtractListDouble()
        {
            //Arrange
            NewCustomList<double> mylist = new NewCustomList<double>() {1.1,1.2,1.3,1.4};
            NewCustomList<double> mylist2 = new NewCustomList<double>() {1.1,1.5,1.6,1.7};
            NewCustomList<double> expected = new NewCustomList<double>() {1.2,1.3,1.4};
            NewCustomList<double> actual;

            //Act

            actual = mylist - mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Minusoperator_CanSubtractListString()
        {
            //Arrange
            NewCustomList<string> mylist = new NewCustomList<string>() {"Sunny","Rain","Sleet","Snow"};
            NewCustomList<string> mylist2 = new NewCustomList<string>() {"Sunny","Rain","Stormy","Hail"};
            NewCustomList<string> expected = new NewCustomList<string>() {"Sleet","Snow"};
            NewCustomList<string> actual;

            //Act
            actual = mylist - mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void MinusOperator_CanSubtractListofInt()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>() {1,2,3,4,5,6};
            NewCustomList<int> mylist2 = new NewCustomList<int>() {4,5,6};
            NewCustomList<int> expected = new NewCustomList<int>() {1,2,3};
            NewCustomList<int> actual;

            //Act
            actual = mylist - mylist2;

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        //break
        [TestMethod]
        public void Zip_CanZipListInt()
        {
            //Arrange
            NewCustomList<int> mylist = new NewCustomList<int>() {1,2,3};
            NewCustomList<int> mylist2 = new NewCustomList<int>() {4,5,6};
            NewCustomList<int> expected = new NewCustomList<int>() {1,4,2,5,3,6};
            NewCustomList<int> actual;

            //Act
            actual = NewCustomList<int>.Zip(mylist,mylist2);

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
            
        }

        [TestMethod]
        public void Zip_CanZipListString()
        {
            //Arrange
            NewCustomList<string> mylist = new NewCustomList<string>() { "Sunny", "Rain", "Sleet" };
            NewCustomList<string> mylist2 = new NewCustomList<string>() {"Windy", "Wet", "Stormy"};
            NewCustomList<string> expected = new NewCustomList<string>() { "Sunny","Windy", "Rain", "Wet", "Sleet", "Stormy"};
            NewCustomList<string> actual;

            //Act
            actual = NewCustomList<string>.Zip(mylist, mylist2);

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void Zip_CanZipListDpouble()
        {
            //Arrange
            NewCustomList<double> mylist = new NewCustomList<double>() { 1.1, 1.2, 1.3, 1.4 };
            NewCustomList<double> mylist2 = new NewCustomList<double>() { 1.5, 1.6};
            NewCustomList<double> expected = new NewCustomList<double>() { 1.1, 1.5, 1.2, 1.6, 1.3, 1.4};
            NewCustomList<double> actual;

            //Act

            actual = NewCustomList<double>.Zip(mylist, mylist2);

            //Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }







    }
}
