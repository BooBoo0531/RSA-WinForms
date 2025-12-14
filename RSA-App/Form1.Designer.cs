namespace RSA_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbPrivateKey = new Label();
            lbPublicKey = new Label();
            txtPhi = new TextBox();
            txtD = new TextBox();
            txtN = new TextBox();
            btnCreateKey = new Button();
            btnAutoGenerate = new Button();
            txtE = new TextBox();
            label3 = new Label();
            txtQ = new TextBox();
            label2 = new Label();
            txtP = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCLear = new Button();
            label12 = new Label();
            btnSaveFile = new Button();
            btnChooseFile = new Button();
            btnDecrypt = new Button();
            txtOutput = new TextBox();
            label4 = new Label();
            btnEncrypt = new Button();
            txtInput = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbPrivateKey);
            groupBox1.Controls.Add(lbPublicKey);
            groupBox1.Controls.Add(txtPhi);
            groupBox1.Controls.Add(txtD);
            groupBox1.Controls.Add(txtN);
            groupBox1.Controls.Add(btnCreateKey);
            groupBox1.Controls.Add(btnAutoGenerate);
            groupBox1.Controls.Add(txtE);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtQ);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtP);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(35, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 381);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Key Generation";
            // 
            // label11
            // 
            label11.BackColor = Color.SteelBlue;
            label11.Location = new Point(227, 32);
            label11.Name = "label11";
            label11.Size = new Size(1, 100);
            label11.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.SteelBlue;
            label10.Location = new Point(30, 291);
            label10.Name = "label10";
            label10.Size = new Size(400, 1);
            label10.TabIndex = 18;
            // 
            // label9
            // 
            label9.BackColor = Color.SteelBlue;
            label9.Location = new Point(30, 154);
            label9.Name = "label9";
            label9.Size = new Size(400, 1);
            label9.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(100, 243);
            label7.Name = "label7";
            label7.Size = new Size(172, 23);
            label7.TabIndex = 16;
            label7.Text = "d = e^-1 mod Phi(n):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 207);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 15;
            label6.Text = "Phi (n) = (p-1) * (q-1):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 171);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 14;
            label5.Text = "n = p * q:";
            label5.Click += label5_Click;
            // 
            // lbPrivateKey
            // 
            lbPrivateKey.AutoSize = true;
            lbPrivateKey.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrivateKey.Location = new Point(60, 302);
            lbPrivateKey.Name = "lbPrivateKey";
            lbPrivateKey.Size = new Size(94, 23);
            lbPrivateKey.TabIndex = 13;
            lbPrivateKey.Text = "Private Key";
            // 
            // lbPublicKey
            // 
            lbPublicKey.AutoSize = true;
            lbPublicKey.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPublicKey.Location = new Point(60, 340);
            lbPublicKey.Name = "lbPublicKey";
            lbPublicKey.Size = new Size(88, 23);
            lbPublicKey.TabIndex = 12;
            lbPublicKey.Text = "Public Key";
            // 
            // txtPhi
            // 
            txtPhi.BorderStyle = BorderStyle.FixedSingle;
            txtPhi.Location = new Point(276, 205);
            txtPhi.Name = "txtPhi";
            txtPhi.ReadOnly = true;
            txtPhi.Size = new Size(110, 30);
            txtPhi.TabIndex = 11;
            // 
            // txtD
            // 
            txtD.BorderStyle = BorderStyle.FixedSingle;
            txtD.Location = new Point(276, 241);
            txtD.Name = "txtD";
            txtD.ReadOnly = true;
            txtD.Size = new Size(110, 30);
            txtD.TabIndex = 10;
            // 
            // txtN
            // 
            txtN.BorderStyle = BorderStyle.FixedSingle;
            txtN.Location = new Point(276, 169);
            txtN.Name = "txtN";
            txtN.ReadOnly = true;
            txtN.Size = new Size(110, 30);
            txtN.TabIndex = 9;
            // 
            // btnCreateKey
            // 
            btnCreateKey.BackColor = Color.LightSteelBlue;
            btnCreateKey.FlatStyle = FlatStyle.Popup;
            btnCreateKey.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateKey.Location = new Point(276, 97);
            btnCreateKey.Name = "btnCreateKey";
            btnCreateKey.Size = new Size(174, 40);
            btnCreateKey.TabIndex = 8;
            btnCreateKey.Text = "Tạo khóa";
            btnCreateKey.UseVisualStyleBackColor = false;
            btnCreateKey.Click += btnCreateKey_Click;
            // 
            // btnAutoGenerate
            // 
            btnAutoGenerate.BackColor = Color.LightSteelBlue;
            btnAutoGenerate.FlatStyle = FlatStyle.Popup;
            btnAutoGenerate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutoGenerate.Location = new Point(276, 33);
            btnAutoGenerate.Name = "btnAutoGenerate";
            btnAutoGenerate.Size = new Size(174, 40);
            btnAutoGenerate.TabIndex = 7;
            btnAutoGenerate.Text = "Tự động sinh p, q";
            btnAutoGenerate.UseVisualStyleBackColor = false;
            btnAutoGenerate.Click += btnAutoGenerate_Click;
            // 
            // txtE
            // 
            txtE.BorderStyle = BorderStyle.FixedSingle;
            txtE.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtE.Location = new Point(36, 104);
            txtE.Name = "txtE";
            txtE.Size = new Size(145, 30);
            txtE.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(23, 23);
            label3.TabIndex = 5;
            label3.Text = "e:";
            // 
            // txtQ
            // 
            txtQ.BorderStyle = BorderStyle.FixedSingle;
            txtQ.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQ.Location = new Point(36, 68);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(145, 30);
            txtQ.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(24, 23);
            label2.TabIndex = 3;
            label2.Text = "q:";
            // 
            // txtP
            // 
            txtP.BorderStyle = BorderStyle.FixedSingle;
            txtP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtP.Location = new Point(36, 32);
            txtP.Name = "txtP";
            txtP.Size = new Size(145, 30);
            txtP.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(24, 23);
            label1.TabIndex = 1;
            label1.Text = "p:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightBlue;
            groupBox2.Controls.Add(btnCLear);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnSaveFile);
            groupBox2.Controls.Add(btnChooseFile);
            groupBox2.Controls.Add(btnDecrypt);
            groupBox2.Controls.Add(txtOutput);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnEncrypt);
            groupBox2.Controls.Add(txtInput);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(560, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(482, 447);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encryption / Decryption";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnCLear
            // 
            btnCLear.BackColor = Color.LightCoral;
            btnCLear.FlatStyle = FlatStyle.Popup;
            btnCLear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCLear.Location = new Point(382, 394);
            btnCLear.Name = "btnCLear";
            btnCLear.Size = new Size(94, 29);
            btnCLear.TabIndex = 20;
            btnCLear.Text = "CLEAR";
            btnCLear.UseVisualStyleBackColor = false;
            btnCLear.Click += btnCLear_Click;
            // 
            // label12
            // 
            label12.BackColor = Color.SteelBlue;
            label12.Location = new Point(38, 245);
            label12.Name = "label12";
            label12.Size = new Size(400, 1);
            label12.TabIndex = 19;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(6, 394);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(94, 29);
            btnSaveFile.TabIndex = 12;
            btnSaveFile.Text = "Lưu file";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click_1;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChooseFile.Location = new Point(382, 26);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 29);
            btnChooseFile.TabIndex = 11;
            btnChooseFile.Text = "Chọn file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.SteelBlue;
            btnDecrypt.FlatStyle = FlatStyle.Popup;
            btnDecrypt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.ForeColor = SystemColors.ButtonHighlight;
            btnDecrypt.Location = new Point(267, 194);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(174, 40);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Giải mã";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtOutput
            // 
            txtOutput.BorderStyle = BorderStyle.FixedSingle;
            txtOutput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOutput.Location = new Point(6, 278);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(470, 110);
            txtOutput.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 249);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 8;
            label4.Text = "Output";
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.SteelBlue;
            btnEncrypt.FlatStyle = FlatStyle.Popup;
            btnEncrypt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.ForeColor = SystemColors.ButtonHighlight;
            btnEncrypt.Location = new Point(38, 194);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(174, 40);
            btnEncrypt.TabIndex = 7;
            btnEncrypt.Text = "Mã hóa";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtInput
            // 
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(6, 61);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(470, 110);
            txtInput.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 32);
            label8.Name = "label8";
            label8.Size = new Size(51, 23);
            label8.TabIndex = 1;
            label8.Text = "Input";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._0f6d6f9ae4ae58928f7ac10b4f174bb3;
            ClientSize = new Size(1080, 673);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "RSA Application";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtE;
        private Label label3;
        private TextBox txtQ;
        private Label label2;
        private TextBox txtP;
        private Label lbPublicKey;
        private TextBox txtPhi;
        private TextBox txtD;
        private TextBox txtN;
        private Button btnCreateKey;
        private Button btnAutoGenerate;
        private Label lbPrivateKey;
        private GroupBox groupBox2;
        private Button btnEncrypt;
        private TextBox txtInput;
        private Label label8;
        private Button btnDecrypt;
        private TextBox txtOutput;
        private Label label4;
        private Button btnChooseFile;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label11;
        private Button btnSaveFile;
        private Label label12;
        private Button btnCLear;
    }
}
