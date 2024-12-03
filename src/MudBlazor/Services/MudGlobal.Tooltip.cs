// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTooltip"/> component.
    /// </summary>
    public static class TooltipDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudTooltip"/>.
        /// </summary>
        /// <seealso cref="MudTooltip.Delay"/>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudTooltip"/>.
        /// </summary>
        /// <seealso cref="MudTooltip.Duration"/>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;

        /// <summary>
        /// The default arrow setting for <see cref="MudTooltip"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudTooltip.Arrow"/>
        public static bool Arrow { get; set; } = false;
    }
}
