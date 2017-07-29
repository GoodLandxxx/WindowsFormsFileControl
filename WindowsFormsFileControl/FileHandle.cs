using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsFileControl
{
    static class FileHandle
    {
        static List<fileeee> fileeeeList = new List<fileeee> { };
        static string fileState = null;
        static public List<fileeee> ReadAllText(string path)
        {
            string presentFolder = null;

            DirectoryInfo folder = new DirectoryInfo(path);


            if (folder.Exists)
            {
                //FileInfo[] fileinfos = folder.GetFiles();
                //if (fileinfos.Length == 0)
                //{
                //    fileState = "该文件为空";
                //}
                //else
                //    {
                if (folder.GetDirectories().Length != 0)
                {
                    foreach (DirectoryInfo DirectoryInfo in folder.GetDirectories())
                    {
                        presentFolder = DirectoryInfo.FullName;
                        ReadAllText(presentFolder);
                    }
                }
                if (folder.GetFiles().Length != 0)
                {
                    foreach (FileInfo fileinfo in folder.GetFiles())
                        fileeeeList.Add(fileHandle(fileinfo));
                }
                else
                {
                    fileState = "文件不存在";
                }
            }
            return fileeeeList;
        }
        
       
       

     
        
        static public fileeee fileHandle(FileInfo fileInfo)
        {
            bool type = true;
            string fileName = null;
            fileeee fileeee = new fileeee();
            fileeee.fileName = fileInfo.Name;
            fileeee.fileSize = countFileSize(fileInfo);
            fileeee.filePath = fileInfo.DirectoryName;
            fileeee.fileType = fileInfo.Extension;//原来这里使用是自己写的函数
            return fileeee;
        }
        static public string countFileSize(FileInfo fileInfo)
        {


            string size = null;
            long sizeInt = fileInfo.Length;
            double kbit = 1024.0;
            double mbit = 1024 * 1024.0;
            double gbit = 1024 * 1024 * 1024.0;
            if (sizeInt > kbit && sizeInt / kbit < 1024)
            {

                return String.Format("{0:f1}", sizeInt / kbit) + " KB;";
            }
            else if (sizeInt > mbit && sizeInt / mbit < 1024)
            {
                return String.Format("{0:f1}", sizeInt / mbit) + "MB";

            }
            else if (sizeInt > 1024 * 1024 * 1024)
            {
                return string.Format("{0:f2}", sizeInt / gbit) + "GB";
            }
            return Convert.ToString(sizeInt);

        }
        /// <summary>
        /// 是否视频文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool isVideo(string Extension)
        {
            if (Extension.Equals(".mkv")
                  || Extension.Equals(".mp4")
                   || Extension.Equals(".avi")
                   || Extension.Equals(".rmvb")
                   || Extension.Equals(".flv")
                   || Extension.Equals(".Ts")
                   || Extension.Equals(".vob")
                   )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 是否压缩文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool isZip(string Extension)
        {
            if (Extension.Equals(".7z")
                  || Extension.Equals(".zip")
                  || Extension.Equals(".rar")
                  )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 是否文本文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool isTxt(string Extension)
        {
            if (Extension.Equals(".txt")
                || Extension.Equals(".pdf")
                || Extension.Equals(".eubp"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 是否网络文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool isIntenetFile(string Extension)
        {
            if (Extension.Equals(".html")
                  || Extension.Equals(".css")
                  || Extension.Equals(".js")
                  || Extension.Equals(".jsp")
                  || Extension.Equals(".url")
                  )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 是否图片
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public bool isPicture(string Extension)
        {
            if (Extension.Equals(".jpg")
                  || Extension.Equals(".jpge")
                  || Extension.Equals(".gif")
                  || Extension.Equals(".png")
                  || Extension.Equals(".bmp")
                  || Extension.Equals(".psd")
                  )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static public bool isExe(string Extension)
        {
            if (Extension.Equals(".exe"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static private string endTypeName(string fileName)
        {
            string newFileName = null;
            newFileName = fileName.Substring(fileName.Length - 4, 4);

            if (newFileName[0] == '.')
            {
                newFileName = fileName.Substring(fileName.Length - 3, 3);
                if (newFileName[0] == '.')
                {
                    newFileName = fileName.Substring(fileName.Length - 2, 2);
                }
            }
            return newFileName;
        }
    }
}
