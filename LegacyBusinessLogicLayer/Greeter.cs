using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public class Greeter
    {
        public string SayHello(int id)
        {
            var person = DataAccess.GetPerson(id);
            if (person != null)
            {
                return string.Format("Hello, {0}!", person.Name);
            }
            else
            {
                return "Hello, World!";
            }
        }
    }
}