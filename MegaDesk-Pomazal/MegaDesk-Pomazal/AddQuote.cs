using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Pomazal
{
    
    public partial class AddQuote : Form
    {
        Desk desk;
        public AddQuote()
        {
            InitializeComponent();
            desk = new Desk();
            desk.deskWidth = (int)deskWidth.Value;
            desk.deskHeight = (int) deskHeight.Value;
        }

        private void submitQuote_Click(object sender, EventArgs e)
        {
            desk.numDrawers = (int)numDrawer.Value;
            if (Enum.TryParse<Desk.surfaceMaterial>(selectedSurfaceMaterial.SelectedItem?.ToString(), out var selectedMaterial))
                desk.selectedSurfaceMaterial = selectedMaterial;
            desk.deskHeight = (int)deskHeight.Value;
            desk.custName = (string)custName.Text;
            desk.deskWidth = (int)deskWidth.Value;
            var submitQuote = new DisplayQuote();
            int.TryParse(rushAmt.SelectedItem?.ToString(), out var rushAmtV);
            DeskQuote dq = new DeskQuote(desk, rushAmtV);
            var dqr = dq.CalQuoteCost();
            submitQuote.totalQuoteCost.Text = dqr.quoteAmount?.ToString("C");
            submitQuote.custNameQuote.Text = dqr.desk.custName;
            submitQuote.selectedMaterialQuote.Text = Enum.GetName(typeof(Desk.surfaceMaterial), dqr.desk.selectedSurfaceMaterial);
            submitQuote.drawerNumQuote.Text = dqr.desk.numDrawers?.ToString();
            submitQuote.heightQuote.Text = dqr.desk.deskHeight?.ToString();
            submitQuote.widthQuote.Text = dqr.desk.deskWidth?.ToString();
            submitQuote.Tag = this;
            this.Hide();
            submitQuote.ShowDialog();
            this.Close();
        }
    }
}
