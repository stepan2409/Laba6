using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!check(name))
            {
                SpawnErrorBox("В поле названия должны быть русские буквы");
                return;
            }
            if (decimal.TryParse(farePriceTextBox.Text.Trim(), out decimal value) && value > 0)
            {
                value = Math.Round(value, 2);
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
            if (!check(name))
            {
                SpawnErrorBox("В поле имени должны быть русские буквы");
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
                usedTraffic = Math.Round(usedTraffic, 6);
                if (discountCheckBox.Checked)
                {
                    if (decimal.TryParse(discountTextBox.Text.Trim(), out decimal discount) && discount >= 0 )
                    {
                        discount = Math.Round(discount, 2);
                        decimal farePrice = Operator.GetInstance().GetFarePrice(fareName);
                        if (usedTraffic * farePrice - discount < 1)
                        {
                            SpawnErrorBox("Скидка слишком большая");
                            return;
                        }
                        Operator.GetInstance().AddClient(name, usedTraffic, fareName, true, discount);
                    } else
                    {
                        SpawnErrorBox("В поле \"Скидка\" нужно ввести положительное число");
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

        private bool check(string st)
        {
            return Regex.Match(st, @"[АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя]").Success;
        }
    }
}
