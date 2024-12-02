// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudRadio{T}"/> component.
    /// </summary>
    public static class RadioDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudRadio{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Ripple"/>
        /// </remarks>
        /// <seealso cref="MudRadio{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudRadio{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudRadio{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
