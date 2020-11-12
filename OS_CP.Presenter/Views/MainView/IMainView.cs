using System;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific view interface for Main view
    /// </summary>
    public interface IMainView : IView
    {
        /// <summary>
        /// Get value table
        /// </summary>
        string[][] ValueTable { get; set; }

        /// <summary>
        /// Calculating function value table, drawing chart
        /// </summary>
        event Action Calculate;

        /// <summary>
        /// Reading data
        /// </summary>
        event Action Open;

        /// <summary>
        /// Saving data
        /// </summary>
        event Action Save;

        /// <summary>
        /// Exporting data to Excel
        /// </summary>
        event Action Export;

        /// <summary>
        /// Showing about window
        /// </summary>
        event Action About;

        /// <summary>
        /// Showing about window
        /// </summary>
        event Action Help;

        /// <summary>
        /// Showing about window
        /// </summary>
        event Action Settings;

        /// <summary>
        /// Exiting program
        /// </summary>
        event Action Exit;

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

        /// <summary>
        /// Drawing chart in main form
        /// </summary>
        /// <param name="table"> Function value table </param>
        void DrawChart(double[][] table);
    }
}