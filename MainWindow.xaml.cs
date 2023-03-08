using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Media.Animation;

namespace 抽奖程序
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = viewModel;
            viewModel.GetDiamondNum();
            viewModel.ShovelNums = "送出        x5 可获5个水晶      ";
            #region 改样式
            btn_num1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            btn_num1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ebebeb"));
            btn_num2.Foreground = btn_num3.Foreground = btn_num4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
            btn_num2.Background = btn_num3.Background = btn_num4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            #endregion
        }
        #region 基操
        private void BtnPop_Click(object sender, RoutedEventArgs e)
        {
            if (Pop.IsOpen==true)
                Pop.IsOpen = false;
            else
                Pop.IsOpen = true;
        }

        private void Pop_LostFocus(object sender, RoutedEventArgs e)
        {
            Pop.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ModifyWindow modifyWindow = new ModifyWindow();
            modifyWindow.Show();
            this.Hide();
        }
        #endregion

        #region 购买按钮点击事件
        // 至尊宝箱
        private void btn_zhizun_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.DiamondNum < 100)
                Fun_Animation();
            //Supreme
            if (viewModel.BtnClick(100))
            {
                var query = viewModel.LuckyDraw("Supreme");
                if (query != null)
                {
                    list_result.ItemsSource = query;
                    giftInfo.Visibility = Visibility.Visible;
                    rm.Reduction = 100;
                    rm.GiftType = "Supreme";
                }
                else
                    MessageBox.Show("获取数据失败");
            }
        }
        //高级宝箱
        private void btn_gaoji_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.DiamondNum < 10)
                Fun_Animation();
            //Senior
            if (viewModel.BtnClick(10))
            {
                var query = viewModel.LuckyDraw("Senior");
                if (query != null)
                {
                    list_result.ItemsSource = viewModel.LuckyDraw("Senior");
                    giftInfo.Visibility = Visibility.Visible;
                    rm.Reduction = 10;
                    rm.GiftType = "Senior";
                }
                else
                    MessageBox.Show("获取数据失败");

            }
        }
        // 普通宝箱
        private void btn_putong_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.DiamondNum < 5)
                Fun_Animation();
            //Ordinary
            if (viewModel.BtnClick(5))
            {
                var query = viewModel.LuckyDraw("Ordinary");
                if (query != null)
                {
                    list_result.ItemsSource = query;
                    giftInfo.Visibility = Visibility.Visible;
                    rm.Reduction = 5;
                    rm.GiftType = "Ordinary";
                }
                else
                    MessageBox.Show("获取数据失败");
            }
        }
        #endregion

        #region 弹窗提示
        private void GetGiftInfo()
        {
            giftInfo.Visibility = Visibility.Visible;
        }
        #endregion

        #region 窗体拖动
        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        #endregion
        //打开规则说明
        private void btn_explain_Click(object sender, RoutedEventArgs e)
        {
            ModifyWindow mw=new ModifyWindow();
            mw.Show();
            this.Hide();
            Pop.IsOpen = false;
        }

        #region PopNum 小铲铲数量变更
        int needCount=5;
        private void btn_num_Click(object sender, RoutedEventArgs e)
        {
                PopNum.IsOpen = true;
        }
 
        private void btn_num1_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ShovelNums = "送出        x5 可获5个水晶      ";
            Thickness margin = new Thickness(70, 19, 0, 19);
            img_shovel.Margin=margin;
            PopNum.IsOpen=false;
            needCount = 5;
            #region 改样式
            btn_num1.Foreground= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            btn_num1.Background= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ebebeb"));
            btn_num2.Foreground=btn_num3.Foreground=btn_num4.Foreground= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
            btn_num2.Background=btn_num3.Background=btn_num4.Background= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            #endregion
        }

        private void btn_num2_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ShovelNums = "送出        x10 可获10个水晶      ";
            Thickness margin = new Thickness(52, 19, 0, 19);
            img_shovel.Margin = margin;
            PopNum.IsOpen = false;
            needCount = 10;
            #region 改样式
            btn_num2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            btn_num2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ebebeb"));
            btn_num1.Foreground = btn_num3.Foreground = btn_num4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
            btn_num1.Background = btn_num3.Background = btn_num4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            #endregion
        }

        private void btn_num3_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ShovelNums = "送出        x100 可获100个水晶      ";
            Thickness margin = new Thickness(37, 19, 0, 19);
            img_shovel.Margin = margin;
            PopNum.IsOpen = false;
            needCount=100;
            #region 改样式
            btn_num3.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            btn_num3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ebebeb"));
            btn_num2.Foreground = btn_num1.Foreground = btn_num4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
            btn_num2.Background = btn_num1.Background = btn_num4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            #endregion
        }

        private void btn_num4_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ShovelNums = "送出        x500 可获500个水晶      ";
            Thickness margin = new Thickness(37, 19, 0, 19);
            img_shovel.Margin = margin;
            PopNum.IsOpen = false;
            needCount =500;
            #region 改样式
            btn_num4.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
            btn_num4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ebebeb"));
            btn_num2.Foreground = btn_num3.Foreground = btn_num1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999999"));
            btn_num2.Background = btn_num3.Background = btn_num1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            #endregion
        }
        #endregion

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            giftInfo.Visibility = Visibility.Hidden;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PopNum_LostFocus(object sender, RoutedEventArgs e)
        {
            Pop.IsOpen = false;
        }
        RecordModel rm=new RecordModel();
        private void btn_saleagain_Click(object sender, RoutedEventArgs e)
        {
            if (viewModel.DiamondNum > rm.Reduction)
            {
                giftInfo.Visibility = Visibility.Hidden;
                IHelper.Delay(300);
            }
            if (viewModel.BtnClick(rm.Reduction))
            {
                list_result.ItemsSource = viewModel.LuckyDraw(rm.GiftType);
                giftInfo.Visibility = Visibility.Visible;
            }        
        }
        #region 摇摆功能
        void Fun_Animation()
        {
            DoubleAnimation DAnimation = new DoubleAnimation();
            DAnimation.From = 16;//起点
            DAnimation.To = -16;//终点
            DAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.1));//时间

            Storyboard.SetTarget(DAnimation, GroupboxArea);
            Storyboard.SetTargetProperty(DAnimation, new PropertyPath(Canvas.LeftProperty));
            Storyboard story = new Storyboard();

            story.Completed += new EventHandler(story_Completed);//完成后要做的事
            story.Children.Add(DAnimation);
            story.Begin();
        }
        void story_Completed(object sender, EventArgs e)
        {
            DoubleAnimation DAnimation = new DoubleAnimation();
            DAnimation.From = -16;//起点
            DAnimation.To = 16;//终点
            DAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.1));//时间

            Storyboard.SetTarget(DAnimation, GroupboxArea);
            Storyboard.SetTargetProperty(DAnimation, new PropertyPath(Canvas.LeftProperty));
            Storyboard story = new Storyboard();

            story.Completed += new EventHandler(storyCompleted);//完成后要做的事
            story.Children.Add(DAnimation);
            story.Begin();
        }

        void storyCompleted(object sender, EventArgs e)
        {
            DoubleAnimation DAnimation = new DoubleAnimation();
            DAnimation.From = 16;//起点
            DAnimation.To = 0;//终点
            DAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.1));//时间

            Storyboard.SetTarget(DAnimation, GroupboxArea);
            Storyboard.SetTargetProperty(DAnimation, new PropertyPath(Canvas.LeftProperty));
            Storyboard story = new Storyboard();
            story.Children.Add(DAnimation);
            story.Begin();
        }
        #endregion

        #region 置顶功能
        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }
        #endregion

        //加水晶
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            viewModel.IncreaseStr1=$"×{needCount}";
            viewModel.IncreaseStr2 = $"{needCount}";
            tips_increase.Visibility = Visibility.Visible;
            IHelper.Delay(300);
            tips_increase.Visibility = Visibility.Collapsed;
            IHelper.Delay(180);
            grid_Area.Visibility = Visibility.Visible;
            AreaUp();
            IHelper.Delay(180);
            grid_Area.Visibility = Visibility.Hidden;
            viewModel.IncreaseDiamond(needCount);
        }
        //水晶数增加提示
        private void AreaUp()
        {
            DoubleAnimation DAnimation = new DoubleAnimation();
            DAnimation.From = 75;//起点
            DAnimation.To = 32;//终点
            DAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.08));//时间

            Storyboard.SetTarget(DAnimation, grid_Area);
            Storyboard.SetTargetProperty(DAnimation, new PropertyPath(Canvas.TopProperty));
            Storyboard story = new Storyboard();
            //story.RepeatBehavior = RepeatBehavior.Forever;//无限次循环，需要的自己加上
            story.Children.Add(DAnimation);
            story.Begin();
        }

    }
}
