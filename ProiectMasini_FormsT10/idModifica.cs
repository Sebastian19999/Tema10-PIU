using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;
using ManagerM;

namespace ProiectMasini_FormsT10
{
    public partial class idModifica : Form
    {
        public idModifica()
        {
            InitializeComponent();
        }

        public string getId()
        {
            return idTxt.Text;
        }

        private void idModifica_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTxt.Text);
            getId();
            Masina masina = ManagerMasini.getMasina(id);
            ModificareForm modifica = new ModificareForm(masina,2);
            modifica.ShowDialog();
            this.Close();
        }
    }
}
