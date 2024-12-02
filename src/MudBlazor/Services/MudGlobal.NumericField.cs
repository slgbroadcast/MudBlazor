// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudNumericField{T}"/> component.
    /// </summary>
    public static class NumericFieldDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudNumericField{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudNumericField{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default variant for <see cref="MudNumericField{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudNumericField{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudNumericField{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudNumericField{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }
}
