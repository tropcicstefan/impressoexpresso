using System;
using System.Diagnostics;
using System.IO;

namespace User_manual
{
    public class Class1
    {
        public static void OtvoriPodrsku(int broj)
        {
            Byte[] bytes = Properties.Resources.User_manual;

            using (FileStream fs = File.Create("test.pdf"))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            Process process1 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            process1.StartInfo = startInfo;
            startInfo.Arguments = "/A \"page=" + broj.ToString() + "=OpenActions\" test.pdf";
            startInfo.FileName = "AcroRd32.exe";
            process1.Start();


        }
    }
}
