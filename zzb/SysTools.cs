using CCWin.SkinControl;
using Microsoft.Win32;
using MyCompression;
using MyEncrypt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace zzb
{
    public class SysTools
    {
        public const string SYSNAME = "zzb_client";

        public static void show_err_msg(string msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void show_info_msg(string msg)
        {
            MessageBox.Show(msg, "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool testIsEmpty(TextBox txt, string msg)
        {
            if (txt.Text.Trim() == "")
            {
                show_err_msg(msg);
                txt.Focus();
                return true;
            }
            return false;
        }

        public static bool testIsEmpty(SkinTextBox txt, string msg)
        {
            if (txt.Text.Trim() == "")
            {
                show_err_msg(msg);
                txt.Focus();
                return true;
            }
            return false;
        }

        /// <summary>  
        /// Post提交获取返回数据  
        /// </summary>  
        /// <param name="url">网址</param>  
        /// <returns></returns>  
        public static string GetWebContent(string url)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            // 要注意的这是这个编码方式，还有内容的Xml内容的编码方式  
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            byte[] data = encoding.GetBytes(url);

            // 准备请求,设置参数  
            request = WebRequest.Create(url) as HttpWebRequest;
            //request.Method = "POST";
            request.Method = "GET";
            request.ContentType = "text/plain";
            //request.ContentLength = data.Length; //设置这个，request.GetResponse() 会超时，好奇怪
            request.KeepAlive = false;

            //outstream = request.GetRequestStream();
            //outstream.Write(data, 0, data.Length);
            //outstream.Flush();
            //outstream.Close();
            //发送请求并获取相应回应数据

            response = request.GetResponse() as HttpWebResponse;

            //直到request.GetResponse()程序才开始向目标网页发送Post请求  
            instream = response.GetResponseStream();
            sr = new StreamReader(instream, encoding);
            //返回结果网页(html)代码  

            string content = sr.ReadToEnd();
            sr.Close();

            if (response != null)
            {
                response.Close();
            }
            if (request != null)
            {
                request.Abort();
            }

            return content;
        }

        public static string save_regkey(string regkey, string regvalue)
        {
            try
            {
                string nm = @"software\" + SYSNAME;

                Encrypt encrypt = new Encrypt();
                string value = encrypt.EncryptString(CompressionString.DeflateCompress(regvalue));

                RegistryKey key = Registry.CurrentUser;
                RegistryKey software = key.CreateSubKey(nm); //创建注册表项
                software = key.OpenSubKey(nm, true); //打开注册表项
                software.SetValue(regkey, value);
                software.Close();
                key.Close();

                return "";
            }
            catch (Exception ex)
            {
                return "[ERROR]" + ex.Message;
            }
        }

        public static string read_regkey(string regkey)
        {
            string nm = @"software\" + SYSNAME;
            string info = "";

            RegistryKey Key = Registry.CurrentUser;
            RegistryKey myreg = Key.OpenSubKey(nm);

            if (myreg != null)
            {
                Encrypt encrypt = new Encrypt();
                info = CompressionString.DeflateDecompress(
                    encrypt.DecryptString(Convert.ToString(myreg.GetValue(regkey))));
                myreg.Close();
            }
            return info;
        }
    }
}
