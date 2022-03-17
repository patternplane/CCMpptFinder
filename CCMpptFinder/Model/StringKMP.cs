using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMpptFinder
{
    class StringKMP
    {
        /// <summary>
        /// 전처리 테이블
        /// </summary>
        static private int[] patternTable = new int[512];

        /// <summary>
        /// 문자 비교함수의 명세
        /// 같으면 true, 다르면 false일 것
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public delegate bool StringCompare(char a, char b);

        /// <summary>
        /// KMP - 전처리 테이블 제작 함수
        /// </summary>
        /// <param name="sample"></param>
        /// <param name="compareFunc"></param>
        /// <returns></returns>
        static private int MakeTable(string sample, StringCompare compareFunc)
        {
            if (sample.Length > 512)
                return -1;

            int len = sample.Length;
            int setter = 0;
            int checker = 0;
            patternTable[setter++] = checker;

            while (setter < len)
            {
                if (compareFunc(sample[setter] , sample[checker]))
                    patternTable[setter++] = ++checker;
                else
                {
                    if (checker == 0)
                        setter++;
                    else
                        checker = patternTable[checker];
                }
            }

            return 0;
        }



        /// <summary>
        /// KMP 검색
        /// (origin에서 sample을 하나라도 발견하면 바로 종료)
        /// </summary>
        /// <param name="origin">
        /// 원본 문자열
        /// </param>
        /// <param name="sample">
        /// 찾을 문자열
        /// </param>
        /// <param name="compareFunc">
        /// 비교함수
        /// </param>
        /// <returns>
        /// 발견시 1, 찾을 수 없을시 0, 오류시 -1을 반환
        /// </returns>
        static public int FindPattern_simple(string origin, string sample, StringCompare compareFunc)
        {
            if (MakeTable(sample, compareFunc) == -1)
                return -1;

            int o_len = origin.Length;
            int s_len = sample.Length;
            int o_i = 0;
            int s_i = 0;

            while (o_i < o_len)
            {
                if (compareFunc(origin[o_i] , sample[s_i]))
                {
                    o_i++;
                    s_i++;

                    if (s_i == s_len)
                    {
                        /* 만약 다 찾고자 한다면 다음의 코드를 입력 :
                         *      [출력] 현재항목의 인덱스 범위 : (o_i - s_i) ~ (o_i - 1);
                         *      s_i = patternTable[s_i - 1];
                        */
                        return 1;
                    }
                }
                else
                {
                    if (s_i == 0)
                        o_i++;
                    else
                        s_i = patternTable[s_i];
                }
            }
            return 0;
        }
        
    }
}
