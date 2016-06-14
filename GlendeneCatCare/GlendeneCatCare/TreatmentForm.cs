using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlendeneCatCare
{
    public partial class TreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            lblTreatmentID.DataBindings.Add("Text", DM.DSGlendene, "Treatment.TreatmentID");
            txtDescription.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Description");
            txtCost.DataBindings.Add("Text", DM.DSGlendene, "Treatment.Cost");
            lstBoxTreatments.DataSource = DM.DSGlendene;
            lstBoxTreatments.DisplayMember = "Treatment.Description";
            lstBoxTreatments.ValueMember = "Treatment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.DSGlendene, "TREATMENT"];
        }
        private void TreatmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            lblTreatmentID.Text = null;
            DataRow newTreatmentRow = DM.dtTreatment.NewRow();
            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");
            }
            else
            {
                newTreatmentRow["Description"] = txtDescription.Text;
                newTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                DM.dtTreatment.Rows.Add(newTreatmentRow);
                MessageBox.Show("Treatment added successfully", "Success");
                DM.UpdateTreatment();
            }
            return;
        }

        private void btnDeleteTreatment_Click(object sender, EventArgs e)
        {
            DataRow deleteTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            DataRow[] VisitTreatmentRow = DM.dtVisitTreatment.Select("TreatmentID = " + lblTreatmentID.Text);
            if (VisitTreatmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning") == DialogResult.OK)
                {
                    deleteTreatmentRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Treatments that are not allocated to visits", "Error");
                return;
            }
            //Update
            DM.UpdateTreatment();
        }

        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            DataRow updateTreatmentRow = DM.dtTreatment.Rows[currencyManager.Position];
            if ((txtDescription.Text == "") || (txtCost.Text == ""))
            {
                MessageBox.Show("You must type in a Treatment description and cost", "Error");
            }
            else
            {
                updateTreatmentRow["Description"] = txtDescription.Text;
                updateTreatmentRow["Cost"] = Convert.ToDouble(txtCost.Text);
                currencyManager.EndCurrentEdit();
                DM.UpdateTreatment();
                MessageBox.Show("Treatment updated successfully", "Success");
            }
            return;
        }
    }
}
