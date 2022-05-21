

using EnumsNET;
using Microsoft.AspNetCore.Components;
using ToDoApp.Shared.Enums;

namespace ToDoApp.Shared.Extensions.NavigateManagerExtensions;

public static class NavigateManagerExtensions4
{
    public static void NavigateTo(this NavigationManager navigationManager, NavigationManagerPaths path)
        => navigationManager.NavigateTo(((NavigationManagerPaths)path).AsString(EnumFormat.Description));
    public static void NavigateTo(this NavigationManager navigationManager, NavigationManagerPaths path, bool forceReload)
    => navigationManager.NavigateTo(((NavigationManagerPaths)path).AsString(EnumFormat.Description), forceReload);
}
