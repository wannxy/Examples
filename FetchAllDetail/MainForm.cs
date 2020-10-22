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
            con = new MySqlConnection(connstr);
            con.Open();
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Fetch(tb_phone.Text.Trim(), tb_jsession.Text.Trim());
            });
            btn_fetch.Enabled = false;
        }

        private void Fetch(string phone, string session)
        {
            Back2Client back2 = new Back2Client(session, "back2");
            __MemberAccountDetail__.Result result;
            result = back2.MemberAccountDetail(account: phone, beginDate: "2020-07-01", endDate: "2020-07-15");
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
                Log(string.Format("{0}/{1}", i, pages));
                result = back2.MemberAccountDetail(i, 950, account: phone, beginDate: "2020-07-01", endDate: "2020-07-15");
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
                        SqlInsert(item);
                    }
                    catch (Exception ex)
                    {
                        XLog.E("", "{0}", ex.Message);
                    }
                }
            }
            ChangeBtnStatus();
            con.Close();
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
