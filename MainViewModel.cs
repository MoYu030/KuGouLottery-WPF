using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace 抽奖程序
{
    public class MainViewModel:ViewModelBase
    {
        #region 定义
        //水晶数
        private int _diamondNum;

        public int DiamondNum
        {
            get { return _diamondNum; }
            set { _diamondNum = value;OnPropertyChanged(); }
        }
        //提示内容
        private string _numTips;

        public string NumTips
        {
            get { return _numTips; }
            set { _numTips = value;OnPropertyChanged(); }
        }
        //提示隐藏与否
        private string _tipsVisibility;

        public string TipsVisibility
        {
            get { return _tipsVisibility; }
            set { _tipsVisibility = value; OnPropertyChanged(); }
        }
        //抽奖窗体隐藏与否
        private string _resultVisibility;

        public string ResultVisibility
        {
            get { return _resultVisibility; }
            set { _resultVisibility = value; OnPropertyChanged(); }
        }
        //铲子数
        private string _shovelNums;

        public string ShovelNums
        {
            get { return _shovelNums; }
            set { _shovelNums = value; OnPropertyChanged(); }
        }
        //增加量 x
        private string _increaseStr1;

        public string IncreaseStr1
        {
            get { return _increaseStr1; }
            set { _increaseStr1 = value; OnPropertyChanged(); }
        }
        //增加量 +
        private string _increaseStr2;

        public string IncreaseStr2
        {
            get { return _increaseStr2; }
            set { _increaseStr2 = value; OnPropertyChanged(); }
        }
        #endregion
        ValueInfo vi =new ValueInfo();
        string vi_fp = "LuckDrawValueInfo.json";
        #region 获取水晶数
        public void GetDiamondNum()
        {
            if (File.Exists(vi_fp))
            {
                vi = JsonConvert.DeserializeObject<ValueInfo>(File.ReadAllText(vi_fp));
            }
            else
            {
                vi.DiamondNum = 999;
                File.WriteAllText(vi_fp, JsonConvert.SerializeObject(vi));
            }
            DiamondNum= vi.DiamondNum;
            TipsVisibility = "Collapsed";
            ResultVisibility = "Collapsed";
        }
        #endregion

        #region 增加水晶数
        ValueInfo increase = new ValueInfo();
        public void IncreaseDiamond(int num)
        {
            try
            {
                string fp = "LuckDrawValueInfo.json";
                increase = JsonConvert.DeserializeObject<ValueInfo>(File.ReadAllText(fp));
                increase.DiamondNum = num + increase.DiamondNum;
                File.Delete(fp);
                //写入
                File.WriteAllText(fp, JsonConvert.SerializeObject(increase));
                increase = JsonConvert.DeserializeObject<ValueInfo>(File.ReadAllText(fp));
                DiamondNum = increase.DiamondNum;
            }
            catch
            {
                MessageBox.Show("未找到文件");
            }
        }
        #endregion

        #region 购买功能
        public bool BtnClick(int num)
        {
            vi = JsonConvert.DeserializeObject<ValueInfo>(File.ReadAllText(vi_fp));
            DiamondNum = vi.DiamondNum;
            bool isSuccess = true;
            if (vi.DiamondNum < num)
            {
                NumTips = $"还差{num - vi.DiamondNum}个水晶，赠送{num - vi.DiamondNum}个黄金铲可获得";
                TipsVisibility = "Visible";
                IHelper.Delay(700);
                TipsVisibility = "Collapsed";
                isSuccess= false;
            }
            else
            {
                vi.DiamondNum = vi.DiamondNum - num;
                ResultVisibility = "Visible";
            }
            DiamondNum = vi.DiamondNum;
            File.Delete(vi_fp);
            File.WriteAllText(vi_fp, JsonConvert.SerializeObject(vi));
            return isSuccess;
        }
        #endregion

        #region 抽奖
        ValueInfo valueInfo = new ValueInfo();
        List<GiftModel> get = new List<GiftModel>();
        public List<ResultModel> LuckyDraw(string FileName)
        {
            try
            {
                #region unimpossible
                List<ResultModel> getResult = new List<ResultModel>();
                //保底
                string vi_fp = "LuckDrawValueInfo.json";
                valueInfo = JsonConvert.DeserializeObject<ValueInfo>(File.ReadAllText(vi_fp));
                List<MinGuarantee> mg = new List<MinGuarantee>();
                string mg_fp = "LuckDrawMinGuarantee.json";
                mg = JsonConvert.DeserializeObject<List<MinGuarantee>>(File.ReadAllText(mg_fp));
                //抽奖
                List<GiftModel> list = new List<GiftModel>();
                string fp = $"LuckDraw{FileName}GiftData.json";
                list = JsonConvert.DeserializeObject<List<GiftModel>>(File.ReadAllText(fp));
                #endregion
                Random rand = new Random();
                int randnum = rand.Next(0,100);
                int i_value = 2;
                if (randnum < 40)
                    i_value = 3;
                //出保底后
                if (valueInfo.Count == 0)
                {
                    if (valueInfo.Count != -1)
                    {
                        i_value--;
                        var query = mg.Where(t => t.GiftType == FileName).ToList();
                        MinGuarantee minGuarantee = new MinGuarantee();
                        if (query.Count == 1)
                            minGuarantee = mg.Where(t => t.GiftType == FileName).ToList()[0];
                        else
                        {
                            Random r_mg = new Random();
                            minGuarantee = mg.Where(t => t.GiftType == FileName).ToList()[r_mg.Next(0, query.Count())];
                        }
                        var data = list.Single(t => t.Count == minGuarantee.GuaranteeGiftNum && t.Name == minGuarantee.GuaranteeGiftName);
                        get.Add(new GiftModel() { Name = data.Name, StartPoint = data.StartPoint, EndPoint = data.EndPoint, Count = data.Count });
                        // MessageBox.Show("有保底哦");
                        valueInfo.Count = -1;
                    }
                }
                for (int i = 0; i < i_value; i++)
                {
                //生成随机数
                Rand:
                    Random r = new Random();
                    Random ran_float = new Random();
                    int ints = r.Next(0, 100);
                    double floats = ran_float.NextDouble();
                    decimal value = Convert.ToDecimal((ints + floats).ToString("F2"));
                    Thread.Sleep(50);
                    //如果随机生成数为0重新生成一个随机数
                    if (value == 0)
                        goto Rand;
                    //读取抽到的礼物信息
                    var data = list.Single(t => t.StartPoint < value && t.EndPoint >= value);
                    //如果抽取的礼物中已有相同的则重新抽一次来代替
                    if(get.Count(t=>t.Name== data.Name)>0)
                        goto Rand;
                    //判断是否抽到相同的礼物，并对其累加
                    get.Add(new GiftModel() { Name = data.Name, StartPoint = data.StartPoint, EndPoint = data.EndPoint, Count = data.Count });
                }
                //保底次数减一
                if (valueInfo.Count != -1)
                    valueInfo.Count--;
                //保底数据保存本地
                SaveGuarantee(valueInfo);

                foreach (var item in get)
                {
                    getResult.Add(new ResultModel() { ImgName = GetGitOrPng(item.Name), Name = $"{item.Name}x{item.Count}" });
                }
                get.Clear();
                return getResult;
            }
            catch
            {
                return null;
            }
                
        }
        private string GetGitOrPng(string str)
        {
            List<string> result = new List<string>() { "真爱钻戒","吃瓜","璀璨烟花","凤冠霞帔","好声音","黄金骑士","烈鹰指环","胜利权杖","王者之冠"};
            if(result.Count(t=>t==str)>0)
            {
                str= $@"Resources\{str}.gif";
            }
            else
            {
                str= $@"Resources\{str}.png";
            }
            return str;
        }

        private void SaveGuarantee(ValueInfo data)
        {
            string vi_fp = "LuckDrawValueInfo.json";
            if (!File.Exists(vi_fp))  // 判断是否已有相同文件 
            {
                FileStream fs1 = new FileStream(vi_fp, FileMode.Create, FileAccess.ReadWrite);
                fs1.Close();
            }
            else
                File.Delete(vi_fp);
            File.WriteAllText(vi_fp, JsonConvert.SerializeObject(data));
        }
        #endregion
    }
}
