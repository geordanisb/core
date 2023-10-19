using System;

namespace core.Records
{
	public class Person: Record
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

        public static new (string,string)[] ImportantFields()
        {
            return new[] {
                ("FirstName","Name"),
                ("LastName", "Last Name"),
                ("Age", "Age")
            };
        }
    }
}

