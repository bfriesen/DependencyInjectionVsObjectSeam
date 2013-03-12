using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

namespace LegacyDataLayer
{
    public static class DataAccess
    {
        private static readonly string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"people.xml");
        private static readonly XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new XmlRootAttribute("People"));

        public static IEnumerable<Person> GetAllPeople()
        {
            using (var reader = new StreamReader(path))
            {
                return (List<Person>)serializer.Deserialize(reader);
            }
        }

        public static Person GetPerson(int id)
        {
            return GetAllPeople().SingleOrDefault(p => p.Id == id);
        }

        public static IEnumerable<Person> FindPeople(Func<Person, bool> predicate)
        {
            return GetAllPeople().Where(predicate);
        }
    }
}