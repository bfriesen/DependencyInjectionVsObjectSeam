using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public interface IDataAccessAdapter
    {
        Person GetPerson(int id);
    }
}