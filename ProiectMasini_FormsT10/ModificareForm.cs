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
    public partial class ModificareForm : Form
    {

        IStocareData adminMasini;
        ArrayList optiuniSelectate = new ArrayList();

        private int id;
        private int nr;

        public ModificareForm(Masina mas,int nrC)
        {
            InitializeComponent();

            adminMasini = ManagerMasini.GetAdministratorStocare();

            id = mas.getIdMasina();
            nr = nrC;

            idLabel.Text = id.ToString();

            firmaTxt.Text = mas.firmaProp;
            modelTxt.Text = mas.modelProp;
            anFTxt.Text = mas.anFabricatie.ToString();


            if (mas.culoareProp == "alb")
                albRdb.Checked = true;
            else
                if (mas.culoareProp == "albastru")
                albastruRdb.Checked = true;
            else
                if (mas.culoareProp == "mov")
                movRdb.Checked = true;
            else
                if (mas.culoareProp == "galben")
                galbenRdb.Checked = true;
            else
                if (mas.culoareProp == "portocaliu")
                portocaliuRdb.Checked = true;
            else
                if (mas.culoareProp == "rosu")
                rosuRdb.Checked = true;
            else
                if (mas.culoareProp == "verde")
                verdeRdb.Checked = true;
            else
                if (mas.culoareProp == "maro")
                maroRdb.Checked = true;
            else
                if (mas.culoareProp == "negru")
                negruRdb.Checked = true;
            numeVanzatorTxt.Text = mas.numeVanzator;
            numeCumparatorTxt.Text = mas.numeCumparator;
            dataTxt.Text = mas.dataTranzactie;
            pretTxt.Text = mas.pretProp.ToString();
            //tipCmbBox.Text = mas.tipMasina;


            foreach (var culoare in culoareGrpBox.Controls)
            {
                if (culoare is RadioButton)
                {
                    var culoareBox = culoare as RadioButton;
                    if (culoareBox.Text == mas.culoareProp.ToString())
                    {
                        culoareBox.Checked = true;
                    }
                }
            }

            tipCmbBox.Text = mas.tipMasina.ToString();

            identificareOptiuni(mas);

            
        }
    
        private void identificareOptiuni(Masina m)
        {
            string[] optiuniSt = m.OptiuniAsString.Split(',');

            if (m.tipMasina.Trim().Equals("Sedan"))
            {
                foreach(string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("ABS"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Conectivitate Bluetooth"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Proiectoare ceata"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Pilot automat"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        leatherCheck.Checked = true;
                }
                
            }else if (m.tipMasina.Trim().Equals("Sport"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("WiFi Hotspot"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Pachet Alcantara"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Fibra de carbon"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Frane ceramice"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Camere laterale"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Smart Suspension"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Volan piele"))
                        leatherCheck.Checked = true;

                    
                }
                }else if (m.tipMasina.Trim().Equals("SUV"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("Track Pace"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Keyless Entry"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Conectivitate Bluetooth"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Head-Up Display"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Power Tailgate"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Volan piele"))
                        leatherCheck.Checked = true;
                }

                

            }else if (m.tipMasina.Trim().Equals("Lux"))
            {
                foreach (string opt in optiuniSt)
                {
                    if (opt.Trim().Equals("Bara spate"))
                        absCheck.Checked = true;
                    if (opt.Trim().Equals("Airbaguri laterale"))
                        airbagCheck.Checked = true;
                    if (opt.Trim().Equals("Cruise Control"))
                        cruiseCheck.Checked = true;
                    if (opt.Trim().Equals("Solar Roof"))
                        solarCheck.Checked = true;
                    if (opt.Trim().Equals("Head-Up Display"))
                        bluetoothCheck.Checked = true;
                    if (opt.Trim().Equals("Keyless Entry"))
                        proiectoareCheck.Checked = true;
                    if (opt.Trim().Equals("Pilot automat"))
                        pilotCheck.Checked = true;
                    if (opt.Trim().Equals("Scaune masaj"))
                        masajCheck.Checked = true;
                    if (opt.Trim().Equals("Full Leather"))
                        leatherCheck.Checked = true;
                }

            }
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


        private void tipMasinaLbl_Click(object sender, EventArgs e)
        {

        }

        private void ModificareForm_Load(object sender, EventArgs e)
        {

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

        private void modificaBtn_Click(object sender, EventArgs e)
        {
            Masina masina;

            if (nr == 1)
                masina = ManagerMasini.getMasina(id - 1);
            else
                masina = ManagerMasini.getMasina(id);

            masina.Optiuni = new ArrayList();
            masina.Optiuni.AddRange(optiuniSelectate);

            masina.firmaProp = firmaTxt.Text;
            masina.modelProp = modelTxt.Text;
            masina.anFabricatie = Convert.ToInt32(anFTxt.Text);
            masina.CuloareMasina = GetCuloareSelectata();
            masina.identificaCuloare();
            masina.numeVanzator = numeVanzatorTxt.Text;
            masina.numeCumparator = numeCumparatorTxt.Text;
            masina.dataTranzactie = dataTxt.Text;
            masina.pretProp = Convert.ToDouble(pretTxt.Text);
            if (OptiuniAsString() != string.Empty)
                masina.setOptiuni(OptiuniAsString());

            masina.dataActualizare = DateTime.Now;

            List<Masina> masini = new List<Masina>(ManagerMasini.getMasiniList());
            File.WriteAllText(@"C:\Users\sebyg\source\repos\ProiectMasiniPIU\ProiectMasiniPIU\MasiniSalvate.txt", String.Empty);

            foreach (Masina m in masini)
            {

                adminMasini.AddMasina(m);

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
