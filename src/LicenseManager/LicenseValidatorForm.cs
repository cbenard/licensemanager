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
    public partial class LicenseValidatorForm : Form
    {
        public LicenseValidatorForm()
        {
            InitializeComponent();
        }

        private void btnValidateLicense_Click(object sender, EventArgs e)
        {
            LicenseInformation info = LicenseEncryption.Decrypt(txtLicense.Text, txtPublicKey.Text);

            txtProduct.Text = info.Product;
            txtExpiration.Text = info.Expiration.HasValue ? info.Expiration.Value.ToString("yyyy-MM-dd HH:mm:ss") : "never";
            txtIsValid.Text = info.IsValid.ToString();
        }

        private void txtPublicKey_DragEnter(object sender, DragEventArgs e)
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

        private void txtPublicKey_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string data = e.Data.GetData(typeof(string)) as string;
                if (!String.IsNullOrWhiteSpace(data))
                {
                    txtPublicKey.Text = data;
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string file = files.First();

                txtPublicKey.Text = File.ReadAllText(file);
            }
        }

        private void txtLicense_DragEnter(object sender, DragEventArgs e)
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

        private void txtLicense_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                string data = e.Data.GetData(typeof(string)) as string;
                if (!String.IsNullOrWhiteSpace(data))
                {
                    txtLicense.Text = data;
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string file = files.First();

                txtLicense.Text = File.ReadAllText(file);
            }
        }
    }
}
