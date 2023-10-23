using System;
using core.Models;

namespace core.Records.parent
{
    public class Master : Record
    {
        public string Code { get; set; } = "";

        public static new IEnumerable<DataColumn> ImportantFields()
        {
            var ifm = new List<DataColumn>
            {
                new DataColumn
                {
                    Property = nameof(Master.Code),
                    Title = "Code",
                    Sortable = true,
                    Pickable = false,
                    Frozen = true,
                    Width = "80px",
                },
            };
            return Record.ImportantFields().Concat(ifm);
        }
    }

}

