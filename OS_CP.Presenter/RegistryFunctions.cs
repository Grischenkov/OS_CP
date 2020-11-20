using Microsoft.Win32;
using System.IO;

namespace OS_CP.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public static class RegistryFunctions
    {
        public static readonly string CurrentPath = Directory.GetCurrentDirectory();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static RegistryKey CheckRegistry(string path)
        {
            if (Registry.CurrentUser.OpenSubKey(path, true) == null)
            {
                Registry.CurrentUser.CreateSubKey(path, true);
            }
            string[] keyNames = RegistryFunctions.GetKeys(Registry.CurrentUser.OpenSubKey(path, true));
            if (keyNames.Length != 4)
            {
                SetDefaultValues(Registry.CurrentUser.OpenSubKey(path, true));
            }
            return Registry.CurrentUser.OpenSubKey(path, true);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void SetDefaultValues(RegistryKey key)
        {
            SetValue(key, "ShowLoad", true.ToString());
            SetValue(key, "ShowVideo", true.ToString());
            SetValue(key, "ExportDLLPath", CurrentPath);
            SetValue(key, "MathDLLPath", CurrentPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetValue(RegistryKey key, string name)
        {
            return key.GetValue(name).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string[] GetKeys(RegistryKey key)
        {
            return key.GetValueNames();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetValue(RegistryKey key, string name, string value)
        {
            key.SetValue(name, value);
        }
    }
}
