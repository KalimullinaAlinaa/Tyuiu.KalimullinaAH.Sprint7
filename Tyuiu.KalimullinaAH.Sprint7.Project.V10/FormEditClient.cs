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
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();
            openFileDialogEdit_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogEdit_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();

        static int rows;
        static int columns;
        static string openFilePath;
        public  string[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);
            //разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            //выделите массив данных
            string[,] arrayValues = new string[rows, columns];

            //заполняем массив данными
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        private void buttonOpen_KAH_Click(object sender, EventArgs e)
        {
               
            try
            {
                DialogResult res = openFileDialogEdit_KAH.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogEdit_KAH.FileName;
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



        private void buttonSave_KAH_Click(object sender, EventArgs e)
        {
            saveFileDialogEdit_KAH.FileName = "123.csv";
            saveFileDialogEdit_KAH.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogEdit_KAH.ShowDialog();

            string path = saveFileDialogEdit_KAH.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }


            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewClient_KAH.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewClient_KAH.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                 str = "";
            }
        }  
            private void FormMain_Load(object sender, EventArgs e)
            {
                dataGridViewClient_KAH.ColumnCount = 50;

                dataGridViewClient_KAH.RowCount = 50;

              //  panelInPut_KAH.Width = this.Width / 2;

                for (int i = 0; i < 50; i++)
                {
                    dataGridViewClient_KAH.Columns[i].Width = 25;
                }
            }

        
    }
}   
