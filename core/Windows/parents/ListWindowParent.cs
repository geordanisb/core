using System;
using Microsoft.AspNetCore.Components;
using core.Records;

namespace core.Windows.parents
{
	public partial class ListWindowParent: ComponentBase
	{
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        public virtual IQueryable<Record>? GetRecords()
        {
            return null;
        }
    }
}

