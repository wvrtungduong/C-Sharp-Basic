namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new Label();
            txtCarID = new TextBox();
            btnLoad = new Button();
            dgvCarList = new DataGridView();
            txtCarName = new TextBox();
            lbCarName = new Label();
            txtManufacturer = new TextBox();
            lbManufacturer = new Label();
            txtReleaseYear = new TextBox();
            lbReleaseYear = new Label();
            txtPrice = new TextBox();
            lbPrice = new Label();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(24, 35);
            lbCarID.Margin = new Padding(2, 0, 2, 0);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(36, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(122, 32);
            txtCarID.Margin = new Padding(2);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(153, 23);
            txtCarID.TabIndex = 1;
            txtCarID.TextChanged += txtCarID_TextChanged;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(122, 113);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(78, 20);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(11, 137);
            dgvCarList.Margin = new Padding(2);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(543, 133);
            dgvCarList.TabIndex = 3;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(122, 59);
            txtCarName.Margin = new Padding(2);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(153, 23);
            txtCarName.TabIndex = 5;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(24, 62);
            lbCarName.Margin = new Padding(2, 0, 2, 0);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 4;
            lbCarName.Text = "Car Name";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(122, 86);
            txtManufacturer.Margin = new Padding(2);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(153, 23);
            txtManufacturer.TabIndex = 7;
            txtManufacturer.TextChanged += txtManufacturer_TextChanged;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(24, 89);
            lbManufacturer.Margin = new Padding(2, 0, 2, 0);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 6;
            lbManufacturer.Text = "Manufacturer";
            lbManufacturer.Click += lbManufacturer_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(382, 59);
            txtReleaseYear.Margin = new Padding(2);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(141, 23);
            txtReleaseYear.TabIndex = 11;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(290, 62);
            lbReleaseYear.Margin = new Padding(2, 0, 2, 0);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 10;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(382, 32);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(141, 23);
            txtPrice.TabIndex = 9;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(289, 35);
            lbPrice.Margin = new Padding(2, 0, 2, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 8;
            lbPrice.Text = "Price";
            lbPrice.Click += lbPrice_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(244, 113);
            btnNew.Margin = new Padding(2);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 20);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(369, 113);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 20);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(244, 274);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 20);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 301);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(lbCarName);
            Controls.Add(dgvCarList);
            Controls.Add(btnLoad);
            Controls.Add(txtCarID);
            Controls.Add(lbCarID);
            Margin = new Padding(2);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarID;
        private Button btnLoad;
        private DataGridView dgvCarList;
        private TextBox txtCarName;
        private Label lbCarName;
        private TextBox txtManufacturer;
        private Label lbManufacturer;
        private TextBox txtReleaseYear;
        private Label lbReleaseYear;
        private TextBox txtPrice;
        private Label lbPrice;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
    }
}