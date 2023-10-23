using System;
using core.Models;

namespace core.Records.parent
{
    public class Record
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public static IEnumerable<DataColumn> ImportantFields()
        {
            return new List<DataColumn>
                {
                    new DataColumn
                    {
                        Property = nameof(Record.Id),
                        Title = "ID",
                        Sortable = true,
                        Pickable = false,
                        Frozen = true,
                        Width = "80px",
                    },
                    new DataColumn
                    {
                        Property = nameof(Record.CreatedAt),
                        Title = "CreatedAt",
                        Sortable = true,
                        Pickable = false,
                        Frozen = true,
                        Width = "80px",
                    },
                    new DataColumn
                    {
                        Property = nameof(Record.UpdatedAt),
                        Title = "UpdatedAt",
                        Sortable = true,
                        Pickable = false,
                        Frozen = true,
                        Width = "80px",
                    },
                };
        }
    }

}

