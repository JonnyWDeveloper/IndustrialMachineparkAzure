using Microsoft.AspNetCore.Components;

namespace IndustrialMachinepark.Shared
{
    public interface IListItem
    {
        RenderFragment ChildContent
        {
            get;
        }
    }
}
