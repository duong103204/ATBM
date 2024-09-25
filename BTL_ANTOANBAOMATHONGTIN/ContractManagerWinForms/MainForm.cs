using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ContractManagerWinForms
{
    public partial class MainForm : Form
    {
        private RSACryptoServiceProvider rsa;

        public MainForm()
        {
            InitializeComponent();
            rsa = new RSACryptoServiceProvider(2048);
            DisplayKeys();
        }

        private void DisplayKeys()
        {
            txtPrivateKey.Text = rsa.ToXmlString(true);
            txtPublicKey.Text = rsa.ToXmlString(false);
        }

        private void btnSelectContract_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    string hashValue = CalculateHash(filePath);
                    dgvContracts.Rows.Add(dgvContracts.Rows.Count + 1, filePath, hashValue);
                }
            }
        }

        private string CalculateHash(string filePath)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = File.ReadAllBytes(filePath);
                byte[] hash = sha256.ComputeHash(data);
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }

        private void btnSignContract_Click(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để ký.");
                return;
            }

            string contractPath = dgvContracts.SelectedRows[0].Cells[1].Value.ToString();
            byte[] contractData = File.ReadAllBytes(contractPath);
            byte[] signature = rsa.SignData(contractData, CryptoConfig.MapNameToOID("SHA256"));
            txtSignature.Text = BitConverter.ToString(signature).Replace("-", "");

            try
            {
                rsa.VerifyData(contractData, CryptoConfig.MapNameToOID("SHA256"), signature);
                MessageBox.Show("Chữ ký hợp lệ!");
            }
            catch (Exception)
            {
                MessageBox.Show("Chữ ký không hợp lệ.");
            }
        }

        private void btnVerifyIntegrity_Click(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng để kiểm tra.");
                return;
            }

            string contractPath = dgvContracts.SelectedRows[0].Cells[1].Value.ToString();
            string originalHash = dgvContracts.SelectedRows[0].Cells[2].Value.ToString();
            string currentHash = CalculateHash(contractPath);

            if (originalHash == currentHash)
            {
                MessageBox.Show("Tính toàn vẹn của tài liệu đã được xác nhận. Không có thay đổi nào được phát hiện.");
            }
            else
            {
                MessageBox.Show("Tính toàn vẹn của tài liệu bị xâm phạm: Tài liệu đã bị sửa đổi.");
            }
        }
    }
}
