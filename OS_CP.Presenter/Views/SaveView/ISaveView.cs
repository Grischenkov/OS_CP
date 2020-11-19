using System;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific view interface for Splash View
    /// </summary>
    public interface ISaveView : IView
    {
        bool SaveValueTable { get; set; }
        bool SaveChartImage { get; set; }
        bool SaveChartImageEnabled { set; }
        event Action Save;

        /// <summary>
        /// Showing message about error
        /// </summary>
        /// <param name="errorMessage"> Error message </param>
        void ShowError(string errorMessage);

        /// <summary>
        /// Showing message about warning
        /// </summary>
        /// <param name="warningMessage"> Warning message </param>
        void ShowWarning(string warningMessage);

        /// <summary>
        /// Showing message about success
        /// </summary>
        /// <param name="successMessage"> Success message </param>
        void ShowSuccess(string successMessage);
    }
}
