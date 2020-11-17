using System;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific view interface for Help view
    /// </summary>
    public interface IHelpView : IView
    {
        string TextInfo { set; }

        /// <summary>
        /// Editing load settings
        /// </summary>
        event Action BasicInfo;

        /// <summary>
        /// Editing video settings
        /// </summary>
        event Action LoadingData;

        /// <summary>
        /// Selecting Export type DLL
        /// </summary>
        event Action SavingData;

        /// <summary>
        /// Selecting Interpolation type DLL
        /// </summary>
        event Action Export;

        /// <summary>
        /// Discarding Export type DLL
        /// </summary>
        event Action Math;

        /// <summary>
        /// Discarding Interpolation type DLL
        /// </summary>
        event Action ForDevelopers;
    }
}