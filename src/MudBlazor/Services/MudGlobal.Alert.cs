// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudAlert"/> component.
    /// </summary>
    public static class AlertDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudAlert"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudAlert.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudAlert"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudAlert.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }
}
