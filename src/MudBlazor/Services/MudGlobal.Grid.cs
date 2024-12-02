// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudGrid"/> component.
    /// </summary>
    public static class GridDefaults
    {
        /// <summary>
        /// The default spacing between items in a <see cref="MudGrid"/>, measured in increments of <c>4px</c>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>6</c> (24px).  
        /// Maximum is <c>20</c> (80px).
        /// </remarks>
        /// <seealso cref="MudGrid.Spacing"/>
        public static int Spacing { set; get; } = 6;
    }
}
