// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudStack"/> component.
    /// </summary>
    public static class StackDefaults
    {
        /// <summary>
        /// The default justify setting for <see cref="MudStack"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, items will be placed horizontally in a row instead of vertically.
        /// </remarks>
        public static bool Row { get; set; }

        /// <summary>
        /// The default reverse setting for <see cref="MudStack"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, order of the items will be reversed.
        /// </remarks>
        public static bool Reverse { get; set; }

        /// <summary>
        /// The default gap between items for <see cref="MudStack"/>, measured in increments of <c>4px</c>..
        /// </summary>
        /// <remarks>
        /// Default is <c>3</c>.
        /// Maximum is <c>20</c>.
        /// </remarks>
        public static int Spacing { get; set; } = 3;
    }
}
