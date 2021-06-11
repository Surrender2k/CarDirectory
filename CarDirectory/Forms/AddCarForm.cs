﻿using System;
using System.Drawing;
using System.Windows.Forms;
using static CarDirectory.HelpMethod;

namespace CarDirectory
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(ref HashTable hashTable, ref RBTree<string, Car> rBTreeCar, ref RBTree<int, Car> rBTreeYear, ref DataGridView dataGridView) : this()
        {
            this.rBTreeYear = rBTreeYear;
            this.rBTreeCar = rBTreeCar;
            this.hashTable = hashTable;
            this.dataGridView = dataGridView;
        }

        private Car car;
        private RBTree<string, Car> rBTreeCar;
        private HashTable hashTable;
        private DataGridView dataGridView;
        private RBTree<int, Car> rBTreeYear;

        private void BrandTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Неверный символ";
            toolTip1.Show("Введите буквы", BrandTextBox, 1000);
        }

        private void BrandTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            BrandTextBox.BackColor = Color.Beige;
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ActiveControl = ModelTextBox;
                ModelTextBox.BackColor = Color.Beige;
            }
        }

        private void ModelTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ActiveControl = StartTextBox;
                StartTextBox.BackColor = Color.Beige;
            }
        }

        private void StartTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ActiveControl = EndTextBox;
                EndTextBox.BackColor = Color.Beige;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckTextBox(ref BrandTextBox, ref ModelTextBox, ref StartTextBox, ref EndTextBox);
            if (!IsEmpty(ref ModelTextBox) && !IsEmpty(ref BrandTextBox) && IsCorrectStartYear(ref StartTextBox) && IsCorrectEndYear(ref EndTextBox))
                if (IsCorrectStartAndEndYear(ref StartTextBox, ref EndTextBox))
                    AddNewCar();
                else MessageBox.Show("Исправьте поля, отмеченные красным цветом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void AddNewCar()
        {
            car = new Car(BrandTextBox.Text, ModelTextBox.Text, int.Parse(StartTextBox.Text), EndTextBox.Text);
            FixEndCar(ref car);
            if (rBTreeCar.Contains(car.Brand))
            {
                if (hashTable.Contains(car.Brand + car.Model))
                {
                    if (rBTreeCar.Contains(car.Brand, car))
                    {
                        MessageBox.Show("Введенный вами элемент уже находится в справочнике", "Информация об элементе", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (IsCorrectDates(ref rBTreeCar, ref car))
                    {
                        rBTreeCar.Add(car.Brand, car);
                        rBTreeYear.Add(car.Start, car);
                        RefreshDataGridView(ref rBTreeCar, ref dataGridView);
                        Visible = false;
                        MessageBox.Show("Введенный вами элемент успешно добавлен в справочник", "Информация об элементе", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Неккоректные значения годов начала и конца производства", "Информация об элементе", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    hashTable.Add(new BrandAndModel(car.Brand, car.Model));
                    rBTreeCar.Add(car.Brand, car);
                    rBTreeYear.Add(car.Start, car);
                    RefreshDataGridView(ref rBTreeCar, ref dataGridView);
                    Visible = false;
                    MessageBox.Show("Введенный вами элемент успешно добавлен в справочник", "Информация об элементе", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Введенный вами марка автомобиля не найдена в справочникe", "Информация об элементе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EndTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                AddButton_Click(sender, e);
            }
        }

        private void InfoPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Ограничение на год";
            toolTip1.Show(">1967 и <2022", InfoPictureBox1, 5000);
        }

        private void BrandTextBox_Click(object sender, EventArgs e)
        {
            BrandTextBox.BackColor = Color.Beige;
        }

        private void ModelTextBox_Click(object sender, EventArgs e)
        {
            ModelTextBox.BackColor = Color.Beige;
        }

        private void StartTextBox_Click(object sender, EventArgs e)
        {
            StartTextBox.BackColor = Color.Beige;
        }

        private void EndTextBox_Click(object sender, EventArgs e)
        {
            EndTextBox.BackColor = Color.Beige;
        }
    }
}