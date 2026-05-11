using DaiBase.Forms;
using DaiBase.Models;
using DaiBase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DaiBase
{
    public partial class MainForm : Form
    {
        private VehicleRepository _repository;

        public MainForm()
        {
            InitializeComponent();

            _repository = new VehicleRepository();

            UpdateGrid(_repository.GetAll());
        }

        private void UpdateGrid(List<Vehicle> vehicles)
        {
            dgvVehicles.DataSource = null;

            dgvVehicles.DataSource = vehicles.Select(v => new
            {
                Номер = v.StateNumber,
                Марка = v.Brand,
                Колір = v.Color,
                Власник = v.VehicleOwner?.FullName,
                Техогляд = v.LastInspectionDate.ToShortDateString()
            }).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = _repository.SearchVehicles(txtSearchNumber.Text, txtSearchOwner.Text, cmbSearchBrand.Text);
            UpdateGrid(result);
        }

        private void txtSearchNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {
            var result = _repository.GetOverdueInspections();
            UpdateGrid(result);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VehicleForm form = new VehicleForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var newVehicle = form.ResultVehicle;

                if (newVehicle != null)
                {
                    _repository.AddVehicle(newVehicle);
                    UpdateGrid(_repository.GetAll());
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}