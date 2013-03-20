using LegacyDataLayer;

namespace BusinessLogicLayer
{
    public class Greeter
    {
        public string SayHello(int id)
        {
            // This line makes the SayHello method untestable...
            var person = DataAccess.GetPerson(id);

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
    }
}