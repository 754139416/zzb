using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace zzb
{
    public partial class frmMain : CCWin.CCSkinMain //Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
            {
                System.Environment.Exit(System.Environment.ExitCode);
                this.Dispose();
                this.Close();
            }

            lbl_shopName.Text = login.shopName; //商户名称
            lbl_shopDetailedAddress.Text = login.shopDetailedAddress; //地址

            //二维码
            ThoughtWorks.QRCode.Codec.QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
            encoder.QRCodeScale = 4;//大小(值越大生成的二维码图片像素越高)
            encoder.QRCodeVersion = 0;//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
            encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//错误效验、错误更正(有4个等级)
            String qrdata = login.userId + "|" + login.paymentType;
            System.Drawing.Bitmap bp = encoder.Encode(qrdata.ToString(), Encoding.GetEncoding("GB2312"));
            Image image = bp;
            pictureBox1.Image = bp;
        }
    }
}
