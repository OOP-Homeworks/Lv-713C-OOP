using System;
using Marichka2003_Homework_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonIdentificationTest
{
    [TestClass]
    public class Indentification
    {
        [TestClass]
        public class TestMethod1
        {
            [TestMethod]
            public void CalculateAgeOfPersonTest()
            {
                DateTime dateTime = new DateTime(2003,1,6);
                Person person = new Person();
                int expected = 19;
                int age = person.Age(dateTime);
                Assert.AreEqual(expected, age);
            }
            [TestMethod]
            public void CheckNameOfPerson()
            {
                string name = "Maria";
                Person person1 = new Person(name);

                Assert.AreEqual(name, person1.ToString());
            }
            [TestMethod]
            public void CheckCorrectedOverrideTrue()
            {
                Person check1 = new Person("Maria");
                Person check2 = new Person("Maria");

                bool expected = true;
                bool actual = check1 == check2;      

                Assert.AreEqual(expected, actual);
            }
            public void CheckCorrectedOverrideFalse()
            {
                Person check1 = new Person("Andrii");
                Person check2 = new Person("Maria");

                bool expected = true;           
                bool actual = check1 != check2;

               Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ChangePersonsName()
            {
                Person change = new Person();

                string expected = "Very Young";
                string actual = change.ChangeName(16);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
