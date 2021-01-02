using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_Finder_Windows_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSurgeon_Click(object sender, EventArgs e)
        {
            SurgeonForm sf = new SurgeonForm();
            this.Close();
            sf.ShowDialog();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm gf = new GeneralForm();
            this.Close();
            gf.ShowDialog();

        }

        private void btnRadiologist_Click(object sender, EventArgs e)
        {
            RadiologistForm rf = new RadiologistForm();
            this.Close();
            rf.ShowDialog();
        }

        private void btnpediatrician_Click(object sender, EventArgs e)
        {
            PediatricianForm pf = new PediatricianForm();
            this.Close();
            pf.ShowDialog();
        }

        private void btnOptometrist_Click(object sender, EventArgs e)
        {
            OptometristForm of = new OptometristForm();
            this.Close();
            of.ShowDialog();
        }

        private void btnInternhist_Click(object sender, EventArgs e)
        {
            InternhistForm inf = new InternhistForm();
            this.Close();
            inf.ShowDialog();
        }

        private void btnDentist_Click(object sender, EventArgs e)
        {
            DentistForm df = new DentistForm();
            this.Close();
            df.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
