using System;
using Microsoft.AspNetCore.Components;
using core.Windows.parents;
using core.Records;

namespace core.Windows
{
	public partial class PersonListWindow: ListWindowParent
	{
        public override IQueryable<Record> GetRecords()
        {
            return new[]
            {
                new Person{
                    Id=1,
                    FirstName="Emmanuel",
                    LastName="B. Lovio",
                    Age=1,
                },
                new Person{
                    Id=2,
                    FirstName="Camila",
                    LastName="B. Mesa",
                    Age=11,
                },
                new Person{
                    Id=3,
                    FirstName="L. Gabriela",
                    LastName="Dominguez Vega",
                    Age=7,
                }
            }.AsQueryable();
        }
    }
}

