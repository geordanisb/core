using System;
using Microsoft.AspNetCore.Components;

namespace core.Records
{
	public partial class User:ComponentBase
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int Age { get; set; }

		public override string ToString()
        {
			return $"!!!123Id: {Id} | FirstName: {FirstName} | LastName: {LastName} | Age: {Age}!!!";
        }
    }
}

