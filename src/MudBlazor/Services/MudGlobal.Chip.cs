// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudChip{T}"/> component.
    /// </summary>
    public static class ChipDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudChip{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudChip{T}.Ripple"/>
        public static bool? Ripple { get; set; }

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudChip{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudChip{T}.Variant"/>
        public static Variant? Variant { get; set; }
    }
}
