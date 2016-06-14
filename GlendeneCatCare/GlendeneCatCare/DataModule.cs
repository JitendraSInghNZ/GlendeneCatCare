using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;
        public DataView catView;
        public DataView treatmentView;
        public DataView ownergView;
        public DataView veterinarianView;
        public DataView visitView;
        public DataView visitTreatmentView;

        public DataModule()
        {
            InitializeComponent();
            DSGlendene.EnforceConstraints = false;
            daCat.Fill(DSGlendene);
            daTreatment.Fill(DSGlendene);
            daOwner.Fill(DSGlendene);
            daVisit.Fill(DSGlendene);
            daVeterinarian.Fill(DSGlendene);
            daVisitTreatment.Fill(DSGlendene);
            dtCat = DSGlendene.Tables["Cat"];
            dtTreatment = DSGlendene.Tables["Treatment"];
            dtOwner = DSGlendene.Tables["Owner"];
            dtVeterinarian = DSGlendene.Tables["Veterinarian"];
            dtVisit = DSGlendene.Tables["Visit"];
            dtVisitTreatment = DSGlendene.Tables["VisitTreatment"];
            catView = new DataView(dtCat);
            catView.Sort = "CatID";
            ownergView = new DataView(dtOwner);
            ownergView.Sort = "OwnerID";
            treatmentView = new DataView(dtTreatment);
            treatmentView.Sort = "TreatmentID";
            veterinarianView = new DataView(dtVeterinarian);
            veterinarianView.Sort = "VeterinarianID";
            DSGlendene.EnforceConstraints = true;
        }
        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }
        public void UpdateVeterinarian()
        {
            daVeterinarian.Update(dtVeterinarian);
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daTreatment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //Include a variable and a command to retrive
            //the identity value from the Access database
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnGlendene);
            if (e.StatementType == StatementType.Insert)
            { 
                //retrive the identity value
                //store it in the TreatmentID
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TreatmentID"] = newID;
            }
        }
    }
}
