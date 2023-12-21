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
            this.saveFileDialogTask_KAH = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogEdit_KAH = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile_KAH = new System.Windows.Forms.Button();
            this.buttonAdd_KAH = new System.Windows.Forms.Button();
            this.panelButton_KAH = new System.Windows.Forms.Panel();
            this.panelDataGrid_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).BeginInit();
            this.panelButton_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDataGrid_KAH
            // 
            this.panelDataGrid_KAH.Controls.Add(this.dataGridViewClient_KAH);
            this.panelDataGrid_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid_KAH.Location = new System.Drawing.Point(0, 101);
            this.panelDataGrid_KAH.Name = "panelDataGrid_KAH";
            this.panelDataGrid_KAH.Size = new System.Drawing.Size(844, 507);
            this.panelDataGrid_KAH.TabIndex = 13;
            // 
            // dataGridViewClient_KAH
            // 
            this.dataGridViewClient_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient_KAH.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClient_KAH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClient_KAH.Name = "dataGridViewClient_KAH";
            this.dataGridViewClient_KAH.RowHeadersWidth = 51;
            this.dataGridViewClient_KAH.Size = new System.Drawing.Size(844, 507);
            this.dataGridViewClient_KAH.TabIndex = 9;
            // 
            // openFileDialogEdit_KAH
            // 
            this.openFileDialogEdit_KAH.FileName = "openFileDialog1";
            // 
            // buttonOpenFile_KAH
            // 
            this.buttonOpenFile_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_add;
            this.buttonOpenFile_KAH.Location = new System.Drawing.Point(19, 12);
            this.buttonOpenFile_KAH.Name = "buttonOpenFile_KAH";
            this.buttonOpenFile_KAH.Size = new System.Drawing.Size(135, 62);
            this.buttonOpenFile_KAH.TabIndex = 3;
            this.buttonOpenFile_KAH.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAH.Click += new System.EventHandler(this.buttonOpenFile_KAH_Click);
            // 
            // buttonAdd_KAH
            // 
            this.buttonAdd_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.table_save;
            this.buttonAdd_KAH.Location = new System.Drawing.Point(179, 12);
            this.buttonAdd_KAH.Name = "buttonAdd_KAH";
            this.buttonAdd_KAH.Size = new System.Drawing.Size(135, 62);
            this.buttonAdd_KAH.TabIndex = 3;
            this.buttonAdd_KAH.UseVisualStyleBackColor = true;
            // 
            // panelButton_KAH
            // 
            this.panelButton_KAH.Controls.Add(this.buttonOpenFile_KAH);
            this.panelButton_KAH.Controls.Add(this.buttonAdd_KAH);
            this.panelButton_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_KAH.Location = new System.Drawing.Point(0, 0);
            this.panelButton_KAH.Name = "panelButton_KAH";
            this.panelButton_KAH.Size = new System.Drawing.Size(844, 101);
            this.panelButton_KAH.TabIndex = 11;
            // 
            // FormEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 608);
            this.Controls.Add(this.panelDataGrid_KAH);
            this.Controls.Add(this.panelButton_KAH);
            this.Name = "FormEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать клиента";
            this.panelDataGrid_KAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).EndInit();
            this.panelButton_KAH.ResumeLayout(false);
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
    }
}