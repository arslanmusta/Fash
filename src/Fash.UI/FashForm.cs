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
using Fash.Lib;

namespace Fash.UI
{
    public partial class FashForm : Form
    {
        private readonly string _filePath;

        private readonly IHasherBuilder _hashBuilder;

        public FashForm(string[] args)
        {

            _filePath = args.Length > 0 ? args[0] : string.Empty;
            
            using var fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read);

            _hashBuilder = new HasherBuilder()
                .SetInput(fs)
                .SetAlgorithm(new Sha512())
                .SetRepresentation(new HexRepresentation());
            
            
            InitializeComponent();

            this.HashComboBox.DataSource = new List<KeyValuePair<string, IHashAlgorithm>>
            {
                new("SHA512", new Sha512()),
                new("SHA256", new Sha256()),
                new("SHA1", new Sha1()),
                new("MD5", new Md5())
            };
            this.HashComboBox.ValueMember = "Value";
            this.HashComboBox.DisplayMember = "Key";
            this.HashComboBox.SelectedIndex = 0;
        }

        private void HashComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hashAlgorithm = ((KeyValuePair<string, IHashAlgorithm>)this.HashComboBox.SelectedItem).Value;

            using var fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read);

            this.HashResultTextBox.Text = _hashBuilder
                .SetInput(fs)
                .SetAlgorithm(hashAlgorithm)
                .Build().Hash();
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            var expectedHash = this.CompareTextBox.Text.ToLower();
            var calculatedHash = this.HashResultTextBox.Text;

            this.CompareResultLabel.Visible = true;
            this.CompareResultLabel.Text = expectedHash == calculatedHash ? "Comparison successful" : "Comparison failed";
        }
    }
}
