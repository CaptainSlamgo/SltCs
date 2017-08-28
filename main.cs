using System;
using Tools.STOLeaks;

internal class main
{
    internal static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Attempting to run...");
            Hogg.DeleteBinsHogg();
            Hogg.DeleteBinsUnpack();
            Hogg.CopyBinsHogg();
            Hogg.UnpackBinsHogg();
            ClientMessagesEnglish.DeleteCMEBin();
            ClientMessagesEnglish.DeleteOldCME();
            ClientMessagesEnglish.DeleteCMEFolder();
            ClientMessagesEnglish.CopyCMEBin();
            ClientMessagesEnglish.ConvertCMEBin();
        }
        catch(Exception)
        {
            Console.WriteLine("error");
        }
        finally
        {
            Console.ReadKey();
        }
    }
}