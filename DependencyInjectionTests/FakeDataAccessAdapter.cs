using BusinessLogicLayer;
using LegacyDataLayer;

namespace DependencyInjectionTests
{
    public class FakeDataAccessAdapter : IDataAccessAdapter
    {
        private readonly Person _foundPerson;

        public FakeDataAccessAdapter(Person foundPerson)
        {
            _foundPerson = foundPerson;
        }

        public Person GetPerson(int id)
        {
            return _foundPerson;
        }
    }
}