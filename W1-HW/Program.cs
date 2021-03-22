using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace HomeWork01
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string usermove ="";
            string userconsole ="";
            string path1 ="";
            string path2 ="";
            
            Console.WriteLine("程式開始\n");
            
            if (args.Length == 0) //如果user直接執行exe檔 
            {
                Console.WriteLine("請輸入您想執行的動作: (例:movefile)");
                usermove = Console.ReadLine().ToLower();

            }
            else //如果使用者是用cmd開啟
            {
                // 系統自動抓取第一個參數 = args[0]
                userconsole = args[0].ToLower();
                path1 = args[1];
            }


            // 呼叫搬檔 movefile方法
            if (usermove == "movefile" || userconsole == "movefile") // 呼叫搬檔 movefile方法
            {
                
                if (args.Length != 0)
                {
                    path2 = args[2];
                    fileconsole.movefile(path1, path2);
                }
                else
                {
                    
                    Console.WriteLine("請輸入來源檔案路徑");
                    path1 = Console.ReadLine();
                    Console.WriteLine("請輸入目標路徑");
                    path2 = Console.ReadLine();
                    fileconsole.movefile(path1, path2);
                }
            }


            // 呼叫讀檔 readfile方法
            if (usermove == "readfile" || userconsole == "readfile") // 呼叫讀檔 readfile方法
            {
                if (args.Length != 0)
                {
                    fileconsole.readfile(path1);
                }
                else
                {
                    Console.WriteLine("請輸入來源檔案路徑");
                    path1 = Console.ReadLine();
                    fileconsole.readfile(path1);                   
                }
            }


            // 呼叫搬檔 copyfile方法
            if (usermove == "copyfile" || userconsole == "copyfile") // 呼叫拷檔 movefile方法
            {

                if (args.Length != 0)
                {
                    path2 = args[2];
                    fileconsole.copyfile(path1, path2);
                }
                else
                {

                    Console.WriteLine("請輸入來源檔案路徑");
                    path1 = Console.ReadLine();
                    Console.WriteLine("請輸入目標路徑");
                    path2 = Console.ReadLine();
                    fileconsole.copyfile(path1, path2);
                }
            }

            // 呼叫刪檔 delete方法
            if (usermove == "deletefile" || userconsole == "deletefile") // 呼叫刪檔 deletefile方法
            {

                if (args.Length != 0)
                {

                    fileconsole.deletefile(args);
                }
                else
                {

                    Console.WriteLine("請輸入欲之刪除檔案路徑,如為多筆路徑 請以空格分隔每筆路徑");
                    string delfile = Console.ReadLine();
                    string[] delfileArray = delfile.Split(' ');
                    fileconsole.deletefile(delfileArray);
                }
            }

            // 呼叫刪資料夾 deletefolder方法
            if (usermove == "deletefolder" || userconsole == "deletefolder") 
            {

                if (args.Length != 0)
                {
                    
                    fileconsole.deletefolder(args);
                }
                else
                {

                    Console.WriteLine("請輸入欲之刪除資料夾完整路徑,如為多筆路徑 請以空格分隔每筆路徑");
                    string delfolder = Console.ReadLine();
                    string[] delfolderArray = delfolder.Split(' ');
                    fileconsole.deletefolder(delfolderArray);
                }
            }

            // 呼叫建資料夾 createfolder方法
            if (usermove == "createfolder" || userconsole == "createfolder") // 呼叫建資料夾 createfolder方法
            {

                if (args.Length != 0)
                {
                    path1 = args[1];
                    fileconsole.createfolder(path1);
                }
                else
                {

                    Console.WriteLine("請輸入目標路徑");
                    path1 = Console.ReadLine();
                    fileconsole.createfolder(path1);
                }
            }


            Console.ReadLine();
            
            
        }
    }
}
