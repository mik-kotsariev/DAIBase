using System;
using System.Windows.Forms;
using DaiBase.Models;

namespace DaiBase.Forms
{
    public partial class VehicleForm : Form
    {
        private Vehicle? _vehicle;

        public VehicleForm()
        {
            InitializeComponent();
            this.Text = "Реєстрація транспортного засобу";
        }

        public VehicleForm(Vehicle vehicle) : this() 
        {
            _vehicle = vehicle;
            this.Text = "Редагування даних";

            txtStateNumber.Text = vehicle.StateNumber;
            txtBrand.Text = vehicle.Brand;
            txtColor.Text = vehicle.Color;
            txtYear.Text = vehicle.ManufactureYear.ToString();
            txtOwnerName.Text = vehicle.VehicleOwner.FullName;
            txtPassportSeries.Text = vehicle.VehicleOwner.PassportSeries;
            txtPassportNumber.Text = vehicle.VehicleOwner.PassportNumber;
            dateTimePicker1.Value = vehicle.LastInspectionDate;

            txtStateNumber.ReadOnly = true;
        }

        public Vehicle? ResultVehicle => _vehicle;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Введіть коректний рік!");
                    return;
                }

                if (_vehicle == null) _vehicle = new Vehicle { VehicleOwner = new Owner() };

                _vehicle.StateNumber = txtStateNumber.Text;
                _vehicle.Brand = txtBrand.Text;
                _vehicle.Color = txtColor.Text;
                _vehicle.ManufactureYear = year;
                _vehicle.LastInspectionDate = dateTimePicker1.Value;
                _vehicle.VehicleOwner.FullName = txtOwnerName.Text;
                _vehicle.VehicleOwner.PassportSeries = txtPassportSeries.Text;
                _vehicle.VehicleOwner.PassportNumber = txtPassportNumber.Text;

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
    }
}