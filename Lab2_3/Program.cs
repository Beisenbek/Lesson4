using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Part2();
        }

        static void Part1()
        {
            FileStream fs = new FileStream(@"C:\Users\bsnbk2\Desktop\new.txt", FileMode.Open);
            FileStream fs2 = new FileStream(@"C:\Users\bsnbk2\Desktop\new.gz", FileMode.Append);
            GZipStream g = new GZipStream(fs2, CompressionMode.Compress);

            int readByte = fs.ReadByte();
            while (readByte != -1)
            {
                g.WriteByte((byte)readByte);
                readByte = fs.ReadByte();
            }

            fs.Close();
            fs2.Close();
            g.Close();
        }

        static void Part2()
        {

            using (FileStream fs = new FileStream(@"C:\Users\bsnbk2\Desktop\new.txt", FileMode.Open))
            {
                using (FileStream fs2 = new FileStream(@"C:\Users\bsnbk2\Desktop\new.gz", FileMode.Append))
                {
                    using (GZipStream g = new GZipStream(fs2, CompressionMode.Compress))
                    {
                        int readByte = fs.ReadByte();
                        while (readByte != -1)
                        {
                            g.WriteByte((byte)readByte);
                            readByte = fs.ReadByte();
                        }
                    }
                }

            }
        }


    }
}
