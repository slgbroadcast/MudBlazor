// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudDataGrid{T}"/> component.
    /// </summary>
    public static class DataGridDefaults
    {
        /// <summary>
        /// The default elevation level for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>1</c>.
        /// </remarks>
        public static int Elevation { set; get; } = 1;

        /// <summary>
        /// The default square setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, disables rounded corners.
        /// </remarks>
        public static bool Square { get; set; }

        /// <summary>
        /// The default outlined setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, shows an outline around this grid.
        /// </remarks>
        public static bool Outlined { get; set; }

        /// <summary>
        /// The default bordered setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, shows left and right borders for each column.
        /// </remarks>
        public static bool Bordered { get; set; }

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudDataGrid{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default hover setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, highlights rows when hovering over them.
        /// </remarks>
        public static bool Hover { get; set; }

        /// <summary>
        /// The default striped setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, shows alternating row styles.
        /// </remarks>
        public static bool Striped { get; set; }

        /// <summary>
        /// The default fixed header setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, fixes the header in place even as the grid is scrolled.
        /// </remarks>
        public static bool FixedHeader { get; set; }

        /// <summary>
        /// The default fixed footer setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, fixes the footer in place even as the grid is scrolled.
        /// </remarks>
        public static bool FixedFooter { get; set; }

        /// <summary>
        /// The default virtualize setting for <see cref="MudDataGrid{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, renders only visible items instead of all items.
        /// </remarks>
        public static bool Virtualize { get; set; }
    }
}
