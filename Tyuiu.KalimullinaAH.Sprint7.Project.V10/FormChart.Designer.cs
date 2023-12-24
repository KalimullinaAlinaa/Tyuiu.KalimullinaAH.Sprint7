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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panelButton_KAH = new System.Windows.Forms.Panel();
            this.groupBoxSort_KAH = new System.Windows.Forms.GroupBox();
            this.groupBoxButtonChart_KAH = new System.Windows.Forms.GroupBox();
            this.comboBoxMonths_KAH = new System.Windows.Forms.ComboBox();
            this.buttonBestProductsOfMonth_KAH = new System.Windows.Forms.Button();
            this.buttonOrdersOfMonth_KAH = new System.Windows.Forms.Button();
            this.buttonOrdersOfAllMonth_KAH = new System.Windows.Forms.Button();
            this.panelChart_KAH = new System.Windows.Forms.Panel();
            this.chartOrder_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelButton_KAH.SuspendLayout();
            this.groupBoxSort_KAH.SuspendLayout();
            this.groupBoxButtonChart_KAH.SuspendLayout();
            this.panelChart_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton_KAH
            // 
            this.panelButton_KAH.Controls.Add(this.groupBoxSort_KAH);
            this.panelButton_KAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton_KAH.Location = new System.Drawing.Point(0, 0);
            this.panelButton_KAH.Name = "panelButton_KAH";
            this.panelButton_KAH.Size = new System.Drawing.Size(284, 506);
            this.panelButton_KAH.TabIndex = 0;
            // 
            // groupBoxSort_KAH
            // 
            this.groupBoxSort_KAH.Controls.Add(this.groupBoxButtonChart_KAH);
            this.groupBoxSort_KAH.Controls.Add(this.buttonOrdersOfAllMonth_KAH);
            this.groupBoxSort_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSort_KAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSort_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSort_KAH.Name = "groupBoxSort_KAH";
            this.groupBoxSort_KAH.Size = new System.Drawing.Size(284, 506);
            this.groupBoxSort_KAH.TabIndex = 1;
            this.groupBoxSort_KAH.TabStop = false;
            this.groupBoxSort_KAH.Text = "Сортировать график  по:";
            // 
            // groupBoxButtonChart_KAH
            // 
            this.groupBoxButtonChart_KAH.Controls.Add(this.comboBoxMonths_KAH);
            this.groupBoxButtonChart_KAH.Controls.Add(this.buttonBestProductsOfMonth_KAH);
            this.groupBoxButtonChart_KAH.Controls.Add(this.buttonOrdersOfMonth_KAH);
            this.groupBoxButtonChart_KAH.Location = new System.Drawing.Point(6, 26);
            this.groupBoxButtonChart_KAH.Name = "groupBoxButtonChart_KAH";
            this.groupBoxButtonChart_KAH.Size = new System.Drawing.Size(268, 261);
            this.groupBoxButtonChart_KAH.TabIndex = 8;
            this.groupBoxButtonChart_KAH.TabStop = false;
            // 
            // comboBoxMonths_KAH
            // 
            this.comboBoxMonths_KAH.FormattingEnabled = true;
            this.comboBoxMonths_KAH.Location = new System.Drawing.Point(15, 205);
            this.comboBoxMonths_KAH.Name = "comboBoxMonths_KAH";
            this.comboBoxMonths_KAH.Size = new System.Drawing.Size(237, 28);
            this.comboBoxMonths_KAH.TabIndex = 7;
            this.comboBoxMonths_KAH.Text = "Выберите месяц:";
            // 
            // buttonBestProductsOfMonth_KAH
            // 
            this.buttonBestProductsOfMonth_KAH.Location = new System.Drawing.Point(15, 119);
            this.buttonBestProductsOfMonth_KAH.Name = "buttonBestProductsOfMonth_KAH";
            this.buttonBestProductsOfMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonBestProductsOfMonth_KAH.TabIndex = 6;
            this.buttonBestProductsOfMonth_KAH.Text = "Популярным позициям за месяц:";
            this.buttonBestProductsOfMonth_KAH.UseVisualStyleBackColor = true;
            this.buttonBestProductsOfMonth_KAH.Click += new System.EventHandler(this.buttonBestProductsOfMonth_KAH_Click);
            // 
            // buttonOrdersOfMonth_KAH
            // 
            this.buttonOrdersOfMonth_KAH.Location = new System.Drawing.Point(15, 26);
            this.buttonOrdersOfMonth_KAH.Name = "buttonOrdersOfMonth_KAH";
            this.buttonOrdersOfMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonOrdersOfMonth_KAH.TabIndex = 4;
            this.buttonOrdersOfMonth_KAH.Text = "Динамике заказов за месяц:";
            this.buttonOrdersOfMonth_KAH.UseVisualStyleBackColor = true;
            this.buttonOrdersOfMonth_KAH.Click += new System.EventHandler(this.buttonOrdersOfMonth_KAH_Click);
            // 
            // buttonOrdersOfAllMonth_KAH
            // 
            this.buttonOrdersOfAllMonth_KAH.Location = new System.Drawing.Point(21, 314);
            this.buttonOrdersOfAllMonth_KAH.Name = "buttonOrdersOfAllMonth_KAH";
            this.buttonOrdersOfAllMonth_KAH.Size = new System.Drawing.Size(237, 63);
            this.buttonOrdersOfAllMonth_KAH.TabIndex = 3;
            this.buttonOrdersOfAllMonth_KAH.Text = "Динамике заказов за год:";
            this.buttonOrdersOfAllMonth_KAH.UseVisualStyleBackColor = true;
            this.buttonOrdersOfAllMonth_KAH.Click += new System.EventHandler(this.buttonOrdersOfAllMonth_KAH_Click);
            // 
            // panelChart_KAH
            // 
            this.panelChart_KAH.Controls.Add(this.chartOrder_KAH);
            this.panelChart_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_KAH.Location = new System.Drawing.Point(284, 0);
            this.panelChart_KAH.Name = "panelChart_KAH";
            this.panelChart_KAH.Size = new System.Drawing.Size(998, 506);
            this.panelChart_KAH.TabIndex = 0;
            // 
            // chartOrder_KAH
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOrder_KAH.ChartAreas.Add(chartArea1);
            this.chartOrder_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Orders";
            this.chartOrder_KAH.Legends.Add(legend1);
            this.chartOrder_KAH.Location = new System.Drawing.Point(0, 0);
            this.chartOrder_KAH.Name = "chartOrder_KAH";
            this.chartOrder_KAH.Size = new System.Drawing.Size(998, 506);
            this.chartOrder_KAH.TabIndex = 0;
            this.chartOrder_KAH.Text = " ";
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 506);
            this.Controls.Add(this.panelChart_KAH);
            this.Controls.Add(this.panelButton_KAH);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.panelButton_KAH.ResumeLayout(false);
            this.groupBoxSort_KAH.ResumeLayout(false);
            this.groupBoxButtonChart_KAH.ResumeLayout(false);
            this.panelChart_KAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrder_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_KAH;
        private System.Windows.Forms.Panel panelChart_KAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrder_KAH;
        private System.Windows.Forms.GroupBox groupBoxSort_KAH;
        private System.Windows.Forms.Button buttonBestProductsOfMonth_KAH;
        private System.Windows.Forms.Button buttonOrdersOfMonth_KAH;
        private System.Windows.Forms.Button buttonOrdersOfAllMonth_KAH;
        private System.Windows.Forms.ComboBox comboBoxMonths_KAH;
        private System.Windows.Forms.GroupBox groupBoxButtonChart_KAH;
    }
}