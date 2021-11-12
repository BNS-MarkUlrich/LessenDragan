using System;
using System.IO;
using System.Net.Http;

namespace DirectoryAssignment
{
    public static class PathHelper
    {
        public static string GetExeDir()
        {
            string locaiton = typeof(PathHelper).Assembly.Location;
            FileInfo fileInfo = new FileInfo(locaiton);

            string exeDir = fileInfo.DirectoryName;

            return exeDir;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string exeDir = PathHelper.GetExeDir();
            string path = Path.Combine(exeDir, "fileinfo");
            Directory.CreateDirectory(path);

            string newPath = Path.Combine(path, "myname.txt");

            using (StreamReader r = new StreamReader(newPath))
            {
                string eenRegel = r.ReadLine();
                Console.WriteLine(eenRegel);
            }
        }
    }
}
