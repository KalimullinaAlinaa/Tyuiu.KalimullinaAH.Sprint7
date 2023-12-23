namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.panelTitle_KAH = new System.Windows.Forms.Panel();
            this.panelManual_KAH = new System.Windows.Forms.Panel();
            this.textBoxManual_KAH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Manual_KAH = new System.Windows.Forms.Label();
            this.panelTitle_KAH.SuspendLayout();
            this.panelManual_KAH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_KAH
            // 
            this.panelTitle_KAH.Controls.Add(this.label_Manual_KAH);
            this.panelTitle_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle_KAH.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitle_KAH.Name = "panelTitle_KAH";
            this.panelTitle_KAH.Size = new System.Drawing.Size(800, 54);
            this.panelTitle_KAH.TabIndex = 0;
            // 
            // panelManual_KAH
            // 
            this.panelManual_KAH.Controls.Add(this.groupBox1);
            this.panelManual_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManual_KAH.Location = new System.Drawing.Point(0, 54);
            this.panelManual_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelManual_KAH.Name = "panelManual_KAH";
            this.panelManual_KAH.Size = new System.Drawing.Size(800, 508);
            this.panelManual_KAH.TabIndex = 2;
            // 
            // textBoxManual_KAH
            // 
            this.textBoxManual_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxManual_KAH.Location = new System.Drawing.Point(3, 24);
            this.textBoxManual_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxManual_KAH.Multiline = true;
            this.textBoxManual_KAH.Name = "textBoxManual_KAH";
            this.textBoxManual_KAH.ReadOnly = true;
            this.textBoxManual_KAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxManual_KAH.Size = new System.Drawing.Size(794, 480);
            this.textBoxManual_KAH.TabIndex = 0;
            this.textBoxManual_KAH.Text = resources.GetString("textBoxManual_KAH.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxManual_KAH);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(800, 508);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label_Manual_KAH
            // 
            this.label_Manual_KAH.AutoSize = true;
            this.label_Manual_KAH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Manual_KAH.Location = new System.Drawing.Point(299, 19);
            this.label_Manual_KAH.Name = "label_Manual_KAH";
            this.label_Manual_KAH.Size = new System.Drawing.Size(207, 20);
            this.label_Manual_KAH.TabIndex = 0;
            this.label_Manual_KAH.Text = "Руководство пользователя";
            this.label_Manual_KAH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panelManual_KAH);
            this.Controls.Add(this.panelTitle_KAH);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.panelTitle_KAH.ResumeLayout(false);
            this.panelTitle_KAH.PerformLayout();
            this.panelManual_KAH.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle_KAH;
        private System.Windows.Forms.Label label_Manual_KAH;
        private System.Windows.Forms.Panel panelManual_KAH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxManual_KAH;
    }
}