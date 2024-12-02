// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

public static partial class MudGlobal
{
    /// <summary>
    /// Defaults for the <see cref="MudAvatar"/> component.
    /// </summary>
    public static class AvatarDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudAvatar"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Filled" />.
        /// </remarks>
        /// <seealso cref="MudAvatar.Variant"/>
        public static Variant Variant { get; set; } = Variant.Filled;
    }

    /// <summary>
    /// Defaults for the <see cref="MudAvatarGroup"/> component.
    /// </summary>
    public static class AvatarGroupDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudAvatarGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Filled" />.
        /// </remarks>
        /// <seealso cref="MudAvatarGroup.MaxVariant"/>
        public static Variant MaxVariant { get; set; } = Variant.Filled;
    }
}
