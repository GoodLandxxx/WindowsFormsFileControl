using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFileControl
{
    class File_class
    {
        public string fileName { get; set; }
        public string fileType { get; set; }
        public string fileSize { get; set; }
        public string filePath { get; set; }
        public DateTime fileCreateDate { get; set; }//创建时间
        public DateTime fileLastWriteTime { get; set; }//获取或设置上次访问当前文件或目录的时间。
        public DateTime fileLastAccessTime { get; set; }/////     获取或设置上次写入当前文件或目录的时间。

    }
}
