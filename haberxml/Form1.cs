using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace haberxml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXmlOku_Click(object sender, EventArgs e)
        {

            DataSet dset = new DataSet();
            XmlReader okuyucu = XmlReader.Create("https://www.cumhuriyet.com.tr/rss/son_dakika.xml",new XmlReaderSettings());
            dset.ReadXml(okuyucu);

            dgvSnc.DataSource = dset.Tables[3];
        }

        private void btnXmlYaz_Click(object sender, EventArgs e)
        {

        }
    }
}
