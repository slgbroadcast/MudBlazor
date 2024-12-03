// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudExpansionPanel"/> component.
    /// </summary>
    public static class ExpansionPanelDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudExpansionPanel"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudExpansionPanel.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudExpansionPanels"/> component.
    /// </summary>
    public static class ExpansionPanelsDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudExpansionPanels"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudExpansionPanels.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
