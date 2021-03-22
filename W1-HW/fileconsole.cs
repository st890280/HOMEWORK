using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace HomeWork01
{
    public class fileconsole

    {
        public static void movefile(string path1, string path2) //搬檔method
        {
            Stopwatch sw = new Stopwatch();
            sw.Start(); //計時器開始

            if (!File.Exists(path1)) //判斷來源檔案路徑存不存在
            {
                Console.WriteLine($"{path1} 來源路徑檔案不存在;");
                sw.Stop();
                Console.WriteLine($"\n程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"確定要將{path1}的檔案,搬移至{path2}.請輸入: Y / N"); //提示使用者是否確定操作
            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫
            
            if (File.Exists(path2)) //判斷目標路徑是否已存在相同檔案
            {
                Console.WriteLine($"{path2} 目標路徑已存在相同檔案;");
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
                Console.ReadLine();
                return;
            }

            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {
                File.Move(path1,path2);
                sw.Stop();
                Console.WriteLine($"檔案搬移完成! 總共用時 {sw.Elapsed.TotalMilliseconds}秒");
            }
            else
            {
                return;
            }

        }


        public static void readfile(string path1)               //讀檔method
        {
           
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (!File.Exists(path1))
            {
                Console.WriteLine($"{path1} 不存在;");
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"確定要讀取{path1}的檔案,請輸入: Y / N"); //提示使用者是否確定操作
            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫

            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {

                
                Console.WriteLine(File.ReadAllText(path1));
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
            }
            else
            {
                return;
            }

        }


        public static void copyfile(string path1, string path2) //拷檔method
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (!File.Exists(path1))
            {
                Console.WriteLine($"{path1} 不存在;");
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
                Console.ReadLine();
                return;
            }

            if (File.Exists(path2)) //判斷目標路徑是否已存在相同檔案
            {
                Console.WriteLine($"{path2} 目標路徑已存在相同檔案;");
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.ElapsedMilliseconds}秒");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"確定要複製{path1}的檔案至{path2},請輸入: Y / N"); //提示使用者是否確定操作
            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫

            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {
                File.Copy(path1,path2);
                sw.Stop();
                Console.WriteLine($"檔案複製成功. 總共用時 {sw.ElapsedMilliseconds}秒");
            }
            else
            {
                return;
            }
        }


        public static void deletefile(string[] delfile)             //刪檔method
        {
            Stopwatch sw = new Stopwatch();  //設定計時器
            sw.Start(); //計時器開始

            for (int i = 0; i < delfile.Length; i++) //顯示user想刪的所有檔案路徑及數量
            {
                int k = 0; //用在顯示結果數量時與i相加

                if (delfile[0] != "deletefile")  //如果user是用exe檔開啟的話 第一筆輸入的路徑參數會被歸類在[0] 最後顯示結果數量會少1筆
                {
                    k = 1;
                }

                if (delfile[i] == "deletefile") //判斷如果第一筆參數如果是 "deletefolder" 跳過一次
                {
                    continue;
                }

                if (File.Exists(delfile[i])) //判斷檔案是否存在 如存在 顯示出來
                {
                    Console.WriteLine(delfile[i]);
                }

                if (!File.Exists(delfile[i])) //判斷目標路徑是否已存在相同檔案
                {
                    Console.WriteLine($"{delfile[i]} 目標路徑不存在檔案");
                    sw.Stop();  //計時器停止計時
                    Console.WriteLine($"程式結束. 總共用時 {sw.Elapsed} 秒");
                    Console.ReadLine();
                    return;
                }

                if (i == delfile.Length - 1)
                {
                    Console.WriteLine($"確定要刪除以上{i + k}個檔案?請輸入: Y / N"); //提示使用者是否確定操作
                }

            }

            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫
            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {
                int total = 0;
                for (int i = 0; i < delfile.Length; i++)
                {

                    if (delfile[i] == "deletefile")
                    {
                        continue;
                    }

                    File.Delete(delfile[i]);
                    total += 1;
                }
                Console.WriteLine($"共刪除{total}筆檔案");

            }
            else
            {
                return;
            }
            sw.Stop();
            Console.WriteLine($"檔案刪除成功. 總共用時 {sw.Elapsed}秒");
        } 


        public static void deletefolder(string[] delfolder)     //刪資料夾method
        {
            Stopwatch sw = new Stopwatch();  //設定計時器
            sw.Start(); //計時器開始

            for (int i=0; i<delfolder.Length; i++) //顯示user想刪的所有資料夾路徑及數量
            {
                int k = 0; //用在顯示結果數量時與i相加

                if (delfolder[0] != "deletefolder")  //如果user是用exe檔開啟的話 第一筆輸入的路徑參數會被歸類在[0] 最後顯示結果數量會少1筆
                {
                    k = 1;  
                }

                if (delfolder[i] == "deletefolder")
                {
                    continue;
                }

                if (Directory.Exists(delfolder[i]))
                {
                    Console.WriteLine(delfolder[i]);
                }

                if (!Directory.Exists(delfolder[i])) //判斷目標路徑是否已存在相同資料夾
                {
                    Console.WriteLine($"{delfolder[i]} 目標路徑不存在相同資料夾;");
                    sw.Stop();  //計時器停止計時
                    Console.WriteLine($"程式結束. 總共用時 {sw.Elapsed} 秒");
                    Console.ReadLine();
                    return;
                }

                if (i == delfolder.Length - 1)
                {
                    Console.WriteLine($"確定要刪除以上{i+k}個的資料夾?請輸入: Y / N"); //提示使用者是否確定操作
                }

            }
            
            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫
            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {
                int total = 0;
                for (int i = 0; i < delfolder.Length; i++)
                {
                    
                    if (delfolder[i] == "deletefolder")
                    {
                        continue;
                    }

                    Directory.Delete(delfolder[i]);
                    total += 1;
                }
                Console.WriteLine($"共刪除{total}筆資料");
                
            }
            else
            {
                return;
            }
            sw.Stop();
            Console.WriteLine($"資料夾刪除成功. 總共用時 {sw.Elapsed}秒");
        }


        public static void createfolder(string path1)           //建資料夾method
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            

            if (Directory.Exists(path1)) //判斷目標路徑是否已存在相同資料夾
            {
                Console.WriteLine($"{path1} 目標路徑已存在相同資料夾;");
                sw.Stop();
                Console.WriteLine($"程式結束. 總共用時 {sw.Elapsed} 秒");
                Console.ReadLine();
                return;
            }


            Console.WriteLine($"確定要新增一個資料夾至 {path1} ? 請輸入: Y / N"); //提示使用者是否確定操作
            string yes = Console.ReadLine().ToLower(); //宣告一個變數 來裝使用者輸入的 Y/N，並統一轉換成小寫

            if (yes == "y" || yes == "yes") //如果使用者確定執行
            {
                Directory.CreateDirectory(path1);
                sw.Stop();
                Console.WriteLine($"資料夾建立成功. 總共用時 {sw.Elapsed}秒");
            }
            else
            {
                return;
            }
        }




    }
}
