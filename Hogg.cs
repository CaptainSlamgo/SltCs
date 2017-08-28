using System;
using System.IO;
using System.Diagnostics;

namespace Tools.STOLeaks
{
    internal static class Hogg
    {
        private static String hogg_origin = Paths.bindir,
                              hogg_current = "\\bins.hogg",
                              bins_unpack = "\\bins_unpack";
        // 1:
        internal static void DeleteBinsHogg()
        {
            if(File.Exists(hogg_current))
            {
                try
                {
                    File.Delete(hogg_current);
                    Console.WriteLine("removed bins.hogg");
                }
                catch(IOException)
                {
                    Console.WriteLine("failed to remove bins.hogg");
                }
            }
        }
        // 2:
        internal static void DeleteBinsUnpack()
        {
            if(Directory.Exists(bins_unpack))
            {
                try
                {
                    Directory.Delete(bins_unpack, true);
                    Console.WriteLine("removed bins_unpack");
                }
                catch(IOException)
                {
                    Console.WriteLine("failed to remove bins_unpack");
                }
            }
        }
        // 3:
        internal static void CopyBinsHogg()
        {
            if(File.Exists(Paths.bindir))
            {
                try
                {
                    File.Copy(Paths.bindir, "bins.hogg");
                    Console.WriteLine("copied bins.hogg");
                }
                catch(IOException)
                {
                    Console.WriteLine("failed to copy bins.hogg");
                }
            }
        }
        // 4:
        internal static void UnpackBinsHogg()
        {
            try
            {
                var process = Process.Start("Gibbed.Cryptic.Unpack.exe", "bins.hogg");
                process.WaitForExit();
                Console.WriteLine("unpacked bins.hogg");
            }
            catch (SystemException)
            {
                Console.WriteLine("failed to unpack bins.hogg");
            }
        }
    }
}