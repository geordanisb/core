using System;
using Microsoft.AspNetCore.Components;
using core.Windows.parents;
using core.Records;

namespace core.Windows
{
	public partial class UserListWindow: ListWindowParent
	{
        public override IQueryable<User> GetRecords()
        {
            return new[]
            {
                new User{
                    Id=1,
                    FirstName="Emmanuel",
                    LastName="B. Lovio",
                    Role="admin",
                },
                new User{
                    Id=2,
                    FirstName="Camila",
                    LastName="B. Mesa",
                    Role="editor",
                },
                new User{
                    Id=3,
                    FirstName="L. Gabriela",
                    LastName="Dominguez Vega",
                    Role="supervisor",
                }
            }.AsQueryable();
        }
    }
}

