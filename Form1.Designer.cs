namespace Practica_20
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
            label1 = new Label();
            label2 = new Label();
            edad = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(427, 52);
            label1.TabIndex = 0;
            label1.Text = "Este programa determinara en que rango de\r\ndesarrollo se encuentra en base a su edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(196, 26);
            label2.TabIndex = 1;
            label2.Text = "Introduzca su edad:";
            // 
            // edad
            // 
            edad.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            edad.Location = new Point(234, 111);
            edad.Name = "edad";
            edad.Size = new Size(169, 33);
            edad.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(142, 176);
            button1.Name = "button1";
            button1.Size = new Size(134, 37);
            button1.TabIndex = 3;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 244);
            Controls.Add(button1);
            Controls.Add(edad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Practica 20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox edad;
        private Button button1;
    }
}