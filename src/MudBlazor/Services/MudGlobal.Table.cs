// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTable{T}"/> component.
    /// </summary>
    public static class TableDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudTable{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudTable{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
