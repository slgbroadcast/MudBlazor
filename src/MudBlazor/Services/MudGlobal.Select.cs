// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudSelect{T}"/> component.
    /// </summary>
    public static class SelectDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.ShrinkLabel"/>
        /// </remarks>
        /// <seealso cref="MudSelect{T}.ShrinkLabel"/>
        public static bool ShrinkLabel { get; set; } = All.ShrinkLabel;

        /// <summary>
        /// The default variant for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudSelect{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudSelect{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudSelect{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default location where the popover will open from for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Origin.BottomLeft" />.
        /// </remarks>
        /// <seealso cref="MudSelect{T}.AnchorOrigin"/>
        public static Origin AnchorOrigin { get; set; } = Origin.BottomLeft;

        /// <summary>
        /// The default transform origin point for the popover for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.TransformOrigin"/>
        /// </remarks>
        /// <seealso cref="MudSelect{T}.TransformOrigin"/>
        public static Origin TransformOrigin { get; set; } = All.TransformOrigin;
    }
}
