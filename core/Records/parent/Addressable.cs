using System;
using core.Models;

namespace core.Records.parent
{
    public class Addressable : Record
    {
        public string? CEP { get; set; }

        public static new IEnumerable<DataColumn> ImportantFields()
        {
            var ifa = new List<DataColumn>
            {
                new DataColumn
                {
                    Property = nameof(Addressable.CEP),
                    Title = "CEP",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
            };
            var res = Record.ImportantFields().Concat(ifa).ToList();
            return res;
        }
    }
}

