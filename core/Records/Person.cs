using System;
using core.Models;
using core.Records.parent;

namespace core.Records
{
    public class Person : Addressable
    {
        public string CPF { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public DateOnly BirthDate { get; set; }

        public static new IEnumerable<DataColumn> ImportantFields()
        {
            var ifp = new List<DataColumn>
            {
                new DataColumn
                {
                    Property = nameof(Person.Id),
                    Title = "ID",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
                new DataColumn
                {
                    Property = nameof(Person.CPF),
                    Title = "CPF",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
                new DataColumn
                {
                    Property = nameof(Person.FirstName),
                    Title = "FirstName",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
                new DataColumn
                {
                    Property = nameof(Person.LastName),
                    Title = "LastName",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
                new DataColumn
                {
                    Property = nameof(Person.BirthDate),
                    Title = "BirdtDate",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                }
            };
            var res = Addressable.ImportantFields().Concat(ifp).ToList();
            return res;
        }
    }

}

