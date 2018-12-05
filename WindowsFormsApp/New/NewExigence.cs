using bean;
using services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.New
{
    public partial class NewExigence : Form
    {
        public NewExigence()
        {
            InitializeComponent();
            CBTypeExigences.Items.Clear();
            CBTypeExigences.DisplayMember = "Text";
            CBTypeExigences.ValueMember = "Value";
            foreach (TypeExigence type in FactoryService.CreateServiceTypeExigence().GetAllTypeExigences())
            {
                CBTypeExigences.Items.Add(new { Text = type.Label, Value = type.Id });
            }
            RBYes.Checked = true;
            CBTypeExigences.Enabled = false;
        }

        private void NewExigence_Load(object sender, EventArgs e)
        {

        }
    }
}
