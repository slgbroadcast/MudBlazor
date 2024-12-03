// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudSlider{T}"/> component.
    /// </summary>
    public static class SliderDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudSlider{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudSlider{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }
}
