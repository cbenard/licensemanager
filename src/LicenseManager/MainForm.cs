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

namespace LicenseManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newKeypairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyMakerForm form = new KeyMakerForm();
            form.ShowDialog();
        }

        private void txtPrivateKey_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string))
                || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtPrivateKey_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string data = e.Data.GetData(typeof(string)) as string;
                if (!String.IsNullOrWhiteSpace(data))
                {
                    txtPrivateKey.Text = data;
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string file = files.First();

                txtPrivateKey.Text = File.ReadAllText(file);
            }
        }

        private void btnCreateLicense_Click(object sender, EventArgs e)
        {
            DateTime? expiration = null;
            if (!String.IsNullOrWhiteSpace(txtExpiration.Text))
            {
                expiration = DateTime.Parse(txtExpiration.Text);
            }

            txtLicense.Text = LicenseEncryption.Encrypt(txtProduct.Text, expiration, txtPrivateKey.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLicense.Text);
        }

        private void validateLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LicenseValidatorForm form = new LicenseValidatorForm();
            form.ShowDialog();
        }
    }
}
