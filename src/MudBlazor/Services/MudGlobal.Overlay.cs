// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudOverlay"/> component.
    /// </summary>
    public static class OverlayDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudOverlay"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Delay"/>.
        /// </remarks>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudOverlay"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Duration"/>.
        /// </remarks>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;
    }
}
