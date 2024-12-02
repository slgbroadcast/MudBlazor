// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudTextField{T}"/> component.
    /// </summary>
    public static class TextFieldDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudTextField{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudTextField{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default variant for <see cref="MudTextField{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudTextField{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudTextField{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudTextField{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }
}
