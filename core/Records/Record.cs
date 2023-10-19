using System;

namespace core.Records
{
	public class Field {
		public Type Type { get; set; }
		public object Value { get; set; }
		public string Name { get; set; }
        public string Label { get; set; }
	}
	public class Record
	{
		public int Id { get; set; }

		public static (string,string)[] ImportantFields() {
			return new [] {("Id","ID")};
		}
    }
}

