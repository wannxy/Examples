using NDevHelper_V1.Log;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountCheck
{
    public partial class MainForm : Form
    {
        public static Action<string> ZombieCallback;
        public static Action<string> WoolCallback;

        public MainForm()
        {
            InitializeComponent();
            ZombieCallback = ZombieLog;
            WoolCallback = WoolLog;
            XLog.LogInfoCallBack = ZombieLog;
            XLog.LogErrCallBack = ZombieLog;
        }
        private void btn_fetch_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Check.InitMember();
            });
        }

        private void btn_zombie_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(()=>
            {
                Check.zombie();
            });
        }

        private void btn_wool_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(()=>
            {
                Check.wool();
            });
        }

        #region 代理
        public void ZombieLog(string log)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(ZombieLog);
                Invoke(callback, log);
            }
            else
            {
                tb_zombie_log.AppendText(log + "\r\n");
            }
        }
        public void WoolLog(string log)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(WoolLog);
                Invoke(callback, log);
            }
            else
            {
                tb_wool_log.AppendText(log + "\r\n");
            }
        }
        #endregion


    }
}
