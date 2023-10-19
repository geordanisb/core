using System;

namespace core.Records
{
	public class User: Person
	{
		public string Role { get; set; }
		public int CountAccess { get; set; }

        public static new (string, string)[] ImportantFields()
        {
            return new[] {
                ("Id", "ID"),
                ("Role", "Role"),
                ("CountAccess", "No. Access")
            };
        }

    }
}

