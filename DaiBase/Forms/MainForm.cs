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
            UpdateBrandsComboBox();
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
            string searchNumber = txtSearchNumber.Text;
            string searchOwner = txtSearchOwner.Text;

            string searchBrand = cmbSearchBrand.SelectedItem?.ToString() ?? "";

            if (searchBrand == "Усі марки")
            {
                searchBrand = "";
            }

            var searchResults = _repository.SearchVehicles(searchNumber, searchOwner, searchBrand);


            UpdateGrid(searchResults);
        }

        private void txtSearchNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOverdue_Click(object sender, EventArgs e)
        {

            var overdueVehicles = _repository.GetAll()
                .Where(v => v.IsInspectionOverdue)
                .ToList();

            UpdateGrid(overdueVehicles);

            if (overdueVehicles.Count == 0)
            {
                MessageBox.Show("Машин з простроченим ТО (більше 2 років) не знайдено.", "Інформація");
            }
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
            if (dgvVehicles.CurrentRow != null)
            {
                string stateNumber = dgvVehicles.CurrentRow.Cells["Номер"].Value?.ToString() ?? "";

                var vehicleToEdit = _repository.GetAll().FirstOrDefault(v => v.StateNumber == stateNumber);

                if (vehicleToEdit != null)
                {
                    VehicleForm editForm = new VehicleForm(vehicleToEdit);

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        _repository.UpdateVehicle();
                        UpdateGrid(_repository.GetAll());
                        MessageBox.Show("Дані успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль у списку для редагування.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBrandsComboBox()
        {

            var brands = _repository.GetAll()
                .Select(v => v.Brand)
                .Where(b => !string.IsNullOrWhiteSpace(b))
                .Distinct()
                .OrderBy(b => b)
                .ToList();
            brands.Insert(0, "Усі марки");

            cmbSearchBrand.DataSource = brands;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null)
            {
                string stateNumber = dgvVehicles.CurrentRow.Cells["Номер"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(stateNumber)) return;

                var result = MessageBox.Show(
                    $"Ви впевнені, що хочете видалити автомобіль з номером {stateNumber}?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _repository.DeleteVehicle(stateNumber);

                    UpdateGrid(_repository.GetAll());
                    UpdateBrandsComboBox();

                    MessageBox.Show("Запис успішно видалено.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, спочатку виберіть рядок у таблиці.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (dgvVehicles.CurrentRow != null)
            {
                string stateNumber = dgvVehicles.CurrentRow.Cells["Номер"].Value?.ToString() ?? "";

                var vehicle = _repository.GetAll().FirstOrDefault(v => v.StateNumber == stateNumber);

                if (vehicle != null)
                {

                    VehicleDetailsForm detailsForm = new VehicleDetailsForm(vehicle);
                    detailsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль для перегляду.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerateNotice_Click(object sender, EventArgs e)
        {
            string stateNumber = dgvVehicles.CurrentRow?.Cells["Номер"].Value?.ToString() ?? "";
            var vehicle = _repository.GetAll().FirstOrDefault(v => v.StateNumber == stateNumber);

            if (vehicle != null)
            {
                string noticeText = vehicle.GenerateInspectionNotice();

                MessageBox.Show(noticeText, "Друк документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFindAllOwnerCars_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.CurrentRow != null)
            {
                string stateNumber = dgvVehicles.CurrentRow.Cells["Номер"].Value?.ToString() ?? "";
                var vehicle = _repository.GetAll().FirstOrDefault(v => v.StateNumber == stateNumber);

                if (vehicle != null)
                {

                    txtSearchOwner.Text = vehicle.VehicleOwner.FullName;


                    txtSearchNumber.Text = "";
                    cmbSearchBrand.SelectedIndex = 0; 

                    btnSearch.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Виберіть автомобіль, щоб знайти інші авто цього власника.");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateGrid(_repository.GetAll());
        }

        
    }
}