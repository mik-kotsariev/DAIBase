namespace DaiBase
{
    partial class MainForm
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
            dgvVehicles = new DataGridView();
            txtSearchNumber = new TextBox();
            txtSearchOwner = new TextBox();
            cmbSearchBrand = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnOverdue = new Button();
            btnSearch = new Button();
            StateNumber = new Label();
            ПІБ = new Label();
            model = new Label();
            btnDelete = new Button();
            btnDetails = new Button();
            btnFindAllOwnerCars = new Button();
            btnGenerateNotice = new Button();
            groupBox1 = new GroupBox();
            btnShowAll = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehicles
            // 
            dgvVehicles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(12, 227);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.Size = new Size(735, 245);
            dgvVehicles.TabIndex = 0;
            dgvVehicles.CellContentClick += dgvVehicles_CellContentClick;
            // 
            // txtSearchNumber
            // 
            txtSearchNumber.Location = new Point(283, 22);
            txtSearchNumber.Name = "txtSearchNumber";
            txtSearchNumber.Size = new Size(163, 23);
            txtSearchNumber.TabIndex = 1;
            txtSearchNumber.TextChanged += txtSearchNumber_TextChanged;
            // 
            // txtSearchOwner
            // 
            txtSearchOwner.Location = new Point(283, 51);
            txtSearchOwner.Name = "txtSearchOwner";
            txtSearchOwner.Size = new Size(163, 23);
            txtSearchOwner.TabIndex = 2;
            // 
            // cmbSearchBrand
            // 
            cmbSearchBrand.FormattingEnabled = true;
            cmbSearchBrand.Location = new Point(283, 80);
            cmbSearchBrand.Name = "cmbSearchBrand";
            cmbSearchBrand.Size = new Size(163, 23);
            cmbSearchBrand.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(55, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(67, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редагувати ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnOverdue
            // 
            btnOverdue.Location = new Point(223, 22);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(101, 23);
            btnOverdue.TabIndex = 7;
            btnOverdue.Text = "Просрочені ТО";
            btnOverdue.UseVisualStyleBackColor = true;
            btnOverdue.Click += btnOverdue_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(371, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Пошук";
            btnSearch.Click += btnSearch_Click;
            // 
            // StateNumber
            // 
            StateNumber.AutoSize = true;
            StateNumber.Location = new Point(159, 30);
            StateNumber.Name = "StateNumber";
            StateNumber.Size = new Size(109, 15);
            StateNumber.TabIndex = 9;
            StateNumber.Text = "Державний номер";
            // 
            // ПІБ
            // 
            ПІБ.AutoSize = true;
            ПІБ.Location = new Point(159, 59);
            ПІБ.Name = "ПІБ";
            ПІБ.Size = new Size(84, 15);
            ПІБ.TabIndex = 10;
            ПІБ.Text = "ПІБ Власника ";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Location = new Point(159, 88);
            model.Name = "model";
            model.Size = new Size(70, 15);
            model.TabIndex = 11;
            model.Text = "Марка авто";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(148, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(633, 22);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 23);
            btnDetails.TabIndex = 12;
            btnDetails.Text = "Картка авто";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnFindAllOwnerCars
            // 
            btnFindAllOwnerCars.Location = new Point(508, 22);
            btnFindAllOwnerCars.Name = "btnFindAllOwnerCars";
            btnFindAllOwnerCars.Size = new Size(119, 23);
            btnFindAllOwnerCars.TabIndex = 13;
            btnFindAllOwnerCars.Text = "Усі авто власника";
            btnFindAllOwnerCars.UseVisualStyleBackColor = true;
            btnFindAllOwnerCars.Click += btnFindAllOwnerCars_Click;
            // 
            // btnGenerateNotice
            // 
            btnGenerateNotice.Location = new Point(330, 22);
            btnGenerateNotice.Name = "btnGenerateNotice";
            btnGenerateNotice.Size = new Size(178, 23);
            btnGenerateNotice.TabIndex = 14;
            btnGenerateNotice.Text = "Надіслати запрошення на ТО ";
            btnGenerateNotice.UseVisualStyleBackColor = true;
            btnGenerateNotice.Click += btnGenerateNotice_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnFindAllOwnerCars);
            groupBox1.Controls.Add(btnGenerateNotice);
            groupBox1.Controls.Add(btnDetails);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnOverdue);
            groupBox1.Location = new Point(12, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 48);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дії з реєстром авто";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(290, 109);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 16;
            btnShowAll.Text = "Усі авто ";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 484);
            Controls.Add(btnShowAll);
            Controls.Add(groupBox1);
            Controls.Add(model);
            Controls.Add(ПІБ);
            Controls.Add(StateNumber);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearchBrand);
            Controls.Add(txtSearchOwner);
            Controls.Add(txtSearchNumber);
            Controls.Add(dgvVehicles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довыник працывника ДАІ";
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVehicles;
        private TextBox txtSearchNumber;
        private TextBox txtSearchOwner;
        private ComboBox cmbSearchBrand;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnOverdue;
        private Button btnSearch;
        private Label StateNumber;
        private Label ПІБ;
        private Label model;
        private Button btnDelete;
        private Button btnDetails;
        private Button btnFindAllOwnerCars;
        private Button btnGenerateNotice;
        private GroupBox groupBox1;
        private Button btnShowAll;
    }
}
