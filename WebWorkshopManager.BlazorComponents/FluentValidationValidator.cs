using System;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using WebWorkshopManager.BlazorComponents.Helpers;

namespace WebWorkshopManager.BlazorComponents
{
    public class FluentValidationValidator : ComponentBase
    {
        [CascadingParameter] EditContext CurrentEditContext { get; set; }

        protected override void OnInitialized()
        {
            if (this.CurrentEditContext == null)
            {
                throw new InvalidOperationException($"{nameof(FluentValidationValidator)} requires a cascading " +
                                                    $"parameter of type {nameof(EditContext)}. For example, you can use {nameof(FluentValidationValidator)} " +
                                                    $"inside an {nameof(EditForm)}.");
            }

            this.CurrentEditContext.AddFluentValidation();
        }
    }
}
