// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor;

/// <summary>
/// Settings which control the default behavior and appearance of MudBlazor components.
/// </summary>
public static class MudGlobal
{
    /// <summary>
    /// Default values for all components.
    /// </summary>
    public static class All
    {
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

    // TODO: MudRadio uses Ripple from MudBooleanInput. Should i set MudBooleanInput.Ripple to virtual and overwrite the default value in MudRadio ?

    /// <summary>
    /// Defaults for the <see cref="MudAlert"/> component.
    /// </summary>
    public static class AlertDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudAlert"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
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

    /// <summary>
    /// Defaults for the <see cref="MudAppBar"/> component.
    /// </summary>
    public static class AppBarDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudAppBar"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudAppBar.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudAutocomplete{T}"/> component.
    /// </summary>
    public static class AutoCompleteDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default for the maximum number of items to display for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>10</c>.  A value of <c>null</c> will display all items.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.MaxItems"/>
        public static int? MaxItems { get; set; } = 10;

        /// <summary>
        /// The default strict setting for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.Strict"/>
        public static bool Strict { get; set; } = true;

        /// <summary>
        /// The default value setting when pressing tab for <see cref="MudAutocomplete{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudAutocomplete{T}.SelectValueOnTab"/>
        public static bool SelectValueOnTab { get; set; }
    }

    #region Avatar

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

    #endregion

    /// <summary>
    /// Defaults for the <see cref="MudBooleanInput{T}"/> component.
    /// </summary>
    public static class BooleanInputDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudBooleanInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudBooleanInput{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    #region Buttons

    /// <summary>
    /// Defaults for the <see cref="MudButton"/> component.
    /// </summary>
    public static class ButtonDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Default"/>.
        /// </remarks>
        public static Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The default size for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Size.Medium"/>.
        /// </remarks>
        public static Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The default variant for <see cref="MudButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        /// <seealso cref="MudButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudBaseButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudBaseButton.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudBaseButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudBaseButton.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }


    /// <summary>
    /// Defaults for the <see cref="MudIconButton"/> component.
    /// </summary>
    public static class IconButtonDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudIconButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    /// <summary>
    /// Defaults for the <see cref="MudToggleIconButton"/> component.
    /// </summary>
    public static class ToggleIconButtonDefaults
    {
        /// <summary>
        /// The default drop shadow setting for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudToggleIconButton"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudToggleIconButton.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    /// <summary>
    /// Defaults for the <see cref="MudButtonGroup"/> component.
    /// </summary>
    public static class ButtonGroupDefaults
    {
        /// <summary>
        /// The default drop shadow setting for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudButtonGroup.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudButtonGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudButtonGroup.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    #endregion

    /// <summary>
    /// Defaults for the <see cref="MudCard"/> component.
    /// </summary>
    public static class CardDefaults
    {
        /// <summary>
        /// The default elevation level for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>1</c>.
        /// </remarks>
        public static int Elevation { get; set; } = 1;

        /// <summary>
        /// The default square setting for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, disables rounded corners.
        /// </remarks>
        public static bool Square { get; set; }

        /// <summary>
        /// The default outline setting for <see cref="MudCard"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, shows an outline around this card.
        /// </remarks>
        public static bool Outlined { get; set; }
    }

    /// <summary>
    /// Defaults for the <see cref="MudCheckBox{T}"/> component.
    /// </summary>
    public static class CheckBoxDefaults
    {
        // public static bool Ripple { get; set; } = true; // TODO

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudCheckBox{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudCheckBox{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudChip{T}"/> component.
    /// </summary>
    public static class ChipDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudChip{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudChip{T}.Ripple"/>
        public static bool? Ripple { get; set; }

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudChip{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudChip{T}.Variant"/>
        public static Variant? Variant { get; set; }
    }

    /// <summary>
    /// Defaults for the <see cref="MudChipSet{T}"/> component.
    /// </summary>
    public static class ChipSetDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudChipSet{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>. Can be overridden by setting <see cref="ChipDefaults.Ripple"/>.
        /// </remarks>
        /// <seealso cref="MudChipSet{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudChipSet{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Filled" />.
        /// </remarks>
        /// <seealso cref="MudChipSet{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Filled;
    }

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
        /// Defaults to <c>false</c>.
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

    /// <summary>
    /// Defaults for the <see cref="MudDrawerHeader"/> component.
    /// </summary>
    public static class DrawerHeaderDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudDrawerHeader"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudDrawerHeader.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

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
        public static DefaultFocus DefaultFocus { get; set; } = DefaultFocus.Element;
    }

    /// <summary>
    /// Defaults for the <see cref="MudExpansionPanel"/> component.
    /// </summary>
    public static class ExpansionPanelDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudExpansionPanel"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudExpansionPanel.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudExpansionPanels"/> component.
    /// </summary>
    public static class ExpansionPanelsDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudExpansionPanels"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudExpansionPanels.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudField"/> component.
    /// </summary>
    public static class FieldDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudField"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudField.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    /// <summary>
    /// Defaults for the <see cref="MudGrid"/> component.
    /// </summary>
    public static class GridDefaults
    {
        /// <summary>
        /// The default spacing between items in a <see cref="MudGrid"/>, measured in increments of <c>4px</c>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>6</c> (24px).  
        /// Maximum is <c>20</c> (80px).
        /// </remarks>
        public static int Spacing { set; get; } = 6;
    }

    /// <summary>
    /// Defaults for the <see cref="MudBaseInput{T}"/> component.
    /// </summary>
    public static class InputDefaults
    {
        /// <summary>
        /// The default label shrink setting for <see cref="MudBaseInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the label will not move into the input when the input is empty.
        /// </remarks>
        public static bool ShrinkLabel { get; set; }

        /// <summary>
        /// The default variant for <see cref="MudBaseInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text"/>.
        /// </remarks>
        public static Variant Variant { get; set; } = Variant.Text;

        /// <summary>
        /// The default margin for <see cref="MudBaseInput{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Margin.None"/>.
        /// </remarks>
        public static Margin Margin { get; set; } = Margin.None;
    }

    #region Input

    /// <summary>
    /// Defaults for the <see cref="MudInputLabel"/> component.
    /// </summary>
    public static class InputLabelDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudInputLabel"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudInputLabel.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    #endregion

    /// <summary>
    /// Defaults for the <see cref="MudInputControl"/> component.
    /// </summary>
    public static class InputControlDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudInputControl"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudInputControl.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    /// <summary>
    /// Defaults for the <see cref="MudLink"/> component.
    /// </summary>
    public static class LinkDefaults
    {
        /// <summary>
        /// The default color for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Color.Primary"/>.
        /// </remarks>
        public static Color Color { get; set; } = Color.Primary;

        /// <summary>
        /// The default typography variant for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Typo.body1"/>.
        /// </remarks>
        public static Typo Typo { get; set; } = Typo.body1;

        /// <summary>
        /// The default underline setting for <see cref="MudLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Underline.Hover"/>.
        /// </remarks>
        public static Underline Underline { get; set; } = Underline.Hover;
    }

    #region List

    /// <summary>
    /// Defaults for the <see cref="MudList{T}"/> component.
    /// </summary>
    public static class ListDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudList{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudList{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudListItem{T}"/> component.
    /// </summary>
    public static class ListItemDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudListItem{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudListItem{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudListItem{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c>.
        /// </remarks>
        /// <seealso cref="MudListItem{T}.Dense"/>
        public static bool? Dense { get; set; }
    }

    #endregion

    /// <summary>
    /// Defaults for the <see cref="MudMenu"/> component.
    /// </summary>
    public static class MenuDefaults
    {
        /// <summary>
        /// Indicate the default delay time before starting to close after a leave event.
        /// Unit : ms
        /// </summary>
        public static int HoverDelay { get; set; } = 100;

        /// <summary>
        /// Indicate the default waiting time to prevent closing if a mouse enter event occurs.
        /// </summary>
        public static int PreventCloseWaitingTime { get; set; } = 50;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudMenu.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;

        /// <summary>
        /// The default ripple effect setting for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudMenu.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudMenu.Dense"/>
        public static bool Dense { get; set; } = All.Dense;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudMenu.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }

    /// <summary>
    /// Defaults for the <see cref="MudNavMenu"/> component.
    /// </summary>
    public static class NavMenuDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudNavMenu"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudNavMenu.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudNavGroup"/> component.
    /// </summary>
    public static class NavGroupDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudNavGroup"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudNavGroup.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudNavLink"/> component.
    /// </summary>
    public static class NavLinkDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudNavLink"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudNavLink.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }


    /// <summary>
    /// Defaults for the <see cref="MudOverlay"/> component.
    /// </summary>
    public static class OverlayDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudOverlay"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Delay"/>.
        /// </remarks>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudOverlay"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Duration"/>.
        /// </remarks>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;
    }

    /// <summary>
    /// Defaults for the <see cref="MudPagination"/> component.
    /// </summary>
    public static class PaginationDefaults
    {
        /// <summary>
        /// The default drop shadow setting for <see cref="MudPagination"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
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

    /// <summary>
    /// Defaults for the <see cref="MudPicker{T}"/> component.
    /// </summary>
    public static class PickerDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Delay"/>.
        /// </remarks>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="TransitionDefaults.Duration"/>.
        /// </remarks>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;

        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudPicker{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Text" />.
        /// </remarks>
        /// <seealso cref="MudPicker{T}.Variant"/>
        public static Variant Variant { get; set; } = Variant.Text;
    }


    /// <summary>
    /// Defaults for the <see cref="MudPopover"/> component.
    /// </summary>
    public static class PopoverDefaults
    {
        /// <summary>
        /// The default elevation level for <see cref="MudPopover"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>8</c>.
        /// </remarks>
        public static int Elevation { get; set; } = 8;

        /// <summary>
        /// The default drop shadow setting for <see cref="MudPopover"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudPopover.DropShadow"/>
        public static bool DropShadow { get; set; } = All.DropShadow;
    }


    /// <summary>
    /// Defaults for the <see cref="MudRadio{T}"/> component.
    /// </summary>
    public static class RadioDefaults
    {
        // public static bool Ripple { get; set; } = true; TODO

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudRadio{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudRadio{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudRating"/> component.
    /// </summary>
    public static class RatingDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudRating"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudRating.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudRatingItem"/> component.
    /// </summary>
    public static class RatingItemDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudRatingItem"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudRatingItem.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }


    #region Select

    /// <summary>
    /// Defaults for the <see cref="MudSelect{T}"/> component.
    /// </summary>
    public static class SelectDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudSelect{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudSelect{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    #endregion


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


    /// <summary>
    /// Defaults for the <see cref="MudSwitch{T}"/> component.
    /// </summary>
    public static class SwitchDefaults
    {
        // public static bool Ripple { get; set; } = true; TODO
    }


    /// <summary>
    /// Defaults for the <see cref="MudStack"/> component.
    /// </summary>
    public static class StackDefaults
    {
        /// <summary>
        /// The default justify setting for <see cref="MudStack"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, items will be placed horizontally in a row instead of vertically.
        /// </remarks>
        public static bool Row { get; set; }

        /// <summary>
        /// The default reverse setting for <see cref="MudStack"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, order of the items will be reversed.
        /// </remarks>
        public static bool Reverse { get; set; }

        /// <summary>
        /// The default gap between items for <see cref="MudStack"/>, measured in increments of <c>4px</c>..
        /// </summary>
        /// <remarks>
        /// Default is <c>3</c>.
        /// Maximum is <c>20</c>.
        /// </remarks>
        public static int Spacing { get; set; } = 3;
    }

    /// <summary>
    /// Defaults for the <see cref="MudStepper"/> component.
    /// </summary>
    public static class StepperDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudStepper"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudStepper.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    /// <summary>
    /// Defaults for the <see cref="MudTable{T}"/> component.
    /// </summary>
    public static class TableDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudTable{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudTable{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudSimpleTable"/> component.
    /// </summary>
    public static class SimpleTable
    {
        public static int Elevation { set; get; } = 1;
        public static bool Hover { get; set; }

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudSimpleTable"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudSimpleTable.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    #region Toggle

    /// <summary>
    /// Defaults for the <see cref="MudToggleGroup{T}"/> component.
    /// </summary>
    public static class ToggleGroupDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudToggleGroup{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudToggleGroup{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    #endregion


    /// <summary>
    /// Defaults for the <see cref="MudTabs"/> component.
    /// </summary>
    public static class TabDefaults
    {
        /// <summary>
        /// The default rounding setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tabs will be rounded.
        /// </remarks>
        public static bool Rounded { get; set; }

        /// <summary>
        /// The default border setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, sets a border between the content and the tab header depending on the position.
        /// </remarks>
        public static bool Border { get; set; }

        /// <summary>
        /// The default outlined setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tab header will be outlined.
        /// </remarks>
        public static bool Outlined { get; set; }

        /// <summary>
        /// The default centered setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the tab items will be centered.
        /// </remarks>
        public static bool Centered { get; set; }

        /// <summary>
        /// The default hide slider setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the slider will be hidden.
        /// </remarks>
        public static bool HideSlider { get; set; }

        /// <summary>
        /// The default show scroll buttons setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the scroll buttons will always be shown.
        /// </remarks>
        public static bool AlwaysShowScrollButtons { get; set; }

        /// <summary>
        /// The default maximum tab height setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>null</c> (no maximum height).
        /// </remarks>
        public static int? MaxHeight { get; set; } = null;

        /// <summary>
        /// The default minimum tab width setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>160px</c>.
        /// </remarks>
        public static string MinimumTabWidth { get; set; } = "160px";

        /// <summary>
        /// The default position for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="Position.Top"/>.
        /// </remarks>
        public static Position Position { get; set; } = Position.Top;

        /// <summary>
        /// The default color for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref=" Color.Default"/>.
        /// </remarks>
        public static Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The default slider color for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref=" Color.Inherit"/>.
        /// </remarks>
        public static Color SliderColor { get; set; } = Color.Inherit;

        /// <summary>
        /// The default elevation setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>0</c>.
        /// </remarks>
        public static int Elevation { set; get; } = 0;

        /// <summary>
        /// The default apply effects to container setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>. When <c>true</c>, the effects will be applied to the container as well.
        /// </remarks>
        public static bool ApplyEffectsToContainer { get; set; }

        /// <summary>
        /// The default ripple effect setting for <see cref="MudTabs"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudTabs.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;
    }

    #region Timeline

    /// <summary>
    /// Defaults for the <see cref="MudTimelineItem"/> component.
    /// </summary>
    public static class TimelineItemDefaults
    {
        /// <summary>
        /// The default <see cref="MudBlazor.Variant"/> for <see cref="MudTimelineItem"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <see cref="MudBlazor.Variant.Outlined" />.
        /// </remarks>
        /// <seealso cref="MudTimelineItem.Variant"/>
        public static Variant Variant { get; set; } = Variant.Outlined;
    }

    #endregion


    /// <summary>
    /// Defaults for the <see cref="MudToolBar"/> component.
    /// </summary>
    public static class ToolBarDefaults
    {
        /// <summary>
        /// The default setting to use compact padding for <see cref="MudToolBar"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudToolBar.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
    }

    /// <summary>
    /// Defaults for the <see cref="MudTooltip"/> component.
    /// </summary>
    public static class TooltipDefaults
    {
        /// <summary>
        /// The default transition delay for <see cref="MudTooltip"/>.
        /// </summary>
        public static TimeSpan Delay { get; set; } = TransitionDefaults.Delay;

        /// <summary>
        /// The default transition time for <see cref="MudTooltip"/>.
        /// </summary>
        public static TimeSpan Duration { get; set; } = TransitionDefaults.Duration;
    }

    /// <summary>
    /// Defaults for the <see cref="MudTreeView{T}"/> component.
    /// </summary>
    public static class TreeViewDefaults
    {
        /// <summary>
        /// The default ripple effect setting for <see cref="MudTreeView{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>true</c>.
        /// </remarks>
        /// <seealso cref="MudTreeView{T}.Ripple"/>
        public static bool Ripple { get; set; } = All.Ripple;

        /// <summary>
        /// The default setting to use compact padding for <see cref="MudTreeView{T}"/>.
        /// </summary>
        /// <remarks>
        /// Defaults to <c>false</c>.
        /// </remarks>
        /// <seealso cref="MudTreeView{T}.Dense"/>
        public static bool Dense { get; set; } = All.Dense;
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
