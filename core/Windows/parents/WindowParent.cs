using System;
using Microsoft.AspNetCore.Components;
using core.Records;

namespace core.Windows.parents
{
	public partial class WindowParent: ComponentBase
	{
        [Parameter]
        public Record? Record { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}

