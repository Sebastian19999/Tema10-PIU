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
using System.Collections;
using LibrarieModele;
using NivelAccesDate;
using ManagerM;

namespace ProiectMasini_FormsT10
{
    public partial class CautareForm : Form
    {

        IStocareData adminMasini;
        ArrayList optiuniSelectate = new ArrayList();

        public CautareForm()
        {
            InitializeComponent();
            adminMasini = ManagerMasini.GetAdministratorStocare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Masina> cautari = new List<Masina>(ManagerMasini.CautareMasiniFormsDate(firmaTxt.Text, modelTxt.Text,
                                        getCuloareCautata(), anFTxt.Text, numeVanzatorTxt.Text, numeCumparatorTxt.Text,
                                        dataTxt.Text, pretTxt.Text, "ABS",
                                        startDateTimePicker.Value.ToString(),stopDateTimePicker.Value.ToString()));

            var antetTabel = String.Format("{0,-8}{1,-30}{2,-30}{3,-20}{4,-15}{5,-15}{6,-14}{7,-20}{8,-10}\n", "Id", "Nume vanzator", "Nume cumparator", "Data tranzactie", "Firma", "Model", "Culoare", "An fabricatie", "Pret");
            AdaugaStudentiInControlDataGridView(cautari);
            ResetareControale();
        }

        private void AdaugaStudentiInControlDataGridView(List<Masina> masini)
        {
            afisareGridView.DataSource = null;

            
            afisareGridView.DataSource = masini.Select(mas => new { V = mas.getIdMasina(), mas.firmaProp,mas.modelProp,mas.anFabricatie,mas.culoareProp,mas.numeVanzator,mas.numeCumparator,mas.dataTranzactie,mas.pretProp,mas.tipMasina,mas.dataActualizare,mas.OptiuniAsString}).ToList(); //s.Nume, s.Prenume, s.ProgramSTD, Discipline = string.Join(",", s.Discipline), Note = string.Join(",", s.GetNote()), s.DataNastere, s.DataActualizare }).ToList();
        }

        private string getCuloareCautata()
        {
            if (albRdb.Checked == true)
                return "alb";
            if (albastruRdb.Checked == true)
                return "albastru";
            if (movRdb.Checked == true)
                return "mov";
            if (galbenRdb.Checked == true)
                return "galben";
            if (portocaliuRdb.Checked == true)
                return "portocaliu";
            if (rosuRdb.Checked == true)
                return "rosu";
            if (verdeRdb.Checked == true)
                return "verde";
            if (maroRdb.Checked == true)
                return "maro";
            if (negruRdb.Checked == true)
                return "negru";
            return string.Empty;
        }

        private void ResetareControale()
        {
            firmaTxt.Text = string.Empty;
            modelTxt.Text = string.Empty;
            anFTxt.Text = string.Empty;
            numeVanzatorTxt.Text = string.Empty;
            numeCumparatorTxt.Text = string.Empty;
            dataTxt.Text = string.Empty;
            pretTxt.Text = string.Empty;
            albRdb.Checked = false;
            albastruRdb.Checked = false;
            rosuRdb.Checked = false;
            portocaliuRdb.Checked = false;
            negruRdb.Checked = false;
            verdeRdb.Checked = false;
            maroRdb.Checked = false;
            movRdb.Checked = false;
            galbenRdb.Checked = false;
            absCheck.Checked = false;
            airbagCheck.Checked = false;
            cruiseCheck.Checked = false;
            solarCheck.Checked = false;
            bluetoothCheck.Checked = false;
            proiectoareCheck.Checked = false;
            pilotCheck.Checked = false;
            masajCheck.Checked = false;
            leatherCheck.Checked = false;
            optiuniSelectate.Clear();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CautareForm_Load(object sender, EventArgs e)
        {

        }
    }
}
