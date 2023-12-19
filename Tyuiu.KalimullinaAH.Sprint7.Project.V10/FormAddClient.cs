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
            openFileDialogTask_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            dateTimePicker_KAH.CustomFormat = "DD MM YYYY";
        }
        DataService ds = new DataService();


        string path = @"C:\Users\boulevarovaalina\Desktop\Новая папка\InPutFile.csv";



        private void buttonOpenFile_KAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogTask_KAH.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogTask_KAH.FileName;

                    Encoding encoding = Encoding.UTF8;
                    string[,] DataMatrix = ds.GetData(FileName, encoding);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    dataGridViewClient_KAH.RowCount = rows + 1;
                    dataGridViewClient_KAH.ColumnCount = columns;
                    for (int i = 0; i < columns; i++)
                    {
                        dataGridViewClient_KAH.Columns[i].Width = 100;
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
        }

    
    


    private void button1_Click(object sender, EventArgs e)
                
             {
                    FormEditClient formEditClient = new FormEditClient();
                    formEditClient.Show();
                
              }

        private void buttonAdd_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                string[] row = new string[] { $"{textBoxName_KAH.Text}", $"{textBoxSname_KAH.Text}",
                $"{textBoxPname_KAH.Text}", $"{dateTimePicker_KAH.Text}",
                $"{textBoxPhone_KAH.Text}", $"{textBoxAdress_KAH.Text}", };
                dataGridViewClient_KAH.Rows.Add(row);
                bool completed = ds.AddNewData(path, row);
                if (completed)
                {
                    MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   

}