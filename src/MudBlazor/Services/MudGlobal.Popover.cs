// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudPopover"/> component.
    /// </summary>
    public static class PopoverDefaults
    {
        /// <summary>
        /// The default elevation level for <see cref="MudPopover"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>8</c>.
        /// </remarks>
        public static int Elevation { get; set; } = 8;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudPopover"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudPopover.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;
    }
}
