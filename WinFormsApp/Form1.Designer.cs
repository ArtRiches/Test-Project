namespace WinFormsApp
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
            button1 = new Button();
            inputPriceWithNDS = new TextBox();
            ProcNDS = new TextBox();
            lable1 = new Label();
            lable2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(388, 63);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 0;
            button1.Text = "test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputPriceWithNDS
            // 
            inputPriceWithNDS.Location = new Point(103, 39);
            inputPriceWithNDS.Name = "inputPriceWithNDS";
            inputPriceWithNDS.PlaceholderText = "Напишите число через точку";
            inputPriceWithNDS.Size = new Size(258, 23);
            inputPriceWithNDS.TabIndex = 1;
            inputPriceWithNDS.TextChanged += textBox1_TextChanged;
            // 
            // ProcNDS
            // 
            ProcNDS.Location = new Point(103, 100);
            ProcNDS.Name = "ProcNDS";
            ProcNDS.PlaceholderText = "Напишите число через точку";
            ProcNDS.Size = new Size(258, 23);
            ProcNDS.TabIndex = 2;
            ProcNDS.TextChanged += textBox2_TextChanged;
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(104, 17);
            lable1.Name = "lable1";
            lable1.Size = new Size(109, 15);
            lable1.TabIndex = 3;
            lable1.Text = "InputPriceWithNDS";
            lable1.Click += label1_Click;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(104, 74);
            lable2.Name = "lable2";
            lable2.Size = new Size(54, 15);
            lable2.TabIndex = 4;
            lable2.Text = "ProcNDS";
            lable2.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(103, 153);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 198);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 6;
            label1.Text = "correctedPriceWithNDS";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 247);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 7;
            label2.Text = "correctedPriceWithoutNDS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(273, 198);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLightLight;
            label5.Location = new Point(273, 247);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 408);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lable2);
            Controls.Add(lable1);
            Controls.Add(ProcNDS);
            Controls.Add(inputPriceWithNDS);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox inputPriceWithNDS;
        private TextBox ProcNDS;
        private Label lable1;
        private Label lable2;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
