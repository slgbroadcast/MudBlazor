// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudSwitch{T}"/> component.
    /// </summary>
    public static class SwitchDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudSwitch{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudSwitch{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }
}
