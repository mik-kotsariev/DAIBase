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
            btnDelete = new Button();
            btnOverdue = new Button();
            btnSearch = new Button();
            StateNumber = new Label();
            ПІБ = new Label();
            model = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // dgvVehicles
            // 
            dgvVehicles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Location = new Point(24, 227);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.Size = new Size(616, 244);
            dgvVehicles.TabIndex = 0;
            dgvVehicles.CellContentClick += dgvVehicles_CellContentClick;
            // 
            // txtSearchNumber
            // 
            txtSearchNumber.Location = new Point(156, 12);
            txtSearchNumber.Name = "txtSearchNumber";
            txtSearchNumber.Size = new Size(163, 23);
            txtSearchNumber.TabIndex = 1;
            txtSearchNumber.TextChanged += txtSearchNumber_TextChanged;
            // 
            // txtSearchOwner
            // 
            txtSearchOwner.Location = new Point(156, 41);
            txtSearchOwner.Name = "txtSearchOwner";
            txtSearchOwner.Size = new Size(163, 23);
            txtSearchOwner.TabIndex = 2;
            // 
            // cmbSearchBrand
            // 
            cmbSearchBrand.FormattingEnabled = true;
            cmbSearchBrand.Location = new Point(156, 70);
            cmbSearchBrand.Name = "cmbSearchBrand";
            cmbSearchBrand.Size = new Size(163, 23);
            cmbSearchBrand.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(105, 198);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Редагувати ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(186, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnOverdue
            // 
            btnOverdue.Location = new Point(267, 198);
            btnOverdue.Name = "btnOverdue";
            btnOverdue.Size = new Size(101, 23);
            btnOverdue.TabIndex = 7;
            btnOverdue.Text = "Просрочені ТО";
            btnOverdue.UseVisualStyleBackColor = true;
            btnOverdue.Click += btnOverdue_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(244, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Пошук";
            btnSearch.Click += btnSearch_Click;
            // 
            // StateNumber
            // 
            StateNumber.AutoSize = true;
            StateNumber.Location = new Point(32, 20);
            StateNumber.Name = "StateNumber";
            StateNumber.Size = new Size(109, 15);
            StateNumber.TabIndex = 9;
            StateNumber.Text = "Державний номер";
            // 
            // ПІБ
            // 
            ПІБ.AutoSize = true;
            ПІБ.Location = new Point(32, 49);
            ПІБ.Name = "ПІБ";
            ПІБ.Size = new Size(84, 15);
            ПІБ.TabIndex = 10;
            ПІБ.Text = "ПІБ Власника ";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Location = new Point(32, 78);
            model.Name = "model";
            model.Size = new Size(70, 15);
            model.TabIndex = 11;
            model.Text = "Марка авто";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 483);
            Controls.Add(model);
            Controls.Add(ПІБ);
            Controls.Add(StateNumber);
            Controls.Add(btnSearch);
            Controls.Add(btnOverdue);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbSearchBrand);
            Controls.Add(txtSearchOwner);
            Controls.Add(txtSearchNumber);
            Controls.Add(dgvVehicles);
            Name = "MainForm";
            Text = "Довыник працывника ДАІ";
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
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
        private Button btnDelete;
        private Button btnOverdue;
        private Button btnSearch;
        private Label StateNumber;
        private Label ПІБ;
        private Label model;
    }
}
