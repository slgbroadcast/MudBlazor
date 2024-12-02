// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudRating"/> component.
    /// </summary>
    public static class RatingDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudRating"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudRating.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudRatingItem"/> component.
    /// </summary>
    public static class RatingItemDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudRatingItem"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudRatingItem.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
