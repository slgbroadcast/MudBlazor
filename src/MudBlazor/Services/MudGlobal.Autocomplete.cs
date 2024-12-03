// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudAutocomplete{T}"/> component.
    /// </summary>
    public static class AutocompleteDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default location where the popover will open from for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Origin.BottomLeft" />.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.AnchorOrigin"/>
        public static Origin AnchorOrigin { get; set; } = Origin.BottomLeft;

        /// <summary>
        /// The default transform origin point for the popover for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.TransformOrigin"/>
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.TransformOrigin"/>
        public static Origin TransformOrigin { get; set; } = All.TransformOrigin;

        /// <summary>
        /// The default variant for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default for the maximum number of items to display for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>10</c>.  A value of <c>null</c> will display all items.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.MaxItems"/>
        public static int? MaxItems { get; set; } = 10;

        /// <summary>
        /// The default strict setting for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Strict"/>
        public static bool Strict { get; set; } = true;

        /// <summary>
        /// The default value setting when pressing tab for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.SelectValueOnTab"/>
        public static bool SelectValueOnTab { get; set; }
    }
}
