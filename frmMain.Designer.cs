
namespace StoreApplication
{
    partial class frmMain
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
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grdResult = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpNew.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNew
            // 
            this.grpNew.Controls.Add(this.lblId);
            this.grpNew.Controls.Add(this.btnCancel);
            this.grpNew.Controls.Add(this.btnSave);
            this.grpNew.Controls.Add(this.txtSerial);
            this.grpNew.Controls.Add(this.label5);
            this.grpNew.Controls.Add(this.label4);
            this.grpNew.Controls.Add(this.txtColor);
            this.grpNew.Controls.Add(this.txtPrice);
            this.grpNew.Controls.Add(this.label1);
            this.grpNew.Controls.Add(this.txtName);
            this.grpNew.Controls.Add(this.label3);
            this.grpNew.Controls.Add(this.label2);
            this.grpNew.Controls.Add(this.txtCount);
            this.grpNew.Location = new System.Drawing.Point(12, 12);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(562, 237);
            this.grpNew.TabIndex = 0;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "ثبت کالا جدید";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(208, 196);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 18);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(253, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(6, 158);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(432, 26);
            this.txtSerial.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "سریال کالا";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "رنگ کالا";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 126);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(432, 26);
            this.txtColor.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(6, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(432, 26);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کالا";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 26);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "قیمت ( تومان )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد موجودی انبار ";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(6, 61);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(432, 26);
            this.txtCount.TabIndex = 3;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.btnRefresh);
            this.grpList.Controls.Add(this.txtSearch);
            this.grpList.Controls.Add(this.label6);
            this.grpList.Controls.Add(this.btnEdit);
            this.grpList.Controls.Add(this.grdResult);
            this.grpList.Controls.Add(this.btnDelete);
            this.grpList.Location = new System.Drawing.Point(12, 255);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(562, 330);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "لیست کالا های موجود در سیستم";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(492, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "جستجو ";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(6, 281);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grdResult
            // 
            this.grdResult.AllowUserToAddRows = false;
            this.grdResult.AllowUserToDeleteRows = false;
            this.grdResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product_Name,
            this.Product_Count,
            this.Product_Price,
            this.Product_Color,
            this.Product_Serial});
            this.grdResult.Location = new System.Drawing.Point(6, 51);
            this.grdResult.MultiSelect = false;
            this.grdResult.Name = "grdResult";
            this.grdResult.ReadOnly = true;
            this.grdResult.RowHeadersWidth = 51;
            this.grdResult.RowTemplate.DividerHeight = 1;
            this.grdResult.RowTemplate.Height = 30;
            this.grdResult.Size = new System.Drawing.Size(550, 224);
            this.grdResult.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(424, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.HeaderText = "نام کالا";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Count
            // 
            this.Product_Count.DataPropertyName = "Product_Count";
            this.Product_Count.HeaderText = "موجودی انبار";
            this.Product_Count.MinimumWidth = 6;
            this.Product_Count.Name = "Product_Count";
            this.Product_Count.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.DataPropertyName = "Product_Price";
            this.Product_Price.HeaderText = "قیمت - تومان";
            this.Product_Price.MinimumWidth = 6;
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            // 
            // Product_Color
            // 
            this.Product_Color.DataPropertyName = "Product_Color";
            this.Product_Color.HeaderText = "رنگ کالا";
            this.Product_Color.MinimumWidth = 6;
            this.Product_Color.Name = "Product_Color";
            this.Product_Color.ReadOnly = true;
            // 
            // Product_Serial
            // 
            this.Product_Serial.DataPropertyName = "Product_Serial";
            this.Product_Serial.HeaderText = "سریال کالا";
            this.Product_Serial.MinimumWidth = 6;
            this.Product_Serial.Name = "Product_Serial";
            this.Product_Serial.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(208, 281);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "بازگردانی لیست";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(585, 590);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpNew);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کالا های فروشگاه ( ثبت ، ویرایش ، حذف ، جستجو )";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNew;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView grdResult;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Serial;
        private System.Windows.Forms.Button btnRefresh;
    }
}

