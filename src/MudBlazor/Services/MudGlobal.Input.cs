// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudInput{T}"/> component.
    /// </summary>
    public static class InputDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudInput{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default variant for <see cref="MudInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudInput{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudInput{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }

    /// <summary>
    /// Defaults for the <see cref="MudInputLabel"/> component.
    /// </summary>
    public static class InputLabelDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudInputLabel"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudInputLabel.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;


        /// <summary>
        /// The default margin for <see cref="MudInputLabel"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudInputLabel.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }

    /// <summary>
    /// Defaults for the <see cref="MudRangeInput{T}"/> component.
    /// </summary>
    public static class RangeInputDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudRangeInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudRangeInput{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default variant for <see cref="MudRangeInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudRangeInput{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudRangeInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudRangeInput{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }
}
