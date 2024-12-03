// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudMenu"/> component.
    /// </summary>
    public static class MenuDefaults
    {
        /// <summary>
        /// Indicate the default delay time before starting to close after a leave event.
        /// Unit : ms
        /// </summary>
        public static int HoverDelay { get; set; } = 100;

        /// <summary>
        /// Indicate the default waiting time to prevent closing if a mouse enter event occurs.
        /// </summary>
        public static int PreventCloseWaitingTime { get; set; } = 50;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudMenu.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudMenu.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudMenu.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudMenu.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default location where the popover will open from for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Origin.BottomLeft" />.
        /// </remarks>
        /// <seealso cref="MudMenu.AnchorOrigin"/>
        public static Origin AnchorOrigin { get; set; } = Origin.BottomLeft;

        /// <summary>
        /// The default transform origin point for the popover for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.TransformOrigin"/>
        /// </remarks>
        /// <seealso cref="MudMenu.TransformOrigin"/>
        public static Origin TransformOrigin { get; set; } = All.TransformOrigin;
    }
}
