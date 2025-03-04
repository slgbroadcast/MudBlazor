﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MudBlazor.Utilities;

namespace MudBlazor
{
#nullable enable
    /// <summary>
    /// Represents a button consisting of an icon.
    /// </summary>
    /// <remarks>
    /// Creates a <see href="https://developer.mozilla.org/docs/Web/HTML/Element/Button">button</see> element,
    /// or <see href="https://developer.mozilla.org/docs/Web/HTML/Element/a">anchor</see> if <c>Href</c> is set.<br/>
    /// You can directly add attributes like <c>title</c> or <c>aria-label</c>.
    /// </remarks>
    /// <seealso cref="MudButton" />
    /// <seealso cref="MudFab" />
    /// <seealso cref="MudToggleIconButton" />
    /// <seealso cref="MudIcon"/>
    public partial class MudIconButton : MudBaseButton
    {
        protected string Classname => new CssBuilder("mud-button-root mud-icon-button")
            .AddClass("mud-button", when: AsButton)
            .AddClass($"mud-{Color.ToDescriptionString()}-text hover:mud-{Color.ToDescriptionString()}-hover", !AsButton && Color != Color.Default)
            .AddClass($"mud-button-{Variant.ToDescriptionString()}", AsButton)
            .AddClass($"mud-button-{Variant.ToDescriptionString()}-{Color.ToDescriptionString()}", AsButton)
            .AddClass($"mud-button-{Variant.ToDescriptionString()}-size-{Size.ToDescriptionString()}", AsButton)
            .AddClass($"mud-ripple", Ripple)
            .AddClass($"mud-ripple-icon", Ripple && !AsButton)
            .AddClass($"mud-icon-button-size-{Size.ToDescriptionString()}", when: () => Size != Size.Medium)
            .AddClass($"mud-icon-button-edge-{Edge.ToDescriptionString()}", when: () => Edge != Edge.False)
            .AddClass($"mud-button-disable-elevation", !DropShadow)
            .AddClass(Class)
            .Build();

        protected bool AsButton => Variant != Variant.Text;

        /// <summary>
        /// The icon to display.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public string? Icon { get; set; }

        /// <summary>
        /// The color of the button.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Default"/> in <see cref="MudGlobal.ButtonDefaults.Color"/>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Color Color { get; set; } = MudGlobal.ButtonDefaults.Color;

        /// <summary>
        /// The size of the button.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Size.Medium"/>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The amount of negative margin applied.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Edge.False"/>.  Other values are <see cref="Edge.Start"/> and <see cref="Edge.End"/>
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Edge Edge { get; set; }

        /// <summary>
        /// The display variation to use.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Variant.Text"/> in <see cref="MudGlobal.ButtonDefaults.Variant"/>.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Appearance)]
        public Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The custom content within this button.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.  Only displays if <see cref="Icon"/> is not set.
        /// </remarks>
        [Parameter]
        [Category(CategoryTypes.Button.Behavior)]
        public RenderFragment? ChildContent { get; set; }
    }
}
