using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using WindowsTileCustomizer.Properties;

namespace WindowsTileCustomizer.Utils
{
    class ResUtils
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        public static void LoadEmbeddedFont(byte[] font, ref PrivateFontCollection fonts)
        {
            IntPtr fontPtr = Marshal.AllocCoTaskMem(font.Length);
            Marshal.Copy(font, 0, fontPtr, font.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, font.Length);
            AddFontMemResourceEx(fontPtr, (uint) font.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);
        }

        public static string[] LoadColors()
        {
            string[] separators = { Environment.NewLine };
            return Resources.Colors.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
