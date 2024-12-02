// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudChipSet{T}"/> component.
    /// </summary>
    public static class ChipSetDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudChipSet{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>. Can be overridden by setting <see cref="ChipDefaults.Ripple"/>.
        /// </remarks>
        /// <seealso cref="MudChipSet{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudChipSet{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Filled" />. Can be overridden by setting <see cref="ChipDefaults.Variant"/>.
        /// </remarks>
        /// <seealso cref="MudChipSet{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Filled;
    }
}
