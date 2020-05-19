using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibrarieModele;
using NivelAccesDate;
using ManagerM;

namespace ProiectMasini_FormsT10
{
    public partial class AfisareForm : Form
    {

        IStocareData adminMasini;

        public AfisareForm()
        {
            InitializeComponent();
            adminMasini = ManagerMasini.GetAdministratorStocare();

            List<Masina> masini = new List<Masina>(ManagerMasini.getMasiniList());
            File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\MasiniSalvate.txt", String.Empty);

            afisareListBox.Items.Clear();
            var antetTabel = String.Format("{0,-8}{1,-30}{2,-30}{3,-20}{4,-15}{5,-15}{6,-14}{7,-20}{8,-10}\n", "Id", "Nume vanzator", "Nume cumparator", "Data tranzactie", "Firma", "Model", "Culoare", "An fabricatie", "Pret");
            afisareListBox.Items.Add(antetTabel);




            foreach (Masina m in masini)
            {
                int calculId = -8 - m.getIdMasina().ToString().Length + 1;
                int calculNumeVanzator = -30 - m.numeVanzator.Length + 10;
                int calculNumeCumparator = -30 - m.numeCumparator.Length + 7;
                int calculData = -20 - m.dataTranzactie.Length + 6;
                int calculFirma = -15 - m.firmaProp.Length + 4;
                int calculModel = -15 - m.modelProp.Length + 3;
                int calculCuloare = -14 - m.culoareProp.Length + 4;
                int calculAn = -20 - m.anFabricatie.ToString().Length + 2;
                int calculPret = -10 - m.pretProp.ToString().Length + 1;

                var mAfisare = String.Format("\n{0," + calculId.ToString() + "}{1," + calculNumeVanzator.ToString() + "}{2," + calculNumeCumparator.ToString() + "}{3," + calculData.ToString() + "}{4," + calculFirma.ToString() + "}{5," + calculModel.ToString() + "}{6," + calculCuloare.ToString() + "}{7," + calculAn.ToString() + "}{8," + calculPret.ToString() + "}\n",
                    m.getIdMasina().ToString(), m.numeVanzator, m.numeCumparator, m.dataTranzactie, m.firmaProp, m.modelProp, m.culoareProp, m.anFabricatie.ToString(), m.pretProp.ToString());
                afisareListBox.Items.Add(mAfisare);
                adminMasini.AddMasina(m);

            }
        }

        private void AfisareForm_Load(object sender, EventArgs e)
        {

        }

        private void afisareListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = afisareListBox.SelectedIndex - 1;
            Masina mas = adminMasini.GetMasinaByIndex(afisareListBox.SelectedIndex - 1);
            ModificareForm modificareForm = new ModificareForm(mas,1);
            modificareForm.ShowDialog();
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
