using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public class Greeter
    {
        public string SayHello(int id)
        {
            // Since the data access has been extracted to a virtual
            // method, SayHello is now testable.
            var person = GetPerson(id);

            // This is the interesting bit - the part we want to test.
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