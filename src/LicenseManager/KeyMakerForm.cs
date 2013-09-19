using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseManager
{
    public partial class KeyMakerForm : Form
    {
        public KeyMakerForm()
        {
            InitializeComponent();
        }

        private void btnRegenerate_Click(object sender, EventArgs e)
        {
            RegenerateKeys();
        }

        private void RegenerateKeys()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                txtPrivate.Text = rsa.ToXmlString(true);
                txtPublic.Text = rsa.ToXmlString(false);
            }            
        }

        private void btnSavePublic_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Public Key";
            sfd.FileName = "public.xml";
            sfd.SupportMultiDottedExtensions = true;
            sfd.ValidateNames = true;
            sfd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            DialogResult result = sfd.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtPublic.Text);
            }
        }

        private void btnSavePrivate_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Public Key";
            sfd.FileName = "private.xml";
            sfd.SupportMultiDottedExtensions = true;
            sfd.ValidateNames = true;
            sfd.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            DialogResult result = sfd.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtPrivate.Text);
            }
        }

        private void KeyMakerForm_Load(object sender, EventArgs e)
        {
            RegenerateKeys();
        }

        private void btnCopyPublic_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublic.Text);
        }

        private void btnCopyPrivate_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPrivate.Text);
        }
    }
}
