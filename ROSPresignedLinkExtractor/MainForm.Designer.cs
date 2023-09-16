namespace ROSPresignedLinkExtractor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.T_Endpoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.T_AccessKey = new System.Windows.Forms.TextBox();
            this.T_SecretKey = new System.Windows.Forms.TextBox();
            this.T_BucketName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.T_ObjectName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.UpDown_ExpireDate = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.T_PresignedLink = new System.Windows.Forms.RichTextBox();
            this.PresignedLinkPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.GeneratePresignedLinkBtn = new System.Windows.Forms.Button();
            this.TipPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Link_ClearAll = new System.Windows.Forms.LinkLabel();
            this.Link_CopyLink = new System.Windows.Forms.LinkLabel();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ExpireDate)).BeginInit();
            this.PresignedLinkPanel.SuspendLayout();
            this.TipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROS Presigned Link Extractor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endpoint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Access Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secret Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bucket Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Object Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Expire Date";
            // 
            // T_Endpoint
            // 
            this.T_Endpoint.Location = new System.Drawing.Point(91, 61);
            this.T_Endpoint.Name = "T_Endpoint";
            this.T_Endpoint.Size = new System.Drawing.Size(292, 29);
            this.T_Endpoint.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Presigned Link";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "API端点";
            // 
            // T_AccessKey
            // 
            this.T_AccessKey.Location = new System.Drawing.Point(104, 96);
            this.T_AccessKey.Name = "T_AccessKey";
            this.T_AccessKey.Size = new System.Drawing.Size(383, 29);
            this.T_AccessKey.TabIndex = 10;
            // 
            // T_SecretKey
            // 
            this.T_SecretKey.Location = new System.Drawing.Point(104, 131);
            this.T_SecretKey.Name = "T_SecretKey";
            this.T_SecretKey.Size = new System.Drawing.Size(383, 29);
            this.T_SecretKey.TabIndex = 11;
            // 
            // T_BucketName
            // 
            this.T_BucketName.Location = new System.Drawing.Point(121, 171);
            this.T_BucketName.Name = "T_BucketName";
            this.T_BucketName.Size = new System.Drawing.Size(366, 29);
            this.T_BucketName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "存储桶名称";
            // 
            // T_ObjectName
            // 
            this.T_ObjectName.Location = new System.Drawing.Point(121, 211);
            this.T_ObjectName.Name = "T_ObjectName";
            this.T_ObjectName.Size = new System.Drawing.Size(366, 29);
            this.T_ObjectName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "对象名称";
            // 
            // UpDown_ExpireDate
            // 
            this.UpDown_ExpireDate.Location = new System.Drawing.Point(121, 251);
            this.UpDown_ExpireDate.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.UpDown_ExpireDate.Name = "UpDown_ExpireDate";
            this.UpDown_ExpireDate.Size = new System.Drawing.Size(294, 29);
            this.UpDown_ExpireDate.TabIndex = 16;
            this.UpDown_ExpireDate.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "到期日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "预签名链接";
            // 
            // T_PresignedLink
            // 
            this.T_PresignedLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_PresignedLink.DetectUrls = false;
            this.T_PresignedLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T_PresignedLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_PresignedLink.Location = new System.Drawing.Point(0, 0);
            this.T_PresignedLink.Name = "T_PresignedLink";
            this.T_PresignedLink.ReadOnly = true;
            this.T_PresignedLink.Size = new System.Drawing.Size(354, 91);
            this.T_PresignedLink.TabIndex = 20;
            this.T_PresignedLink.Text = "";
            // 
            // PresignedLinkPanel
            // 
            this.PresignedLinkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PresignedLinkPanel.Controls.Add(this.T_PresignedLink);
            this.PresignedLinkPanel.Location = new System.Drawing.Point(131, 295);
            this.PresignedLinkPanel.Name = "PresignedLinkPanel";
            this.PresignedLinkPanel.Size = new System.Drawing.Size(356, 93);
            this.PresignedLinkPanel.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(421, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "(单位: 秒)";
            // 
            // GeneratePresignedLinkBtn
            // 
            this.GeneratePresignedLinkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePresignedLinkBtn.Location = new System.Drawing.Point(502, 412);
            this.GeneratePresignedLinkBtn.Name = "GeneratePresignedLinkBtn";
            this.GeneratePresignedLinkBtn.Size = new System.Drawing.Size(156, 35);
            this.GeneratePresignedLinkBtn.TabIndex = 23;
            this.GeneratePresignedLinkBtn.Text = "生成预签名链接";
            this.GeneratePresignedLinkBtn.UseVisualStyleBackColor = true;
            this.GeneratePresignedLinkBtn.Click += new System.EventHandler(this.GeneratePresignedLinkBtn_Click);
            // 
            // TipPanel
            // 
            this.TipPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipPanel.Controls.Add(this.label16);
            this.TipPanel.Controls.Add(this.label15);
            this.TipPanel.Location = new System.Drawing.Point(502, 56);
            this.TipPanel.Name = "TipPanel";
            this.TipPanel.Size = new System.Drawing.Size(242, 348);
            this.TipPanel.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 181);
            this.label16.TabIndex = 1;
            this.label16.Text = "· 请确保存储桶的“公共访问”是关闭的；\r\n· 请合理使用预签名链接；\r\n· API端点不要带有http://或https；\r\n· ObjectName即为所下载" +
    "的文件名称，必要时请带上存储路径；\r\n· 使用该工具所造成的任何后果均由使用者自行承担。";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 21);
            this.label15.TabIndex = 0;
            this.label15.Text = "提示";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(664, 412);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(80, 35);
            this.ExitBtn.TabIndex = 25;
            this.ExitBtn.Text = "退出";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Link_ClearAll
            // 
            this.Link_ClearAll.AutoSize = true;
            this.Link_ClearAll.Location = new System.Drawing.Point(13, 419);
            this.Link_ClearAll.Name = "Link_ClearAll";
            this.Link_ClearAll.Size = new System.Drawing.Size(112, 21);
            this.Link_ClearAll.TabIndex = 26;
            this.Link_ClearAll.TabStop = true;
            this.Link_ClearAll.Text = "清空所有内容";
            this.Link_ClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_ClearAll_LinkClicked);
            // 
            // Link_CopyLink
            // 
            this.Link_CopyLink.AutoSize = true;
            this.Link_CopyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_CopyLink.Location = new System.Drawing.Point(402, 389);
            this.Link_CopyLink.Name = "Link_CopyLink";
            this.Link_CopyLink.Size = new System.Drawing.Size(85, 15);
            this.Link_CopyLink.TabIndex = 27;
            this.Link_CopyLink.TabStop = true;
            this.Link_CopyLink.Text = "复制到剪贴板";
            this.Link_CopyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_CopyLink_LinkClicked);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(389, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "(不带http(s)://)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 459);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Link_CopyLink);
            this.Controls.Add(this.Link_ClearAll);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TipPanel);
            this.Controls.Add(this.GeneratePresignedLinkBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.PresignedLinkPanel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UpDown_ExpireDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.T_ObjectName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.T_BucketName);
            this.Controls.Add(this.T_SecretKey);
            this.Controls.Add(this.T_AccessKey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.T_Endpoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROS Presigned Link Extractor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_ExpireDate)).EndInit();
            this.PresignedLinkPanel.ResumeLayout(false);
            this.TipPanel.ResumeLayout(false);
            this.TipPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox T_Endpoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox T_AccessKey;
        private System.Windows.Forms.TextBox T_SecretKey;
        private System.Windows.Forms.TextBox T_BucketName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox T_ObjectName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown UpDown_ExpireDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox T_PresignedLink;
        private System.Windows.Forms.Panel PresignedLinkPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button GeneratePresignedLinkBtn;
        private System.Windows.Forms.Panel TipPanel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.LinkLabel Link_ClearAll;
        private System.Windows.Forms.LinkLabel Link_CopyLink;
        private System.Windows.Forms.Label label17;
    }
}