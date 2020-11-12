namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Settings view
    /// </summary>
    public sealed class SettingsPresenter : BasePresenter<ISettingsView>
    {
        private const string Path = @"Software\Grshchnkv\OS_CP";
        
        Microsoft.Win32.RegistryKey RegistryKey;

        /// <summary>
        /// Constructor of SettingsPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SettingsPresenter(IApplicationController controller, ISettingsView view) : base(controller, view)
        {
            CheckRegistry();
            LoadValues();

            View.LoadShowing += LoadShowing;
            View.VideoShowing += VideoShowing;
            View.SelectExport += SelectExport;
            View.SelectInterpolation += SelectInterpolation;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckRegistry()
        {
            RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Path, true) ??
                            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(Path, true);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadValues()
        {
            if (RegistryKey == null) return;

            string[] keyNames = RegistryKey.GetValueNames();
            if (keyNames.Length != 0)
            {
                foreach (string keyName in keyNames)
                {
                    switch (keyName)
                    {
                        case "ShowLoad":
                            View.ShowLoad = (bool)RegistryKey.GetValue("ShowLoad");
                            break;
                        case "ShowVideo":
                            View.ShowVideo = (bool)RegistryKey.GetValue("ShowVideo");
                            break;
                        case "ExportDLLPath":
                            View.ExportDLLPath = (string)RegistryKey.GetValue("ExportDLLPath");
                            break;
                        case "InterpolationDLLPath":
                            View.InterpolationDLLPath = (string)RegistryKey.GetValue("InterpolationDLLPath");
                            break;
                    }
                }
                RegistryKey.Close();
            }
            else
            {
                RegistryKey.SetValue("ShowLoad", true);
                RegistryKey.SetValue("ShowVideo", true);
                RegistryKey.SetValue("ExportDLLPath", null);
                RegistryKey.SetValue("InterpolationDLLPath", null);
                RegistryKey.Close();
            }
        }

        /// <summary>
        /// Change load settings
        /// </summary>
        private void LoadShowing()
        {
            if (RegistryKey == null) return;

            RegistryKey.SetValue("ShowLoad", View.ShowLoad);
            RegistryKey.Close();
        }

        /// <summary>
        /// Change video settings
        /// </summary>
        private void VideoShowing()
        {
            if (RegistryKey == null) return;

            RegistryKey.SetValue("ShowLoad", View.ShowVideo);
            RegistryKey.Close();
        }

        /// <summary>
        /// Load export type DLL
        /// </summary>
        private void SelectExport()
        {
            if (RegistryKey == null) return;

            View.ExportDLLPath = FileFunctions.Open("dll");
            RegistryKey.SetValue("ExportDLLPath", View.ExportDLLPath);
            RegistryKey.Close();
        }

        /// <summary>
        /// Load interpolation type DLL
        /// </summary>
        private void SelectInterpolation()
        {
            if (RegistryKey == null) return;

            View.InterpolationDLLPath = FileFunctions.Open("dll");
            RegistryKey.SetValue("InterpolationDLLPath", View.InterpolationDLLPath);
            RegistryKey.Close();
        }
    }
}