// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

/// <summary>
/// Settings which control the default behavior and appearance of MudBlazor components.
/// </summary>
public static partial class MudGlobal
{
    /// <summary>
    /// Default values for all components.
    /// </summary>
    public static class All
    {
        /// <summary>
        /// The default label shrink setting for all components.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the label will not move into the input when the input is empty.
        /// </remarks>
        public static bool ShrinkLabel { get; set; }

        /// <summary>
        /// The default margin for all components.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Margin.None"/>.
        /// </remarks>
        public static Margin Margin { get; set; } = Margin.None;

        /// <summary>
        /// The default drop shadow setting for all components.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        public static bool DropShadow { get; set; } = true;

        /// <summary>
        /// The default ripple effect setting for all components.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        public static bool Ripple { get; set; } = true;

        /// <summary>
        /// The default setting to use compact padding for all components.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        public static bool Dense { get; set; }
    }

    /// <summary>
    /// Defaults for MudBlazor components which use transitions.
    /// </summary>
    public static class TransitionDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudOverlay"/>, <see cref="MudPicker{T}"/>, <see cref="MudPopover"/>, and <see cref="MudTooltip"/>.
        /// </summary>
        public static TimeSpan Delay { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// The default transition time for components like <see cref="MudOverlay"/>, <see cref="MudPicker{T}"/>, <see cref="MudPopover"/>, and <see cref="MudTooltip"/>.
        /// </summary>
        public static TimeSpan Duration { get; set; } = TimeSpan.FromMilliseconds(251);
    }

    /// <summary>
    /// The handler for unhandled MudBlazor component exceptions.
    /// </summary>
    /// <remarks>
    /// Exceptions which use this handler are typically rare, such as errors which occur during a "fire-and-forget" <see cref="Task"/> which cannot be awaited.<br />
    /// By default, exceptions are logged to the console via <see cref="Console.Write(object?)"/>.<br />
    /// To handle all .NET exceptions, see: <see href="https://learn.microsoft.com/aspnet/core/fundamentals/error-handling">Handle errors in ASP.NET Core</see>.
    /// </remarks>
    public static Action<Exception> UnhandledExceptionHandler { get; set; } = (exception) => Console.Write(exception);
}
