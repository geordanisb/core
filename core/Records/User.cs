using System;
using core.Models;
using core.Records.parent;

namespace core.Records
{
    public class User : Person
    {
        public string Role { get; set; } = "";

        public static new IEnumerable<DataColumn> ImportantFields()
        {
            var ifb = Record.ImportantFields();
            ifb.Append(new DataColumn
            {
                Property = nameof(User.Role),
                Title = "Role",
                Sortable = true,
                Pickable = false,
                Frozen = true,
                Width = "80px",
            });
            return ifb;
        }
    }

}

