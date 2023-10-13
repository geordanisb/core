﻿using System;
namespace core.Records
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public override string ToString()
        {
			return $"***Id: {Id} | FirstName: {FirstName} | LastName: {LastName} | Age: {Age}***";
        }
    }
}

