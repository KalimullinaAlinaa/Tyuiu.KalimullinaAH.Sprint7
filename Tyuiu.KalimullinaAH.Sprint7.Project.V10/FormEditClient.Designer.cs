namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    partial class FormEditClient
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
            this.panelDataGrid_KAH = new System.Windows.Forms.Panel();
            this.dataGridViewClient_KAH = new System.Windows.Forms.DataGridView();
            this.toolTip_KAH = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_KAH = new System.Windows.Forms.Button();
            this.buttonAdd_KAH = new System.Windows.Forms.Button();
            this.saveFileDialogTask_KAH = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogEdit_KAH = new System.Windows.Forms.OpenFileDialog();
            this.panelButton_KAH = new System.Windows.Forms.Panel();
            this.groupBoxSearch_KAH = new System.Windows.Forms.GroupBox();
            this.buttonSearch_KAH = new System.Windows.Forms.Button();
            this.textBoxSearch_KAH = new System.Windows.Forms.TextBox();
            this.panelDataGrid_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).BeginInit();
            this.panelButton_KAH.SuspendLayout();
            this.groupBoxSearch_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGrid_KAH
            // 
            this.panelDataGrid_KAH.Controls.Add(this.dataGridViewClient_KAH);
            this.panelDataGrid_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid_KAH.Location = new System.Drawing.Point(0, 97);
            this.panelDataGrid_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDataGrid_KAH.Name = "panelDataGrid_KAH";
            this.panelDataGrid_KAH.Size = new System.Drawing.Size(795, 546);
            this.panelDataGrid_KAH.TabIndex = 13;
            // 
            // dataGridViewClient_KAH
            // 
            this.dataGridViewClient_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient_KAH.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClient_KAH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewClient_KAH.Name = "dataGridViewClient_KAH";
            this.dataGridViewClient_KAH.RowHeadersWidth = 51;
            this.dataGridViewClient_KAH.Size = new System.Drawing.Size(795, 546);
            this.dataGridViewClient_KAH.TabIndex = 9;
            // 
            // toolTip_KAH
            // 
            this.toolTip_KAH.IsBalloon = true;
            this.toolTip_KAH.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonOpenFile_KAH
            // 
            this.buttonOpenFile_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_add;
            this.buttonOpenFile_KAH.Location = new System.Drawing.Point(19, 15);
            this.buttonOpenFile_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOpenFile_KAH.Name = "buttonOpenFile_KAH";
            this.buttonOpenFile_KAH.Size = new System.Drawing.Size(144, 69);
            this.buttonOpenFile_KAH.TabIndex = 3;
            this.toolTip_KAH.SetToolTip(this.buttonOpenFile_KAH, "Добавить данные нового клиента");
            this.buttonOpenFile_KAH.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAH.Click += new System.EventHandler(this.buttonOpenFile_KAH_Click);
            this.buttonOpenFile_KAH.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAH_MouseEnter);
            // 
            // buttonAdd_KAH
            // 
            this.buttonAdd_KAH.Enabled = false;
            this.buttonAdd_KAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_KAH.ForeColor = System.Drawing.Color.Silver;
            this.buttonAdd_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_save;
            this.buttonAdd_KAH.Location = new System.Drawing.Point(179, 15);
            this.buttonAdd_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd_KAH.Name = "buttonAdd_KAH";
            this.buttonAdd_KAH.Size = new System.Drawing.Size(144, 69);
            this.buttonAdd_KAH.TabIndex = 3;
            this.toolTip_KAH.SetToolTip(this.buttonAdd_KAH, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonAdd_KAH.UseVisualStyleBackColor = true;
            this.buttonAdd_KAH.Click += new System.EventHandler(this.buttonAdd_KAH_Click);
            this.buttonAdd_KAH.MouseEnter += new System.EventHandler(this.buttonAdd_KAH_MouseEnter);
            // 
            // openFileDialogEdit_KAH
            // 
            this.openFileDialogEdit_KAH.FileName = "openFileDialog1";
            // 
            // panelButton_KAH
            // 
            this.panelButton_KAH.Controls.Add(this.groupBoxSearch_KAH);
            this.panelButton_KAH.Controls.Add(this.buttonOpenFile_KAH);
            this.panelButton_KAH.Controls.Add(this.buttonAdd_KAH);
            this.panelButton_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_KAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelButton_KAH.Location = new System.Drawing.Point(0, 0);
            this.panelButton_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButton_KAH.Name = "panelButton_KAH";
            this.panelButton_KAH.Size = new System.Drawing.Size(795, 97);
            this.panelButton_KAH.TabIndex = 11;
            // 
            // groupBoxSearch_KAH
            // 
            this.groupBoxSearch_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch_KAH.Controls.Add(this.buttonSearch_KAH);
            this.groupBoxSearch_KAH.Controls.Add(this.textBoxSearch_KAH);
            this.groupBoxSearch_KAH.Location = new System.Drawing.Point(339, 3);
            this.groupBoxSearch_KAH.Name = "groupBoxSearch_KAH";
            this.groupBoxSearch_KAH.Size = new System.Drawing.Size(444, 81);
            this.groupBoxSearch_KAH.TabIndex = 5;
            this.groupBoxSearch_KAH.TabStop = false;
            this.groupBoxSearch_KAH.Text = "Поиск:";
            // 
            // buttonSearch_KAH
            // 
            this.buttonSearch_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.page_white_magnify;
            this.buttonSearch_KAH.Location = new System.Drawing.Point(335, 18);
            this.buttonSearch_KAH.Name = "buttonSearch_KAH";
            this.buttonSearch_KAH.Size = new System.Drawing.Size(64, 56);
            this.buttonSearch_KAH.TabIndex = 6;
            this.buttonSearch_KAH.UseVisualStyleBackColor = true;
            this.buttonSearch_KAH.Click += new System.EventHandler(this.buttonSearch_KAH_Click);
            // 
            // textBoxSearch_KAH
            // 
            this.textBoxSearch_KAH.Location = new System.Drawing.Point(6, 41);
            this.textBoxSearch_KAH.Name = "textBoxSearch_KAH";
            this.textBoxSearch_KAH.Size = new System.Drawing.Size(295, 27);
            this.textBoxSearch_KAH.TabIndex = 4;
            // 
            // FormEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 643);
            this.Controls.Add(this.panelDataGrid_KAH);
            this.Controls.Add(this.panelButton_KAH);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать клиента";
            this.panelDataGrid_KAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).EndInit();
            this.panelButton_KAH.ResumeLayout(false);
            this.groupBoxSearch_KAH.ResumeLayout(false);
            this.groupBoxSearch_KAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGrid_KAH;
        private System.Windows.Forms.DataGridView dataGridViewClient_KAH;
        private System.Windows.Forms.ToolTip toolTip_KAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KAH;
        private System.Windows.Forms.OpenFileDialog openFileDialogEdit_KAH;
        private System.Windows.Forms.Button buttonOpenFile_KAH;
        private System.Windows.Forms.Button buttonAdd_KAH;
        private System.Windows.Forms.Panel panelButton_KAH;
        private System.Windows.Forms.GroupBox groupBoxSearch_KAH;
        private System.Windows.Forms.TextBox textBoxSearch_KAH;
        private System.Windows.Forms.Button buttonSearch_KAH;
    }
}