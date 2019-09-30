using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ExtendedDialogBoxApp.Utils
{
    /// <summary>
    /// Set of extensions for working with SecureString
    /// 
    /// <see cref="https://github.com/dotnet/platform-compat/blob/master/docs/DE0001.md"> DE0001: SecureString shouldn't be used </see>
    /// Use in production may be unsafe
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Convert SecureString to string
        /// 
        /// Author <see cref="https://blogs.msdn.microsoft.com/fpintos/2009/06/12/how-to-properly-convert-securestring-to-string/"> How to properly convert SecureString to String </see>
        /// </summary>
        /// <param name="securePassword">SecureString source</param>
        /// <returns>String converted from SecureString</returns>
        public static string ToUnsecureString(this SecureString securePassword)
        {
            if (securePassword == null)
            {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        /// <summary>
        /// Convert string to SecureString
        ///
        /// Author <see cref="https://blogs.msdn.microsoft.com/fpintos/2009/06/12/how-to-properly-convert-securestring-to-string/"> How to properly convert SecureString to String </see>
        /// </summary>
        /// <param name="password">String source</param>
        /// <returns>SecureString converted from String</returns>
        public static SecureString ToSecureString(this string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            var secureString = new SecureString();

            foreach (var chr in password.ToCharArray())
            {
                secureString.AppendChar(chr);
            }
            secureString.MakeReadOnly();


            return secureString;
        }

        /// <summary>
        /// Equals two secure string.
        /// 
        /// Use in production may be unsafe
        /// Author <see cref="https://stackoverflow.com/questions/4502676/c-sharp-compare-two-securestrings-for-equality/4502736#4502736"/>
        /// </summary>
        /// 
        /// <param name="secureString1">SecureString source</param>
        /// <param name="secureString2">SecureString compared</param>
        /// <returns>True if equals, false otherwise</returns>
        public static bool SecureEqual(this SecureString secureString1, SecureString secureString2)
        {
            if (secureString1 == null)
            {
                throw new ArgumentNullException(nameof(secureString1));
            }
            if (secureString2 == null)
            {
                throw new ArgumentNullException(nameof(secureString2));
            }

            if (secureString1.Length != secureString2.Length)
            {
                return false;
            }

            IntPtr ss_bstr1_ptr = IntPtr.Zero;
            IntPtr ss_bstr2_ptr = IntPtr.Zero;

            try
            {
                ss_bstr1_ptr = Marshal.SecureStringToBSTR(secureString1);
                ss_bstr2_ptr = Marshal.SecureStringToBSTR(secureString2);

                string str1 = Marshal.PtrToStringBSTR(ss_bstr1_ptr);
                string str2 = Marshal.PtrToStringBSTR(ss_bstr2_ptr);

                return str1.Equals(str2);
            }
            finally
            {
                if (ss_bstr1_ptr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(ss_bstr1_ptr);
                }

                if (ss_bstr2_ptr != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(ss_bstr2_ptr);
                }
            }
        }
    }
}
