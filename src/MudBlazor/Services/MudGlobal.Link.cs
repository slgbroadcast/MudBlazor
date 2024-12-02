// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudLink"/> component.
    /// </summary>
    public static class LinkDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Primary"/>.
        /// </remarks>
        /// <seealso cref="MudLink.Color"/>
        public static Color Color { get; set; } = Color.Primary;

        /// <summary>
        /// The default typography variant for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Typo.body1"/>.
        /// </remarks>
        /// <seealso cref="MudLink.Typo"/>
        public static Typo Typo { get; set; } = Typo.body1;

        /// <summary>
        /// The default underline setting for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Underline.Hover"/>.
        /// </remarks>
        /// <seealso cref="MudLink.Underline"/>
        public static Underline Underline { get; set; } = Underline.Hover;
    }
}
