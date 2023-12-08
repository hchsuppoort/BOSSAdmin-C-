using System;
using System.Windows.Forms;

namespace BossAdmin
{

    public partial class ErrorDisplay
    {
        public ErrorDisplay()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }

    }
}