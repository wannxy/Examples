using NDevHelper_V1.CustomType;
using NDevHelper_V1.Handler;
using NDevHelper_V1.Handlers.Common;
using NDevHelper_V1.Log;
using NDevHelper_V1.Media.Audio;
using NDevHelper_V1.Net.Client;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            XLog.LogInfoCallBack = LogIRefresh;
            XLog.LogErrCallBack = LogERefresh;
        }

        OpenApiClient apiClient = new OpenApiClient("303098cc6c1bbb6edf5e9ea118b6e0bc", "d07e28bcf6af618fcd2d080273a1863e", "18609205178");

        #region 盘口数据
        /// <summary>
        /// 刷新盘口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_PKSX_Click(object sender, EventArgs e)
        {
            DeptHandler handler = new DeptHandler(Convert.ToInt32(tb_PK_Delay.Text.Trim()))
            {
                apiClient = apiClient,
                callback = StripRefresh
            };
            HandlerManager.GetManager().AddHandler(handler, 1);
        }
        /// <summary>
        /// 停止刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TZSX_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().StopAll();
            HandlerManager.GetManager().RemoveAll();
        }
        #endregion

        #region 代理
        private void LogIRefresh(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(LogIRefresh);
                Invoke(callback, msg);
            }
            else
            {
                Log_I.AppendText(msg);
            }
        }

        private void LogERefresh(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callback = new Action<string>(LogERefresh);
                Invoke(callback, msg);
            }
            else
            {
                Log_E.AppendText(msg);
            }
        }

        private void StripRefresh(CallBackMessage message)
        {
            if (InvokeRequired)
            {
                Action<CallBackMessage> callback = new Action<CallBackMessage>(StripRefresh);
                Invoke(callback, message);
            }
            else
            {
                if ((long)message.Extend > 200)
                {
                    toolStripStatusLabel.ForeColor = Color.Red;
                }
                else
                {
                    toolStripStatusLabel.ForeColor = Color.Green;
                }
                toolStripStatusLabel.Text = message.Data.ToString();

            }
        }

        #endregion

        #region 区间检测
        /// <summary>
        /// 开始检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KSJC_Click(object sender, EventArgs e)
        {
            RangeCheckHandler handler = new RangeCheckHandler(Convert.ToInt32(tb_QJJC_Delay.Text.Trim()))
            {
                TopV = Convert.ToDecimal(tb_QJJC_Max.Text.Trim()),
                LowerV = Convert.ToDecimal(tb_QJJC_Min.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            HandlerManager.GetManager().AddHandler(handler, 2);
        }
        /// <summary>
        /// 停止检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TZJC_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().RemoveHandler(2);
            AudioManager.GetAudioManager().Stop();
        }
        /// <summary>
        /// 暂停音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ZTYY_Click(object sender, EventArgs e)
        {
            AudioManager.GetAudioManager().Stop();
        }
        #endregion

        #region 区间内补单-手动
        /// <summary>
        /// 区间内卖补
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_INNERSB_Click(object sender, EventArgs e)
        {
            PatchInRangeHandler handler = new PatchInRangeHandler(0)
            {
                Side = "SELL",
                IsAuto = false,
                RepairStepMax = Convert.ToDecimal(tb_QJNBD_Smax.Text.Trim()),
                RepairStepMin = Convert.ToDecimal(tb_QJNBD_Smin.Text.Trim()),
                RepairVolumeMin = Convert.ToDecimal(tb_QJNBD_Vmin.Text.Trim()),
                RepairVolumeMax = Convert.ToDecimal(tb_QJNBD_Vmax.Text.Trim()),
                DestPrice = Convert.ToDecimal(tb_QJNBD_EP.Text.Trim()),
                VolumeLimit = Convert.ToDecimal(tb_QJNBD_Limit.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            handler.Start();
            label1.Focus();
        }
        /// <summary>
        /// 区间内买补
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_INNERBB_Click(object sender, EventArgs e)
        {
            PatchInRangeHandler handler = new PatchInRangeHandler(0)
            {
                Side = "BUY",
                IsAuto = false,
                RepairStepMax = Convert.ToDecimal(tb_QJNBD_Smax.Text.Trim()),
                RepairStepMin = Convert.ToDecimal(tb_QJNBD_Smin.Text.Trim()),
                RepairVolumeMin = Convert.ToDecimal(tb_QJNBD_Vmin.Text.Trim()),
                RepairVolumeMax = Convert.ToDecimal(tb_QJNBD_Vmax.Text.Trim()),
                DestPrice = Convert.ToDecimal(tb_QJNBD_EP.Text.Trim()),
                VolumeLimit = Convert.ToDecimal(tb_QJNBD_Limit.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            handler.Start();
            label1.Focus();
        }
        #endregion

        #region 区间内补单-自动
        /// <summary>
        /// 自动区间内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_QJNBD_KS_Click(object sender, EventArgs e)
        {
            PatchInRangeHandler handler = new PatchInRangeHandler(Convert.ToInt32(tb_QJNBD_Delay.Text.Trim()))
            {
                Side = "",
                IsAuto = true,
                RepairStepMax = Convert.ToDecimal(tb_QJNBD_Smax.Text.Trim()),
                RepairStepMin = Convert.ToDecimal(tb_QJNBD_Smin.Text.Trim()),
                RepairVolumeMin = Convert.ToDecimal(tb_QJNBD_Vmin.Text.Trim()),
                RepairVolumeMax = Convert.ToDecimal(tb_QJNBD_Vmax.Text.Trim()),
                Size = Convert.ToDecimal(tb_QJNBD_Size.Text.Trim()),
                VolumeLimit = Convert.ToDecimal(tb_QJNBD_Limit.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            HandlerManager.GetManager().AddHandler(handler, 3);
            tb_QJNBD_KS.Enabled = false;
            tb_QJNBD_TZ.Enabled = true;
            label1.Focus();
        }
        /// <summary>
        /// 停止区间内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_QJNBD_TZ_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().RemoveHandler(3);
            tb_QJNBD_KS.Enabled = true;
            tb_QJNBD_TZ.Enabled = false;
            label1.Focus();
        }
        #endregion

        #region 区间外补单-手动
        /// <summary>
        /// 卖补
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OUTERSB_Click(object sender, EventArgs e)
        {
            PatchOutRangeHandler handler = new PatchOutRangeHandler(0)
            {
                Side = "SELL",
                IsAuto = false,
                RepairStepMax = Convert.ToDecimal(tb_QJWBD_Smax.Text.Trim()),
                RepairStepMin = Convert.ToDecimal(tb_QJWBD_Smin.Text.Trim()),
                RepairVolumeMin = Convert.ToDecimal(tb_QJWBD_Vmin.Text.Trim()),
                RepairVolumeMax = Convert.ToDecimal(tb_QJWBD_Vmax.Text.Trim()),
                ED = Convert.ToInt32(tb_QJWBD_ED.Text.Trim()),
                VolumeLimit = Convert.ToInt32(tb_QJNBD_Limit.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            handler.Start();
            label1.Focus();
        }
        /// <summary>
        /// 买补
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OUTERBB_Click(object sender, EventArgs e)
        {
            PatchOutRangeHandler handler = new PatchOutRangeHandler(0)
            {
                Side = "BUY",
                IsAuto = false,
                RepairStepMax = Convert.ToDecimal(tb_QJWBD_Smax.Text.Trim()),
                RepairStepMin = Convert.ToDecimal(tb_QJWBD_Smin.Text.Trim()),
                RepairVolumeMin = Convert.ToDecimal(tb_QJWBD_Vmin.Text.Trim()),
                RepairVolumeMax = Convert.ToDecimal(tb_QJWBD_Vmax.Text.Trim()),
                ED = Convert.ToInt32(tb_QJWBD_ED.Text.Trim()),
                VolumeLimit = Convert.ToInt32(tb_QJNBD_Limit.Text.Trim()),
                apiClient = apiClient,
                where = HandlerWhere.LDAPI
            };
            handler.Start();
            label1.Focus();
        }
        #endregion
    }
}
