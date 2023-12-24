using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib;
using static Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib.DataService;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string pathClients = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint7\Заказы\Clients.csv";

        //редактирование  

        private void buttonOpenFile_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogEdit_KAH.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogEdit_KAH.FileName;
                    string[,] DataMatrix = ds.GetData(FileName);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    dataGridViewClient_KAH.RowCount = rows + 1;
                    dataGridViewClient_KAH.ColumnCount = columns;

                    dataGridViewClient_KAH.Columns[1].HeaderText = "Имя";
                    dataGridViewClient_KAH.Columns[0].HeaderText = "Фамилия";
                    dataGridViewClient_KAH.Columns[2].HeaderText = "Отчество";
                    dataGridViewClient_KAH.Columns[3].HeaderText = "Дата рождения";
                    dataGridViewClient_KAH.Columns[4].HeaderText = "Номер телефона ";
                    dataGridViewClient_KAH.Columns[5].HeaderText = "Адрес";
                    dataGridViewClient_KAH.Columns[6].HeaderText = "Персональная скидка";
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewClient_KAH.Columns[i].Width = 200;
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewClient_KAH.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                }
                else
                {
                    throw new Exception("Файл не выбран!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonAdd_KAH.Enabled = true;

        }

        private void buttonOpenFile_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAH.ToolTipTitle = "Открыть файл";

        }

        private void buttonAdd_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAH.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonAdd_KAH_Click(object sender, EventArgs e)
        {
            try
            {


                var currentData = ds.GetData(pathClients);

                //  временный список для новых данных
                var updatedData = new List<string[]>();

                foreach (DataGridViewRow row in dataGridViewClient_KAH.Rows)
                {
                    row.Visible = true;
                    if (!row.IsNewRow)
                    {
                        var rowArray = new string[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; ++i)
                        {
                            rowArray[i] = Convert.ToString(row.Cells[i].Value);
                        }
                        updatedData.Add(rowArray);
                    }
                }

                foreach (var line in updatedData)
                {
                    if (!ds.AddNewData(pathClients, line))
                    {
                        throw new Exception("Не удалось сохранить строку данных.");
                    }
                }

                MessageBox.Show("Изменения успешно сохранены.", "Сохранение выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxSearch_KAH.Clear();
        }

        private void buttonSearch_KAH_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_KAH.Text;
            dataGridViewClient_KAH.ClearSelection();
            bool dataFound = false; 

            foreach (DataGridViewRow row in dataGridViewClient_KAH.Rows)
            {
                bool rowContainsSearchText = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        rowContainsSearchText = true;
                        break;
                    }
                }

                if (rowContainsSearchText)
                {
                    row.Selected = true;
                    dataGridViewClient_KAH.FirstDisplayedScrollingRowIndex = row.Index; 
                    dataFound = true; 
                }
            }

            if (!dataFound)
            {
                MessageBox.Show("Данные не найдены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


