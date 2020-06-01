using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RKWpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer = new Timer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

            timer.Start();
            timer.Interval = 5 * 1000;
            renkuan();
            timer.Elapsed += new System.Timers.ElapsedEventHandler((o,eea)=> {
                renkuan();
            });
            timer.AutoReset = true;
            this.btnStart.IsEnabled = false;
            this.btnStop.IsEnabled = true;
        }

        public static string constr = "Data Source=10.0.2.21;database=VOCEN2013;User ID=sa;Password=VOCENqwe369";



        #region 定时器执行的方法
        private void renkuan()
        {
            IEnumerable<YJUI.Model.RubMao> list = GetRubMaos();//
            foreach (var item in list)
            {
                YJUI.Model.RubMao model = new YJUI.Model.RubMao();
                model.Tlaji = item.Tlaji;
                model.ReceiveDate = item.ReceiveDate;
                //

            }

        } 
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<YJUI.Model.RubMao> GetRubMaos()
        {
            string sql = "select * from rub_mao where flag=0";
            using (SqlConnection conn = new SqlConnection(constr))
            {
               return conn.Query<YJUI.Model.RubMao>(sql);
            }
        }


        #region 服务暂停

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            this.btnStop.IsEnabled = false;
            this.btnStart.IsEnabled = true;
        } 
        #endregion
    }
}
