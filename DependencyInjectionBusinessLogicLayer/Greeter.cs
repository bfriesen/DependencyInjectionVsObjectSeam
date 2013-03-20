namespace BusinessLogicLayer
{
    public class Greeter
    {
        private readonly IDataAccessAdapter _dataAccessAdapter;

        public Greeter(IDataAccessAdapter dataAccessAdapter)
        {
            _dataAccessAdapter = dataAccessAdapter;
        }

        public string SayHello(int id)
        {
            // Since the data access has been extracted to an interface,
            // SayHello is now testable.
            var person = _dataAccessAdapter.GetPerson(id);

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