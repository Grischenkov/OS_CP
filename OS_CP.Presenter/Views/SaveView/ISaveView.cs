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
    }
}
