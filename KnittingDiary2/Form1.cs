using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnittingDiary2
{
    public partial class KnittingDiary : MaterialSkin.Controls.MaterialForm;
    {
        public KnittingDiary()
        {
            InitializeComponent();
        }

        private void KnittingDiary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.appData.Table);

        }
    }
}
