using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xipton.Razor;

namespace TestRazorHTMLTemplate.Utils
{
    public class RazorGenerator
    {
        private static RazorMachine m_razorMachine = null;
        public string HtmlTemplate { get; set; }
        public object Model { get; set; }

        public RazorGenerator(string htmlTemplate)
        {
            HtmlTemplate = htmlTemplate;
            Initialise();
        }

        public RazorGenerator(string htmlTemplate, object model) : this(htmlTemplate)
        {
            Model = model;
            Initialise();
        }

        public static void Initialise()
        {
            if (m_razorMachine == null)
                m_razorMachine = new RazorMachine(htmlEncode: false);
        }

        public string Run()
        {
            string content = null;

            if (!string.IsNullOrEmpty(HtmlTemplate))
            {
                content = m_razorMachine.ExecuteContent(HtmlTemplate, Model).Result;
            }

            return content;
        }
    }
}
