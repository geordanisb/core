using System;

namespace core.Records
{
	public class Field {
		public Type Type { get; set; }
        public string Label { get; set; }
	}
	public class Record
	{
		public int Id { get; set; }

		public static Dictionary<string,Field> ImportantFields() {
			return new Dictionary<string, Field> { { "Id",new Field { Type=typeof(int),Label="ID"} } };
		}
    }
}

