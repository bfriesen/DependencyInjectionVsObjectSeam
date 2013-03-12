using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public class DataAccessAdapter : IDataAccessAdapter
    {
        public Person GetPerson(int id)
        {
            return DataAccess.GetPerson(id);
        }
    }
}