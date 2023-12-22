namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxProducts_KAH = new System.Windows.Forms.CheckBox();
            this.checkBoxMonth_KAH = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartOrder_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 74);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBoxProducts_KAH);
            this.groupBox1.Controls.Add(this.checkBoxMonth_KAH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать график  по:";
            // 
            // checkBoxProducts_KAH
            // 
            this.checkBoxProducts_KAH.AutoSize = true;
            this.checkBoxProducts_KAH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBoxProducts_KAH.Location = new System.Drawing.Point(275, 31);
            this.checkBoxProducts_KAH.Name = "checkBoxProducts_KAH";
            this.checkBoxProducts_KAH.Size = new System.Drawing.Size(79, 20);
            this.checkBoxProducts_KAH.TabIndex = 1;
            this.checkBoxProducts_KAH.Text = "Товары";
            this.checkBoxProducts_KAH.UseVisualStyleBackColor = true;
            this.checkBoxProducts_KAH.CheckedChanged += new System.EventHandler(this.checkBoxProducts_KAH_CheckedChanged);
            // 
            // checkBoxMonth_KAH
            // 
            this.checkBoxMonth_KAH.AutoSize = true;
            this.checkBoxMonth_KAH.Location = new System.Drawing.Point(12, 31);
            this.checkBoxMonth_KAH.Name = "checkBoxMonth_KAH";
            this.checkBoxMonth_KAH.Size = new System.Drawing.Size(18, 17);
            this.checkBoxMonth_KAH.TabIndex = 0;
            this.checkBoxMonth_KAH.UseVisualStyleBackColor = true;
            this.checkBoxMonth_KAH.CheckedChanged += new System.EventHandler(this.checkBoxMonth_KAH_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartOrder_KAH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 405);
            this.panel2.TabIndex = 0;
            // 
            // chartOrder_KAH
            // 
            chartArea4.Name = "ChartArea1";
            this.chartOrder_KAH.ChartAreas.Add(chartArea4);
            this.chartOrder_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartOrder_KAH.Legends.Add(legend4);
            this.chartOrder_KAH.Location = new System.Drawing.Point(0, 0);
            this.chartOrder_KAH.Name = "chartOrder_KAH";
            this.chartOrder_KAH.Size = new System.Drawing.Size(820, 405);
            this.chartOrder_KAH.TabIndex = 0;
            this.chartOrder_KAH.Text = " ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(460, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChart";
            this.Text = "График";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder_KAH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMonth_KAH;
        private System.Windows.Forms.CheckBox checkBoxProducts_KAH;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}