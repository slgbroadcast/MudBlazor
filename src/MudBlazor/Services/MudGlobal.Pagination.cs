// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudPagination"/> component.
    /// </summary>
    public static class PaginationDefaults
    {
        /// <summary>
        /// The default drop shadow setting for <see cref="MudPagination"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.DropShadow"/>
        /// </remarks>
        /// <seealso cref="MudPagination.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudPagination"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudPagination.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }
}
