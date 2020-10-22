using NDevHelper_V1.CustomType;
using NDevHelper_V1.Handler;
using NDevHelper_V1.Handlers.Common;
using NDevHelper_V1.Handlers.LD;
using NDevHelper_V1.Handlers.LD.Assist;
using NDevHelper_V1.Handlers.Mixing;
using NDevHelper_V1.Handlers.Mixing.Actions;
using NDevHelper_V1.Handlers.Mixing.Contions;
using NDevHelper_V1.Handlers.Wbf;
using NDevHelper_V1.Handlers.Wbf.Assist;
using NDevHelper_V1.Log;
using NDevHelper_V1.Media.Audio;
using NDevHelper_V1.Net;
using NDevHelper_V1.Net.Client;
using NDevHelper_V1.Net.OpenApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FormTemple
{
    public partial class MainForm : Form
    {
        ClientManager clientManager = ClientManager.GetManager();

        public MainForm()
        {
            AutoScaleMode = AutoScaleMode.Dpi;

            InitializeComponent();

            XLog.LogErrCallBack = Loge;
            XLog.LogInfoCallBack = Logi;
            clientManager.AddClient(new OpenApiClient("9d2d0b31094e86e53b633269996e6356", "cda39831ccd48008c1a99a4466be2069", "18537381088"), "Loex_18537381088");
            clientManager.AddClient(new OpenApiClient("303098cc6c1bbb6edf5e9ea118b6e0bc", "d07e28bcf6af618fcd2d080273a1863e", "18609205178"), "Loex_18609205178");
            clientManager.AddClient(new OpenApiClient("3842d1a303a2193489e44ef4d6f0fcec", "fe7f1a16ce9f70391d29297fbe03e451", "15592153762"), "Loex_15592153762");

            clientManager.AddClient(new WbfApiClient("ecd660748cee052db40dd2429f0b4207", "8ad9e1a49ef9bb0fc56fdc44b96a901a", "18537381088"), "Wbf_18537381088");
            clientManager.AddClient(new WbfApiClient("1498c794c7f35f1316aa8c2be14aeedb", "f33990fe27fcdefcf9d7c50fefdfd4c3", "18609205178"), "Wbf_18609205178");
            clientManager.AddClient(new WbfApiClient("d220bb3bb1e21315500752a71dad9574", "98e9d21d9b6a31b8c1cf4833a81e97a5", "15592153762"), "Wbf_15592153762");
        }


        #region 雷盾
        private void ld_ks_Click(object sender, EventArgs e)
        {

            LdDeptHandler handler = new LdDeptHandler(2000)
            {
                apiClient = clientManager.GetClient<OpenApiClient>("Loex_18537381088"),
                dataCallback = LDPK,
                callback = Ldinfo
            };
            handler.AddExtendAccount("3842d1a303a2193489e44ef4d6f0fcec", "fe7f1a16ce9f70391d29297fbe03e451", "15592153762");
            handler.AddExtendAccount("303098cc6c1bbb6edf5e9ea118b6e0bc", "d07e28bcf6af618fcd2d080273a1863e", "18609205178");
            handler.NeedNewOrder();
            HandlerManager.GetManager().AddHandler(handler, LdDeptHandler.WhatIs);
            ld_ks.Enabled = false;
            ld_tz.Enabled = true;
        }

        private void ld_tz_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().RemoveHandler(LdDeptHandler.WhatIs);
            ld_ks.Enabled = true;
            ld_tz.Enabled = false;
        }
        #endregion

        #region 瓦特
        private void wbf_ks_Click(object sender, EventArgs e)
        {

            WbfDeptHandler handler = new WbfDeptHandler(2000)
            {
                wbfClient = clientManager.GetClient<WbfApiClient>("Wbf_18537381088"),
                dataCallback = WBFPK,
                callback = Wbfinfo
            };
            handler.AddExtendAccount("1498c794c7f35f1316aa8c2be14aeedb", "f33990fe27fcdefcf9d7c50fefdfd4c3", "18609205178");
            handler.AddExtendAccount("d220bb3bb1e21315500752a71dad9574", "98e9d21d9b6a31b8c1cf4833a81e97a5", "15592153762");
            handler.NeedNewOrder();
            HandlerManager.GetManager().AddHandler(handler, WbfDeptHandler.WhatIs);
            wbf_ks.Enabled = false;
            wbf_tz.Enabled = true;
        }

        private void wbf_tz_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().RemoveHandler(WbfDeptHandler.WhatIs);
            wbf_ks.Enabled = true;
            wbf_tz.Enabled = false;
        }
        #endregion

        private decimal coefficient = 0.01M;
        #region 代理
        private Dictionary<int, decimal> LdBuyJdList = new Dictionary<int, decimal>(50);
        private Dictionary<int, decimal> LdSellJdList = new Dictionary<int, decimal>(50);
        /// <summary>
        /// 雷盾盘口
        /// </summary>
        /// <param name="depths"></param>
        private void LDPK(LdDepths depths)
        {
            if (InvokeRequired)
            {
                Action<LdDepths> callback = new Action<LdDepths>(LDPK);
                Invoke(callback, depths);
            }
            else
            {
                {// 在这里更新下瓦特区间控制的上下限
                    WbfRangeControlHandler controlHandler = HandlerManager.GetManager().GetHandler<WbfRangeControlHandler>(WbfRangeControlHandler.WhatIs);
                    if (controlHandler != null)
                    {
                        controlHandler.LimitBP = depths.GetB1().Price - 0.002M;
                        controlHandler.LimitSP = depths.GetS1().Price + 0.002M;
                    }
                }
                // 刷新雷盾买和自己的单子
                lv_ld_b.BeginUpdate();
                lv_ld_b.Clear();
                lv_ld_b_me.BeginUpdate();
                lv_ld_b_me.Clear();
                ListViewItem viewItem;
                decimal sum = 0;
                int e = 0;

                lv_ld_b.Columns.Add("1", 80, HorizontalAlignment.Left);
                lv_ld_b.Columns.Add("2", 80, HorizontalAlignment.Center);
                lv_ld_b.Columns.Add("3", -2, HorizontalAlignment.Right);
                lv_ld_b_me.Columns.Add("0", 0);
                lv_ld_b_me.Columns.Add("1", 80, HorizontalAlignment.Center);
                lv_ld_b_me.Columns.Add("2", 30, HorizontalAlignment.Center);

                if (depths.GetAllBuy().Count < 13)
                {
                    e = depths.GetAllBuy().Count;
                }
                else
                {
                    e = 13;
                }
                for (int i = 1; i <= e; i++)
                {
                    viewItem = new ListViewItem("" + depths.GetAllBuy()[i].Price);
                    viewItem.SubItems.Add("" + depths.GetAllBuy()[i].Volume);
                    viewItem.SubItems.Add("" + (sum += depths.GetAllBuy()[i].Volume));
                    lv_ld_b.Items.Add(viewItem);
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + Math.Round(depths.GetAllBuy()[i].MyVolume, 2));
                    viewItem.SubItems.Add("" + depths.GetAllBuy()[i].MyOrderCount);
                    lv_ld_b_me.Items.Add(viewItem);
                }
                lv_ld_b.EndUpdate();
                lv_ld_b_me.EndUpdate();

                // 刷新雷盾卖和自己的单子
                lv_ld_s.BeginUpdate();
                lv_ld_s.Clear();
                lv_ld_s_me.BeginUpdate();
                lv_ld_s_me.Clear();
                sum = 0;
                lv_ld_s.Columns.Add("1", 80, HorizontalAlignment.Left);
                lv_ld_s.Columns.Add("2", 80, HorizontalAlignment.Center);
                lv_ld_s.Columns.Add("3", -2, HorizontalAlignment.Right);
                lv_ld_s_me.Columns.Add("0", 0);
                lv_ld_s_me.Columns.Add("1", 80, HorizontalAlignment.Center);
                lv_ld_s_me.Columns.Add("2", 30, HorizontalAlignment.Center);
                ListViewItem[] items = new ListViewItem[13];
                ListViewItem[] meitems = new ListViewItem[13];
                if (depths.GetAllSell().Count < 13)
                {
                    e = depths.GetAllSell().Count;
                }
                else
                {
                    e = 13;
                }
                for (int i = 1; i <= e; i++)
                {
                    viewItem = new ListViewItem("" + depths.GetAllSell()[i].Price);
                    viewItem.SubItems.Add("" + depths.GetAllSell()[i].Volume);
                    viewItem.SubItems.Add("" + (sum += depths.GetAllSell()[i].Volume));
                    items[e - i] = viewItem;
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + Math.Round(depths.GetAllSell()[i].MyVolume, 2));
                    viewItem.SubItems.Add("" + depths.GetAllSell()[i].MyOrderCount);
                    meitems[e - i] = viewItem;
                }
                lv_ld_s.Items.AddRange(items);
                lv_ld_s.EndUpdate();
                lv_ld_s_me.Items.AddRange(meitems);
                lv_ld_s_me.EndUpdate();

                // 刷新雷盾买阶段
                LdBuyJdList.Clear();
                lv_ld_b_jd.BeginUpdate();
                lv_ld_b_jd.Clear();
                lv_ld_b_jd.Columns.Add("0", 0);
                lv_ld_b_jd.Columns.Add("1", 50, HorizontalAlignment.Center);
                lv_ld_b_jd.Columns.Add("2", 100, HorizontalAlignment.Center);
                int key = 0;
                foreach (DepthCell cell in depths.GetAllBuy().Values)
                {
                    key = (int)Math.Floor(cell.Price / coefficient);
                    if (!LdBuyJdList.ContainsKey(key))
                    {
                        LdBuyJdList.Add(key, cell.Volume - cell.MyVolume);
                    }
                    else
                    {
                        LdBuyJdList[key] += (cell.Volume - cell.MyVolume);
                    }
                }
                int[] keys = LdBuyJdList.Keys.ToArray();
                for (int k = 0; k < keys.Length; k++)
                {
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + keys[k] * coefficient);
                    viewItem.SubItems.Add("" + Math.Round(LdBuyJdList[keys[k]], 2));
                    lv_ld_b_jd.Items.Add(viewItem);
                }
                lv_ld_b_jd.EndUpdate();

                // 刷新雷盾卖阶段数据
                LdSellJdList.Clear();
                lv_ld_s_jd.BeginUpdate();
                lv_ld_s_jd.Clear();
                lv_ld_s_jd.Columns.Add("0", 0);
                lv_ld_s_jd.Columns.Add("1", 50, HorizontalAlignment.Center);
                lv_ld_s_jd.Columns.Add("2", 100, HorizontalAlignment.Center);
                key = 0;
                foreach (DepthCell cell in depths.GetAllSell().Values)
                {
                    key = (int)Math.Floor(cell.Price / coefficient);
                    if (!LdSellJdList.ContainsKey(key))
                    {
                        LdSellJdList.Add(key, cell.Volume - cell.MyVolume);
                    }
                    else
                    {
                        LdSellJdList[key] += (cell.Volume - cell.MyVolume);
                    }
                }
                keys = LdSellJdList.Keys.ToArray();
                for (int k = 12; k >= 0; k--)
                {
                    viewItem = new ListViewItem("");
                    if (k >= keys.Length)
                    {
                        viewItem.SubItems.Add("");
                        viewItem.SubItems.Add("");
                    }
                    else
                    {
                        viewItem.SubItems.Add("" + keys[k] * coefficient);
                        viewItem.SubItems.Add("" + Math.Round(LdSellJdList[keys[k]], 2));
                    }
                    lv_ld_s_jd.Items.Add(viewItem);
                }
                lv_ld_s_jd.EndUpdate();
            }
        }

        private Dictionary<int, decimal> WbfBuyJdList = new Dictionary<int, decimal>(50);
        private Dictionary<int, decimal> WbfSellJdList = new Dictionary<int, decimal>(50);
        /// <summary>
        /// 瓦特盘口
        /// </summary>
        /// <param name="depths"></param>
        private void WBFPK(WbfDepths depths)
        {
            if (InvokeRequired)
            {
                Action<WbfDepths> callback = new Action<WbfDepths>(WBFPK);
                Invoke(callback, depths);
            }
            else
            {
                // 刷新瓦特买和自己的单子
                lv_wbf_b.BeginUpdate();
                lv_wbf_b.Clear();
                lv_wbf_b_me.BeginUpdate();
                lv_wbf_b_me.Clear();
                ListViewItem viewItem;
                decimal sum = 0;
                int e = 0;

                lv_wbf_b.Columns.Add("1", 80, HorizontalAlignment.Left);
                lv_wbf_b.Columns.Add("2", 80, HorizontalAlignment.Center);
                lv_wbf_b.Columns.Add("3", -2, HorizontalAlignment.Right);
                lv_wbf_b_me.Columns.Add("0", 0);
                lv_wbf_b_me.Columns.Add("1", 80, HorizontalAlignment.Center);
                lv_wbf_b_me.Columns.Add("2", 30, HorizontalAlignment.Center);
                if (depths.GetAllBuy().Count < 13)
                {
                    e = depths.GetAllBuy().Count;
                }
                else
                {
                    e = 13;
                }

                for (int i = 1; i <= e; i++)
                {
                    viewItem = new ListViewItem("" + depths.GetAllBuy()[i].Price);
                    viewItem.SubItems.Add("" + depths.GetAllBuy()[i].Volume);
                    viewItem.SubItems.Add("" + (sum += depths.GetAllBuy()[i].Volume));
                    lv_wbf_b.Items.Add(viewItem);
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + Math.Round(depths.GetAllBuy()[i].MyVolume, 2));
                    viewItem.SubItems.Add("" + depths.GetAllBuy()[i].MyOrderCount);
                    lv_wbf_b_me.Items.Add(viewItem);
                }
                lv_wbf_b.EndUpdate();
                lv_wbf_b_me.EndUpdate();

                // 刷新瓦特卖和自己的单子
                lv_wbf_s.BeginUpdate();
                lv_wbf_s.Clear();
                lv_wbf_s_me.BeginUpdate();
                lv_wbf_s_me.Clear();
                sum = 0;
                lv_wbf_s.Columns.Add("1", 80, HorizontalAlignment.Left);
                lv_wbf_s.Columns.Add("2", 80, HorizontalAlignment.Center);
                lv_wbf_s.Columns.Add("3", -2, HorizontalAlignment.Right);
                lv_wbf_s_me.Columns.Add("0", 0);
                lv_wbf_s_me.Columns.Add("1", 80, HorizontalAlignment.Center);
                lv_wbf_s_me.Columns.Add("2", 30, HorizontalAlignment.Center);
                ListViewItem[] items = new ListViewItem[13];
                ListViewItem[] meitems = new ListViewItem[13];
                if (depths.GetAllSell().Count < 13)
                {
                    e = depths.GetAllBuy().Count;
                }
                else
                {
                    e = 13;
                }
                for (int i = 1; i <= e; i++)
                {
                    viewItem = new ListViewItem("" + depths.GetAllSell()[i].Price);
                    viewItem.SubItems.Add("" + depths.GetAllSell()[i].Volume);
                    viewItem.SubItems.Add("" + (sum += depths.GetAllSell()[i].Volume));
                    items[e - i] = viewItem;
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + Math.Round(depths.GetAllSell()[i].MyVolume, 2));
                    viewItem.SubItems.Add("" + depths.GetAllSell()[i].MyOrderCount);
                    meitems[e - i] = viewItem;
                }
                lv_wbf_s.Items.AddRange(items);
                lv_wbf_s.EndUpdate();
                lv_wbf_s_me.Items.AddRange(meitems);
                lv_wbf_s_me.EndUpdate();

                // 刷新瓦特买阶段
                WbfBuyJdList.Clear();
                lv_wbf_b_jd.BeginUpdate();
                lv_wbf_b_jd.Clear();
                lv_wbf_b_jd.Columns.Add("0", 0);
                lv_wbf_b_jd.Columns.Add("1", 50, HorizontalAlignment.Center);
                lv_wbf_b_jd.Columns.Add("2", 100, HorizontalAlignment.Center);
                int key = 0;
                foreach (DepthCell cell in depths.GetAllBuy().Values)
                {
                    key = (int)Math.Floor(cell.Price / coefficient);
                    if (!WbfBuyJdList.ContainsKey(key))
                    {
                        WbfBuyJdList.Add(key, cell.Volume - cell.MyVolume);
                    }
                    else
                    {
                        WbfBuyJdList[key] += (cell.Volume - cell.MyVolume);
                    }
                }
                int[] keys = WbfBuyJdList.Keys.ToArray();
                for (int k = 0; k < keys.Length; k++)
                {
                    viewItem = new ListViewItem("");
                    viewItem.SubItems.Add("" + keys[k] * coefficient);
                    viewItem.SubItems.Add("" + Math.Round(WbfBuyJdList[keys[k]], 2));
                    lv_wbf_b_jd.Items.Add(viewItem);
                }
                lv_wbf_b_jd.EndUpdate();

                // 刷新瓦特卖阶段数据
                WbfSellJdList.Clear();
                lv_wbf_s_jd.BeginUpdate();
                lv_wbf_s_jd.Clear();
                lv_wbf_s_jd.Columns.Add("0", 0);
                lv_wbf_s_jd.Columns.Add("1", 60, HorizontalAlignment.Center);
                lv_wbf_s_jd.Columns.Add("2", 100, HorizontalAlignment.Center);
                key = 0;
                foreach (DepthCell cell in depths.GetAllSell().Values)
                {
                    key = (int)Math.Floor(cell.Price / coefficient);
                    if (!WbfSellJdList.ContainsKey(key))
                    {
                        WbfSellJdList.Add(key, cell.Volume - cell.MyVolume);
                    }
                    else
                    {
                        WbfSellJdList[key] += (cell.Volume - cell.MyVolume);
                    }
                }
                keys = WbfSellJdList.Keys.ToArray();
                for (int k = 12; k >= 0; k--)
                {
                    viewItem = new ListViewItem("");
                    if (k >= keys.Length)
                    {
                        viewItem.SubItems.Add("");
                        viewItem.SubItems.Add("");
                    }
                    else
                    {
                        viewItem.SubItems.Add("" + keys[k] * coefficient);
                        viewItem.SubItems.Add("" + Math.Round(WbfSellJdList[keys[k]], 2));
                    }
                    lv_wbf_s_jd.Items.Add(viewItem);
                }
                lv_wbf_s_jd.EndUpdate();
            }
        }

        private void Ldinfo(CallBackMessage message)
        {
            if (InvokeRequired)
            {
                Action<CallBackMessage> callback = new Action<CallBackMessage>(Ldinfo);
                Invoke(callback, message);
            }
            else
            {
                ld_info.Text = "   LD " + message.Data.ToString();
            }
        }

        private void Wbfinfo(CallBackMessage message)
        {
            if (InvokeRequired)
            {
                Action<CallBackMessage> callback = new Action<CallBackMessage>(Wbfinfo);
                Invoke(callback, message);
            }
            else
            {
                Wbf_info.Text = "WBF " + message.Data.ToString();
            }
        }

        private void Logi(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callbakc = new Action<string>(Logi);
                Invoke(callbakc, msg);
            }
            else
            {
                Log_I.AppendText(msg);
            }
        }

        private void Loge(string msg)
        {
            if (InvokeRequired)
            {
                Action<string> callbakc = new Action<string>(Loge);
                Invoke(callbakc, msg);
            }
            else
            {
                Log_E.AppendText(msg);
            }
        }

        private void loggd(string msg)
        {
            tb_gd.AppendText("\r\n" + msg);
        }

        /// <summary>
        /// 雷盾辅助处理器撤单
        /// </summary>
        /// <param name="order"></param>
        private void LdCancelCallBack(Order order)
        {
            if (InvokeRequired)
            {
                Action<Order> callback = new Action<Order>(LdCancelCallBack);
                Invoke(callback, order);
            }
            else
            {
                CancelLd(order);
            }
        }
        /// <summary>
        /// 瓦特辅助处理器撤单
        /// </summary>
        /// <param name="order"></param>
        private void WfbCancelCallBack(Order order)
        {
            if (InvokeRequired)
            {
                Action<Order> callback = new Action<Order>(WfbCancelCallBack);
                Invoke(callback, order);
            }
            else
            {
                CancelWbf(order);
            }
        }
        #endregion

        #region 单击盘口
        // 雷盾卖
        private void lv_ld_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ld_s.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_ld_s.SelectedItems[0];
                UpdateData(item.SubItems[0].Text, item.SubItems[1].Text);
            }
            else
            {
                Debug.WriteLine("未选中");
            }
        }
        // 雷盾买
        private void lv_ld_b_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ld_b.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_ld_b.SelectedItems[0];
                UpdateData(item.SubItems[0].Text, item.SubItems[1].Text);
            }
            else
            {
                Debug.WriteLine("未选中");
            }
        }
        // 瓦特卖
        private void lv_wbf_s_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_wbf_s.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_wbf_s.SelectedItems[0];
                UpdateData(item.SubItems[0].Text, item.SubItems[1].Text);
            }
            else
            {
                Debug.WriteLine("未选中");
            }
        }
        // 瓦特买
        private void lv_wbf_b_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_wbf_b.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_wbf_b.SelectedItems[0];
                UpdateData(item.SubItems[0].Text, item.SubItems[1].Text);
            }
            else
            {
                Debug.WriteLine("未选中");
            }
        }
        #endregion

        #region 双击自己订单列表，撤单
        // 雷盾卖
        private void lv_ld_s_me_DoubleClick(object sender, EventArgs e)
        {
            if (lv_ld_s_me.SelectedItems.Count > 0)
            {
                int d = 13 - lv_ld_s_me.SelectedItems[0].Index;
                CancelLdDepth("SELL", d);
                Debug.WriteLine("当前深度: {0}", d);
            }
            else
            {
                Debug.WriteLine("未选中！");
            }
        }
        // 雷盾买
        private void lv_ld_b_me_DoubleClick(object sender, EventArgs e)
        {
            if (lv_ld_b_me.SelectedItems.Count > 0)
            {
                int d = lv_ld_b_me.SelectedItems[0].Index + 1;
                CancelLdDepth("BUY", d);
                Debug.WriteLine("当前深度: {0}", d);
            }
            else
            {
                Debug.WriteLine("未选中！");
            }
        }
        // 瓦特卖
        private void lv_wbf_s_me_DoubleClick(object sender, EventArgs e)
        {
            if (lv_wbf_s_me.SelectedItems.Count > 0)
            {
                int d = 13 - lv_wbf_s_me.SelectedItems[0].Index;
                CancelWbfDepth("SELL", d);
                Debug.WriteLine("当前深度: {0}", d);
            }
            else
            {
                Debug.WriteLine("未选中！");
            }
        }
        // 瓦特买
        private void lv_wbf_b_me_DoubleClick(object sender, EventArgs e)
        {
            if (lv_wbf_b_me.SelectedItems.Count > 0)
            {
                int d = lv_wbf_b_me.SelectedItems[0].Index + 1;
                CancelWbfDepth("BUY", d);
                Debug.WriteLine("当前深度: {0}", d);
            }
            else
            {
                Debug.WriteLine("未选中！");
            }
        }
        #endregion

        private void UpdateData(string price, string volume)
        {
            tb_ld_v.Text = volume;
            tb_wbf_v.Text = volume;
            nud_ld_p.Value = Convert.ToDecimal(price);
            nud_wbf_p.Value = Convert.ToDecimal(price);
        }

        /// <summary>
        /// 撤销雷盾某个深度的单子
        /// </summary>
        /// <param name="d"></param>
        private void CancelLdDepth(string side, int d)
        {
            LdDepths depths = LdDepthsManager.GetManager().GetCurrentDepths();
            if ("BUY".Equals(side))
            {
                DepthCell cell = depths.GetBuyDepth(d);
                foreach (Order item in cell.GetOrders())
                {
                    CancelLd(item);
                }
            }
            else if ("SELL".Equals(side))
            {
                DepthCell cell = depths.GetSellDepth(d);
                foreach (Order item in cell.GetOrders())
                {
                    CancelLd(item);
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// 辅助雷盾撤单
        /// </summary>
        /// <param name="order"></param>
        private void CancelLd(Order order)
        {
            __CancelOrder__.Result result = null;
            if ("18609205178".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<OpenApiClient>("Loex_18609205178").CancelOrder(order.OrderId);
            }
            else if ("15592153762".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<OpenApiClient>("Loex_15592153762").CancelOrder(order.OrderId);
            }
            else if ("18537381088".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<OpenApiClient>("Loex_18537381088").CancelOrder(order.OrderId);
            }
            loggd(string.Format("LD V: {0} - P: {1} - A: {2} - CODE: {3}", order.Price, order.Volume, order.Owner.apiname, result?.code));
            //XLog.I("", string.Format("雷盾撤单, {0} - {1} - {2}, {3}", order.Price, order.Volume, order.Owner.apiname, result?.ToString()));
        }

        /// <summary>
        /// 撤销瓦特某个深度的单子
        /// </summary>
        /// <param name="side"></param>
        /// <param name="d"></param>
        private void CancelWbfDepth(string side, int d)
        {
            WbfDepths depths = WbfDepthsManager.GetManager().GetCurrentDepths();
            if ("BUY".Equals(side))
            {
                DepthCell cell = depths.GetBuyDepth(d);
                foreach (Order item in cell.GetOrders())
                {
                    CancelWbf(item);
                }
            }
            else if ("SELL".Equals(side))
            {
                DepthCell cell = depths.GetSellDepth(d);
                foreach (Order item in cell.GetOrders())
                {
                    CancelWbf(item);
                }
            }
        }

        /// <summary>
        /// 辅助瓦特撤单
        /// </summary>
        /// <param name="order"></param>
        private void CancelWbf(Order order)
        {
            NDevHelper_V1.Net.WbfOpenApi.__CancelOrder__.Result result = null;
            if ("18609205178".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<WbfApiClient>("Wbf_18609205178").CancelOrder(order.OrderId + "");
            }
            else if ("15592153762".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<WbfApiClient>("Wbf_15592153762").CancelOrder(order.OrderId + "");
            }
            else if ("18537381088".Equals(order.Owner.apiname))
            {
                result = clientManager.GetClient<WbfApiClient>("Wbf_18537381088").CancelOrder(order.OrderId + "");
            }
            loggd(string.Format("Wbf P: {0} - V: {1} - A: {2} - CODE: {3}", order.Price, order.Volume, order.Owner.apiname, result?.code));
        }


        #region 雷盾挂单
        // 卖
        private void btn_ld_s_Click(object sender, EventArgs e)
        {
            NDevHelper_V1.Net.OpenApi.__CeateOrder__.Result result = null;
            result = clientManager.GetClient<OpenApiClient>("Loex_18537381088").CreateOrder("SELL", Convert.ToDecimal(tb_ld_v.Text.Trim()), nud_ld_p.Value);
            loggd(string.Format("LD SELL - V: {0} - P: {1} CODE: {2}", tb_ld_v.Text.Trim(), nud_ld_p.Value, result?.code));
        }
        // 买
        private void btn_ld_b_Click(object sender, EventArgs e)
        {
            NDevHelper_V1.Net.OpenApi.__CeateOrder__.Result result = null;
            result = clientManager.GetClient<OpenApiClient>("Loex_18537381088").CreateOrder("BUY", Convert.ToDecimal(tb_ld_v.Text.Trim()), nud_ld_p.Value);
            loggd(string.Format("LD BUY - V: {0} - P: {1} CODE: {2}", tb_ld_v.Text.Trim(), nud_ld_p.Value, result?.code));
        }
        #endregion

        #region 瓦特挂单
        // 买
        private void btn_wbf_b_Click(object sender, EventArgs e)
        {
            NDevHelper_V1.Net.WbfOpenApi.__CreateOrder__.Result result = null;
            result = clientManager.GetClient<WbfApiClient>("Wbf_18537381088").CreateOrder("BUY", Convert.ToDecimal(tb_wbf_v.Text.Trim()), nud_wbf_p.Value);
            loggd(string.Format("Wbf BUY - V: {0} - P: {1} CODE: {2}", tb_wbf_v.Text.Trim(), nud_wbf_p.Value, result?.code));
        }
        // 卖
        private void btn_wbf_s_Click(object sender, EventArgs e)
        {
            NDevHelper_V1.Net.WbfOpenApi.__CreateOrder__.Result result = null;
            result = clientManager.GetClient<WbfApiClient>("Wbf_18537381088").CreateOrder("SELL", Convert.ToDecimal(tb_wbf_v.Text.Trim()), nud_wbf_p.Value);
            loggd(string.Format("Wbf SELL - V: {0} - P: {1} CODE: {2}", tb_wbf_v.Text.Trim(), nud_wbf_p.Value, result?.code));
        }

        #endregion

        #region 无量绿线检查
        private void cb_klinec_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_klinec.Checked)
            {
                LdKlineCheckHandler handler = new LdKlineCheckHandler(3000)
                {
                    apiClient = clientManager.GetClient<OpenApiClient>("Loex_18537381088"),
                    state = KLineTick.KLineState.GLineNoneV,
                    Number = 1
                };
                HandlerManager.GetManager().AddHandler(handler, LdKlineCheckHandler.WhatIs);
            }
            else
            {
                HandlerManager.GetManager().RemoveHandler(LdKlineCheckHandler.WhatIs);
                AudioManager.GetAudioManager().Stop();
            }
        }

        private void cb_klinec_wbf_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_klinec_wbf.Checked)
            {
                WbfKlineCheckHandler handler = new WbfKlineCheckHandler(3000)
                {
                    apiClient = clientManager.GetClient<WbfApiClient>("Wbf_18537381088"),
                    state = KLineTick.KLineState.GLineNoneV,
                    Number = 1
                };
                HandlerManager.GetManager().AddHandler(handler, WbfKlineCheckHandler.WhatIs);
            }
            else
            {
                HandlerManager.GetManager().RemoveHandler(WbfKlineCheckHandler.WhatIs);
                AudioManager.GetAudioManager().Stop();
            }
        }

        #endregion

        #region 平台之间区间对齐
        /// <summary>
        /// 对齐开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dqks_Click(object sender, EventArgs e)
        {
            RangeAlignHandler handler = new RangeAlignHandler(Convert.ToInt32(tb_dqdelay.Text.Trim()))
            {
                TimeDeviation = Convert.ToInt32(tb_dqdev.Text.Trim()),
                TimeOut = Convert.ToInt32(tb_dqtimeout.Text.Trim())
            };
            HandlerManager.GetManager().AddHandler(handler, RangeAlignHandler.WhatIs);

            btn_dqks.Enabled = false;
            btn_dqtz.Enabled = true;
            cb_tj_ldbz.Enabled = true;
            cb_tj_ldbl.Enabled = true;
        }
        /// <summary>
        /// 对齐停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dqtz_Click(object sender, EventArgs e)
        {
            HandlerManager.GetManager().RemoveHandler(RangeAlignHandler.WhatIs);
            btn_dqks.Enabled = true;
            btn_dqtz.Enabled = false;
            cb_tj_ldbz.Checked = false;
            cb_tj_ldbz.Enabled = false;
            cb_dz_wtzp.Checked = false;
            cb_dz_wtzp.Enabled = false;
            cb_tj_ldbl.Checked = false;
            cb_tj_ldbl.Enabled = false;
            cb_dz_wtlp.Checked = false;
            cb_dz_wtlp.Enabled = false;
        }

        #region 条件
        /// <summary>
        /// 添加或删除 条件-雷盾被砸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_tj_ldbz_CheckedChanged(object sender, EventArgs e)
        {
            RangeAlignHandler handler = HandlerManager.GetManager().GetHandler<RangeAlignHandler>(RangeAlignHandler.WhatIs);
            if (handler == null)
            {
                cb_tj_ldbz.Checked = false;
                return;
            }
            if (cb_tj_ldbz.Checked)
            {
                WRefLSmashCondition wRefLSmash = new WRefLSmashCondition()
                {
                    Time = Convert.ToInt32(tb_ldbz_time.Text.Trim()),
                    Deviation = Convert.ToDecimal(tb_ldbz_dev.Text.Trim()),
                    openApi = clientManager.GetClient<OpenApiClient>("Loex_18537381088")
                };
                handler.AddCondition(WRefLSmashCondition.ConditionId, wRefLSmash);
                cb_dz_wtzp.Enabled = true;
            }
            else
            {
                cb_dz_wtzp.Checked = false;
                cb_dz_wtzp.Enabled = false;
                handler.RemoveCondition(WRefLSmashCondition.ConditionId);
            }
        }
        /// <summary>
        /// 添加或删除 动作-瓦特砸盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_dz_wtzp_CheckedChanged(object sender, EventArgs e)
        {
            RangeAlignHandler handler = HandlerManager.GetManager().GetHandler<RangeAlignHandler>(RangeAlignHandler.WhatIs);
            WRefLSmashCondition wRefLSmash = handler.GetCondition<WRefLSmashCondition>(WRefLSmashCondition.ConditionId);
            if (wRefLSmash == null)
            {
                cb_dz_wtzp.Checked = false;
                return;
            }
            if (cb_dz_wtzp.Checked)
            {
                wRefLSmash.AddAction(WbfSmashAction.ActionID, new WbfSmashAction()
                {
                    VolumeLimit = Convert.ToDecimal(tb_dz_wtzp_limit.Text.Trim()),
                    wbfApi = clientManager.GetClient<WbfApiClient>("Wbf_18537381088")
                });
            }
            else
            {
                wRefLSmash.RemoveAction(WbfSmashAction.ActionID);
            }

        }

        /// <summary>
        /// 添加或删除 条件-雷盾被拉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_tj_ldbl_CheckedChanged(object sender, EventArgs e)
        {
            RangeAlignHandler handler = HandlerManager.GetManager().GetHandler<RangeAlignHandler>(RangeAlignHandler.WhatIs);
            if (handler == null)
            {
                cb_tj_ldbl.Checked = false;
                return;
            }
            if (cb_tj_ldbl.Checked)
            {
                WRefLPullCondition wRefLPull = new WRefLPullCondition()
                {
                    Time = Convert.ToInt32(tb_ldbl_time.Text.Trim()),
                    Deviation = Convert.ToDecimal(tb_ldbl_dev.Text.Trim()),
                    openApi = clientManager.GetClient<OpenApiClient>("Loex_18537381088")
                };
                handler.AddCondition(WRefLPullCondition.ConditionId, wRefLPull);
                cb_dz_wtlp.Enabled = true;
            }
            else
            {
                cb_dz_wtlp.Checked = false;
                cb_dz_wtlp.Enabled = false;
                handler.RemoveCondition(WRefLPullCondition.ConditionId);
            }
        }

        /// <summary>
        /// 添加或删除 动作-瓦特拉盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_dz_wtlp_CheckedChanged(object sender, EventArgs e)
        {
            RangeAlignHandler handler = HandlerManager.GetManager().GetHandler<RangeAlignHandler>(RangeAlignHandler.WhatIs);
            WRefLPullCondition wRefLPull = handler.GetCondition<WRefLPullCondition>(WRefLPullCondition.ConditionId);
            if (wRefLPull == null)
            {
                cb_dz_wtlp.Checked = false;
                return;
            }
            if (cb_dz_wtlp.Checked)
            {
                wRefLPull.AddAction(WbfPullAction.ActionID, new WbfPullAction()
                {
                    VolumeLimit = Convert.ToDecimal(tb_dz_wtlp_limit.Text.Trim()),
                    wbfApi = clientManager.GetClient<WbfApiClient>("Wbf_18537381088")
                });
            }
            else
            {
                wRefLPull.RemoveAction(WbfPullAction.ActionID);
            }
        }
        #endregion

        #endregion

        #region 区间控制
        private void cb_qjkz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_qjkz.Checked)
            {
                LdRangeControlHandler handler = new LdRangeControlHandler(Convert.ToInt32(tb_qjkz_delay.Text.Trim()))
                {
                    LimitSP = Convert.ToDecimal(tb_qjkz_s1p.Text.Trim()),
                    LimitSV = Convert.ToDecimal(tb_qjkz_s1v.Text.Trim()),
                    LimitBV = Convert.ToDecimal(tb_qjkz_b1v.Text.Trim()),
                    LimitBP = Convert.ToDecimal(tb_qjkz_b1p.Text.Trim()),
                    MaxV = Convert.ToDecimal(tb_qjkz_maxV.Text.Trim()),
                    MinV = Convert.ToDecimal(tb_qjkz_minV.Text.Trim()),
                    MinStep = Convert.ToDecimal(tb_qjkz_minStep.Text.Trim()),
                    MaxStep = Convert.ToDecimal(tb_qjkz_maxStep.Text.Trim()),
                    RangeLimit = Convert.ToDecimal(tb_qjkz_rlimit.Text.Trim()),
                    apiClient = clientManager.GetClient<OpenApiClient>("Loex_18537381088"),
                    CancelHelper = LdCancelCallBack
                };
                HandlerManager.GetManager().AddHandler(handler, LdRangeControlHandler.WhatIs);
            }
            else
            {
                HandlerManager.GetManager().RemoveHandler(LdRangeControlHandler.WhatIs);
            }
        }
        #endregion

        private void cb_qjkz_wbf_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_qjkz_wbf.Checked)
            {
                WbfRangeControlHandler handler = new WbfRangeControlHandler(Convert.ToInt32(tb_qjkz_delay_wbf.Text.Trim()))
                {
                    LimitSP = Convert.ToDecimal(tb_qjkz_s1p_wbf.Text.Trim()),
                    LimitSV = Convert.ToDecimal(tb_qjkz_s1v_wbf.Text.Trim()),
                    LimitBV = Convert.ToDecimal(tb_qjkz_b1v_wbf.Text.Trim()),
                    LimitBP = Convert.ToDecimal(tb_qjkz_b1p_wbf.Text.Trim()),
                    MaxV = Convert.ToDecimal(tb_qjkz_maxV_wbf.Text.Trim()),
                    MinV = Convert.ToDecimal(tb_qjkz_minV_wbf.Text.Trim()),
                    MinStep = Convert.ToDecimal(tb_qjkz_minStep_wbf.Text.Trim()),
                    MaxStep = Convert.ToDecimal(tb_qjkz_maxStep_wbf.Text.Trim()),
                    RangeLimit = Convert.ToDecimal(tb_qjkz_rlimit_wbf.Text.Trim()),
                    apiClient = clientManager.GetClient<WbfApiClient>("Wbf_18537381088"),
                    CancelHelper = WfbCancelCallBack
                };
                HandlerManager.GetManager().AddHandler(handler, WbfRangeControlHandler.WhatIs);
            }
            else
            {
                HandlerManager.GetManager().RemoveHandler(WbfRangeControlHandler.WhatIs);
            }
        }
    }
}
