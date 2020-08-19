using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBPubkeyConverter
{
    public partial class frmMain : Form
    {

        public Dictionary<String, String> PubKeyPrefixes = new Dictionary<String, String>()
        {
            ["xpub"] = "0488b21e",
            ["ypub"] = "049d7cb2",
            ["Ypub"] = "0295b43f",
            ["zpub"] = "04b24746",
            ["Zpub"] = "02aa7ed3",
            ["tpub"] = "043587cf",
            ["upub"] = "044a5262",
            ["Upub"] = "024289ef",
            ["vpub"] = "045f1cf6",
            ["Vpub"] = "02575483",
            ["drkp"] = "02fe52cc",
            ["drkv"] = "02fe52f8",
            ["DRKP"] = "3a805837",
            ["DRKV"] = "3a8061a0",
            ["tpub"] = "043587cf",
            ["tprv"] = "04358394",
            ["Ltub"] = "019da462",
        };



        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// xpub = 0488b21e
        /// 
        /// </summary>
        /// <param name="xpubkey"></param>
        /// <param name="newFormat"></param>
        /// <returns></returns>
        public string ParseNewxPubFormats(string xpubkey, string newFormat = "xpub")
        {
            try
            {
                var encoder = new NBitcoin.DataEncoders.Base58CheckEncoder();
                var decoded = encoder.DecodeData(xpubkey);

                var decoded_2 = decoded.Skip(4).ToArray();

                var decoded_3 = StringToByteArray(PubKeyPrefixes[newFormat]).Concat(decoded_2).ToArray();

                var encoded = encoder.EncodeData(decoded_3);

                return encoded;
            }
            catch
            {
                return null;
            }
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void llLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://premium.black");
        }



        static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    var p = Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

                    Thread.Sleep(1000);

                    p.Close();
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void bnConvert_Click(object sender, EventArgs e)
        {
            if(!PubKeyPrefixes.ContainsKey(cmbTypes.SelectedItem.ToString()))
            {
                return;
            }


            var s = ParseNewxPubFormats(txtPublicKeyIn.Text, cmbTypes.SelectedItem.ToString());

            txtConverted.Text = s;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("DISCLAIMER: Please use this tool on your own RISK.\r\nIt can help you, to get your Public Key (xPub) in a different format for PREMIUM BLACK or other services. This tool will be provided \"as-is\" without any warranty about its functionality. But at any time prove the given public key and compare with the one you'll receive from your wallet.\r\nWhen you press on OK you agree with that.", "DISCLAIMER", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                this.Close();
                return;
            }

            loadTypes();

            cmbTypes.SelectedItem = "xpub";
        }

        private void loadTypes()
        {
            

            foreach(var k in PubKeyPrefixes.OrderBy(a => a.Key))
            {
                cmbTypes.Items.Add(k.Key);


            }
        }
    }
}
