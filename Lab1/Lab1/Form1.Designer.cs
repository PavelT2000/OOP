namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MyListBox = new ListBox();
            AddShip = new Button();
            cmbShipType = new ComboBox();
            panelInputContainer = new Panel();
            SuspendLayout();
            // 
            // MyListBox
            // 
            MyListBox.FormattingEnabled = true;
            MyListBox.Location = new Point(477, 105);
            MyListBox.Name = "MyListBox";
            MyListBox.Size = new Size(248, 199);
            MyListBox.TabIndex = 0;
            // 
            // AddShip
            // 
            AddShip.Location = new Point(105, 225);
            AddShip.Name = "AddShip";
            AddShip.Size = new Size(75, 23);
            AddShip.TabIndex = 1;
            AddShip.Text = "AddShip";
            AddShip.UseVisualStyleBackColor = true;
            AddShip.Click += AddShip_Click;
            // 
            // cmbShipType
            // 
            cmbShipType.FormattingEnabled = true;
            cmbShipType.Items.AddRange(new object[] { "Combat", "Transport" });
            cmbShipType.Location = new Point(105, 77);
            cmbShipType.Name = "cmbShipType";
            cmbShipType.Size = new Size(142, 23);
            cmbShipType.TabIndex = 2;
            cmbShipType.SelectedIndexChanged += cmbShipType_SelectedIndexChanged;
            // 
            // panelInputContainer
            // 
            panelInputContainer.Location = new Point(105, 104);
            panelInputContainer.Name = "panelInputContainer";
            panelInputContainer.Size = new Size(142, 115);
            panelInputContainer.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelInputContainer);
            Controls.Add(cmbShipType);
            Controls.Add(AddShip);
            Controls.Add(MyListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox MyListBox;
        private Button AddShip;
        private ComboBox cmbShipType;
        private Panel panelInputContainer;
    }
}
