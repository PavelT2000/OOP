namespace Lab1
{
    partial class TransportInputControl
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
            lblCap = new Label();
            txtCap = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // lblCap
            // 
            lblCap.AutoSize = true;
            lblCap.Location = new Point(1, 8);
            lblCap.Name = "lblCap";
            lblCap.Size = new Size(53, 15);
            lblCap.TabIndex = 0;
            lblCap.Text = "Capacity";
            // 
            // txtCap
            // 
            txtCap.Location = new Point(3, 32);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(127, 23);
            txtCap.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(1, 81);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(127, 23);
            txtName.TabIndex = 3;
            // 
            // TransportInputControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtCap);
            Controls.Add(lblCap);
            Name = "TransportInputControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCap;
        private TextBox txtCap;
        private Label lblName;
        private TextBox txtName;
    }
}
