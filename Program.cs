using System;
using System.Text;
using System.Net;
using System.Web;

namespace SendLineMessage
{
    static class Program
    {

        [STAThread]
        static void Main()
        {

            //アクセストークン
            string token = "qcPWYmn76opeZTWaFvrtg4a61BjGF7tdrVueSBjoHHI";
            int time = DateTime.Now.Day;
           
                //送信するメッセージ
                string strMsg = "aaaa";
                string LINE_url = "https://notify-api.line.me/api/notify";
                Encoding enc = Encoding.UTF8;
                string payload = "message=" + HttpUtility.UrlEncode(strMsg, enc);
                using (WebClient client = new WebClient())
                {
                    client.Encoding = enc;
                    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    client.Headers.Add("Authorization", "Bearer " + token);
                    //メッセージ送信
                    client.UploadString(LINE_url, payload);
                }


            }
            
            
        }
    }
