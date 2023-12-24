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

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        string pathClients = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Clients.csv";



        private void buttonOpenFile_KAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogTask_KAH.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogTask_KAH.FileName;
                    string[,] DataMatrix = ds.GetData(FileName);
                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);
                    string path = openFileDialogTask_KAH.FileName;

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
                        dataGridViewClient_KAH.Columns[i].Width = 100;
                    }
                    for (int r = 0; r < rows; r++)

                    {
                        for (int c = 0; c < columns; c++)
                            dataGridViewClient_KAH.Rows[r].Cells[c].Value = DataMatrix[r, c];
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

        private void buttonAdd_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                string[] row = new string[] { $"{textBoxSname_KAH.Text}", $"{textBoxName_KAH.Text}", $"{textBoxPname_KAH.Text}", $"{dateTimePicker_KAH.Text}", $"{textBoxPhone_KAH.Text}", $"{textBoxAdress_KAH.Text}", $"{numericUpDownDiscont_KAH.Text}" };

                dataGridViewClient_KAH.Rows.Add(row);
                bool completed = ds.AddNewData(pathClients, row);
                if (completed)
                {
                    MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            textBoxSname_KAH.Clear();
            textBoxName_KAH.Clear();
            textBoxPname_KAH.Clear();
            numericUpDownDiscont_KAH.Value = 0;
            dateTimePicker_KAH.Value = DateTime.Now;
            textBoxPhone_KAH.Clear();
            textBoxAdress_KAH.Clear();
        }

       

        private void buttonOpenFile_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAH.ToolTipTitle = "Открыть файл";

        }

        private void buttonAdd_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KAH.ToolTipTitle = "Сохранить в файл";

        }
    }
}
    
    


   