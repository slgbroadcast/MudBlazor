// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudNavMenu"/> component.
    /// </summary>
    public static class NavMenuDefaults
    {
        /// <summary>
        /// The default margin for <see cref="MudNavMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudNavMenu.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;


        /// <summary>
        /// The default setting to use compact padding for <see cref="MudNavMenu"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudNavMenu.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudNavGroup"/> component.
    /// </summary>
    public static class NavGroupDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudNavGroup"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudNavGroup.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudNavLink"/> component.
    /// </summary>
    public static class NavLinkDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudNavLink"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudNavLink.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
