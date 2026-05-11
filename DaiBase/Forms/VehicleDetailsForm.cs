using System;
using System.Linq;
using System.Windows.Forms;
using DaiBase.Models;

namespace DaiBase.Forms
{
    public partial class VehicleDetailsForm : Form
    {

        private Vehicle _vehicle;

        public VehicleDetailsForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            this.Text = $"Картка автомобіля: {vehicle.StateNumber}";

            lblStateNumber.Text = vehicle.StateNumber;
            lblBrand.Text = vehicle.Brand;
            lblColor.Text = vehicle.Color;
            lblYear.Text = vehicle.ManufactureYear.ToString();
            lblInspectionDate.Text = vehicle.LastInspectionDate.ToShortDateString();

            lblOwnerName.Text = vehicle.VehicleOwner.FullName;
            lblPassport.Text = vehicle.VehicleOwner.PassportNumber;

            lblSpecialFeatures.Text = string.IsNullOrWhiteSpace(vehicle.SpecialFeatures)
                                      ? "Немає"
                                      : vehicle.SpecialFeatures;
        }
        private void btnGenerateNotice_Click(object sender, EventArgs e)
        {

            MessageBox.Show(_vehicle.GenerateInspectionNotice(), "Друк документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}