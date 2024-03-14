namespace projekt_gridform_lab3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 278);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Stanowsko";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 53);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 1;
            label2.Text = "Imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 204);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 134);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Nazwisko";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(23, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 31);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "pracownik1", "pracownik2 ", "pracownik3" });
            comboBox1.Location = new Point(23, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(290, 363);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Anuluj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(37, 363);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Zatwierdź";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}