namespace DaiBase.Forms
{
    partial class VehicleForm
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
            label1 = new Label();
            txtStateNumber = new TextBox();
            txtBrand = new TextBox();
            txtOwnerName = new TextBox();
            txtYear = new TextBox();
            txtColor = new TextBox();
            txtSpecialFeatures = new TextBox();
            txtPassportNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cmbVehicleType = new ComboBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 13);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Держ. номер";
            // 
            // txtStateNumber
            // 
            txtStateNumber.Location = new Point(347, 5);
            txtStateNumber.Name = "txtStateNumber";
            txtStateNumber.Size = new Size(209, 23);
            txtStateNumber.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(347, 34);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(209, 23);
            txtBrand.TabIndex = 2;
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(347, 150);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(209, 23);
            txtOwnerName.TabIndex = 3;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(347, 121);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(209, 23);
            txtYear.TabIndex = 4;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(347, 63);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(209, 23);
            txtColor.TabIndex = 5;
            // 
            // txtSpecialFeatures
            // 
            txtSpecialFeatures.Location = new Point(347, 92);
            txtSpecialFeatures.Name = "txtSpecialFeatures";
            txtSpecialFeatures.Size = new Size(209, 23);
            txtSpecialFeatures.TabIndex = 6;
            // 
            // txtPassportNumber
            // 
            txtPassportNumber.Location = new Point(347, 179);
            txtPassportNumber.Name = "txtPassportNumber";
            txtPassportNumber.Size = new Size(209, 23);
            txtPassportNumber.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 42);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Марка авто";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 71);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Колір";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 129);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Рік випуску";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 158);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 12;
            label5.Text = "ПІБ власника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 100);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 13;
            label6.Text = "Особливості авто";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(227, 187);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 14;
            label7.Text = "Номер паспорта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(227, 245);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 15;
            label8.Text = "Дата техогляду";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(250, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Location = new Point(432, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Location = new Point(347, 208);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(209, 23);
            cmbVehicleType.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(227, 216);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 19;
            label9.Text = "Тип ТЗ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(347, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(209, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 457);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(cmbVehicleType);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassportNumber);
            Controls.Add(txtSpecialFeatures);
            Controls.Add(txtColor);
            Controls.Add(txtYear);
            Controls.Add(txtOwnerName);
            Controls.Add(txtBrand);
            Controls.Add(txtStateNumber);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VehicleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Особливості авто";
            Load += VehicleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStateNumber;
        private TextBox txtBrand;
        private TextBox txtOwnerName;
        private TextBox txtYear;
        private TextBox txtColor;
        private TextBox txtSpecialFeatures;
        private TextBox txtPassportNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbVehicleType;
        private Label label9;
        private DateTimePicker dateTimePicker1;
    }
}