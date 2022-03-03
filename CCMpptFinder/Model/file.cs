using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// file 처리를 위해 추가 (Directory Class)
using System.IO;

namespace CCMpptFinder
{
    class File
    {
        static public String[] getPptFiles(String path) 
        {
            try
            {
                String[] files = Directory.GetFiles(path,"*.ppt?");
                return files;
            }
            catch 
            {
                return null;
            }

        }
    }
}
