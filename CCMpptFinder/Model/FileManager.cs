using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CCMpptFinder
{
    class FileManager
    {
        // 
        /// <summary>
        /// 특정 디렉토리의 ppt 프레젠테이션 파일 목록을 생성합니다.
        /// </summary>
        /// <param name="path">
        /// 파일 목록을 살펴볼 디렉토리
        /// </param>
        /// <returns>
        /// ppt 프레젠테이션 파일 이름 String 배열
        /// </returns>
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

        /// <summary>
        /// 프로그램이 실행되는 현재 위치를 가져옵니다.
        /// </summary>
        /// <returns>
        /// 프로그램의 현재 위치
        /// </returns>
        static public String getCurrentDir()
        {
            return Directory.GetCurrentDirectory();
        }

        /// <summary>
        /// 요청한 데이터파일이 해당 경로에 존재하는지 검사합니다.<br/>
        /// 만약 없으면 해당 파일을 만들어둡니다.
        /// </summary>
        /// <param name="paths">
        /// 검사할 데이터파일의 현재 프로그램으로부터의 상대 경로를 적습니다.
        /// </param>
        /// <returns>에러의 횟수를 반환합니다.</returns>
        static public int CheckDataFiles(String[] paths)
        {
            int error = 0;
            foreach(String path in paths)
            {
                try
                {
                    if (!Directory.Exists(getCurrentDir() + "\\" + Path.GetDirectoryName(path)))
                        Directory.CreateDirectory(getCurrentDir() + "\\" + Path.GetDirectoryName(path));
                    if (!File.Exists(getCurrentDir() + "\\" + path))
                        File.Create(getCurrentDir() + "\\" + path);
                }
                catch (Exception e)
                {
                    error++;
                    Console.WriteLine(e.Message);
                }
            }
            return error;
        }

        
    }
}
