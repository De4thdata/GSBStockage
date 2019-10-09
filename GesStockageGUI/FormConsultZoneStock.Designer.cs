namespace GesStockageGUI
{
    partial class FormConsultZoneStock
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
            this.dataConsultZoneStock = new System.Windows.Forms.DataGridView();
            this.btnConsultZoneStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultZoneStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataConsultZoneStock
            // 
            this.dataConsultZoneStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsultZoneStock.Location = new System.Drawing.Point(116, 32);
            this.dataConsultZoneStock.Name = "dataConsultZoneStock";
            this.dataConsultZoneStock.Size = new System.Drawing.Size(555, 150);
            this.dataConsultZoneStock.TabIndex = 0;
            // 
            // btnConsultZoneStock
            // 
            this.btnConsultZoneStock.Location = new System.Drawing.Point(276, 233);
            this.btnConsultZoneStock.Name = "btnConsultZoneStock";
            this.btnConsultZoneStock.Size = new System.Drawing.Size(213, 76);
            this.btnConsultZoneStock.TabIndex = 1;
            this.btnConsultZoneStock.Text = "Consulter";
            this.btnConsultZoneStock.UseVisualStyleBackColor = true;
            // 
            // FormConsultZoneStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultZoneStock);
            this.Controls.Add(this.dataConsultZoneStock);
            this.Name = "FormConsultZoneStock";
            this.Text = "FormConsultZoneStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultZoneStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataConsultZoneStock;
        private System.Windows.Forms.Button btnConsultZoneStock;
    }
}