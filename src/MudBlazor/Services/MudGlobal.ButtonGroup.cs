// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudButtonGroup"/> component.
    /// </summary>
    public static class ButtonGroupDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Default"/>.
        /// </remarks>
        /// <seealso cref="MudButtonGroup.Color"/>
        public static Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The default size for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Size.Medium"/>.
        /// </remarks>
        /// <seealso cref="MudButtonGroup.Size"/>
        public static Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudButtonGroup.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudButtonGroup.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// Override individual button styles with a <see cref="MudButtonGroup"/> style.
        /// When <c>true</c>, the button styles are defined by the group.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>
        /// </remarks>
        /// <seealso cref="MudButtonGroup.OverrideStyles"/>
        public static bool OverrideStyles { get; set; } = true;
    }
}
