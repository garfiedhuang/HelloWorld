using GLD.GBES.Utility;
using GLD.GBES.WCFClientProxy;
using GLD.GBES.WCFExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SR.ServiceClient sc = new SR.ServiceClient())
            {
                WCFContext.Current.Operater = new Operater()
                {
                    Name = "guozili",
                    Time = DateTime.Now,
                    IP = "Fetch.UserIp",
                    LoginToken = Guid.NewGuid(),
                    Method = "button1_Click"
                };

                /*var response = sc.GetProducts(10, 1, 0);*/
                var iservice = new RemoteServiceFactory().CreateService();
                var response = iservice.GetProducts(10, 1, 0);

                MessageBox.Show(Newtonsoft.Json.JsonConvert.SerializeObject(response));
            }
        }
    }
}
