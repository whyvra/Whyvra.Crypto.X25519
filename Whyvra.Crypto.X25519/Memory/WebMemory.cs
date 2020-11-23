using System;
using System.Runtime.InteropServices;

namespace Whyvra.Crypto.X25519.Memory
{
    public class WebMemory : MemoryBase
    {
        public WebMemory() : base(WebZero, WebLockMemory, WebUnlockMemory)
        {
            if (RuntimeInformation.OSDescription != "web" && RuntimeInformation.OSDescription != "Browser")
            {
                throw new DllNotFoundException($"Running on \"{RuntimeInformation.OSDescription}\", not \"web\" or \"Browser\".");
            }
        }

        #nullable enable
        private static string? WebLockMemory(IntPtr m, UIntPtr l)
        #nullable disable
        {
            // cannot prevent memory from swapping within the browser.
            return null;
        }

        private static void WebUnlockMemory(IntPtr m, UIntPtr l)
        {
            // cannot prevent memory from swapping within the browser.
        }

        private static void WebZero(IntPtr m, UIntPtr l)
        {
            Marshal.Copy(new byte[(int)l.ToUInt32()], 0, m, (int)l.ToUInt32());
        }
    }
}