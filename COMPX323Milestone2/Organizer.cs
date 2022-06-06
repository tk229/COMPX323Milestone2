using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace COMPX323Milestone2
{
    public partial class Organizer : Form
    {
        public OracleConnection conn;
        public Organizer()
        {
            InitializeComponent();
        }

        private void buttonUpcomingEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
