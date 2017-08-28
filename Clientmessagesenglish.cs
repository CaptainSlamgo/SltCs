using System;
using System.IO;
using System.Diagnostics;

namespace Tools.STOLeaks
{
    internal static class ClientMessagesEnglish
    {
        private static String cme_bin_old = "/Clientmessagesenglish.bin",
                              cme_old_dir = "/Clientmessagesenglish",
                              cme_bin = "/bins_unpack/bin/Clientmessagesenglish";
        // 5:
        internal static void DeleteCMEBin()
        {
            if(File.Exists(cme_bin_old))
            {
                try
                {
                    File.Delete(cme_bin_old);
                    Console.WriteLine("removed old cme.bin");
                }
                catch(IOException)
                {
                    Console.WriteLine("failed to remove old cme.bin");
                }
            }
        }
        // 6:
        internal static void DeleteOldCME()
        {
            if(File.Exists("/CME_OLD"))
            {
                try
                {
                    File.Delete("/CME_OLD");
                    Console.WriteLine("removed CME_OLD");
                }
                catch(IOException)
                {
                    Console.WriteLine("failed to remove CME_OLD");
                }
            }
        }
        // 7:
        internal static void DeleteCMEFolder()
        {
            if(Directory.Exists(cme_old_dir))
            {
                try
                {
                    String cme_old_file = "/Clientmessagesenglish/Clientmessagesenglish.bin";
                    Directory.Delete(cme_old_dir, true);
                    File.Move(cme_old_file, "/CME_OLD");
                    Console.WriteLine("cleaned cme");
                }
                catch(Exception)
                {
                    Console.WriteLine("failed to clean cme");
                }
            }
        }
        // 8:
        internal static void CopyCMEBin()
        {
            if(File.Exists(cme_bin))
            {
                try
                {
                    File.Move(cme_bin, "/Clientmessagesenglish.bin");
                    Console.WriteLine("moved CME.bin");
                }
                catch(Exception)
                {
                    Console.WriteLine("failed to move CME.bin");
                }
            }
        }
        // 9:
        internal static void ConvertCMEBin()
        {
            try
            {
                var process = Process.Start("Gibbed.Cryptic.ConvertResource.exe", "Clientmessagesenglish.bin");
                process.WaitForExit();
                Console.WriteLine("converted CME.bin");
            }
            catch(Exception)
            {
                Console.WriteLine("failed to convert CME.bin");
            }
        }
    }
}