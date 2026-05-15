namespace DaiBase.Forms
{
    partial class VehicleDetailsForm
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
            groupBox1 = new GroupBox();
            lblYear = new Label();
            lblColor = new Label();
            label6 = new Label();
            label5 = new Label();
            lblBrand = new Label();
            lblStateNumber = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnGenerateNotice = new Button();
            lblSpecialFeatures = new Label();
            lblInspectionDate = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            lblPassport = new Label();
            lblOwnerName = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblBrand);
            groupBox1.Controls.Add(lblStateNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(232, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація про ТЗ";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(133, 98);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(31, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "(Рік)";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(133, 74);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(46, 15);
            lblColor.TabIndex = 6;
            lblColor.Text = "(Колір)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 98);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Рік випуску:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Колір:";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(133, 49);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 15);
            lblBrand.TabIndex = 3;
            lblBrand.Text = "(Марка)";
            // 
            // lblStateNumber
            // 
            lblStateNumber.AutoSize = true;
            lblStateNumber.Location = new Point(133, 23);
            lblStateNumber.Name = "lblStateNumber";
            lblStateNumber.Size = new Size(69, 15);
            lblStateNumber.TabIndex = 2;
            lblStateNumber.Text = "AA 0000 AA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Марка авто:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Державний номер:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btnGenerateNotice);
            groupBox2.Controls.Add(lblSpecialFeatures);
            groupBox2.Controls.Add(lblInspectionDate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(232, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 89);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сервісна інформація";
            // 
            // btnGenerateNotice
            // 
            btnGenerateNotice.Location = new Point(0, 66);
            btnGenerateNotice.Name = "btnGenerateNotice";
            btnGenerateNotice.Size = new Size(344, 23);
            btnGenerateNotice.TabIndex = 4;
            btnGenerateNotice.Text = "Надіслати запрошння на ТО";
            btnGenerateNotice.UseVisualStyleBackColor = true;
            btnGenerateNotice.Click += btnGenerateNotice_Click;
            // 
            // lblSpecialFeatures
            // 
            lblSpecialFeatures.AutoSize = true;
            lblSpecialFeatures.Location = new Point(146, 48);
            lblSpecialFeatures.Name = "lblSpecialFeatures";
            lblSpecialFeatures.Size = new Size(49, 15);
            lblSpecialFeatures.TabIndex = 3;
            lblSpecialFeatures.Text = "(немає)";
            // 
            // lblInspectionDate
            // 
            lblInspectionDate.AutoSize = true;
            lblInspectionDate.Location = new Point(146, 19);
            lblInspectionDate.Name = "lblInspectionDate";
            lblInspectionDate.Size = new Size(61, 15);
            lblInspectionDate.TabIndex = 2;
            lblInspectionDate.Text = "01.01.2000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 48);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 1;
            label4.Text = "Особливості авто:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 19);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 0;
            label3.Text = "Дата останнього ТО:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblPassport);
            groupBox3.Controls.Add(lblOwnerName);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(232, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(344, 71);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Дані власника";
            // 
            // lblPassport
            // 
            lblPassport.AutoSize = true;
            lblPassport.Location = new Point(146, 44);
            lblPassport.Name = "lblPassport";
            lblPassport.Size = new Size(43, 15);
            lblPassport.TabIndex = 3;
            lblPassport.Text = "000000";
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(146, 19);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(80, 15);
            lblOwnerName.TabIndex = 2;
            lblOwnerName.Text = "Прізвище І.Б.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 44);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 1;
            label8.Text = "Номер паспорта:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 19);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 0;
            label7.Text = "ПІБ власника:";
            // 
            // VehicleDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VehicleDetailsForm";
            Text = "Детальна інформація про авто ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblYear;
        private Label lblColor;
        private Label label6;
        private Label label5;
        private Label lblBrand;
        private Label lblStateNumber;
        private Label label2;
        private Label label1;
        private Label lblSpecialFeatures;
        private Label lblInspectionDate;
        private Label label4;
        private Label label3;
        private Label lblPassport;
        private Label lblOwnerName;
        private Label label8;
        private Label label7;
        private Button btnGenerateNotice;
    }
}