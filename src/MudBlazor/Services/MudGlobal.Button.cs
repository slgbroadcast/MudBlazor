// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudButton"/> component.
    /// </summary>
    public static class ButtonDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Default"/>.  Theme colors are supported.
        /// </remarks>
        /// <seealso cref="MudButton.Color"/>
        public static Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The default size for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Size.Medium"/>.
        /// </remarks>
        /// <seealso cref="MudButton.Size"/>
        public static Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The default variant for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudButton.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudButton.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudFab"/> component.
    /// </summary>
    public static class FabDefaults
    {
        /// <summary>
        /// The default drop shadow setting for <see cref="MudFab"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudFab.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudFab"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudFab.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudIconButton"/> component.
    /// </summary>
    public static class IconButtonDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudIconButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudIconButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudIconButton.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudIconButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudIconButton.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudToggleIconButton"/> component.
    /// </summary>
    public static class ToggleIconButtonDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
