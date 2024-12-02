// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTabs"/> component.
    /// </summary>
    public static class TabDefaults
    {
        /// <summary>
        /// The default rounding setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tabs will be rounded.
        /// </remarks>
        public static bool Rounded { get; set; }

        /// <summary>
        /// The default border setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, sets a border between the content and the tab header depending on the position.
        /// </remarks>
        public static bool Border { get; set; }

        /// <summary>
        /// The default outlined setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tab header will be outlined.
        /// </remarks>
        public static bool Outlined { get; set; }

        /// <summary>
        /// The default centered setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tab items will be centered.
        /// </remarks>
        public static bool Centered { get; set; }

        /// <summary>
        /// The default hide slider setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the slider will be hidden.
        /// </remarks>
        public static bool HideSlider { get; set; }

        /// <summary>
        /// The default show scroll buttons setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the scroll buttons will always be shown.
        /// </remarks>
        public static bool AlwaysShowScrollButtons { get; set; }

        /// <summary>
        /// The default maximum tab height setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c> (no maximum height).
        /// </remarks>
        public static int? MaxHeight { get; set; } = null;

        /// <summary>
        /// The default minimum tab width setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>160px</c>.
        /// </remarks>
        public static string MinimumTabWidth { get; set; } = "160px";

        /// <summary>
        /// The default position for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Position.Top"/>.
        /// </remarks>
        public static Position Position { get; set; } = Position.Top;

        /// <summary>
        /// The default color for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref=" Color.Default"/>.
        /// </remarks>
        public static Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The default slider color for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref=" Color.Inherit"/>.
        /// </remarks>
        public static Color SliderColor { get; set; } = Color.Inherit;

        /// <summary>
        /// The default elevation setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>0</c>.
        /// </remarks>
        public static int Elevation { set; get; } = 0;

        /// <summary>
        /// The default apply effects to container setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the effects will be applied to the container as well.
        /// </remarks>
        public static bool ApplyEffectsToContainer { get; set; }

        /// <summary>
        /// The default ripple effect setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudTabs.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
