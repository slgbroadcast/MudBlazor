// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudPicker{T}"/> component.
    /// </summary>
    public static class PickerDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Delay"/>.
        /// </remarks>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Duration"/>.
        /// </remarks>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudPicker{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Margin"/>
        /// </remarks>
        /// <seealso cref="MudPicker{T}.Margin"/>
        public static Margin Margin { get; set; } = All.Margin;
    }
}
