// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTimelineItem"/> component.
    /// </summary>
    public static class TimelineItemDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudTimelineItem"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Outlined" />.
        /// </remarks>
        /// <seealso cref="MudTimelineItem.Variant"/>
        public static Variant Variant { get; set; } = Variant.Outlined;
    }
}
