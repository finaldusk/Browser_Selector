using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Browser_Selector.Model
{
    public class Browser
    {
        //浏览器名称
        public string Browser_Name { get; set; }        
        //浏览器下载地址
        public string Browser_Download { get; set; }
        //远古版本浏览器下载地址(适用于XP版本的下载地址)
        public string Browser_OldDownload { get; set; }
    }
}
