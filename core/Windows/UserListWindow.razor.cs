using System;
using Microsoft.AspNetCore.Components;
using core.Records;

namespace core.Windows
{
	public partial class UserListWindow: ListWindowParent
	{
        //[Parameter]
        //public Type RecordType { get; set; }
        //[Parameter]
        //public IQueryable<Record> Data { get; set; }

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();
        //}

        //public virtual Record? getRecords()
        //{
        //    return null;
        //}
        public override IQueryable<Record> GetRecords()
        {
            return new[]
            {
                new User{
                    Id=1,
                    FirstName="Emmanuel",
                    LastName="B. Lovio",
                    Age=1,
                    Role="admin",
                    CountAccess=32
                },
                new User{
                    Id=2,
                    FirstName="Camila",
                    LastName="B. Mesa",
                    Age=11,
                    Role="editor",
                    CountAccess=10
                },
                new User{
                    Id=3,
                    FirstName="L. Gabriela",
                    LastName="Dominguez Vega",
                    Age=7,
                    Role="supervisor",
                    CountAccess=322
                }
            }.AsQueryable();
        }
    }
}

