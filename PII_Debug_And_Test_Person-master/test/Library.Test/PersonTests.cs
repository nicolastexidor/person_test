using NUnit.Framework;
using UnitTestAndDebug;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.csproj;
namespace Tests
{
    public class Tests
    {
        class PersonTest{

        private Person person;

       [SetUp]
        public void SetUp(){
            NewPerson = new Person("Jane Doe", "8.765.432-1");
        }

}
        [Test]
        public void NameTest()
        {
            string result = NewPerson.Name;
            Assert.AreEqual("Jane Doe", result);
        }
        [Test]
        public void SetNameTest()
        {
            NewPerson.Name = "Nicolas Texidor";
            Assert.AreEqual("Nicolas Texidor", result);
        }

        [Test]
        public void IdIsValidTest()
        {
            bool result = IdIsValid(NewPerson.ID);
            Assert.AreEqual(True, result);
        }

    }
}
        

