using MySql.Data.MySqlClient;
using NDevHelper_V1.Log;
using NDevHelper_V1.Net.Back2Api;
using NDevHelper_V1.Net.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchAllDetail
{
    public partial class MainForm : Form
    {
        private static string connstr = "server=localhost;database=back2;userid=root;password=123456;CharSet=utf8;";
        private static MySqlConnection con = null;

        public MainForm()
        {
            InitializeComponent();
            //con = new MySqlConnection(connstr);
            //con.Open();
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                string all = tb_phone.Text.Trim();
                if ("".Equals(all))
                {
                    _Fetch("", tb_jsession.Text.Trim(), true);
                }
                else
                {
                    string[] ps = all.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                    if (ps != null)
                    {
                        for (int i = 0; i < ps.Length; i++)
                        {
                            LogP(string.Format("账号: {0}/{1}", i, ps.Length));
                            _Fetch(ps[i], tb_jsession.Text.Trim(), false);
                        }

                    }
                    ChangeBtnStatus();
                }

            });
            btn_fetch.Enabled = false;
        }


        private void _Fetch(string phone, string session, bool isDetail)
        {
            if (isDetail)
            {
                Fetch(phone, session);
            }
            else
            {
                Back2Client back2 = new Back2Client(session, "back2");
                __MemberAccountDetail__.Result result;
                result = back2.MemberAccountDetail(1, 10, account: phone);
                int count = -1;
                if (result == null)
                {
                    count = -1;
                }
                else
                {
                    count = result.count;
                }

                // 注册时间
                __Member__.Result result1 = back2.Member(account: phone);

                DateTime registerTime;
                string ip = "";
                if (result1 == null || result1.data == null || result1.data.Length == 0)
                {
                    registerTime = new DateTime(1970, 1, 1);
                    ip = "0:0:0:0";
                }
                else
                {
                    registerTime = result1.data[0].registerTime;
                    ip = result1.data[0].registerIp;
                }
                XLog.I("", "{0}-{1}-{2}-{3}", phone, count, registerTime.ToString("yyyy/MM/dd"), ip);
            }
        }

        private void Fetch(string phone, string session)
        {
            string begin = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string enddate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            if (cb_all.Checked)
            {
                begin = "";
                enddate = "";
            }
            Back2Client back2 = new Back2Client(session, "back2");
            __MemberAccountDetail__.Result result;
            result = back2.MemberAccountDetail(account: phone, beginDate: begin, endDate: enddate);
            if (result == null)
            {
                Log("查询失败！请重重启！");
                ChangeBtnStatus();
                return;
            }
            XLog.D("", "资产账号：{0} 挖矿账号：{1} 指数账号：{2} 收入：{3} 支出：{4}", 1, 3, 2, 1, 2);
            int count = result.count;
            int pages = count / 950 + 1;
            for (int i = 1; i <= pages; i++)
            {
                Log(string.Format("明细: {0}/{1}", i, pages));
                result = back2.MemberAccountDetail(i, 950, account: phone, beginDate: begin, endDate: enddate);
                if (result == null)
                {
                    Log("查询失败！请重重启！");
                    ChangeBtnStatus();
                    return;
                }
                foreach (var item in result.data)
                {
                    try
                    {
                        XLog.I("", "{0}", item);
                        //SqlInsert(item);
                    }
                    catch (Exception ex)
                    {
                        XLog.E("", "{0}", ex.Message);
                    }
                }
            }
            ChangeBtnStatus();
            //con.Close();
        }


        private static void SqlInsert(__MemberAccountDetail__.Result.cell cell)
        {
            var sql = string.Format("INSERT INTO `back2`.`accountdetail`(`id`, `phone`, `accountType`, `ieType`, `amount`, `coinType`, `mark`) " +
                "VALUES ({0}, '{1}', {2}, {3}, {4}, '{5}', '{6}')",
                 cell.id, cell.account, cell.accountType, cell.ieType, cell.amount, cell.coinType, cell.mark);

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        #region 代理
        private void Log(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(Log);
                Invoke(callback, msg);
            }
            else
            {
                lb_log.Text = msg;
            }
        }
        private void LogP(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(LogP);
                Invoke(callback, msg);
            }
            else
            {
                lb_progress.Text = msg;
            }
        }

        private void ChangeBtnStatus()
        {
            if (InvokeRequired)
            {
                Action action = new Action(ChangeBtnStatus);
                Invoke(action);
            }
            else
            {
                if (btn_fetch.Enabled)
                {
                    btn_fetch.Enabled = false;
                }
                else
                {
                    btn_fetch.Enabled = true;
                }
            }
        }
        #endregion


    }
}
