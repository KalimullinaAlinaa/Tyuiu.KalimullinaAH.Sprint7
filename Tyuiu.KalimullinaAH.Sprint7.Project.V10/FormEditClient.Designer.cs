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
            this.buttonSave_KAH = new System.Windows.Forms.Button();
            this.openFileDialogEdit_KAH = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogEdit_KAH = new System.Windows.Forms.SaveFileDialog();
            this.toolTipEdit_KAH = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOpen_KAH = new System.Windows.Forms.Button();
            this.dataGridViewClient_KAH = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave_KAH
            // 
            this.buttonSave_KAH.Location = new System.Drawing.Point(184, 36);
            this.buttonSave_KAH.Name = "buttonSave_KAH";
            this.buttonSave_KAH.Size = new System.Drawing.Size(228, 32);
            this.buttonSave_KAH.TabIndex = 5;
            this.buttonSave_KAH.Text = "С";
            this.buttonSave_KAH.UseVisualStyleBackColor = true;
            this.buttonSave_KAH.Click += new System.EventHandler(this.buttonSave_KAH_Click);
            // 
            // openFileDialogEdit_KAH
            // 
            this.openFileDialogEdit_KAH.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOpen_KAH);
            this.panel1.Controls.Add(this.buttonSave_KAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonOpen_KAH
            // 
            this.buttonOpen_KAH.Location = new System.Drawing.Point(68, 49);
            this.buttonOpen_KAH.Name = "buttonOpen_KAH";
            this.buttonOpen_KAH.Size = new System.Drawing.Size(110, 33);
            this.buttonOpen_KAH.TabIndex = 7;
            this.buttonOpen_KAH.Text = "Открыть";
            this.buttonOpen_KAH.UseVisualStyleBackColor = true;
            this.buttonOpen_KAH.Click += new System.EventHandler(this.buttonOpen_KAH_Click);
            // 
            // dataGridViewClient_KAH
            // 
            this.dataGridViewClient_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewClient_KAH.Location = new System.Drawing.Point(0, 85);
            this.dataGridViewClient_KAH.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClient_KAH.Name = "dataGridViewClient_KAH";
            this.dataGridViewClient_KAH.RowHeadersWidth = 51;
            this.dataGridViewClient_KAH.Size = new System.Drawing.Size(800, 384);
            this.dataGridViewClient_KAH.TabIndex = 8;
            // 
            // FormEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewClient_KAH);
            this.Controls.Add(this.panel1);
            this.Name = "FormEditClient";
            this.Text = "FormEditClient";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave_KAH;
        private System.Windows.Forms.OpenFileDialog openFileDialogEdit_KAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogEdit_KAH;
        private System.Windows.Forms.ToolTip toolTipEdit_KAH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpen_KAH;
        private System.Windows.Forms.DataGridView dataGridViewClient_KAH;
    }
}