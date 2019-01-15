using System;
using System.Web;
using System.Web.UI;
using Newtonsoft.Json;
using System.Text;

namespace WebForm
{

    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("the OsVersion: ");
            stringBuilder.AppendLine(JsonConvert.SerializeObject(Environment.OSVersion));
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("the framework version :");
            stringBuilder.AppendLine(Environment.Version.ToString());
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("the MachineName :");
            stringBuilder.AppendLine(Environment.MachineName);
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("the operation system is  :");
            stringBuilder.AppendLine(Environment.OSVersion.Platform.ToString());
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("the current tiem is :");
            stringBuilder.AppendLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ffff"));
            txtArea.InnerText = stringBuilder.ToString();
        }

        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
        }
    }
}
