using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        class PersonTest{

        private Person person;

       [SetUp]
        public void SetUp(){
              this.person= new Person("John Doe", "1.234.567-8");
        }

}
        [Test]
        public void TestPerson() // Cambiá el nombre para indicar qué estás probando
        {
        public class Person
    {
        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        private string name;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }
    }
        }
    }
