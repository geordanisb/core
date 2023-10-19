using System;
using Microsoft.AspNetCore.Components;
using core.Records;

namespace core.Windows
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

