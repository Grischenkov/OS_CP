using System;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific view interface for Settings view
    /// </summary>
    public interface ISettingsView : IView
    {
        /// <summary>
        /// 
        /// </summary>
        bool ShowVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool ShowLoad { get; set; }

        /// <summary>
        /// Getting/Setting Export type DLL path
        /// </summary>
        string ExportDLLPath { get; set; }

        /// <summary>
        /// Getting/Setting Math type DLL path
        /// </summary>
        string MathDLLPath { get; set; }

        /// <summary>
        /// Editing load settings
        /// </summary>
        event Action LoadShowing;

        /// <summary>
        /// Editing video settings
        /// </summary>
        event Action VideoShowing;

        /// <summary>
        /// Selecting Export type DLL
        /// </summary>
        event Action SelectExport;

        /// <summary>
        /// Selecting Math type DLL
        /// </summary>
        event Action SelectMath;

        /// <summary>
        /// Discarding Export type DLL
        /// </summary>
        event Action DiscardExport;

        /// <summary>
        /// Discarding Math type DLL
        /// </summary>
        event Action DiscardMath;

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