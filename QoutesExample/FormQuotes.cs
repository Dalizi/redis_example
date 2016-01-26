using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using StackExchange.Redis;

namespace QuotesExample
{
    public partial class FormQuotes : Form
    {
        public FormQuotes()
        {
            InitializeComponent();
           
        }


       
        public DataTable quotesTable;
        ConnectionMultiplexer conn;

        private void dataTableMarketQuotesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.dataGridViewQuotes.Refresh();
        }
    }
}
