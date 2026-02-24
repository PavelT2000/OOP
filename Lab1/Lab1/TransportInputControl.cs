using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class TransportInputControl : UserControl
    {
        public string ShipName => txtName.Text;

        public int Capacity
        {
            get
            {
                if (!int.TryParse(txtCap.Text, out int result))
                    throw new ArgumentException("Wrong capacity");
                return result;
            }
        }

        public TransportInputControl() { InitializeComponent(); }
    }
}
