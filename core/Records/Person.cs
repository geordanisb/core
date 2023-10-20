using System;

namespace core.Records
{
	public class Person: Record
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

        public static new Dictionary<string,Field> ImportantFields()
        {
            return new Dictionary<string, Field> {
                { "FirstName", new Field{ Type=typeof(string),Label="Name"} },
                { "LastName", new Field{ Type=typeof(string),Label="Last Name"} },
                { "Age", new Field{ Type=typeof(int),Label="Age"} },
            };
        }
    }
}

