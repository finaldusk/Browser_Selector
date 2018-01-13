using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Browser_Selector.Model;
using Newtonsoft.Json;

namespace Browser_Selector
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var config = new Config();
            try
            {
                var configFile = File.ReadAllText("config.json");
                config= JsonConvert.DeserializeObject<Config>(configFile);
            }
            catch (Exception)
            {
                var DefaultBrowsers= new List<Browser>();
                var chrome = new Browser()
                {
                    Browser_Name = "chrome",
                    Browser_Download = "http://127.0.0.1/chrome.exe",
                    Browser_OldDownload = "http://127.0.0.1/chromeXP.exe"
                };
                DefaultBrowsers.Add(chrome);

                var DefaultWebSites = new List<WebSite>();
                var leisearch = new WebSite()
                {
                    WebSite_Browser = "chrome",
                    WebSite_Url = "https://search.wangxinlei.cn"
                };
                DefaultWebSites.Add(leisearch);

                var DefaultConfig = new Config
                {
                    Online = false,
                    Server = "127.0.0.1",
                    Browsers = DefaultBrowsers,
                    Websites=DefaultWebSites
                };

                config = DefaultConfig;
                string json = JsonConvert.SerializeObject(DefaultConfig);

                FileStream fs = new FileStream("config.json", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(json);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();                
            }

            if (args.Length < 1)
            {
                Application.Run(new MainForm());
            }
            else
            {
                try
                {
                    var website = config.Websites.Find(w => w.WebSite_Url == args[0]);
                    var browser = config.Browsers.Find(b => b.Browser_Name == website.WebSite_Browser);
                    Process.Start(browser.Browser_Name,website.WebSite_Url);
                    
                }
                catch (Exception)
                {

                    throw;
                }
                

            }            
            
            
        }
    }
}
