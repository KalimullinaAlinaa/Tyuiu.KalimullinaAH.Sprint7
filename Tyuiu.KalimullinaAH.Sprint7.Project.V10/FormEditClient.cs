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

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string pathClients = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Clients.csv";
    
       //редактирование  
        private void LoadDataFromCsv()
        {
            List<Client> clients = new List<Client>();

            using (var reader = new StreamReader(pathClients))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(';');

                    Client client = new Client
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        MiddleName = data[2],
                        Birthdate = DateTime.Parse(data[3]),
                        PhoneNumber = data[4],
                        Address = data[5],
                        Discount = int.Parse(data[6]),                   
                        
                    };
                    clients.Add(client);



                }
            }

            dataGridViewClient_KAH.DataSource = clients;
        }



        private void buttonSave_KAH_Click(object sender, EventArgs e)
        {
          
        }

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
        }

       
      
    }
    
}
   
