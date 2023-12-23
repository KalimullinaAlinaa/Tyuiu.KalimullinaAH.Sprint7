namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_KAH = new System.Windows.Forms.Label();
            this.buttonOk_KAH = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_KAH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KAH
            // 
            this.labelInfo_KAH.AutoSize = true;
            this.labelInfo_KAH.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_KAH.Location = new System.Drawing.Point(203, 21);
            this.labelInfo_KAH.Name = "labelInfo_KAH";
            this.labelInfo_KAH.Size = new System.Drawing.Size(335, 204);
            this.labelInfo_KAH.TabIndex = 7;
            this.labelInfo_KAH.Text = resources.GetString("labelInfo_KAH.Text");
            // 
            // buttonOk_KAH
            // 
            this.buttonOk_KAH.Location = new System.Drawing.Point(488, 229);
            this.buttonOk_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOk_KAH.Name = "buttonOk_KAH";
            this.buttonOk_KAH.Size = new System.Drawing.Size(107, 35);
            this.buttonOk_KAH.TabIndex = 6;
            this.buttonOk_KAH.Text = "OK";
            this.buttonOk_KAH.UseVisualStyleBackColor = true;
            this.buttonOk_KAH.Click += new System.EventHandler(this.buttonOk_KAH_Click);
            // 
            // pictureBoxAvatar_KAH
            // 
            this.pictureBoxAvatar_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint7.Project.V10.Properties.Resources.photo_5449884010940583175_y;
            this.pictureBoxAvatar_KAH.Location = new System.Drawing.Point(31, 21);
            this.pictureBoxAvatar_KAH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAvatar_KAH.Name = "pictureBoxAvatar_KAH";
            this.pictureBoxAvatar_KAH.Size = new System.Drawing.Size(148, 192);
            this.pictureBoxAvatar_KAH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_KAH.TabIndex = 8;
            this.pictureBoxAvatar_KAH.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 268);
            this.Controls.Add(this.pictureBoxAvatar_KAH);
            this.Controls.Add(this.labelInfo_KAH);
            this.Controls.Add(this.buttonOk_KAH);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAH;
        private System.Windows.Forms.Label labelInfo_KAH;
        private System.Windows.Forms.Button buttonOk_KAH;
    }
}