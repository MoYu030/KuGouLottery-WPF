using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace 抽奖程序
{
    /// <summary>
    /// ModifyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ModifyWindow : Window
    {
        List<GiftModel> gm=new List<GiftModel>();
        public ModifyWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            try
            {
                xt.Text = GetInfo();
            }
            catch
            {
                MessageBox.Show("获取数据失败");
            }
        }
        //获得规则说明
        private string GetInfo()
        {
            //默认字符串
            string str = "1.每赠送1个“黄金铲”礼物，可获得1个水晶。点击“购买”按钮消耗对应的水晶并开启神秘礼包。\n\n" +
                "2.赠送或收到“黄金铲”礼物不增加明星经验值、财富经验值、星光挑战值、pk票数、小时榜、贡献榜、明星榜等榜单，不可抢头条。\n\n" +
                "3.购买礼包获得的礼物将发放到礼物仓库。\n\n" +
                "4.神秘礼包专属礼物概率：\n";               
            //普通礼包
            str += "1)普通礼包\n";
            string fp = "LuckDrawOrdinaryGiftData.json";
            gm = JsonConvert.DeserializeObject<List<GiftModel>>(File.ReadAllText(fp));
            foreach (var pt in gm)
            {
                if (pt.Count > 1)
                    pt.Name = $"{pt.Name}({pt.Count}个)";
                str += $"{pt.Name}：{pt.EndPoint - pt.StartPoint}%\n";
            }
                str += "\n";
            //高级礼包
            str += "2)高级礼包\n";
            string fp1 = "LuckDrawSeniorGiftData.json";
            gm = JsonConvert.DeserializeObject<List<GiftModel>>(File.ReadAllText(fp1));
            foreach (var gj in gm)
            {
                if (gj.Count > 1)
                    gj.Name = $"{gj.Name}({gj.Count}个)";
                str += $"{gj.Name}：{gj.EndPoint - gj.StartPoint}%\n";
            }
            str += "\n";
            //至尊礼包
            str += "3)至尊礼包\n";
            string fp2 = "LuckDrawSupremeGiftData.json";
            gm = JsonConvert.DeserializeObject<List<GiftModel>>(File.ReadAllText(fp2));
            foreach (var zz in gm)
            {
                if (zz.Count > 1)
                    zz.Name = $"{zz.Name}({zz.Count}个)";
                str += $"{zz.Name}：{zz.EndPoint - zz.StartPoint}%\n";
            }
            str += "\n";
            //默认结尾字符串
            str += "还有更多神秘礼物组合，等你探索！\n\n" +
                "5.通过官方活动和渠道获取的一切礼物道具等，禁止线下交易、收购等不正当行为，酷狗直播将对各类以盈利为目的的交易行为进行严厉打击。\n\n" +
                "6.3月12日早上11点起，从神秘礼包获得的所有礼物有效期为30天，30天后未赠送将会失效。\n\n";
            return str;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw=new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        #region 置顶功能
        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }
        #endregion
    }
}
