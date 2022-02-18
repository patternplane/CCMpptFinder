using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ppt
using Microsoft.Office;
using Microsoft.Office.Interop.PowerPoint;

namespace CCMpptFinder
{
    class Powerpoint
    {
        Application app;
        Presentation ppt;

        public void test()
        {
            app = new Application();

            app.SlideSelectionChanged += event_handle;

            ppt = app.Presentations.Add(Microsoft.Office.Core.MsoTriState.msoCTrue);
            int n = 0;
            while (n++ < 5)
            {
                ppt.Slides.AddSlide(1, ppt.SlideMaster.CustomLayouts[1]).Shapes[1].TextFrame.TextRange.Text = n.ToString();
            }

            // 슬라이드쇼 썸네일을 생성할 방식
            // 파일 처리에 관한 예외가 많이 발생하므로 주의할 것
            ppt.Slides[1].Export("C:\\test.jpg","jpg");
            
        }



        void event_handle(SlideRange SldRange)
        {
            Console.WriteLine("선택 변경 감지");
        }
    }
}
 