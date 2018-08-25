using DownloadFaster.Toos;
using System;

namespace DownloadFaster
{
    class Program
    {
        /// <summary>
        /// Main函数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DownLoadInfo dli = new DownLoadInfo();
            for (int i = 0; i < args.Length; i += 2)
            {
                switch (args[i])
                {
                    case "-h":
                    case "-help":
                        UserHelperPage();
                        break;
                    case "-u":
                    case "-url":
                        dli.DownLoadUrl.Add(args[i + 1]);
                        break;
                    case "-p":
                    case "-path":
                        dli.DownLoadPath = args[i + 1];
                        break;
                    default:
                        break;
                }
            }

            //执行下载动作
            DownLoad.DownLoadFile(dli);
        }

        /// <summary>
        /// 用户操作手册
        /// </summary>
        public static void UserHelperPage()
        {
            Console.WriteLine("----------  DownFaster使用方法 ----");
            Console.WriteLine("|                                |");
            Console.WriteLine("|  -url / -u 下载的url            |");
            Console.WriteLine("----------  DownFaster ----------");
        }
    }
}
