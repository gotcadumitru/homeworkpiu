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

            if (!float.TryParse(txtRaiting.Text, out float raiting))
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
            }
        }

        private void btnAfisareFirme_Click(object sender, EventArgs e)
        {
            rtbAfisare.Clear();
            var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Firma", "Nr Livratori", "Raiting");
            rtbAfisare.AppendText(antetTabel);

            var firme = adminFirme.GetFirme();
            
            foreach(var f in firme)
            {
                var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", f.IdFirma, f.NumeFirma, f.Livratori.Count.ToString(), f.RaitingFirma.ToString());
                rtbAfisare.AppendText(linieTabel);
            }
        }
    }
}