using System.IO;
using System.Security.AccessControl;
using Microsoft.Win32;

namespace OS_CP.Presenter
{
    /// <summary>
    /// Specific presenter interface for Settings view
    /// </summary>
    public sealed class SettingsPresenter : BasePresenter<ISettingsView>
    {
        private const string RegistryPath = @"Software\Grshchnkv\OS_CP";
        private static readonly string CurrentPath = Directory.GetCurrentDirectory();

        private RegistryKey _registryKey;

        /// <summary>
        /// Constructor of SettingsPresenter class
        /// </summary>
        /// <param name="controller"> Application controller </param>
        /// <param name="view"> View </param>
        public SettingsPresenter(IApplicationController controller, ISettingsView view) : base(controller, view)
        {
            LoadValues();

            View.LoadShowing += () => SaveKeyValue("ShowLoad", View.ShowLoad.ToString());
            View.VideoShowing += () => SaveKeyValue("ShowVideo", View.ShowVideo.ToString());
            View.SelectExport += SelectExport;
            View.SelectInterpolation += SelectInterpolation;
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadValues()
        {
            _registryKey = RegistryFunctions.CheckRegistry(RegistryPath);
            
            string[] keyNames = RegistryFunctions.GetKeys(_registryKey);

            if (keyNames.Length != 0)
            {
                foreach (string keyName in keyNames)
                {
                    switch (keyName)
                    {
                        case "ShowLoad":
                            View.ShowLoad = RegistryFunctions.GetValue(_registryKey, "ShowLoad") == "True";
                            break;
                        case "ShowVideo":
                            View.ShowVideo = RegistryFunctions.GetValue(_registryKey, "ShowVideo") == "True";
                            break;
                        case "ExportDLLPath":
                            View.ExportDLLPath = RegistryFunctions.GetValue(_registryKey, "ExportDLLPath") == CurrentPath ? null : RegistryFunctions.GetValue(_registryKey, "ExportDLLPath");
                            break;
                        case "InterpolationDLLPath":
                            View.InterpolationDLLPath = RegistryFunctions.GetValue(_registryKey, "InterpolationDLLPath") == CurrentPath ? null : RegistryFunctions.GetValue(_registryKey, "InterpolationDLLPath");
                            break;
                    }
                }
            }
            else
            {
                RegistryFunctions.SetValue(_registryKey, "ShowLoad", true.ToString());
                RegistryFunctions.SetValue(_registryKey, "ShowVideo", true.ToString());
                RegistryFunctions.SetValue(_registryKey, "ExportDLLPath", CurrentPath);
                RegistryFunctions.SetValue(_registryKey, "InterpolationDLLPath", CurrentPath);
                LoadValues();
            }
            _registryKey.Close();
        }

        /// <summary>
        /// Load export type DLL
        /// </summary>
        private void SelectExport()
        {
            View.ExportDLLPath = FileFunctions.Open("dll");
            SaveKeyValue("ExportDLLPath", View.ExportDLLPath);
        }

        /// <summary>
        /// Load interpolation type DLL
        /// </summary>
        private void SelectInterpolation()
        {
            View.InterpolationDLLPath = FileFunctions.Open("dll");
            SaveKeyValue("InterpolationDLLPath", View.InterpolationDLLPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void SaveKeyValue(string name, string value)
        {
            _registryKey = RegistryFunctions.CheckRegistry(RegistryPath);
            RegistryFunctions.SetValue(_registryKey, name, value);
            _registryKey.Close();
        }
    }
}