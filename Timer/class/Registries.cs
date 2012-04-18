using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Timer
{
    public static class Registries
    {
        private static string subKey="SOFTWARE\\"+Application.ProductName;
        private static RegistryKey baseRegistryKey=Registry.LocalMachine;

        public static int getreg(string KeyName)
        {
            try
            {
                // Opening the registry key
                RegistryKey rk = baseRegistryKey;
                // Open a subKey as read-only
                RegistryKey sk1 = rk.OpenSubKey(subKey);
                // If the RegistrySubKey doesn't exist -> (null)
                if (sk1 == null)
                    return 0;

                // If the RegistryKey exists I get its value
                // or null is returned.
                return (int) sk1.GetValue(KeyName.ToUpper());
            }
            catch
            {
                return 0;
            }
        }

        public static void setreg(string KeyName, object Value)
        {
            // Setting
            RegistryKey rk=baseRegistryKey;
            // I have to use CreateSubKey 
            // (create or open it if already exits), 
            // 'cause OpenSubKey open a subKey as read-only
            RegistryKey sk1=rk.CreateSubKey(subKey);
            // Save the value
            sk1.SetValue(KeyName.ToUpper(), Value);
        }
    }
}
