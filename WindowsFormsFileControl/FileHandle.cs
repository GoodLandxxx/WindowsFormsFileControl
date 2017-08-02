using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsFileControl
{
    static class FileHandle
    {

        private static List<File_class> fileList = new List<File_class> { };
        private static List<FileInfo> FileInfos = new List<FileInfo> { };
        private static string fileState = null;
        private static FileInfo[] arrFile = null;



        static public List<FileInfo> ReadAllText(string path)
        {

            string presentFolder = null;

            DirectoryInfo folder = new DirectoryInfo(path);
            DirectoryInfo[] directoyinfos = folder.GetDirectories();
            try
            {
                if (folder.Exists)
                {

                    if (folder.GetFiles().Length != 0)
                    {
                        foreach (FileInfo fileinfo in folder.GetFiles())
                            FileInfos.Add(fileinfo);
                    }
                    else
                    {
                        fileState = "文件不存在";
                    }
                    if (directoyinfos.Length != 0)
                    {
                        foreach (DirectoryInfo DirectoryInfo in directoyinfos)
                        {
                            presentFolder = DirectoryInfo.FullName;
                            ReadAllText(presentFolder);
                        }
                    }

                }
                return FileInfos;
            }
            catch (Exception e)
            {
                Console.WriteLine("ReadAllText(string path)" + e);

            }
            return FileInfos;
        }
        static public List<File_class> ReadAllText(List<FileInfo> FileInfos)
        {
            try
            {
                listToArray(FileInfos);
                SortAsFileName(ref arrFile);
                arrayToList(arrFile);
                foreach (FileInfo fileinfo in FileInfos)
                {
                    fileList.Add(fileHandle(fileinfo));
                }
                return fileList;
            }
            finally
            {
                ReFresh();
            }
        }

        static public int AddFile(File_class files)
        {
            string sql = string.Format("insert into fileInfo values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                files.fileName,
                files.fileType,
                files.filePath,
                files.fileSize,
                files.handlefileSize,
                files.fileCreateDate,
                files.fileLastWriteTime,
                files.fileLastAccessTime);
            int result = DB_file.ExeuteNonQuery(sql);
            return result;
        }
        static public void ReFresh()
        {
            fileList = null;
            FileInfos = null;
            arrFile = null;
            FileInfos = new List<FileInfo> { };
            fileList = new List<File_class> { };



        }
        static public void listToArray(List<FileInfo> fileinfos)
        {
            arrFile = new FileInfo[fileinfos.Count];
            for (int i = 0; i < fileinfos.Count; i++)
            {
                arrFile[i] = fileinfos[i];
            }
        }
        static public void arrayToList(FileInfo[] arrfi)
        {
            FileInfos.Clear();
            for (int i = 0; i < arrfi.Length; i++)
            {
                FileInfos.Add(arrfi[i]);
            }
        }


        static private void SortAsFileName(ref FileInfo[] arrFi)
        {
            Array.Sort(arrFi, delegate (FileInfo x, FileInfo y) { return x.Name.CompareTo(y.Name); });
        }
        static private void SortAsFileSize(ref FileInfo[] arrFi)
        {
            Array.Sort(arrFi, delegate (FileInfo x, FileInfo y) { return x.Length.CompareTo(y.Length); });
        }


        static private List<FileInfo> SortAsFileName(string filePath)
        {
            List<FileInfo> fileSortList = new List<FileInfo> { };
            DirectoryInfo di = new DirectoryInfo(filePath);

            FileInfo[] arrFi = di.GetFiles("*.*");
            SortAsFileName(ref arrFi);

            for (int i = 0; i < arrFi.Length; i++)
                fileSortList.Add(arrFi[i]);
            return fileSortList;
        }
        static private List<FileInfo> SortAsFileSize(string filePath)
        {
            List<FileInfo> fileSortList = new List<FileInfo> { };
            DirectoryInfo di = new DirectoryInfo(filePath);

            FileInfo[] arrFi = di.GetFiles("*.*");
            SortAsFileSize(ref arrFi);

            for (int i = 0; i < arrFi.Length; i++)
                fileSortList.Add(arrFi[i]);
            return fileSortList;
        }

        static public File_class fileHandle(FileInfo fileInfo)
        {
            //bool type = true;
            //string fileName = null;
            File_class file_Class = new File_class();
            file_Class.fileName = fileInfo.Name;
            file_Class.fileSize = fileInfo.Length;
            file_Class.handlefileSize = countFileSize(fileInfo);
            file_Class.filePath = fileInfo.DirectoryName;
            file_Class.fileCreateDate = fileInfo.CreationTime;
            file_Class.fileLastAccessTime = fileInfo.LastAccessTime;
            file_Class.fileLastWriteTime = fileInfo.LastWriteTime;
            if (!fileInfo.Extension.Equals(""))
            {
                file_Class.fileType = fileInfo.Extension.Substring(1, fileInfo.Extension.Length - 1);//原来这里使用是自己写的函数
            }
            return file_Class;
        }
        static public string countFileSize(FileInfo fileInfo)
        {


            //string size = null;
            long sizeInt = fileInfo.Length;
            double kbit = 1024.0;
            double mbit = 1024 * 1024.0;
            double gbit = 1024 * 1024 * 1024.0;
            if (sizeInt > kbit && sizeInt / kbit < 1024)
            {
                return String.Format("{0:f1}", sizeInt / kbit) + "  KB";
            }
            else if (sizeInt > mbit && sizeInt / mbit < 1024)
            {
                return String.Format("{0:f1}", sizeInt / mbit) + "  MB";

            }
            else if (sizeInt > 1024 * 1024 * 1024)
            {
                return string.Format("{0:f2}", sizeInt / gbit) + "  GB";
            }
            return Convert.ToString(sizeInt + "  字节");

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

            string filetype = null;
            int i = 1;
            while (true)
            {
                filetype = fileName.Substring(fileName.Length - i, i);
                i++;
                if (filetype[0].Equals('.'))
                    break;

            }
            return filetype;
            //newFileName = fileName.Substring(fileName.Length - 4, 4);

            //if (newFileName[0] == '.')
            //{
            //    newFileName = fileName.Substring(fileName.Length - 3, 3);
            //    if (newFileName[0] == '.')
            //    {
            //        newFileName = fileName.Substring(fileName.Length - 2, 2);
            //    }
            //}

        }
        static public List<File_class> sortFile(List<File_class> unSorted, string sortOfName)
        {
            List<File_class> sortFile = new List<File_class> { };
            switch (sortOfName)
            {
                case "name":

                    break;
            }
            return sortFile;
        }



        static public DataTable CreateDataTable(string tableName, List<File_class> File_class)
        {
            DataTable dt = new DataTable(tableName);
            dt.Columns.Add("filename", typeof(String));
            dt.Columns.Add("filetype", typeof(String));
            dt.Columns.Add("filepath", typeof(String));
            dt.Columns.Add("fileSize", typeof(long));
            dt.Columns.Add("handlefileSize", typeof(String));
            dt.Columns.Add("fileCreateDate", typeof(DateTime));
            dt.Columns.Add("fileLastWriteTime", typeof(DateTime));
            dt.Columns.Add("fileLastAccessTime", typeof(DateTime));
            foreach (File_class fc in File_class)
            {
                dt.Rows.Add(
                    fc.fileName,
                    fc.fileType,
                    fc.filePath,
                    fc.fileSize,
                    fc.handlefileSize,
                    fc.fileCreateDate,
                    fc.fileLastWriteTime,
                    fc.fileLastWriteTime);
            }
            return dt;
        }

    }
}


