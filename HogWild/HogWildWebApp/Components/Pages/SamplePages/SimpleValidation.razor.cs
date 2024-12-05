using Microsoft.EntityFrameworkCore.Diagnostics;

namespace HogWildWebApp.Components.Pages.SamplePages
{
    public partial class SimpleValidation
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string city;
        #endregion
        #region Feedback & Error Messages
        //  placeholder for feedback message
        private string feedbackMessage;

        //  placeholder for error messasge
        private string? errorMessage;

        //  return has feedback
        private bool hasFeedback => !string.IsNullOrWhiteSpace(feedbackMessage);

        //  return has error
        private bool hasError => !string.IsNullOrWhiteSpace(errorMessage) || errorDetails.Count > 0;

        //  used to display any collection of errors on web page
        //  whether the errors are generated locally or come from the class library
        private List<string> errorDetails = new();
        #endregion

        #region Methods
        private async void Save()
        {
            feedbackMessage = string.Empty;
            errorDetails.Clear();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorDetails.Add("Missing First Name");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                errorDetails.Add("Missing Last Name");
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                errorDetails.Add("Missing City");
            }

            if (errorDetails.Count == 0)
            {
                feedbackMessage = $"{firstName} {lastName} - {city}";
            }
            await InvokeAsync(StateHasChanged);
        }
        #endregion
    }


}
