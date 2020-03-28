using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticsAlgoritm
{
    public partial class FormGeneticAlgorithm : Form
    {
        public FormGeneticAlgorithm()
        {
            InitializeComponent();
        }

        private Start s;
        private void bCalc_Click(object sender, EventArgs e)
        {
            s = new Start(Convert.ToInt32(nPB.Value),
                Convert.ToDouble(nCo.Value), 
                Convert.ToDouble(nMO.Value), 
                Convert.ToInt32(nS.Value), 
                Convert.ToDouble(nPP.Value), 
                comboBox1.SelectedIndex);
            s.Chart = cData;
            s.Run(Convert.ToInt32(nJS.Value));
        }
    }
}
