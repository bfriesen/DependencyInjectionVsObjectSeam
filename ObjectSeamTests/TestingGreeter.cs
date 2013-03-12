using LegacyDataLayer;
using BusinessLogicLayer;

namespace ObjectSeamTests
{
    public class TestingGreeter : Greeter
    {
        private readonly Person _foundPerson;

        public TestingGreeter(Person foundPerson)
        {
            _foundPerson = foundPerson;
        }

        protected override Person GetPerson(int id)
        {
            return _foundPerson;
        }
    }
}