// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTreeView{T}"/> component.
    /// </summary>
    public static class TreeViewDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudTreeView{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Primary"/>.
        /// </remarks>
        /// <seealso cref="MudTreeView{T}.Color"/>
        public static Color Color { get; set; } = Color.Primary;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudTreeView{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudTreeView{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudTreeView{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudTreeView{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
