using System;
using System.Linq;
using System.Windows.Forms;
using DaiBase.Models; // Твои модели данных

namespace DaiBase.Forms
{
    public partial class VehicleDetailsForm : Form
    {
        // 1. Создаем поле на уровне класса. Теперь объект доступен во всех методах формы.
        private Vehicle _vehicle;

        public VehicleDetailsForm(Vehicle vehicle)
        {
            InitializeComponent();

            // 2. Сохраняем переданный объект в поле класса
            _vehicle = vehicle;

            // Настраиваем заголовок окна
            this.Text = $"Картка автомобіля: {vehicle.StateNumber}";

            // Присваиваем значения лейблам
            lblStateNumber.Text = vehicle.StateNumber;
            lblBrand.Text = vehicle.Brand;
            lblColor.Text = vehicle.Color;
            lblYear.Text = vehicle.ManufactureYear.ToString();
            lblInspectionDate.Text = vehicle.LastInspectionDate.ToShortDateString();

            lblOwnerName.Text = vehicle.VehicleOwner.FullName;
            lblPassport.Text = vehicle.VehicleOwner.PassportNumber;

            // Проверка на пустые особенности
            lblSpecialFeatures.Text = string.IsNullOrWhiteSpace(vehicle.SpecialFeatures)
                                      ? "Немає"
                                      : vehicle.SpecialFeatures;
        }

        // Кнопка для генерування офіційного повідомлення про необхідність техогляду
        private void btnGenerateNotice_Click(object sender, EventArgs e)
        {
            // Теперь _vehicle доступен здесь без ошибок
            MessageBox.Show(_vehicle.GenerateInspectionNotice(), "Друк документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}