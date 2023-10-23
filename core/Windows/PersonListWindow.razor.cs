using System;
using Microsoft.AspNetCore.Components;
using core.Windows.parents;
using core.Records;

namespace core.Windows
{
	public partial class PersonListWindow: ListWindowParent
	{
        public override IQueryable<Person> GetRecords()
        {
            return new[]
            {
                new Person{
                    Id=1,
                    FirstName="Emmanuel",
                    LastName="B. Lovio",
                },
                new Person{
                    Id=2,
                    FirstName="Camila",
                    LastName="B. Mesa",
                },
                new Person{
                    Id=3,
                    FirstName="L. Gabriela",
                    LastName="Dominguez Vega",
                }
            }.AsQueryable();
        }
    }
}

