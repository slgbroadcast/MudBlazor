// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudToggleGroup{T}"/> component.
    /// </summary>
    public static class ToggleGroupDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudToggleGroup{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
