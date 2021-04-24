using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnXmlOku_Click(object sender, EventArgs e)
        {
            xmloku();

            btnXmlYaz.Enabled = true; //btnxmlokuya basmadığımızda veri çekmediği için direk yaza basıldığında boş dosya kaydediyordu.
                                      //bende veriler gelmeden yazma işlemini kapatmak için btnxmlyazmayı btnxmlokuya basıldıktan sonra
                                      //çalışması için burda bunu yaptım.
        }

        private void xmloku()
        {
            DataSet dset = new DataSet();
            XmlReader okuyucu = XmlReader.Create("https://www.cumhuriyet.com.tr/rss/son_dakika.xml", new XmlReaderSettings());
            dset.ReadXml(okuyucu);

            dgvSnc.DataSource = dset.Tables[3];
        }

        private void btnXmlYaz_Click(object sender, EventArgs e)
        {
            xmlyaz();

            XmlDocument cpy = new XmlDocument();
            cpy.Load(@"haber.xml");
            cpy.Save(@"haberyeni.xml");

        }

        private void xmlyaz()
        {
            XmlDocument xdos = new XmlDocument();
            XmlNode root = xdos.CreateElement("haberler");
            xdos.AppendChild(root);



            for (int i = 0; i < dgvSnc.Rows.Count - 1; i++)
            {

                XmlNode item = xdos.CreateElement("item");
                XmlAttribute id = xdos.CreateAttribute("id");
                XmlNode baslık = xdos.CreateElement("baslık");
                XmlNode link = xdos.CreateElement("link");
                XmlNode tarih = xdos.CreateElement("tarih");
                XmlNode acıklama = xdos.CreateElement("acıklama");


                id.Value = i.ToString();
                baslık.InnerText = Convert.ToString(dgvSnc.Rows[i].Cells[0].Value);
                link.InnerText = Convert.ToString(dgvSnc.Rows[i].Cells[1].Value);
                tarih.InnerText = Convert.ToString(dgvSnc.Rows[i].Cells[2].Value);
                acıklama.InnerText = Convert.ToString(dgvSnc.Rows[i].Cells[3].Value);

                item.Attributes.Append(id);
                item.AppendChild(baslık);
                item.AppendChild(link);
                item.AppendChild(tarih);
                item.AppendChild(acıklama);
                root.AppendChild(item);



            }
            FileStream sf = File.Create(@"haber.xml");
            sf.Close();
            string haberdosyası = @"haber.xml";
            xdos.Save(haberdosyası);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            if (btnXmlYaz.Enabled==true)
            {
                if (i==180)
                {
                    xmloku();

                    xmlyaz();


                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(@"haberyeni.xml");
                    XmlNodeList list = xdoc.SelectNodes("//haberler/item");
                    foreach (XmlNode x in list)
                    {

                        string baslık = x["baslık"].InnerText;
                        string baslık1 = Convert.ToString(dgvSnc.Rows[0].Cells[0].Value);
                        if (baslık != baslık1)
                        {
                            tmr.Stop();
                            MessageBox.Show("Yeni Sondakika Haberleri Geldi ve Güncellendi");
                            XmlDocument cpy = new XmlDocument();
                            cpy.Load(@"haber.xml");
                            cpy.Save(@"haberyeni.xml");
                            tmr.Start();
                        }

                        break;

                    }

                    i = 1;
                }
                else
                {
                    i++;
                }


            }
           

        }
    }
    }


