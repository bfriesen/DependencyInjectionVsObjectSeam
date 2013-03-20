using LegacyDataLayer;
using BusinessLogicLayer;
using System;

namespace ObjectSeamTests
{
    public class TestingGreeter : Greeter
    {
        private readonly Func<Person> _foundPerson;

        public TestingGreeter(Func<Person> foundPerson)
        {
            _foundPerson = foundPerson;
        }

        protected override Person GetPerson(int id)
        {
            return _foundPerson != null ? _foundPerson() : base.GetPerson(id);
        }
    }
}