namespace WinFormsApp1
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxnom = new TextBox();
            textBoxelclasse = new TextBox();
            textBoxemail = new TextBox();
            textBoxtel = new TextBox();
            textBoxpnom = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 77);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 141);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Classe";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 77);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 215);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "Telephone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 141);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 7;
            label8.Text = "Prenom";
            // 
            // textBoxnom
            // 
            textBoxnom.Location = new Point(386, 69);
            textBoxnom.Name = "textBoxnom";
            textBoxnom.Size = new Size(100, 23);
            textBoxnom.TabIndex = 8;
            // 
            // textBoxelclasse
            // 
            textBoxelclasse.Location = new Point(691, 146);
            textBoxelclasse.Name = "textBoxelclasse";
            textBoxelclasse.Size = new Size(100, 23);
            textBoxelclasse.TabIndex = 12;
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(691, 61);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(100, 23);
            textBoxemail.TabIndex = 13;
            // 
            // textBoxtel
            // 
            textBoxtel.Location = new Point(386, 215);
            textBoxtel.Name = "textBoxtel";
            textBoxtel.Size = new Size(100, 23);
            textBoxtel.TabIndex = 14;
            // 
            // textBoxpnom
            // 
            textBoxpnom.Location = new Point(386, 141);
            textBoxpnom.Name = "textBoxpnom";
            textBoxpnom.Size = new Size(100, 23);
            textBoxpnom.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(897, 288);
            dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(1333, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Ajouter ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1333, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Actualiser";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1333, 155);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "Modifier";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1333, 253);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 640);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxpnom);
            Controls.Add(textBoxtel);
            Controls.Add(textBoxemail);
            Controls.Add(textBoxelclasse);
            Controls.Add(textBoxnom);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxnom;
        private TextBox textBoxniveau;
        private TextBox textBoxformation;
        private TextBox textBoxgroupe;
        private TextBox textBoxelclasse;
        private TextBox textBoxemail;
        private TextBox textBoxtel;
        private TextBox textBoxpnom;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}