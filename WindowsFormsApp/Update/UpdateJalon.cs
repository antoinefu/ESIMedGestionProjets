using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Update
{
    public partial class UpdateJalon : Form
    {

        public int idJalon { get; set; }

        public UpdateJalon(int p_idJalon)
        {
            InitializeComponent();
            this.idJalon = p_idJalon;
        }

        private void UpdateJalon_Load(object sender, EventArgs e)
        {

        }
    }
}
