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
        }

        private void submitQuote_Click(object sender, EventArgs e)
        {
            var submitQuote = new DisplayQuote();
            DeskQuote dq = new DeskQuote(desk, rushAmt.SelectedIndex);
            submitQuote.quoteResult.Text = dq.calQuoteCost().ToString();
            submitQuote.Tag = this;
            this.Hide();
            submitQuote.ShowDialog();
            this.Close();
        }

    }
}
