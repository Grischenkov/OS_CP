using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace OS_CP.Presenter
{
    /// <summary>
    /// 
    /// </summary>
    public static class RegistryFunctions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static RegistryKey CheckRegistry (string path)
        {
            return Registry.CurrentUser.OpenSubKey(path, true) ?? 
                   Registry.CurrentUser.CreateSubKey(path, true);
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
