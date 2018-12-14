using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using RestSharp;
using WMPLib;

namespace Dictionary1
{
    public partial class Main : Form
    {
        private  HttpClient http = new HttpClient();

        private string url = "https://dict.laban.vn/find?type=1&query=";

        public Main()
        {
            InitializeComponent();
            this.pnRes.Visible = false;
            alert.Hide();
            mask.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void addCard()
        {
            Crawl(searchBox.Text);
        }

        private int pos = 10;
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lblang.Text == "vi") lblang.Text = "en";
            else lblang.Text = "vi";
        }

        private String htmlOxford = "";

        private async void Crawl(string word)
        {
            var client = new RestClient(url + word);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "080294cd-9e59-490d-b1d3-7b6e7f6f1590");
            request.AddHeader("cache-control", "no-cache");
            var html = client.Execute(request).Content;

            var regexMean = new Regex("((<div class=\"green bold margin25 m-top15\">)(.*?)(</div>))");
            var regexPhienAm = new Regex("((<span class=\"color-black\">)/(.*?)/)");
            var regexTuLoai = new Regex("(<div class=\"bg-grey bold font-large m-top20\"><span>)(.*?)(</span>)</div>");

            var mean = regexMean.Match(html).Groups[3].Value;
            if (mean == "")
            {
                pnRes.Visible = false;
                nghia.Visible = pnViDu.Visible = false;
                alert.Visible = true;
                mask.Visible = true;
                return;
            }
            else
            {
                var phienAm = regexPhienAm.Match(html).Groups[3].Value;
                var tuLoai = regexTuLoai.Match(html).Groups[2].Value;
                mask.Visible = false;
                this.alert.Visible = false;
                this.phienAm.Text = "/" + phienAm + "/";
                this.tuLoai.Text = tuLoai;
                this.nghia.Text = "• " + mean;
                this.nghia.AutoSize = true;
                this.pnViDu.Visible = true;
                this.nghia.Visible = true;
                separator.Show();
            }

            try
            {
                vd1.Visible = vd2.Visible = vd3.Visible = false;
                htmlOxford = http.GetStringAsync("https://www.oxfordlearnersdictionaries.com/definition/english/" + searchBox.Text).Result;
                var res = Regex.Matches(htmlOxford, "(<span class=\"x\" dpsid=(.*?)id=(.*?)\">(.*?)</span></span>)");
                int i = 0;
                string temp;
                foreach (var VARIABLE in res)
                {
                    if(i==3) break;
                    temp = res[i].Groups[4].ToString();
                    if (temp[0] >= 'A' && temp[0] <= 'Z' && (!temp.Contains("<")))
                    {
                        if (i == 0)
                        {
                            vd1.Text = "• "+temp;
                            vd1.Visible = true;
                        }

                        if (i == 1)
                        {
                            vd2.Text = "• " + temp;
                            vd2.Visible = true;
                        }

                        if (i == 2)
                        {
                            vd3.Text = "• " + temp;
                            vd3.Visible = true;
                        }

                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                
            }

            
        }

        private void getVoice()
        {
            try
            {
                var regex = new Regex("https://www.oxfordlearnersdictionaries.com/media/english/uk_pron.*?.mp3");
                var link = regex.Match(htmlOxford).Groups[0].ToString();
                var wplayer = new WindowsMediaPlayer();
                wplayer.URL = link;
                wplayer.controls.play();

            }
            catch (Exception e)
            {
                //do nothings
            }
        }

        private string temp;

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (temp == searchBox.Text) return;
                if (searchBox.Text.Length <= 1) return;
                searchBox.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
                addCard();
                moving.Show(pnRes);
                temp = searchBox.Text;
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var setting = new Setting();
            Hide();
            setting.ShowDialog();
            Show();
        } 

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            getVoice();
        }

       
    }
}