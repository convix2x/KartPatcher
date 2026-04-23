using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace KartPatcher
{
    public partial class Form1 : Form
    {
        private string detectedGamePath = "";
        private string tempPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "KartPatcherTemp");

        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 5;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = ipBox.Text;
            string titleId = titleIdBox.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(titleId))
            {
                MessageBox.Show("Please enter both the PS3 IP and the game title id.");
                return;
            }

            try
            {
                stepStatus.Text = "Connecting to PS3...";
                progressBar1.Value = 1;
                if (await TestConnectionAsync(ipAddress))
                {
                    stepStatus.Text = $"Checking for {titleId}...";
                    progressBar1.Value = 2;

                    detectedGamePath = $"/dev_hdd0/game/{titleId}";

                    if (await VerifyPathAsync(ipAddress, detectedGamePath))
                    {
                        await Task.Delay(500);
                        stepStatus.Text = "Downloading USEROPTIONS.XML...";
                        progressBar1.Value = 3;

                        if (!Directory.Exists(tempPath)) Directory.CreateDirectory(tempPath);

                        string remoteFile = $"ftp://{ipAddress}{detectedGamePath}/USRDIR/USEROPTIONS.XML";
                        string localFile = Path.Combine(tempPath, "USEROPTIONS.XML");

                        using (WebClient client = new WebClient())
                        {
                            await client.DownloadFileTaskAsync(new Uri(remoteFile), localFile);
                        }

                        stepStatus.Text = "File downloaded.";
                        await Task.Delay(500);
                        stepStatus.Text = "Patching USEROPTIONS.XML...";
                        progressBar1.Value = 4;

                        string localXmlPath = Path.Combine(tempPath, "USEROPTIONS.XML");
                        XmlDocument doc = new XmlDocument();
                        doc.Load(localXmlPath);

                        XmlNode bombNode = doc.GetElementsByTagName("BombdServerIP")[0];
                        XmlNode playerNode = doc.GetElementsByTagName("PlayerConnectServerIP")[0];

                        if (bombNode != null) bombNode.InnerText = bombServerBox.Text;
                        if (playerNode != null) playerNode.InnerText = playerConnectBox.Text;

                        doc.Save(localXmlPath);
                        stepStatus.Text = "File patched locally.";
                        await Task.Delay(500);

                        stepStatus.Text = "Uploading patched file...";
                        progressBar1.Value = 5;

                        string remoteFileDest = $"ftp://{ipAddress}{detectedGamePath}/USRDIR/USEROPTIONS.XML";

                        using (WebClient client = new WebClient())
                        {
                            await client.UploadFileTaskAsync(new Uri(remoteFileDest), localFile);
                        }

                        stepStatus.Text = "Done!";
                        MessageBox.Show("ModNation Racers has been successfully patched!");
                    }
                    else
                    {
                        stepStatus.Text = "Title ID not found.";
                        MessageBox.Show($"Could not find directory: {detectedGamePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                stepStatus.Text = "Error!";
                MessageBox.Show(ex.Message);
            }
        }

        // standard webman doesn't have a password
        // if you have set one, what are you doing??
        // it's not like your port forwarded your damn ps3
        // did you? then stop doing it
        private async Task<bool> TestConnectionAsync(string ip)
        {
            var request = (FtpWebRequest)WebRequest.Create($"ftp://{ip}/dev_hdd0/");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Timeout = 5000;

            using (var response = (FtpWebResponse)await request.GetResponseAsync())
            {
                return response.StatusCode == FtpStatusCode.OpeningData || response.StatusCode == FtpStatusCode.CommandOK;
            }
        }

        private async Task<bool> VerifyPathAsync(string ip, string path)
        {
            try
            {
                var request = (FtpWebRequest)WebRequest.Create($"ftp://{ip}{path}/");
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                using (var response = (FtpWebResponse)await request.GetResponseAsync())
                {
                    return true;
                }
            }
            catch { return false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 helpWindow = new Form2();
            helpWindow.Show();
        }
    }
}