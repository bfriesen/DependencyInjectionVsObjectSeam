using BusinessLogicLayer;
using LegacyDataLayer;
using Moq;
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

            Mock<IDataAccessAdapter> mockDataAccessAdapter = new Mock<IDataAccessAdapter>();
            mockDataAccessAdapter.Setup(m => m.GetPerson(It.IsAny<int>())).Returns(foundPerson);

            Greeter greeter = new Greeter(mockDataAccessAdapter.Object);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, Bob!"));
        }

        [Test]
        public void WhenAPersonIsNotFoundThenHelloWorldIsReturned()
        {
            Mock<IDataAccessAdapter> mockDataAccessAdapter = new Mock<IDataAccessAdapter>();
            mockDataAccessAdapter.Setup(m => m.GetPerson(It.IsAny<int>())).Returns(() => null);

            Greeter greeter = new Greeter(mockDataAccessAdapter.Object);

            string helloResult = greeter.SayHello(1);

            Assert.That(helloResult, Is.EqualTo("Hello, World!"));
        }
    }
}