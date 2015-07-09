using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HaloOnlineVersionBrowser
{
    public partial class Form1 : Form
    {
        List<Build> _list = new List<Build>();
        List<string> _VersionList = new List<string>();
        string _downloaddir = AppDomain.CurrentDomain.BaseDirectory + "DownLoads\\";
        string _downloadurl = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnalysisJson();
            this.gbContent.Text = "Welcome";
            this.DownLoadbtn.Text = "开始";
            this.lbVersion.Enabled =
                    this.Versionlb.Visible =
                    this.VersionTitlelb.Visible =
                    this.Authorlb.Visible =
                    this.AuthorTitlelb.Visible =
                    this.FileSizelb.Visible =
                    this.FileSizeTilelb.Visible =
                    this.commitIdlb.Visible =
                    this.commitMessagelb.Visible =
                    this.commitTitlelb.Visible =
                    this.DownLoadStatespb.Visible =
                    this.CommitTimeTilelab.Visible =
                    this.commitTimelb.Visible = false;

        }

        private void lbVersion_Click(object sender, EventArgs e)
        {

            var index = this.lbVersion.SelectedIndex;
            if (index > -1)
            {
                this.DownLoadbtn.Text = "下载";
                this.DownLoadbtn.Visible =
                this.Versionlb.Visible =
                this.VersionTitlelb.Visible =
                this.Authorlb.Visible =
                this.AuthorTitlelb.Visible =
                this.FileSizelb.Visible =
                this.FileSizeTilelb.Visible =
                this.commitIdlb.Visible =
                this.commitMessagelb.Visible =
                this.commitTitlelb.Visible =
                this.CommitTimeTilelab.Visible =
                this.DownLoadStatespb.Visible =
                this.commitTimelb.Visible = true;
                this.Versionlb.Text = _list[index].BuildVersion;
                this.Authorlb.Text = _list[index].CommitAuthor;
                this.FileSizelb.Text = (Convert.ToInt32(_list[index].size) / 1000000).ToString("0MB");
                this.commitIdlb.Text = _list[index].CommitId;
                this.commitMessagelb.Text = _list[index].CommitMessage;
                _downloadurl = _list[index].downloadUrl;
                this.branchlb.Text = _list[index].Branch;
                this.commitTimelb.Text = _list[index].CommitDate.ToString();
                this.commitIdlb.Links[0].LinkData = "https://github.com/ElDewrito/ElDorito/commit/" + _list[index].CommitId;
            }
        }
        bool FindDir()
        {
            if (Directory.Exists(_downloaddir))
            {
                return true;
            }
            else
            {
                Directory.CreateDirectory(_downloaddir);
                return FindDir();
            }
        }
        void AnalysisJson()
        {
            var BuildString = (new WebClient()).DownloadString("https://dewrito.halo.click/api/builds");
            _list = JsonConvert.DeserializeObject<List<JObject>>(BuildString).Select((t) =>
            {
                JArray jar = JArray.Parse(t["artifacts"].ToString());
                Build b = new Build()
                {
                    Branch = t["branch"].ToString(),
                    BuildVersion = t["buildVersion"].ToString(),
                    CommitAuthor = t["commitAuthor"].ToString(),
                    CommitId = t["commitId"].ToString(),
                    CommitMessage = t["commitMessage"].ToString(),
                    downloadUrl = t["downloadUrl"].ToString(),
                    CommitDate = Convert.ToDateTime(t["commitDate"])
                };
                for (var i = 0; i < jar.Count; i++)
                {
                    JObject j = JObject.Parse(jar[i].ToString());
                    b.size = j["size"].ToString();
                    b.url = j["url"].ToString();
                }
                return b;
            }).ToList() as List<Build>;
            _list.Reverse();
        }

        private void DownLoadbtn_Click(object sender, EventArgs e)
        {
            if (DownLoadbtn.Text == "开始")
            {
                if (_list.Count > 0)
                {
                    this.gbContent.Text = "版本信息";
                    this.DownLoadbtn.Visible =
                    this.Devlab.Visible = false;

                    lbVersion.DataSource = new List<string>(_list.Select((t) => { return t.BuildVersion; }));
                    this.lbVersion.Enabled = true;
                }
            }
            else if (DownLoadbtn.Text == "下载")
            {
                if (!string.IsNullOrEmpty(_downloadurl)&&FindDir())
                {
                    this.DownLoadbtn.Enabled = false;
                    this.lbVersion.Enabled = false;
                    WebClient downloader = new WebClient();
                    downloader.DownloadFileCompleted += DownLoadCompleted;
                    downloader.DownloadProgressChanged += DownLoadProgressChanged;
                    downloader.DownloadFileAsync(new System.Uri(_downloadurl), _downloaddir + _downloadurl.Substring(_downloadurl.LastIndexOf("/") + 1));
                }
                else
                {
                    MessageBox.Show("请先选择版本", "Halo Online Version Browser");
                }

            }
        }
        private void DownLoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("下载完毕!", "Halo Online Version Browser");
            this.lbVersion.Enabled =
            this.DownLoadbtn.Enabled = true;
            DownLoadStatespb.Value = 0;
            Process.Start(_downloaddir);
        }
        void DownLoadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownLoadStatespb.Value = e.ProgressPercentage;
        }
        private void commitIdlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
