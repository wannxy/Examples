using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HideWindows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(this, "隐藏显示自己: Alt + S\r\n隐藏显示目标: Alt + X");
            toolTip.SetToolTip(tb_title, "隐藏多个,多个窗口标题用半角逗号隔开。\r\n例如: abc,123,aa 这将会隐藏标题为 'abc' '123' 'aa' 的窗口。");
        }

        private const int SW_HIDE = 0;  //隐藏任务栏
        private const int SW_RESTORE = 9;//显示任务栏
        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        private void btn_hide_Click(object sender, EventArgs e)
        {
            HideAll(tb_title.Text.Trim());
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowAll(tb_title.Text.Trim());
        }

        private const int WM_HOTKEY = 0x312; //窗口消息-热键

        private const int WM_CREATE = 0x1; //窗口消息-创建

        private const int WM_DESTROY = 0x2; //窗口消息-销毁

        private const int CMe = 0x3572; //热键ID
        private const int CIt = 0x3573;

        private void ShowAll(string titles)
        {
            if (titles == null || "".Equals(titles))
            {
                return;
            }
            foreach (string title in titles.Split(","))
            {
                ShowWindow(FindWindow(null, title), SW_RESTORE);
            }
        }

        private void HideAll(string titles)
        {
            if (titles == null || "".Equals(titles))
            {
                return;
            }
            foreach (string title in titles.Split(","))
            {
                ShowWindow(FindWindow(null, title), SW_HIDE);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID

                    switch (m.WParam.ToInt32())

                    {
                        case CMe: //热键ID
                            if (IsShowMe)
                            {
                                HideMe();
                            }
                            else
                            {
                                ShowMe();
                            }
                            break;
                        case CIt:
                            if (IsShowIt)
                            {
                                HideIt();
                            }
                            else
                            {
                                ShowIt();
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case WM_CREATE: //窗口消息-创建
                    AppHotKey.RegKey(Handle, CMe, AppHotKey.KeyModifiers.Alt, Keys.S);
                    AppHotKey.RegKey(Handle, CIt, AppHotKey.KeyModifiers.Alt, Keys.X);
                    break;
                case WM_DESTROY: //窗口消息-销毁
                    AppHotKey.UnRegKey(Handle, CMe); //销毁热键
                    AppHotKey.UnRegKey(Handle, CIt);
                    break;
                default:
                    break;
            }
        }

        private bool IsShowMe = true;
        private void HideMe()
        {
            IsShowMe = false;
            ShowWindow(FindWindow(null, Text), SW_HIDE);
        }

        private void ShowMe()
        {
            IsShowMe = true;
            ShowWindow(FindWindow(null, Text), SW_RESTORE);
        }

        private bool IsShowIt = true;
        private void HideIt()
        {
            IsShowIt = false;
            HideAll(tb_title.Text.Trim());
        }

        private void ShowIt()
        {
            IsShowIt = true;
            ShowAll(tb_title.Text.Trim());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
