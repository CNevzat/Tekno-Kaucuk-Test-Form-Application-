namespace TeknoKaucukYazılım_Test_1_
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
            this.textbox_multiplication_table = new System.Windows.Forms.TextBox();
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.button_mtable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fibonacci_input = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fibonacci_output = new System.Windows.Forms.TextBox();
            this.fibonacci_output2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_multiplication_table
            // 
            this.textbox_multiplication_table.BackColor = System.Drawing.SystemColors.Info;
            this.textbox_multiplication_table.Location = new System.Drawing.Point(-1, 154);
            this.textbox_multiplication_table.Multiline = true;
            this.textbox_multiplication_table.Name = "textbox_multiplication_table";
            this.textbox_multiplication_table.Size = new System.Drawing.Size(1142, 185);
            this.textbox_multiplication_table.TabIndex = 0;
            // 
            // textbox_input
            // 
            this.textbox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_input.Location = new System.Drawing.Point(467, 55);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(225, 27);
            this.textbox_input.TabIndex = 1;
            // 
            // button_mtable
            // 
            this.button_mtable.BackColor = System.Drawing.Color.PowderBlue;
            this.button_mtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_mtable.ForeColor = System.Drawing.Color.Green;
            this.button_mtable.Location = new System.Drawing.Point(403, 99);
            this.button_mtable.Name = "button_mtable";
            this.button_mtable.Size = new System.Drawing.Size(354, 39);
            this.button_mtable.TabIndex = 11;
            this.button_mtable.Text = "Çarpım Tablosu Oluştur";
            this.button_mtable.UseVisualStyleBackColor = false;
            this.button_mtable.Click += new System.EventHandler(this.button_mtable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(483, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "1-15 arası bir sayı giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textbox_multiplication_table);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_input);
            this.groupBox1.Controls.Add(this.button_mtable);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 355);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEVSELLİK 3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 306);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEVSELLİK 4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(6, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dosya Yükle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(0, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 27);
            this.textBox2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 148);
            this.listBox1.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.l3);
            this.groupBox3.Controls.Add(this.l2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.fibonacci_output2);
            this.groupBox3.Controls.Add(this.fibonacci_output);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.fibonacci_input);
            this.groupBox3.Location = new System.Drawing.Point(374, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(766, 306);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İŞLEVSELLİK 5";
            // 
            // fibonacci_input
            // 
            this.fibonacci_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fibonacci_input.Location = new System.Drawing.Point(277, 41);
            this.fibonacci_input.Name = "fibonacci_input";
            this.fibonacci_input.Size = new System.Drawing.Size(163, 27);
            this.fibonacci_input.TabIndex = 0;
            this.fibonacci_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(307, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Fibonacci";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fibonacci_output
            // 
            this.fibonacci_output.BackColor = System.Drawing.SystemColors.Info;
            this.fibonacci_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fibonacci_output.Location = new System.Drawing.Point(10, 159);
            this.fibonacci_output.Multiline = true;
            this.fibonacci_output.Name = "fibonacci_output";
            this.fibonacci_output.Size = new System.Drawing.Size(738, 91);
            this.fibonacci_output.TabIndex = 15;
            // 
            // fibonacci_output2
            // 
            this.fibonacci_output2.BackColor = System.Drawing.SystemColors.Info;
            this.fibonacci_output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fibonacci_output2.ForeColor = System.Drawing.Color.Blue;
            this.fibonacci_output2.Location = new System.Drawing.Point(10, 94);
            this.fibonacci_output2.Multiline = true;
            this.fibonacci_output2.Name = "fibonacci_output2";
            this.fibonacci_output2.Size = new System.Drawing.Size(123, 28);
            this.fibonacci_output2.TabIndex = 16;
            this.fibonacci_output2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(277, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sıra numarası giriniz";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l2.Location = new System.Drawing.Point(6, 71);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(131, 20);
            this.l2.TabIndex = 17;
            this.l2.Text = "Fibonacci Sayısı";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l3.Location = new System.Drawing.Point(6, 136);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(129, 20);
            this.l3.TabIndex = 18;
            this.l3.Text = "Fibonacci Dizisi";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeknoKaucukYazılım_Test_1_.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 704);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_multiplication_table;
        private System.Windows.Forms.TextBox textbox_input;
        private System.Windows.Forms.Button button_mtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox fibonacci_input;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox fibonacci_output;
        private System.Windows.Forms.TextBox fibonacci_output2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
    }
}