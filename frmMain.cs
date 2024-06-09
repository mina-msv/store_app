using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreApplication.Models;
namespace StoreApplication
{
    public partial class frmMain : Form
    {
        private Models.StoreDBEntities db = new StoreDBEntities();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Bind_Grd();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpNew.Text = "ثبت کالا جدید";
            lblId.Text = "0";
            txtColor.Text = "";
            txtCount.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtSerial.Text = "";
            txtSearch.Text = "";
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("نام کالا را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCount.Text))
            {
                MessageBox.Show("تعداد کالا را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCount.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("قیمت کالا را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                MessageBox.Show("سریال کالا را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSerial.Focus();
                return;
            }
            try
            {
                Models.Products products = new Products();
                if (!string.IsNullOrWhiteSpace(txtColor.Text))
                    products.Product_Color = txtColor.Text;
                products.Product_Count = Convert.ToInt32(txtCount.Text.Replace(",", ""));
                products.Product_Name = txtName.Text;
                products.Product_Price = Convert.ToInt64(txtPrice.Text.Replace(",", ""));
                products.Product_Serial = txtSerial.Text;
                if (lblId.Text == "0")
                {
                    // insert mode
                    if (db.Products.Where(x => x.Product_Serial == products.Product_Serial).Count() != 0)
                    {
                        MessageBox.Show("سریال کالا تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSerial.Text = "";
                        txtSerial.Focus();
                        return;
                    }
                    db.Products.Add(products);
                    db.SaveChanges();
                    MessageBox.Show("با موفقیت ذخیره گردید", "ذخیره", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // update mode
                    int id = Convert.ToInt32(lblId.Text);
                    var query = db.Products.Where(x => x.Id == id).FirstOrDefault();
                    if (query == null)
                    {
                        MessageBox.Show("موردی یافت نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (db.Products.Where(x => x.Product_Serial == products.Product_Serial && x.Id != query.Id).Count() != 0)
                    {
                        MessageBox.Show("سریال کالا تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSerial.Text = "";
                        return;
                    }
                    query.Product_Color = products.Product_Color;
                    query.Product_Count = products.Product_Count;
                    query.Product_Name = products.Product_Name;
                    query.Product_Price = products.Product_Price;
                    query.Product_Serial = products.Product_Serial;
                    db.SaveChanges();
                    MessageBox.Show("با موفقیت ویرایش گردید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Bind_Grd();
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdResult.Rows.Count == 0)
            {
                MessageBox.Show("موردی یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = Convert.ToInt32(grdResult.CurrentRow.Cells["Id"].Value.ToString());
                var query = db.Products.Where(x => x.Id == id).FirstOrDefault();
                lblId.Text = query.Id.ToString();
                txtColor.Text = query.Product_Color;
                txtCount.Text = query.Product_Count.ToString("N0");
                txtName.Text = query.Product_Name;
                txtPrice.Text = query.Product_Price.ToString("N0");
                txtSerial.Text = query.Product_Serial;
                grpNew.Text = "ویرایش کالا ( " + query.Product_Name + "- " + query.Product_Serial + " ) ";

                txtName.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdResult.Rows.Count == 0)
            {
                MessageBox.Show("موردی یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("آیا برای حذف اطمینان دارید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                int id = Convert.ToInt32(grdResult.CurrentRow.Cells["Id"].Value.ToString());
                var query = db.Products.Where(x => x.Id == id).FirstOrDefault();
                db.Products.Remove(query);
                db.SaveChanges();
                MessageBox.Show("با موفقیت حذف گردید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bind_Grd();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Bind_Grd();
        }

        private void Bind_Grd()
        {
            grdResult.AutoGenerateColumns = false;
            grdResult.DataSource = null;
            grdResult.Rows.Clear();
            IEnumerable<Models.Products> products = null;
            try
            {
                products = db.Products;
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    products = products.Where(x => x.Product_Name.Contains(txtSearch.Text) || x.Product_Serial.Contains(txtSearch.Text) || x.Product_Color.Contains(txtSearch.Text));

                var result = products.OrderBy(x => x.Product_Name).ToList();
                if (result == null || result.Count == 0)
                    return;

                grdResult.Rows.Add(result.Count());
                for (int i = 0; i < result.Count; i++)
                {
                    grdResult.Rows[i].Cells["Id"].Value = result[i].Id;
                    grdResult.Rows[i].Cells["Product_Name"].Value = result[i].Product_Name;
                    grdResult.Rows[i].Cells["Product_Count"].Value = result[i].Product_Count.ToString("N0");
                    grdResult.Rows[i].Cells["Product_Price"].Value = result[i].Product_Price.ToString("N0");
                    grdResult.Rows[i].Cells["Product_Color"].Value = result[i].Product_Color;
                    grdResult.Rows[i].Cells["Product_Serial"].Value = result[i].Product_Serial;
                    if (i % 2 != 0)
                    {
                        grdResult.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#E3E3E3");

                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "حطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCount.Text == "")
                    return;
                int count;
                count = int.Parse(txtCount.Text, System.Globalization.NumberStyles.Currency);
                txtCount.Text = count.ToString("#,#");
                txtCount.SelectionStart = txtCount.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCount.Text = string.Empty;
                txtCount.Focus();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Text == "")
                    return;
                long price;
                price = long.Parse(txtPrice.Text, System.Globalization.NumberStyles.Currency);
                txtPrice.Text = price.ToString("#,#");
                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Text = string.Empty;
                txtPrice.Focus();
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            Bind_Grd();
        }
    }
}
