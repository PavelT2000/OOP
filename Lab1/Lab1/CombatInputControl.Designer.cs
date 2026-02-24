namespace Lab1
{
    partial class CombatInputControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblName = new Label();
            txtFirePower = new TextBox();
            lblCap = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 23);
            txtName.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(1, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // txtFirePower
            // 
            txtFirePower.Location = new Point(3, 33);
            txtFirePower.Name = "txtFirePower";
            txtFirePower.Size = new Size(127, 23);
            txtFirePower.TabIndex = 5;
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Location = new Point(1, 9);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(62, 15);
            lblCap.TabIndex = 4;
            lblCap.Text = "Fire Power";
            // 
            // CombatInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtFirePower);
            Controls.Add(lblCap);
            Name = "CombatInputControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private TextBox txtFirePower;
        private Label lblCap;
    }
}
