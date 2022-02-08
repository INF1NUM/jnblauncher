using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jnblauncher
{
    class Map
    {
        public Map(string _fullPath)
        {
            FullPath = _fullPath;
        }
        public string FullPath { get; set; }
        public string FileName { get { return System.IO.Path.GetFileNameWithoutExtension(FullPath); } }
        public string FileNameEx { get { return System.IO.Path.GetFileName(FullPath); } }
    }
}
