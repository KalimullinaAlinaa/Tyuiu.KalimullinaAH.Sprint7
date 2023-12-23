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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartOrder_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOrdersOfAllMonth_KAH = new System.Windows.Forms.Button();
            this.buttonOrdersOfMonth_KAH = new System.Windows.Forms.Button();
            this.buttonBestProductsOfYear_KAH = new System.Windows.Forms.Button();
            this.buttonBestProductsOfMonth_KAH = new System.Windows.Forms.Button();
            this.comboBoxMonths_KAH = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 479);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMonths_KAH);
            this.groupBox1.Controls.Add(this.buttonBestProductsOfMonth_KAH);
            this.groupBox1.Controls.Add(this.buttonBestProductsOfYear_KAH);
            this.groupBox1.Controls.Add(this.buttonOrdersOfMonth_KAH);
            this.groupBox1.Controls.Add(this.buttonOrdersOfAllMonth_KAH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 479);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать график  по:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartOrder_KAH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 479);
            this.panel2.TabIndex = 0;
            // 
            // chartOrder_KAH
            // 
            chartArea6.Name = "ChartArea1";
            this.chartOrder_KAH.ChartAreas.Add(chartArea6);
            this.chartOrder_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartOrder_KAH.Legends.Add(legend6);
            this.chartOrder_KAH.Location = new System.Drawing.Point(0, 0);
            this.chartOrder_KAH.Name = "chartOrder_KAH";
            this.chartOrder_KAH.Size = new System.Drawing.Size(556, 479);
            this.chartOrder_KAH.TabIndex = 0;
            this.chartOrder_KAH.Text = " ";
            // 
            // buttonOrdersOfAllMonth_KAH
            // 
            this.buttonOrdersOfAllMonth_KAH.Location = new System.Drawing.Point(6, 51);
            this.buttonOrdersOfAllMonth_KAH.Name = "buttonOrdersOfAllMonth_KAH";
            this.buttonOrdersOfAllMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonOrdersOfAllMonth_KAH.TabIndex = 3;
            this.buttonOrdersOfAllMonth_KAH.Text = "Динамике заказов за год:";
            this.buttonOrdersOfAllMonth_KAH.UseVisualStyleBackColor = true;
            this.buttonOrdersOfAllMonth_KAH.Click += new System.EventHandler(this.buttonOrdersOfAllMonth_KAH_Click);
            // 
            // buttonOrdersOfMonth_KAH
            // 
            this.buttonOrdersOfMonth_KAH.Location = new System.Drawing.Point(6, 162);
            this.buttonOrdersOfMonth_KAH.Name = "buttonOrdersOfMonth_KAH";
            this.buttonOrdersOfMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonOrdersOfMonth_KAH.TabIndex = 4;
            this.buttonOrdersOfMonth_KAH.Text = "Динамике заказов за месяц:";
            this.buttonOrdersOfMonth_KAH.UseVisualStyleBackColor = true;
            this.buttonOrdersOfMonth_KAH.Click += new System.EventHandler(this.buttonOrdersOfMonth_KAH_Click);
            // 
            // buttonBestProductsOfYear_KAH
            // 
            this.buttonBestProductsOfYear_KAH.Location = new System.Drawing.Point(6, 270);
            this.buttonBestProductsOfYear_KAH.Name = "buttonBestProductsOfYear_KAH";
            this.buttonBestProductsOfYear_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonBestProductsOfYear_KAH.TabIndex = 5;
            this.buttonBestProductsOfYear_KAH.Text = "Популярным позициям за год:";
            this.buttonBestProductsOfYear_KAH.UseVisualStyleBackColor = true;
            // 
            // buttonBestProductsOfMonth_KAH
            // 
            this.buttonBestProductsOfMonth_KAH.Location = new System.Drawing.Point(6, 378);
            this.buttonBestProductsOfMonth_KAH.Name = "buttonBestProductsOfMonth_KAH";
            this.buttonBestProductsOfMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonBestProductsOfMonth_KAH.TabIndex = 6;
            this.buttonBestProductsOfMonth_KAH.Text = "Популярным позициям за месяц:";
            this.buttonBestProductsOfMonth_KAH.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonths_KAH
            // 
            this.comboBoxMonths_KAH.FormattingEnabled = true;
            this.comboBoxMonths_KAH.Location = new System.Drawing.Point(59, 236);
            this.comboBoxMonths_KAH.Name = "comboBoxMonths_KAH";
            this.comboBoxMonths_KAH.Size = new System.Drawing.Size(121, 28);
            this.comboBoxMonths_KAH.TabIndex = 7;
            this.comboBoxMonths_KAH.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_KAH_SelectedIndexChanged);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder_KAH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBestProductsOfMonth_KAH;
        private System.Windows.Forms.Button buttonBestProductsOfYear_KAH;
        private System.Windows.Forms.Button buttonOrdersOfMonth_KAH;
        private System.Windows.Forms.Button buttonOrdersOfAllMonth_KAH;
        private System.Windows.Forms.ComboBox comboBoxMonths_KAH;
    }
}