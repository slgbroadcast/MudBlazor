using System;
using System.Reflection;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Utilities;

namespace MudBlazor
{
    public partial class MudTextField<T> : MudDebouncedInput<T>
    {
        protected string Classname =>
           new CssBuilder("mud-input-input-control")
           .AddClass(Class)
           .Build();

        private MudInput<string> _elementReference;

        private InputType? _inputType;

        /// <summary>
        /// Type of the input element. It should be a valid HTML5 input type.
        /// </summary>
        [Parameter]
        public InputType InputType
        {
            get
            {
                if (_inputType is not null)
                {
                    return _inputType.Value;
                }

                _inputType = InputType.Text;

                if (For is null)
                {
                    return _inputType.Value;
                }

                var propertyInfo = For.SBS_PropertyInfo();
                var attribute = (DataTypeAttribute)propertyInfo.GetCustomAttribute(typeof(DataTypeAttribute));
                if (attribute is not null)
                {
                    switch (attribute.DataType)
                    {
                        case DataType.Text:
                            _inputType = InputType.Text;
                            break;
                        case DataType.Password:
                            _inputType = InputType.Password;
                            break;
                        case DataType.EmailAddress:
                            _inputType = InputType.Email;
                            InputMode = InputMode.email;
                            break;
                        case DataType.PhoneNumber:
                            _inputType = InputType.Telephone;
                            InputMode = InputMode.tel;
                            break;
                        case DataType.Url:
                            _inputType = InputType.Url;
                            InputMode = InputMode.url;
                            break;

                        default:
                            break;
                    }
                }

                return _inputType.Value;
            }
            set => _inputType = value;
        }

        internal override InputType GetInputType() => InputType;

        private string GetCounterText() => Counter == null ? string.Empty : (Counter == 0 ? (string.IsNullOrEmpty(Text) ? "0" : $"{Text.Length}") : ((string.IsNullOrEmpty(Text) ? "0" : $"{Text.Length}") + $" / {Counter}"));

        /// <summary>
        /// Show clear button.
        /// </summary>
        [Parameter] public bool Clearable { get; set; } = false;

        /// <summary>
        /// Button click event for clear button. Called after text and value has been cleared.
        /// </summary>
        [Parameter] public EventCallback<MouseEventArgs> OnClearButtonClick { get; set; }

        public override ValueTask FocusAsync()
        {
            return _elementReference.FocusAsync();
        }

        public override ValueTask SelectAsync()
        {
            return _elementReference.SelectAsync();
        }

        public override ValueTask SelectRangeAsync(int pos1, int pos2)
        {
            return _elementReference.SelectRangeAsync(pos1, pos2);
        }

        /// <summary>
        /// Clear the text field, set Value to default(T) and Text to null
        /// </summary>
        /// <returns></returns>
        public async Task Clear()
        {
            await _elementReference.SetText(null);
        }
    }

    [Obsolete]
    public class MudTextFieldString : MudTextField<string> { }
}
