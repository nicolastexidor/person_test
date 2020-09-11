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
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
        }
    }
}