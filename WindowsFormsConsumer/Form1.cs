using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using WindowsFormsConsumer.ServiceReference1;


namespace WindowsFormsConsumer
{
    public partial class Form1 : Form
    {
        public WaitForm wform;
        public Form1()
        {
            wform = new WaitForm();
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient service = new ServiceReference1.Service1SoapClient();

            this.button1.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            this.wform.Show();

            int n = await service.FibonacciAsync(10);

            this.button1.Enabled = true;
            this.Cursor = Cursors.Default;
            this.wform.Hide();

            MessageBox.Show(n.ToString());
            
                    
        }
    }
}
