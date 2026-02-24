namespace Lab1
{
    public partial class Form1 : Form
    {
        private List<SpaceVessel> _fleet = new List<SpaceVessel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddShip_Click(object sender, EventArgs e)
        {
            try
            {
                _fleet.Add(new Destroyer("Starkiller"));
                _fleet.Add(new CargoFreighter("Jupiter-Transporter"));


                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Critical exception:{ex.Message}");
            }
        }
        private void UpdateUI()
        {
            MyListBox.Items.Clear();
            foreach (var ship in _fleet)
            {
                MyListBox.Items.Add(ship.GetStatus());
            }
        }

        private void cmbShipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelInputContainer.Controls.Clear(); // Убираем старое "окошко"

            UserControl selectedControl = cmbShipType.SelectedIndex switch
            {
                0 => new CombatInputControl(),    // Если выбрали "Боевой"
                1 => new TransportInputControl(), // Если выбрали "Транспортный"
                _ => throw new Exception("Неизвестный тип корабля")
            };

            selectedControl.Dock = DockStyle.Fill;
            panelInputContainer.Controls.Add(selectedControl);
        }
    }
    
    
}
