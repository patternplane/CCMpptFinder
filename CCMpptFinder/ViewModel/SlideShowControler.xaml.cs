using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CCMpptFinder
{
    /// <summary>
    /// SlideshowControler.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SlideShowControler : Window
    {
        public SlideShowControler()
        {
            InitializeComponent();


            TestList.Items.Add(new slideObject() { number = "number", source = "C:\\Users\\Sun\\Desktop\\프레젠테이션1\\슬라이드1.jpg" }) ;
            TestList.Items.Add(new slideObject() { number = "Apricot2", source = "C:\\Users\\Sun\\Desktop\\프레젠테이션1\\제목 없음.png" });
            TestList.Items.Add(new slideObject() { number = "Apricot3", source = "C:\\Users\\Sun\\Desktop\\프레젠테이션1\\제목 없음.png" });
            TestList.Items.Add(new slideObject() { number = "Apricot4", source = "C:\\Users\\Sun\\Desktop\\프레젠테이션1\\슬라이드1.jpg" });
        }
    }

    class slideObject
    {
        public String number { set; get; }
        public String source { set; get; }
    }
}
