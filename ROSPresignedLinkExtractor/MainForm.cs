using Minio;
using Minio.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROSPresignedLinkExtractor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ResetControl()
        {
            T_Endpoint.Text = "";
            T_AccessKey.Text = "";
            T_SecretKey.Text = "";
            T_BucketName.Text = "";
            T_ObjectName.Text = "";
            UpDown_ExpireDate.Value = 60;
            T_PresignedLink.Text = "";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetControl();
        }
        private async void GeneratePresignedLinkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string EndPoint = T_Endpoint.Text;
                string AccessKey = T_AccessKey.Text;
                string SecretKey = T_SecretKey.Text;

                string BucketName = T_BucketName.Text;
                string ObjectName = T_ObjectName.Text;
                int ExpireDate = (int)UpDown_ExpireDate.Value;

                MinioClient minioClient = new MinioClient()
                   .WithEndpoint(EndPoint)
                   .WithCredentials(AccessKey, SecretKey)
                   .WithSSL()
                   .Build();

                PresignedGetObjectArgs args = new PresignedGetObjectArgs()
                   .WithBucket(BucketName)
                   .WithObject(ObjectName)
                   .WithExpiry(ExpireDate);

                string url = await minioClient.PresignedGetObjectAsync(args);
                T_PresignedLink.Text = url;
            }
            catch (Exception ex)
            {
                MessageBox.Show("生成时发生错误。错误内容如下：\n\n" + ex.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Link_ClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetControl();
        }

        private void Link_CopyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(T_PresignedLink.Text);
        }
    }
}
