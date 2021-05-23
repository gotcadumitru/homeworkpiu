using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;
namespace Firma_Wind_Forms
{
    public partial class Form1 : Form
    {
        IStocareData adminFirme;
        public Form1()
        {
            InitializeComponent();
            adminFirme = StocareFactory.GetAdministratorStocare();
        }

        private bool ValidareDateIntrare()
        {
            if (txtNumeFirma.Text.Length == 0)
            {
                txtFirmaError.Text = "Te rog introdu numele firmei";
                return false;
            }
            if (txtLogoUrl.Text.Length == 0)
            {
                txtFirmaError.Text = "Te rog introdu linkul catre logo";
                return false;
            }

            if (!float.TryParse(txtRaiting.Text, out float raiting) && (txtRaiting.Text.Length != 0))
            {
                txtFirmaError.Text = "Te rog introdu o valoare valida a raitingului (number)";
                return false;
            }
            txtFirmaError.Text = "";
            return true;
        }

        private void btnAdaugaFirma_Click(object sender, EventArgs e)
        {

            if (ValidareDateIntrare())
            {
                if (txtRaiting.Text.Length != 0)
                {
                    adminFirme.AddFirma(new Firma(txtNumeFirma.Text,txtLogoUrl.Text,float.Parse(txtRaiting.Text)));
                }
                else
                {
                    adminFirme.AddFirma(new Firma(txtNumeFirma.Text,txtLogoUrl.Text));
                }
            }
        }

        private void clearFirmaInputs()
        {
            txtNumeFirma.Text = "";
            txtRaiting.Text = "";
            txtLogoUrl.Text = "";
        }

        private void btnAfisareFirme_Click(object sender, EventArgs e)
        {
            lstFirme.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Firma", "Nr Livratori", "Raiting");
            lstFirme.Items.Add(antetTabel);

            var firme = adminFirme.GetFirme();
            
            foreach(var f in firme)
            {
                var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", f.IdFirma, f.NumeFirma, f.Livratori.Count.ToString(), f.RaitingFirma.ToString());
                lstFirme.Items.Add(linieTabel);
            }
        }

        private void lstFirme_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFirmaError.Text = "";
            // Get the currently selected item in the ListBox.
            string curItem = lstFirme.SelectedItem.ToString();
            Int32.TryParse(curItem.Split(' ')[0],out int id);

            if (id != 0)
            {
                var firma = adminFirme.GetFirmaByID(id);
                txtNumeFirma.Text = firma.NumeFirma;
                txtRaiting.Text = firma.RaitingFirma.ToString();
                txtLogoUrl.Text = firma.LogoUrl;
            }
            else
            {
                clearFirmaInputs();
            }
        }

        private void btnUpdateFirma_Click(object sender, EventArgs e)
        {
           
            if (lstFirme.SelectedItem != null)
            {
                string curItem = lstFirme.SelectedItem.ToString();

                Int32.TryParse(curItem.Split(' ')[0], out int id);
                if (id != 0)
                {
                    if (ValidareDateIntrare())
                    {

                        var firma = adminFirme.GetFirmaByID(id);
                        firma.NumeFirma = txtNumeFirma.Text;
                        firma.RaitingFirma = float.Parse(txtRaiting.Text);
                        firma.LogoUrl = txtLogoUrl.Text;
                        adminFirme.UpdateFirma(firma);
                        clearFirmaInputs();
                    }
                   
                }
                else
                {
                    txtFirmaError.Text = "Selecteaza o firma din lista";
                }
                
            }
            else
            {
                txtFirmaError.Text = "Selecteaza o firma din lista";
            }

        }

        private bool ValidareDateIntrareLivrator()
        {
            if (txtNumeLivrator.Text.Length == 0)
            {
                txtErorareLivrator.Text = "Te rog introdu numele livratorului";
                return false;
            }
            if (txtPrenumeLivrator.Text.Length == 0)
            {
                txtErorareLivrator.Text = "Te rog introdu prenumele livratorului";
                return false;
            }

            if (!GetVehicolSelectat().HasValue)
            {
                txtErorareLivrator.Text = "Te rog selecteaza un vehicol";
                return false;
            }
            
            txtErorareLivrator.Text = "";
            return true;
        }
        
        
        private TipVehicol? GetVehicolSelectat()
        {
            if (rdbAutomobil.Checked)
                return TipVehicol.Automobil;
            if (rdbAvion.Checked)
                return TipVehicol.Avion;
            if (rdbBicicleta.Checked)
                return TipVehicol.Bicicleta;
            if (rdbMotocicleta.Checked)
                return TipVehicol.Motocicleta;
            if (rdbTanc.Checked)
                return TipVehicol.Tanc;
            if (rdbTrotineta.Checked)
                return TipVehicol.Trotineta;

            return null;
        }
        private void btnAdaugaLivrator_Click(object sender, EventArgs e)
        {
            if (ValidareDateIntrareLivrator())
            {
                if (lstFirme.SelectedItem != null)
                {
                    string curItem = lstFirme.SelectedItem.ToString();

                    Int32.TryParse(curItem.Split(' ')[0], out int id);
                    if (id != 0)
                    {
                        var firma = adminFirme.GetFirmaByID(id);

                        TipVehicol? veh = GetVehicolSelectat();
                        if (veh.HasValue)
                        {
                            firma.AddLivrator(new Livrator(txtNumeLivrator.Text,txtPrenumeLivrator.Text,new Vehicol((TipVehicol)GetVehicolSelectat())));
                            adminFirme.UpdateFirma(firma);
                            txtNumeLivrator.Text = "";
                            txtPrenumeLivrator.Text = "";
                            
                            rdbBicicleta.Checked = false;
                            rdbAutomobil.Checked = false;
                            rdbAvion.Checked = false;
                            rdbMotocicleta.Checked = false;
                            rdbTanc.Checked = false;
                            rdbTrotineta.Checked = false;
                        }
                        
                        
                    }
                    else
                    {
                        txtErorareLivrator.Text = "Selecteaza o firma din lista";
                    }

                }
                else
                {
                    txtErorareLivrator.Text = "Selecteaza o firma din lista";
                }
            }
        }

        private void txtErorareLivrator_Click(object sender, EventArgs e)
        {
        }
    }
}