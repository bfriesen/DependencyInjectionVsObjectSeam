using BusinessLogicLayer;
using LegacyDataLayer;
using NUnit.Framework;

namespace DependencyInjectionTests
{
    public class GreeterSayHelloTests
    {
        [Test]
        public void WhenAPersonIsFoundThenThePersonsNameIsIncluded()
        {
            Person foundPerson = new Person();
            foundPerson.Name = "Bob";

            IDataAccessAdapter fakeDataAccessAdapter = new FakeDataAccessAdapter(foundPerson);

            Greeter greeter = new Greeter(fakeDataAccessAdapter);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, Bob!"));
        }

        [Test]
        public void WhenAPersonIsNotFoundThenHelloWorldIsReturned()
        {
            IDataAccessAdapter fakeDataAccessAdapter = new FakeDataAccessAdapter(null);

            Greeter greeter = new Greeter(fakeDataAccessAdapter);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, World!"));
        }
    }
}