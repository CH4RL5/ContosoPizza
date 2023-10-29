namespace CRUD_ContosoPizza.CRUD
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label4 = new Label();
            bSave = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 93);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 139);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(123, 23);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(136, 137);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(123, 23);
            txtPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(96, 38);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 6;
            label4.Text = "Add New Product";
            // 
            // bSave
            // 
            bSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bSave.Location = new Point(126, 187);
            bSave.Name = "bSave";
            bSave.Size = new Size(81, 36);
            bSave.TabIndex = 7;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += button1_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 271);
            Controls.Add(bSave);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = " Add New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label label4;
        private Button bSave;
    }
}