using System;
using core.Models;

namespace core.Records.parent
{
    public class Numerable : Record
    {
        public string SerNr { get; set; } = "";

        public static new IEnumerable<DataColumn> ImportantFields()
        {
            var ifn = new List<DataColumn>
            {
                new DataColumn
                {
                    Property = nameof(Numerable.SerNr),
                    Title = "SerNr",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
            };
            return Record.ImportantFields().Concat(ifn);
        }
    }

}

