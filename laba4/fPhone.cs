using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_5
{
    public partial class fPhone : Form
    {
        public Phone ThePhone;
        public fPhone(Phone t)
        {
            ThePhone = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePhone.Model = tbModel.Text.Trim();
            ThePhone.Diagonal = tbDiagonal.Text.Trim();
            ThePhone.Cores = int.Parse(tbCores.Text.Trim());
            ThePhone.Platform = tbPlatform.Text.Trim();
            ThePhone.SimQuantity = int.Parse(tbSimQuantity.Text.Trim());
            ThePhone.HasAI = chbHasAI.Checked;
            ThePhone.HasTypeC = chbHasTypeC.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            if (ThePhone != null)
            {
                tbModel.Text = ThePhone.Model;
                tbDiagonal.Text = ThePhone.Diagonal;
                tbCores.Text = ThePhone.Cores.ToString();
                tbPlatform.Text = ThePhone.Platform;
                tbSimQuantity.Text = ThePhone.SimQuantity.ToString();
                chbHasAI.Checked = ThePhone.HasAI;
                chbHasTypeC.Checked = ThePhone.HasTypeC;
            }
        }
    }
}
