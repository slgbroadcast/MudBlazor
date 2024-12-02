// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudPaper"/> component.
    /// </summary>
    public static class PaperDefaults
    {
        /// <summary>
        /// Gets or sets the default elevation level for <see cref="MudPaper"/>.
        /// </summary>
        public static int Elevation { get; set; } = 1;

        /// <summary>
        /// Gets or sets the default square setting for <see cref="MudPaper"/>.
        /// </summary>
        public static bool Square { get; set; }

        /// <summary>
        /// Gets or sets the default square setting for <see cref="MudPaper"/>.
        /// </summary>
        public static bool Outlined { get; set; }
    }
}
