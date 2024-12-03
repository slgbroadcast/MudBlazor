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

        /// <summary>
        /// The default color for <see cref="MudToggleGroup{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Primary"/>.
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Color"/>
        public static Color Color { get; set; } = Color.Primary;

        /// <summary>
        /// The default size for <see cref="MudToggleGroup{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Size.Medium"/>.
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Size"/>
        public static Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The default outline border setting for <see cref="MudToggleGroup{T}"/>
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Outlined"/>
        public static bool Outlined { get; set; } = true;

        /// <summary>
        /// The default delimiter between items setting fro <see cref="MudToggleGroup{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Delimiters"/>
        public static bool Delimiters { get; set; } = true;
    }
}
