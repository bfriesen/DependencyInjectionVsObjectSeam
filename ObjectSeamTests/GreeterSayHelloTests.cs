using LegacyDataLayer;
using NUnit.Framework;
using BusinessLogicLayer;

namespace ObjectSeamTests
{
    public class GreeterSayHelloTests
    {
        [Test]
        public void WhenAPersonIsFoundThenThePersonsNameIsIncluded()
        {
            Person foundPerson = new Person();
            foundPerson.Name = "Bob";

            Greeter greeter = new TestingGreeter(foundPerson);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, Bob!"));
        }

        [Test]
        public void WhenAPersonIsNotFoundThenHelloWorldIsReturned()
        {
            Greeter greeter = new TestingGreeter(null);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, World!"));
        } 
    }
}