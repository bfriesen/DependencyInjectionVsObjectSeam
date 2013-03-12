using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public class Greeter
    {
        public string SayHello(int id)
        {
            var person = GetPerson(id);
            if (person != null)
            {
                return string.Format("Hello, {0}!", person.Name);
            }
            else
            {
                return "Hello, World!";
            }
        }

        protected virtual Person GetPerson(int id)
        {
            return DataAccess.GetPerson(id);
        }
    }
}