using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using LibrarieModele;
using NivelAccesDate;
using ManagerM;

namespace ProiectMasini_FormsT10
{
    public partial class AdaugareForm : Form
    {

        IStocareData adminMasini;
        ArrayList optiuniSelectate = new ArrayList();

        public AdaugareForm()
        {
            InitializeComponent();
            adminMasini = ManagerMasini.GetAdministratorStocare();
        }

        private void AdaugareForm_Load(object sender, EventArgs e)
        {
           
        }

        private CodEroare Validare(string firma, string model,string anFabricatie,
                    string numeVanzator, string numeCumparator, string dataTranzactie, string pret)
        {

            if (firma == string.Empty)
            {
                return CodEroare.FIRMA_INCORECTA;
            }
            else if (model == string.Empty)
            {
                return CodEroare.MODEL_INCORECT;
            }
            else if (anFabricatie == string.Empty)
            {
                return CodEroare.AN_FABRICATIE_INCORECT;
            }
            else if (numeVanzator == string.Empty)
            {
                return CodEroare.NUME_VANZATOR_INCORECT;
            }
            else if (numeCumparator == string.Empty)
            {
                return CodEroare.NUME_CUMPARATOR_INCORECT;
            }
            else if (dataTranzactie == string.Empty)
            {
                return CodEroare.DATA_INCORECTA;
            }
            else if (pret == string.Empty)
            {
                return CodEroare.PRET_INCORECT;
            }
            


            return CodEroare.CORECT;
        }

        private Culori GetCuloareSelectata()
        {
            if (albRdb.Checked)
                return Culori.alb;
            if (albastruRdb.Checked)
                return Culori.albastru;
            if (movRdb.Checked)
                return Culori.mov;
            if (maroRdb.Checked)
                return Culori.maro;
            if (portocaliuRdb.Checked)
                return Culori.portocaliu;
            if (negruRdb.Checked)
                return Culori.negru;
            if (galbenRdb.Checked)
                return Culori.galben;
            if (verdeRdb.Checked)
                return Culori.verde;
            if (rosuRdb.Checked)
                return Culori.rosu;

            return Culori.culoare_inexistenta;
        }

        private int validareOptiuni()
        {
            if (absCheck.Checked == false && airbagCheck.Checked == false && cruiseCheck.Checked == false &&
                solarCheck.Checked == false && bluetoothCheck.Checked == false && proiectoareCheck.Checked == false &&
                pilotCheck.Checked == false && masajCheck.Checked == false && leatherCheck.Checked == false)
                return 0;
            return 1;
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

        public string OptiuniAsString()
        {

            string strOptiuni = string.Empty;

            foreach (string optiune in optiuniSelectate)
            {
                if (strOptiuni != string.Empty)
                {
                    strOptiuni += ", ";
                }
                strOptiuni += optiune;
            }

            return strOptiuni;

        }

        private void ckbDiscipline_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 

            string disciplinaSelectata = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(disciplinaSelectata);
            else
                optiuniSelectate.Remove(disciplinaSelectata);
        }

        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            Masina masina;

            firmaLbl.ForeColor = Color.Black;
            modelLbl.ForeColor = Color.Black;
            anFLbl.ForeColor = Color.Black;
            culoareLbl.ForeColor = Color.Black;
            numeVanzatorLbl.ForeColor = Color.Black;
            numeCumparatorLbl.ForeColor = Color.Black;
            dataLbl.ForeColor = Color.Black;
            pretLbl.ForeColor = Color.Black;
            optiuniLbl.ForeColor = Color.Black;

            firmaTxt.ForeColor = Color.Black;
            modelTxt.ForeColor = Color.Black;
            anFTxt.ForeColor = Color.Black;
            //culoareTxt.ForeColor = Color.Black;
            numeVanzatorTxt.ForeColor = Color.Black;
            numeCumparatorTxt.ForeColor = Color.Black;
            dataTxt.ForeColor = Color.Black;
            pretTxt.ForeColor = Color.Black;
            //optiuniTxt.ForeColor = Color.Black;
            CodEroare valideaza = Validare(firmaTxt.Text, modelTxt.Text,
                //culoareTxt.Text,
                anFTxt.Text, numeVanzatorTxt.Text, numeCumparatorTxt.Text, dataTxt.Text, pretTxt.Text
                //, optiuniTxt.Text
                );
            if (GetCuloareSelectata() == Culori.culoare_inexistenta)
            {
                culoareLbl.ForeColor = Color.Red;
            }
            else
            if (validareOptiuni() == 0)
            {
                optiuniLbl.ForeColor = Color.Red;
            }
            else
            if (valideaza != CodEroare.CORECT)
            {
                switch (valideaza)
                {
                    case CodEroare.FIRMA_INCORECTA:
                        firmaTxt.ForeColor = Color.Red;
                        if (firmaTxt.Text == string.Empty)
                            firmaLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.MODEL_INCORECT:
                        modelTxt.ForeColor = Color.Red;
                        if (modelTxt.Text == string.Empty)
                            modelLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.AN_FABRICATIE_INCORECT:
                        anFTxt.ForeColor = Color.Red;
                        if (anFTxt.Text == string.Empty)
                            anFLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.NUME_VANZATOR_INCORECT:
                        numeVanzatorTxt.ForeColor = Color.Red;
                        if (numeVanzatorTxt.Text == string.Empty)
                            numeVanzatorLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.NUME_CUMPARATOR_INCORECT:
                        numeCumparatorTxt.ForeColor = Color.Red;
                        if (numeCumparatorTxt.Text == string.Empty)
                            numeCumparatorLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.DATA_INCORECTA:
                        dataTxt.ForeColor = Color.Red;
                        if (dataTxt.Text == string.Empty)
                            dataLbl.ForeColor = Color.Red;
                        break;
                    case CodEroare.PRET_INCORECT:
                        pretTxt.ForeColor = Color.Red;
                        if (pretTxt.Text == string.Empty)
                            pretLbl.ForeColor = Color.Red;
                        break;
                }
            }
            else
            {
                string tip = tipCmbBox.Text.Trim();
                string optiuniMasinaForm = OptiuniAsString();
                masina = new Masina(numeVanzatorTxt.Text.ToString(), numeCumparatorTxt.Text.ToString()
                , firmaTxt.Text.ToString(), modelTxt.Text.ToString(), Convert.ToInt32(anFTxt.Text.ToString()),
                "rosu", optiuniMasinaForm, dataTxt.Text.ToString(), Convert.ToDouble(pretTxt.Text.ToString()), tip, DateTime.Now);


                masina.CuloareMasina = GetCuloareSelectata();
                masina.identificaCuloare();

                

                masina.Optiuni = new ArrayList();
                masina.Optiuni.AddRange(optiuniSelectate);





                ManagerMasini.addMasina(masina);


                List<Masina> masini = new List<Masina>(ManagerMasini.getMasiniList());
                File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\MasiniSalvate.txt", String.Empty);

                foreach (Masina m in masini)
                {
                    
                    adminMasini.AddMasina(m);

                }

            }
            ResetareControale();
            this.Close();
        }

        private void tipCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int optiuneCmb = tipCmbBox.SelectedIndex;

            if (optiuneCmb == 0)
            {
                absCheck.Text = "ABS";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Conectivitate Bluetooth";
                proiectoareCheck.Text = "Proiectoare ceata";
                pilotCheck.Text = "Pilot automat";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Full Leather";
            }
            if (optiuneCmb == 1)
            {
                absCheck.Text = "WiFi Hotspot";
                airbagCheck.Text = "Pachet Alcantara";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Fibra de carbon";
                proiectoareCheck.Text = "Frane ceramice";
                pilotCheck.Text = "Camere laterale";
                masajCheck.Text = "Smart Suspension";
                leatherCheck.Text = "Volan piele";
            }
            if (optiuneCmb == 2)
            {
                absCheck.Text = "Track Pace";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Full Leather";
                solarCheck.Text = "Keyless Entry";
                bluetoothCheck.Text = "Conectivitate Bluetooth";
                proiectoareCheck.Text = "Head-Up Display";
                pilotCheck.Text = "Power Tailgate";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Volan piele";
            }
            if (optiuneCmb == 3)
            {
                absCheck.Text = "Bara spate";
                airbagCheck.Text = "Airbaguri laterale";
                cruiseCheck.Text = "Cruise Control";
                solarCheck.Text = "Solar Roof";
                bluetoothCheck.Text = "Head-Up Display";
                proiectoareCheck.Text = "Keyless Entry";
                pilotCheck.Text = "Pilot automat";
                masajCheck.Text = "Scaune masaj";
                leatherCheck.Text = "Full Leather";
            }
        }
    }
}
