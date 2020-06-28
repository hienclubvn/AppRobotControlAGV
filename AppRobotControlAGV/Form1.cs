using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRobotControlAGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBidings();
        }
        private void DataBidings()
        {
            grbSerialOptions.DataBindings.Add   (new Binding("Enabled", rdbSerial,  "Checked", true, DataSourceUpdateMode.OnPropertyChanged));
            grbTCPOptions.DataBindings.Add      (new Binding("Enabled", rdbTCP,     "Checked", true, DataSourceUpdateMode.OnPropertyChanged));
            grbUSBOptions.DataBindings.Add      (new Binding("Enabled", rdbUSB,     "Checked", true, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
