using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace Twitter_Api
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, System.EventArgs e)
      {
         string baseURL = "http://services3.epsilonnet.gr/es3/es/update/234-10013-197/17.2.2.0/4491978/__PKhnMkATnP_S_RsoCWBK2kqkKSaXbsfvc1zw6g2Hbua_P_mH0XQ8Sxd_P_oA_E__E";
         HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL);
         request.Method = "GET";
         request.ContentType = @"application/json";
         HttpResponseMessage response = (HttpResponseMessage)request.GetResponse();
         textBox3.Text = response.Content.ToString();
      }
   }
}
