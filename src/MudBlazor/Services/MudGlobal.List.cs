// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudList{T}"/> component.
    /// </summary>
    public static class ListDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudList{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudList{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudListItem{T}"/> component.
    /// </summary>
    public static class ListItemDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudListItem{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudListItem{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudListItem{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudListItem{T}.Dense"/>
        public static bool? Dense { get; set; }
    }
}
