using System;

namespace core.Records
{
	public class User: Person
	{
		public string Role { get; set; }
		public int CountAccess { get; set; }

        public static new Dictionary<string,Field> ImportantFields()
        {
            return new Dictionary<string, Field> {
                { "Id", new Field{ Type=typeof(int),Label="ID"} },
                { "Role", new Field{ Type=typeof(int)} },
                { "CountAccess", new Field{ Type=typeof(int),Label="No. Access"} },
            };
        }

    }
}

