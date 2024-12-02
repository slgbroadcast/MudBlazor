// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudDialog"/> component.
    /// </summary>
    public static class DialogDefaults
    {
        /// <summary>
        /// The default focus for <see cref="MudDialog"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="DefaultFocus.Element"/>.
        /// </remarks>
        /// <seealso cref="MudDialog.DefaultFocus"/>
        public static DefaultFocus DefaultFocus { get; set; } = DefaultFocus.Element;
    }
}
