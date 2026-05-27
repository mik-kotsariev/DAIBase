using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DaiBase.Models;

namespace DaiBase.Forms
{
    // Форма для додавання або редагування транспортного засобу
    public partial class VehicleForm : Form
    {
        private Vehicle? _vehicle;

        public VehicleForm()
        {
            InitializeComponent();
            this.Text = "Реєстрація транспортного засобу";

            cmbVehicleType.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        public VehicleForm(Vehicle vehicle) : this()
        {
            _vehicle = vehicle;
            this.Text = "Редагування даних";

            txtStateNumber.Text = vehicle.StateNumber;
            txtBrand.Text = vehicle.Brand;
            txtColor.Text = vehicle.Color;
            txtSpecialFeatures.Text = vehicle.SpecialFeatures;
            txtYear.Text = vehicle.ManufactureYear.ToString();
            txtOwnerName.Text = vehicle.VehicleOwner.FullName;
            txtPassportNumber.Text = vehicle.VehicleOwner.PassportNumber;

            cmbVehicleType.SelectedItem = vehicle.Type;
            // Встановлення дати останнього технічного огляду, якщо вона в межах допустимого діапазону
            if (vehicle.LastInspectionDate >= dateTimePicker1.MinDate && vehicle.LastInspectionDate <= dateTimePicker1.MaxDate)
            {
                dateTimePicker1.Value = vehicle.LastInspectionDate;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }

            txtStateNumber.ReadOnly = true;
        }

        public Vehicle? ResultVehicle => _vehicle;
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //перевірка року виробництва
                if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Введіть коректний рік!");
                    return;
                }

                //перевірка формату номера
                string numberPattern = @"^[А-ЯІЇЄA-Z]{2}\s?\d{4}\s?[А-ЯІЇЄA-Z]{2}$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtStateNumber.Text.ToUpper(), numberPattern))
                {
                    MessageBox.Show("Держ. номер має бути у форматі 'АХ 1234 СВ' або 'АХ1234СВ'.", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //перевірка формату паспорта
                string passportNumberPattern = @"^(\d{6})$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPassportNumber.Text, passportNumberPattern))
                {
                    MessageBox.Show("Номер документа має містити 6 цифр ", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_vehicle == null) _vehicle = new Vehicle { VehicleOwner = new Owner() };

                _vehicle.StateNumber = txtStateNumber.Text.ToUpper();
                _vehicle.Brand = txtBrand.Text;
                _vehicle.Color = txtColor.Text;
                _vehicle.SpecialFeatures = txtSpecialFeatures.Text;
                _vehicle.ManufactureYear = year;
                _vehicle.VehicleOwner.FullName = txtOwnerName.Text;
                _vehicle.VehicleOwner.PassportNumber = txtPassportNumber.Text;
                if (cmbVehicleType.SelectedItem != null)
                {
                    _vehicle.Type = (VehicleType)cmbVehicleType.SelectedItem;
                }
                _vehicle.LastInspectionDate = dateTimePicker1.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}