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
    public partial class CombatInputControl : UserControl
    {
        public string ShipName => txtName.Text;

        public int FirePower
        {
            get
            {
                if (!int.TryParse(txtFirePower.Text, out int result))
                    throw new FormatException("Fire power must be int");
                return result;
            }
        }
        public CombatInputControl()
        {
            InitializeComponent();
        }
    }
}
