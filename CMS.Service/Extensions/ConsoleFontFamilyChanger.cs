using PInvoke;
using System.Runtime.InteropServices;

namespace CMS.Service.Extensions;

public class ConsoleFontFamilyChanger
{
    private const int STD_OUTPUT_HANDLE = -11;

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr GetStdHandle(int nStdHandle);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool SetCurrentConsoleFontEx(IntPtr hConsoleOutput, bool bMaximumWindow, ref CONSOLE_FONT_INFOEX lpConsoleCurrentFontEx);

    [StructLayout(LayoutKind.Sequential)]
    public struct CONSOLE_FONT_INFOEX
    {
        public int cbSize;
        public int nFont;
        public COORD dwFontSize;
        public int FontFamily;
        public int FontWeight;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string FaceName;
    }

    public static bool SetConsoleFontFamily(string fontName)
    {
        IntPtr hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);

        CONSOLE_FONT_INFOEX consoleFontInfo = new CONSOLE_FONT_INFOEX();
        consoleFontInfo.cbSize = Marshal.SizeOf(consoleFontInfo);
        consoleFontInfo.FaceName = fontName;

        return SetCurrentConsoleFontEx(hConsoleOutput, false, ref consoleFontInfo);
    }
}