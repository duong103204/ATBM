namespace ContractManagerWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvContracts = new DataGridView();
            colDocId = new DataGridViewTextBoxColumn();
            colPath = new DataGridViewTextBoxColumn();
            colHash = new DataGridViewTextBoxColumn();
            btnSelectContract = new Button();
            btnSignContract = new Button();
            btnVerifyIntegrity = new Button();
            txtSignature = new TextBox();
            lblSignature = new Label();
            txtPrivateKey = new TextBox();
            lblPrivateKey = new Label();
            txtPublicKey = new TextBox();
            lblPublicKey = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContracts).BeginInit();
            SuspendLayout();
            // 
            // dgvContracts
            // 
            dgvContracts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContracts.Columns.AddRange(new DataGridViewColumn[] { colDocId, colPath, colHash });
            dgvContracts.Location = new Point(12, 2);
            dgvContracts.Name = "dgvContracts";
            dgvContracts.ReadOnly = true;
            dgvContracts.Size = new Size(776, 250);
            dgvContracts.TabIndex = 0;
            // 
            // colDocId
            // 
            colDocId.HeaderText = "Mã Tài Liệu";
            colDocId.Name = "colDocId";
            colDocId.ReadOnly = true;
            // 
            // colPath
            // 
            colPath.HeaderText = "Đường Dẫn";
            colPath.Name = "colPath";
            colPath.ReadOnly = true;
            // 
            // colHash
            // 
            colHash.HeaderText = "Giá Trị Băm";
            colHash.Name = "colHash";
            colHash.ReadOnly = true;
            // 
            // btnSelectContract
            // 
            btnSelectContract.Location = new Point(12, 268);
            btnSelectContract.Name = "btnSelectContract";
            btnSelectContract.Size = new Size(150, 30);
            btnSelectContract.TabIndex = 1;
            btnSelectContract.Text = "Chọn Hợp Đồng";
            btnSelectContract.UseVisualStyleBackColor = true;
            btnSelectContract.Click += btnSelectContract_Click;
            // 
            // btnSignContract
            // 
            btnSignContract.Location = new Point(168, 268);
            btnSignContract.Name = "btnSignContract";
            btnSignContract.Size = new Size(150, 30);
            btnSignContract.TabIndex = 2;
            btnSignContract.Text = "Ký Hợp Đồng";
            btnSignContract.UseVisualStyleBackColor = true;
            btnSignContract.Click += btnSignContract_Click;
            // 
            // btnVerifyIntegrity
            // 
            btnVerifyIntegrity.Location = new Point(324, 268);
            btnVerifyIntegrity.Name = "btnVerifyIntegrity";
            btnVerifyIntegrity.Size = new Size(150, 30);
            btnVerifyIntegrity.TabIndex = 3;
            btnVerifyIntegrity.Text = "Kiểm Tra Tính Toàn Vẹn";
            btnVerifyIntegrity.UseVisualStyleBackColor = true;
            btnVerifyIntegrity.Click += btnVerifyIntegrity_Click;
            // 
            // txtSignature
            // 
            txtSignature.Location = new Point(12, 330);
            txtSignature.Multiline = true;
            txtSignature.Name = "txtSignature";
            txtSignature.ReadOnly = true;
            txtSignature.Size = new Size(776, 60);
            txtSignature.TabIndex = 4;
            // 
            // lblSignature
            // 
            lblSignature.AutoSize = true;
            lblSignature.Location = new Point(12, 314);
            lblSignature.Name = "lblSignature";
            lblSignature.Size = new Size(47, 15);
            lblSignature.TabIndex = 5;
            lblSignature.Text = "Chữ Ký:";
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(12, 420);
            txtPrivateKey.Multiline = true;
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.ReadOnly = true;
            txtPrivateKey.Size = new Size(776, 60);
            txtPrivateKey.TabIndex = 6;
            // 
            // lblPrivateKey
            // 
            lblPrivateKey.AutoSize = true;
            lblPrivateKey.Location = new Point(12, 404);
            lblPrivateKey.Name = "lblPrivateKey";
            lblPrivateKey.Size = new Size(70, 15);
            lblPrivateKey.TabIndex = 7;
            lblPrivateKey.Text = "Khóa Riêng:";
            // 
            // txtPublicKey
            // 
            txtPublicKey.Location = new Point(12, 510);
            txtPublicKey.Multiline = true;
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.ReadOnly = true;
            txtPublicKey.Size = new Size(776, 60);
            txtPublicKey.TabIndex = 8;
            // 
            // lblPublicKey
            // 
            lblPublicKey.AutoSize = true;
            lblPublicKey.Location = new Point(12, 494);
            lblPublicKey.Name = "lblPublicKey";
            lblPublicKey.Size = new Size(95, 15);
            lblPublicKey.TabIndex = 9;
            lblPublicKey.Text = "Khóa Công Khai:";
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(lblPublicKey);
            Controls.Add(txtPublicKey);
            Controls.Add(lblPrivateKey);
            Controls.Add(txtPrivateKey);
            Controls.Add(lblSignature);
            Controls.Add(txtSignature);
            Controls.Add(btnVerifyIntegrity);
            Controls.Add(btnSignContract);
            Controls.Add(btnSelectContract);
            Controls.Add(dgvContracts);
            Name = "MainForm";
            Text = "Quản Lý Hợp Đồng";
            ((System.ComponentModel.ISupportInitialize)dgvContracts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHash;
        private System.Windows.Forms.Button btnSelectContract;
        private System.Windows.Forms.Button btnSignContract;
        private System.Windows.Forms.Button btnVerifyIntegrity;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
    }
}
