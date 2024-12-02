// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudToolBar"/> component.
    /// </summary>
    public static class ToolBarDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudToolBar"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudToolBar.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
