using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnNewProjet_Click(object sender, EventArgs e)
        {
            NewProjet frmNewProjet = new NewProjet();
            frmNewProjet.ShowDialog(this);
            frmNewProjet.Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewProjet_Click_1(object sender, EventArgs e)
        {
            NewProjet frmNewProjet = new NewProjet();
            frmNewProjet.ShowDialog(this);
            frmNewProjet.Dispose();
        }
    }
}
