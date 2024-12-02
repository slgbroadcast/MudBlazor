// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudSimpleTable"/> component.
    /// </summary>
    public static class SimpleTableDefaults
    {
        /// <summary>
        /// The default size of the drop shadow for <see cref="MudSimpleTable"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>1</c>.
        /// </remarks>
        /// <seealso cref="MudSimpleTable.Elevation"/>
        public static int Elevation { set; get; } = 1;

        /// <summary>
        /// The default hover setting for <see cref="MudSimpleTable"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudSimpleTable.Hover"/>
        public static bool Hover { get; set; }

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudSimpleTable"/>.
        /// </summary>
        /// <remarks>
        /// <inheritdoc cref="All.Dense"/>
        /// </remarks>
        /// <seealso cref="MudSimpleTable.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }
}
