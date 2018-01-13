using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Browser_Selector.Model
{
    public class Config
    {
        public bool Online { get; set; }
        public string Server { get; set; }
        public List<Browser> Browsers { get; set; }
        public List<WebSite> Websites { get; set; }                
    }
}
