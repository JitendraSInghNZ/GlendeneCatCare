namespace GlendeneCatCare
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnTreatment = new System.Windows.Forms.Button();
            this.btnVeterinarian = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnTreatment);
            this.grpMaintenance.Controls.Add(this.btnVeterinarian);
            this.grpMaintenance.Location = new System.Drawing.Point(12, 12);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(254, 156);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnTreatment
            // 
            this.btnTreatment.Location = new System.Drawing.Point(24, 99);
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Size = new System.Drawing.Size(220, 24);
            this.btnTreatment.TabIndex = 3;
            this.btnTreatment.Text = "Treatment Maintenance";
            this.btnTreatment.UseVisualStyleBackColor = true;
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnVeterinarian
            // 
            this.btnVeterinarian.Location = new System.Drawing.Point(24, 43);
            this.btnVeterinarian.Name = "btnVeterinarian";
            this.btnVeterinarian.Size = new System.Drawing.Size(220, 26);
            this.btnVeterinarian.TabIndex = 1;
            this.btnVeterinarian.Text = "Veterinarian  Maintenance";
            this.btnVeterinarian.UseVisualStyleBackColor = true;
            this.btnVeterinarian.Click += new System.EventHandler(this.btnVeterinarian_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Location = new System.Drawing.Point(12, 190);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(257, 139);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            this.grpReport.Enter += new System.EventHandler(this.grpReport_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(26, 91);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 24);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(26, 29);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(207, 28);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 334);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnTreatment;
        private System.Windows.Forms.Button btnVeterinarian;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
    }
}

