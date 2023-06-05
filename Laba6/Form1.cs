using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal sum = Operator.GetInstance().GetSum();
            label9.Text = $"Суммарная стоимость услуг: \n{sum} рублей";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = fareNameTextBox.Text.Trim();
            if (Operator.GetInstance().FareNamesStringList.Contains(name)) 
            {
                SpawnErrorBox("Тариф с таким названием уже существует");
                return;
            }
            if (decimal.TryParse(farePriceTextBox.Text.Trim(), out decimal value) && value > 0)
            {
                Operator.GetInstance().AddFare(name, value);
                fareListBox.DataSource = Operator.GetInstance().FareStringList;
                fareComboBox.DataSource = Operator.GetInstance().FareNamesStringList;
            } else
            {
                SpawnErrorBox("В поле \"Стоимость\" нужно ввести положительное число");
            }
        }

        private void SpawnErrorBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            if (Operator.GetInstance().ClientNamesStringList.Contains(name))
            {
                SpawnErrorBox("Клиент с таким именем уже существует");
                return;
            }
            string fareName = fareComboBox.Text.Trim();
            if (!Operator.GetInstance().FareNamesStringList.Contains(fareName))
            {
                SpawnErrorBox("Тариф с таким именем не найден");
                return;
            }

            if (decimal.TryParse(usedTrafficTextBox.Text.Trim(), out decimal usedTraffic) && usedTraffic > 0)
            {
                if (discountCheckBox.Checked)
                {
                    if (decimal.TryParse(discountTextBox.Text.Trim(), out decimal discount) && discount >= 0 && discount <= 100)
                    {
                        Operator.GetInstance().AddClient(name, usedTraffic, fareName, true, discount);
                    } else
                    {
                        SpawnErrorBox("В поле \"Скидка\" нужно ввести число от 0 до 100 включительно");
                        return;
                    }
                }
                else
                {
                    Operator.GetInstance().AddClient(name, usedTraffic, fareName, false);
                }
                clientListBox.DataSource = Operator.GetInstance().ClientStringsList;
            } 
            else
            {
                SpawnErrorBox("В поле \"Использованный трафик\" нужно ввести положительное число");
            }
        }

        private void discountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            label5.Enabled = discountCheckBox.Checked;
            discountTextBox.Enabled = discountCheckBox.Checked;
            label10.Enabled = discountCheckBox.Checked;
        }
    }
}
