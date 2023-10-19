using System;
using Microsoft.AspNetCore.Components;
using core.Records;

namespace core.Windows
{
	public partial class ListWindowParent: ComponentBase
	{
        //[Parameter]
        //public Type RecordType { get; set; }
        //[Parameter]
        //public IQueryable<Record> Data { get; set; }

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

