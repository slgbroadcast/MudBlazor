// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudCard"/> component.
    /// </summary>
    public static class CardDefaults
    {
        /// <summary>
        /// The default elevation level for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>1</c>.
        /// </remarks>
        /// <seealso cref="MudCard.Elevation"/>
        public static int Elevation { get; set; } = 1;

        /// <summary>
        /// The default square setting for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, disables rounded corners.
        /// </remarks>
        /// <seealso cref="MudCard.Square"/>
        public static bool Square { get; set; }

        /// <summary>
        /// The default outline setting for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, shows an outline around this card.
        /// </remarks>
        /// <seealso cref="MudCard.Outlined"/>
        public static bool Outlined { get; set; }
    }
}
