namespace GlendeneCatCare
{
    partial class TreatmentForm
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
            this.lstBoxTreatments = new System.Windows.Forms.ListBox();
            this.lblTreatmentNo = new System.Windows.Forms.Label();
            this.lblTreatmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTreatment = new System.Windows.Forms.Button();
            this.btnUpdateTreatment = new System.Windows.Forms.Button();
            this.btnDeleteTreatment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxTreatments
            // 
            this.lstBoxTreatments.FormattingEnabled = true;
            this.lstBoxTreatments.Location = new System.Drawing.Point(36, 16);
            this.lstBoxTreatments.Name = "lstBoxTreatments";
            this.lstBoxTreatments.Size = new System.Drawing.Size(212, 290);
            this.lstBoxTreatments.TabIndex = 0;
            // 
            // lblTreatmentNo
            // 
            this.lblTreatmentNo.AutoSize = true;
            this.lblTreatmentNo.Location = new System.Drawing.Point(293, 16);
            this.lblTreatmentNo.Name = "lblTreatmentNo";
            this.lblTreatmentNo.Size = new System.Drawing.Size(72, 13);
            this.lblTreatmentNo.TabIndex = 1;
            this.lblTreatmentNo.Text = "Treatment ID:";
            // 
            // lblTreatmentID
            // 
            this.lblTreatmentID.AutoSize = true;
            this.lblTreatmentID.Location = new System.Drawing.Point(380, 16);
            this.lblTreatmentID.Name = "lblTreatmentID";
            this.lblTreatmentID.Size = new System.Drawing.Size(51, 13);
            this.lblTreatmentID.TabIndex = 2;
            this.lblTreatmentID.Text = "treatment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(293, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(293, 144);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(383, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(111, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(387, 137);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(107, 20);
            this.txtCost.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(36, 353);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(80, 29);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(158, 353);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddTreatment
            // 
            this.btnAddTreatment.Location = new System.Drawing.Point(274, 353);
            this.btnAddTreatment.Name = "btnAddTreatment";
            this.btnAddTreatment.Size = new System.Drawing.Size(91, 29);
            this.btnAddTreatment.TabIndex = 9;
            this.btnAddTreatment.Text = "Add Treatment";
            this.btnAddTreatment.UseVisualStyleBackColor = true;
            this.btnAddTreatment.Click += new System.EventHandler(this.btnAddTreatment_Click);
            // 
            // btnUpdateTreatment
            // 
            this.btnUpdateTreatment.Location = new System.Drawing.Point(406, 353);
            this.btnUpdateTreatment.Name = "btnUpdateTreatment";
            this.btnUpdateTreatment.Size = new System.Drawing.Size(116, 28);
            this.btnUpdateTreatment.TabIndex = 10;
            this.btnUpdateTreatment.Text = "Update Treatment";
            this.btnUpdateTreatment.UseVisualStyleBackColor = true;
            this.btnUpdateTreatment.Click += new System.EventHandler(this.btnUpdateTreatment_Click);
            // 
            // btnDeleteTreatment
            // 
            this.btnDeleteTreatment.Location = new System.Drawing.Point(563, 353);
            this.btnDeleteTreatment.Name = "btnDeleteTreatment";
            this.btnDeleteTreatment.Size = new System.Drawing.Size(97, 27);
            this.btnDeleteTreatment.TabIndex = 11;
            this.btnDeleteTreatment.Text = "Delete Treatment";
            this.btnDeleteTreatment.UseVisualStyleBackColor = true;
            this.btnDeleteTreatment.Click += new System.EventHandler(this.btnDeleteTreatment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(569, 420);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 28);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // TreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 464);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteTreatment);
            this.Controls.Add(this.btnUpdateTreatment);
            this.Controls.Add(this.btnAddTreatment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTreatmentID);
            this.Controls.Add(this.lblTreatmentNo);
            this.Controls.Add(this.lstBoxTreatments);
            this.Name = "TreatmentForm";
            this.Text = "Treatment Maintenance";
            this.Load += new System.EventHandler(this.TreatmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxTreatments;
        private System.Windows.Forms.Label lblTreatmentNo;
        private System.Windows.Forms.Label lblTreatmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTreatment;
        private System.Windows.Forms.Button btnUpdateTreatment;
        private System.Windows.Forms.Button btnDeleteTreatment;
        private System.Windows.Forms.Button btnReturn;
    }
}