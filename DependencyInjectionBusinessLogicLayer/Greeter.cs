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
            var person = _dataAccessAdapter.GetPerson(id);
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