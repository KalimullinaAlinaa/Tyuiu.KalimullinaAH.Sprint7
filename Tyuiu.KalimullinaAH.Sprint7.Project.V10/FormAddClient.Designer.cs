
namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    partial class FormAddClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpenFile_KAH = new System.Windows.Forms.Button();
            this.buttonAdd_KAH = new System.Windows.Forms.Button();
            this.panelAddInfo_KAH = new System.Windows.Forms.Panel();
            this.groupBoxAdd_KAH = new System.Windows.Forms.GroupBox();
            this.numericUpDownDiscont_KAH = new System.Windows.Forms.NumericUpDown();
            this.labelDiscont_KAH = new System.Windows.Forms.Label();
            this.dateTimePicker_KAH = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdress_KAH = new System.Windows.Forms.TextBox();
            this.textBoxPhone_KAH = new System.Windows.Forms.TextBox();
            this.labelBirthDay_KAH = new System.Windows.Forms.Label();
            this.labelName_KAH = new System.Windows.Forms.Label();
            this.labelSurname_KAH = new System.Windows.Forms.Label();
            this.labelAdress_KAH = new System.Windows.Forms.Label();
            this.textBoxPname_KAH = new System.Windows.Forms.TextBox();
            this.labelNumberOfPhone = new System.Windows.Forms.Label();
            this.labelPatronymic_KAH = new System.Windows.Forms.Label();
            this.textBoxName_KAH = new System.Windows.Forms.TextBox();
            this.textBoxSname_KAH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogTask_KAH = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTask_KAH = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_KAH = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewClient_KAH = new System.Windows.Forms.DataGridView();
            this.panelDataGrid_KAH = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelAddInfo_KAH.SuspendLayout();
            this.groupBoxAdd_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscont_KAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).BeginInit();
            this.panelDataGrid_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOpenFile_KAH);
            this.panel1.Controls.Add(this.buttonAdd_KAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 91);
            this.panel1.TabIndex = 0;
            // 
            // buttonOpenFile_KAH
            // 
            this.buttonOpenFile_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_add;
            this.buttonOpenFile_KAH.Location = new System.Drawing.Point(9, 13);
            this.buttonOpenFile_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile_KAH.Name = "buttonOpenFile_KAH";
            this.buttonOpenFile_KAH.Size = new System.Drawing.Size(144, 69);
            this.buttonOpenFile_KAH.TabIndex = 3;
            this.toolTip_KAH.SetToolTip(this.buttonOpenFile_KAH, "Добавить данные нового клиента");
            this.buttonOpenFile_KAH.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAH.Click += new System.EventHandler(this.buttonOpenFile_KAH_Click_1);
            this.buttonOpenFile_KAH.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAH_MouseEnter);
            // 
            // buttonAdd_KAH
            // 
            this.buttonAdd_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_save;
            this.buttonAdd_KAH.Location = new System.Drawing.Point(168, 14);
            this.buttonAdd_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd_KAH.Name = "buttonAdd_KAH";
            this.buttonAdd_KAH.Size = new System.Drawing.Size(144, 69);
            this.buttonAdd_KAH.TabIndex = 3;
            this.toolTip_KAH.SetToolTip(this.buttonAdd_KAH, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonAdd_KAH.UseVisualStyleBackColor = true;
            this.buttonAdd_KAH.Click += new System.EventHandler(this.buttonAdd_KAH_Click);
            this.buttonAdd_KAH.MouseEnter += new System.EventHandler(this.buttonAdd_KAH_MouseEnter);
            // 
            // panelAddInfo_KAH
            // 
            this.panelAddInfo_KAH.Controls.Add(this.groupBoxAdd_KAH);
            this.panelAddInfo_KAH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddInfo_KAH.Location = new System.Drawing.Point(0, 436);
            this.panelAddInfo_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAddInfo_KAH.Name = "panelAddInfo_KAH";
            this.panelAddInfo_KAH.Size = new System.Drawing.Size(767, 207);
            this.panelAddInfo_KAH.TabIndex = 1;
            // 
            // groupBoxAdd_KAH
            // 
            this.groupBoxAdd_KAH.Controls.Add(this.numericUpDownDiscont_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.label1);
            this.groupBoxAdd_KAH.Controls.Add(this.labelDiscont_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.dateTimePicker_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.textBoxAdress_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.textBoxPhone_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.labelBirthDay_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.labelName_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.labelSurname_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.labelAdress_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.textBoxPname_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.labelNumberOfPhone);
            this.groupBoxAdd_KAH.Controls.Add(this.labelPatronymic_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.textBoxName_KAH);
            this.groupBoxAdd_KAH.Controls.Add(this.textBoxSname_KAH);
            this.groupBoxAdd_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAdd_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdd_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAdd_KAH.Name = "groupBoxAdd_KAH";
            this.groupBoxAdd_KAH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAdd_KAH.Size = new System.Drawing.Size(767, 207);
            this.groupBoxAdd_KAH.TabIndex = 3;
            this.groupBoxAdd_KAH.TabStop = false;
            this.groupBoxAdd_KAH.Text = "Добавить  нового клиента:";
            // 
            // numericUpDownDiscont_KAH
            // 
            this.numericUpDownDiscont_KAH.Location = new System.Drawing.Point(510, 72);
            this.numericUpDownDiscont_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownDiscont_KAH.Name = "numericUpDownDiscont_KAH";
            this.numericUpDownDiscont_KAH.Size = new System.Drawing.Size(141, 27);
            this.numericUpDownDiscont_KAH.TabIndex = 5;
            // 
            // labelDiscont_KAH
            // 
            this.labelDiscont_KAH.AutoSize = true;
            this.labelDiscont_KAH.Location = new System.Drawing.Point(506, 32);
            this.labelDiscont_KAH.Name = "labelDiscont_KAH";
            this.labelDiscont_KAH.Size = new System.Drawing.Size(116, 20);
            this.labelDiscont_KAH.TabIndex = 4;
            this.labelDiscont_KAH.Text = "Скидка клиента";
            // 
            // dateTimePicker_KAH
            // 
            this.dateTimePicker_KAH.Location = new System.Drawing.Point(13, 167);
            this.dateTimePicker_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_KAH.Name = "dateTimePicker_KAH";
            this.dateTimePicker_KAH.Size = new System.Drawing.Size(156, 27);
            this.dateTimePicker_KAH.TabIndex = 1;
            // 
            // textBoxAdress_KAH
            // 
            this.textBoxAdress_KAH.Location = new System.Drawing.Point(352, 167);
            this.textBoxAdress_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdress_KAH.Name = "textBoxAdress_KAH";
            this.textBoxAdress_KAH.Size = new System.Drawing.Size(141, 27);
            this.textBoxAdress_KAH.TabIndex = 1;
            // 
            // textBoxPhone_KAH
            // 
            this.textBoxPhone_KAH.Location = new System.Drawing.Point(186, 167);
            this.textBoxPhone_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPhone_KAH.Name = "textBoxPhone_KAH";
            this.textBoxPhone_KAH.Size = new System.Drawing.Size(141, 27);
            this.textBoxPhone_KAH.TabIndex = 1;
            // 
            // labelBirthDay_KAH
            // 
            this.labelBirthDay_KAH.AutoSize = true;
            this.labelBirthDay_KAH.Location = new System.Drawing.Point(16, 128);
            this.labelBirthDay_KAH.Name = "labelBirthDay_KAH";
            this.labelBirthDay_KAH.Size = new System.Drawing.Size(119, 20);
            this.labelBirthDay_KAH.TabIndex = 2;
            this.labelBirthDay_KAH.Text = "Дата рождения:";
            // 
            // labelName_KAH
            // 
            this.labelName_KAH.AutoSize = true;
            this.labelName_KAH.Location = new System.Drawing.Point(183, 32);
            this.labelName_KAH.Name = "labelName_KAH";
            this.labelName_KAH.Size = new System.Drawing.Size(42, 20);
            this.labelName_KAH.TabIndex = 0;
            this.labelName_KAH.Text = "Имя:";
            // 
            // labelSurname_KAH
            // 
            this.labelSurname_KAH.AutoSize = true;
            this.labelSurname_KAH.Location = new System.Drawing.Point(16, 32);
            this.labelSurname_KAH.Name = "labelSurname_KAH";
            this.labelSurname_KAH.Size = new System.Drawing.Size(76, 20);
            this.labelSurname_KAH.TabIndex = 0;
            this.labelSurname_KAH.Text = "Фамилия:";
            // 
            // labelAdress_KAH
            // 
            this.labelAdress_KAH.AutoSize = true;
            this.labelAdress_KAH.Location = new System.Drawing.Point(348, 128);
            this.labelAdress_KAH.Name = "labelAdress_KAH";
            this.labelAdress_KAH.Size = new System.Drawing.Size(54, 20);
            this.labelAdress_KAH.TabIndex = 0;
            this.labelAdress_KAH.Text = "Адрес:";
            // 
            // textBoxPname_KAH
            // 
            this.textBoxPname_KAH.Location = new System.Drawing.Point(352, 72);
            this.textBoxPname_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPname_KAH.Name = "textBoxPname_KAH";
            this.textBoxPname_KAH.Size = new System.Drawing.Size(141, 27);
            this.textBoxPname_KAH.TabIndex = 1;
            // 
            // labelNumberOfPhone
            // 
            this.labelNumberOfPhone.AutoSize = true;
            this.labelNumberOfPhone.Location = new System.Drawing.Point(183, 131);
            this.labelNumberOfPhone.Name = "labelNumberOfPhone";
            this.labelNumberOfPhone.Size = new System.Drawing.Size(134, 20);
            this.labelNumberOfPhone.TabIndex = 0;
            this.labelNumberOfPhone.Text = "Номер телефона :";
            // 
            // labelPatronymic_KAH
            // 
            this.labelPatronymic_KAH.AutoSize = true;
            this.labelPatronymic_KAH.Location = new System.Drawing.Point(348, 32);
            this.labelPatronymic_KAH.Name = "labelPatronymic_KAH";
            this.labelPatronymic_KAH.Size = new System.Drawing.Size(75, 20);
            this.labelPatronymic_KAH.TabIndex = 2;
            this.labelPatronymic_KAH.Text = "Отчество:";
            // 
            // textBoxName_KAH
            // 
            this.textBoxName_KAH.Location = new System.Drawing.Point(186, 72);
            this.textBoxName_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName_KAH.Name = "textBoxName_KAH";
            this.textBoxName_KAH.Size = new System.Drawing.Size(142, 27);
            this.textBoxName_KAH.TabIndex = 1;
            // 
            // textBoxSname_KAH
            // 
            this.textBoxSname_KAH.Location = new System.Drawing.Point(13, 72);
            this.textBoxSname_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSname_KAH.Name = "textBoxSname_KAH";
            this.textBoxSname_KAH.Size = new System.Drawing.Size(153, 27);
            this.textBoxSname_KAH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // openFileDialogTask_KAH
            // 
            this.openFileDialogTask_KAH.FileName = "openFileDialog1";
            // 
            // toolTip_KAH
            // 
            this.toolTip_KAH.IsBalloon = true;
            this.toolTip_KAH.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dataGridViewClient_KAH
            // 
            this.dataGridViewClient_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient_KAH.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClient_KAH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewClient_KAH.Name = "dataGridViewClient_KAH";
            this.dataGridViewClient_KAH.RowHeadersWidth = 51;
            this.dataGridViewClient_KAH.Size = new System.Drawing.Size(767, 345);
            this.dataGridViewClient_KAH.TabIndex = 9;
            // 
            // panelDataGrid_KAH
            // 
            this.panelDataGrid_KAH.Controls.Add(this.dataGridViewClient_KAH);
            this.panelDataGrid_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid_KAH.Location = new System.Drawing.Point(0, 91);
            this.panelDataGrid_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDataGrid_KAH.Name = "panelDataGrid_KAH";
            this.panelDataGrid_KAH.Size = new System.Drawing.Size(767, 345);
            this.panelDataGrid_KAH.TabIndex = 10;
            // 
            // FormAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 643);
            this.Controls.Add(this.panelDataGrid_KAH);
            this.Controls.Add(this.panelAddInfo_KAH);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нового клиента";
            this.panel1.ResumeLayout(false);
            this.panelAddInfo_KAH.ResumeLayout(false);
            this.groupBoxAdd_KAH.ResumeLayout(false);
            this.groupBoxAdd_KAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscont_KAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).EndInit();
            this.panelDataGrid_KAH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelAddInfo_KAH;
        private System.Windows.Forms.GroupBox groupBoxAdd_KAH;
        private System.Windows.Forms.TextBox textBoxAdress_KAH;
        private System.Windows.Forms.TextBox textBoxPhone_KAH;
        private System.Windows.Forms.Label labelBirthDay_KAH;
        private System.Windows.Forms.Label labelName_KAH;
        private System.Windows.Forms.Label labelSurname_KAH;
        private System.Windows.Forms.Label labelAdress_KAH;
        private System.Windows.Forms.TextBox textBoxPname_KAH;
        private System.Windows.Forms.Label labelNumberOfPhone;
        private System.Windows.Forms.Label labelPatronymic_KAH;
        private System.Windows.Forms.TextBox textBoxName_KAH;
        private System.Windows.Forms.TextBox textBoxSname_KAH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd_KAH;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KAH;
        private System.Windows.Forms.ToolTip toolTip_KAH;
        private System.Windows.Forms.DateTimePicker dateTimePicker_KAH;
        private System.Windows.Forms.DataGridView dataGridViewClient_KAH;
        private System.Windows.Forms.Button buttonOpenFile_KAH;
        private System.Windows.Forms.Panel panelDataGrid_KAH;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscont_KAH;
        private System.Windows.Forms.Label labelDiscont_KAH;
    }
}

