using MemberTree.Tree;
using NDevHelper_V1.Log;
using NDevHelper_V1.Net;
using NDevHelper_V1.Net.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberTree
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            XLog.LogInfoCallBack = LogI;
        }
        Founder founder;
        private void btn_query_Click(object sender, EventArgs e)
        {
            ClientManager.GetManager().AddClient(new Back2Client(tb_jsessionid.Text.Trim(), "Back2"), "Back2");
            Task.Factory.StartNew(() =>
            {
                founder = new Founder(MemberCache.Init());
                founder.Found();
 
            });
        }


        #region 代理
        private void LogI(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(LogI);
                Invoke(callback, msg);
            }
            else
            {
                tb_logI.AppendText(msg);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            founder.FindPhones(tb_phones.Text.Trim());
        }
    }
}
