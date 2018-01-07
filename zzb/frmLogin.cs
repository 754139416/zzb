using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using zzb.ShopLogin;

namespace zzb
{
    public partial class frmLogin : CCWin.CCSkinMain //Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txt_password.SkinTxt.KeyPress += txt_cPassword_KeyPress;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SysTools.testIsEmpty(txt_id, "请输入用户名")) return;
            if (SysTools.testIsEmpty(txt_password, "请输入用户密码")) return;

            string id = txt_id.Text.Trim();

            string url = System.Configuration.ConfigurationManager.AppSettings["url"];
            string __ajax = System.Configuration.ConfigurationManager.AppSettings["__ajax"];

            string mobileLogin = System.Configuration.ConfigurationManager.AppSettings["mobileLogin"];
            if (mobileLogin == null) 
                mobileLogin = "true";

            string mobileType = System.Configuration.ConfigurationManager.AppSettings["mobileType"];
            if (mobileType == null)
                mobileType = "1";

            string json = SysTools.GetWebContent(url + "?__ajax=" + __ajax +
                "&mobileLogin=" + mobileLogin + "&mobileType=" + mobileType + 
                "&username=" + id + "&password=" + txt_password.Text.Trim());
            JShopLogin shopLogin = JsonHelper.DeserializeJsonToObject<JShopLogin>(json);
            if (!shopLogin.success)
            {
                txt_password.Focus();
                SysTools.show_err_msg(shopLogin.msg);
                return;
            }

            shopName = shopLogin.body.data.shopName; //商户名称
            shopDetailedAddress = shopLogin.body.data.shopDetailedAddress; //地址
            userId = shopLogin.body.data.userId; //用户ID
            paymentType = shopLogin.body.data.paymentType;

            //保存登录信息 到 注册表
            SysTools.save_regkey("id", id);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txt_id.Text = SysTools.read_regkey("id");
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (txt_id.Text.Trim() != "")
            txt_password.Focus();
        }

        private void txt_cPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                btn_login.PerformClick();
            }
        }

        public string shopName { get; set; }

        public string shopDetailedAddress { get; set; }

        public string userId { get; set; }

        public string paymentType { get; set; }
    }
}
