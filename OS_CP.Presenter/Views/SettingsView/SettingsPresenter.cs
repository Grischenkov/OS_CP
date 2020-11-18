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
            View.SelectMath += SelectMath;
            View.DiscardExport += () => DiscardPath("ExportDLLPath");
            View.DiscardMath += () => DiscardPath("MathDLLPath");
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadValues()
        {
            _registryKey = RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath);
            string[] keyNames = RegistryFunctions.GetKeys(_registryKey);
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
                        View.ExportDLLPath = RegistryFunctions.GetValue(_registryKey, "ExportDLLPath") == RegistryFunctions.CurrentPath ? null : RegistryFunctions.GetValue(_registryKey, "ExportDLLPath");
                        break;
                    case "MathDLLPath":
                        View.MathDLLPath = RegistryFunctions.GetValue(_registryKey, "MathDLLPath") == RegistryFunctions.CurrentPath ? null : RegistryFunctions.GetValue(_registryKey, "MathDLLPath");
                        break;
                }
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
        /// Load Math type DLL
        /// </summary>
        private void SelectMath()
        {
            View.MathDLLPath = FileFunctions.Open("dll");
            SaveKeyValue("MathDLLPath", View.MathDLLPath);
        }

        private void DiscardPath(string name)
        {
            switch (name)
            {
                case "ExportDLLPath":
                    View.ExportDLLPath = null;
                    break;
                case "MathDLLPath":
                    View.MathDLLPath = null;
                    break;
            }
            SaveKeyValue(name, RegistryFunctions.CurrentPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void SaveKeyValue(string name, string value)
        {
            _registryKey = RegistryFunctions.CheckRegistry(Properties.Settings.Default.RegistryPath);
            RegistryFunctions.SetValue(_registryKey, name, value);
            _registryKey.Close();
        }
    }
}