using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ExtendedDialogBoxApp.Utils
{
    public static class Extension
    {
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
