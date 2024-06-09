using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApplication
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            // تنظیم فونت و سایز لیبل
            label1.Font = new Font("B nazanin", 24, FontStyle.Bold); // شما می‌توانید هر فونتی را که می‌خواهید انتخاب کنید

            // تنظیم رنگ پس‌زمینه
            label1.BackColor = Color.Green;

            // تنظیم رنگ متن (در صورت نیاز)
            label1.ForeColor = Color.White;

            // تنظیم AutoSize به false در صورت نیاز به تنظیم اندازه دستی
            label1.AutoSize = false;

            // تنظیم اندازه لیبل
            label1.Size = new Size(500, 50); // اندازه دلخواه خود را تنظیم کنید
                                             // قرار دادن لیبل در وسط فرم
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Optional: if you want to keep the minimize button
        }
    }
}
