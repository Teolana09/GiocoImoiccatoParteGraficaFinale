namespace GiocoImoiccatoParteGrafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            BottonePSemplici = new Button();
            BottonePMedie = new Button();
            BottonePDifficile = new Button();
            BottoneCoggetti = new Button();
            BottoneCcittà = new Button();
            BottoneCanimali = new Button();
            lblParola = new Label();
            CasellaInsTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BottonInsertLett = new Button();
            LBLparolaErrata = new Label();
            lblVittoria = new Label();
            LBLtentativi = new Label();
            lblPerso = new Label();
            lblinizio = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 72);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(32, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Jolly";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(32, 152);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(78, 23);
            textBox7.TabIndex = 10;
            textBox7.Text = "TENTATIVI";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(32, 245);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            textBox5.Text = "Scegli la difficoltà";
            // 
            // BottonePSemplici
            // 
            BottonePSemplici.Location = new Point(32, 274);
            BottonePSemplici.Name = "BottonePSemplici";
            BottonePSemplici.Size = new Size(75, 23);
            BottonePSemplici.TabIndex = 12;
            BottonePSemplici.Text = "Semplice";
            BottonePSemplici.UseVisualStyleBackColor = true;
            BottonePSemplici.Click += button2_Click;
            // 
            // BottonePMedie
            // 
            BottonePMedie.Location = new Point(32, 303);
            BottonePMedie.Name = "BottonePMedie";
            BottonePMedie.Size = new Size(75, 23);
            BottonePMedie.TabIndex = 13;
            BottonePMedie.Text = "Media";
            BottonePMedie.UseVisualStyleBackColor = true;
            BottonePMedie.Click += button3_Click;
            // 
            // BottonePDifficile
            // 
            BottonePDifficile.Location = new Point(32, 332);
            BottonePDifficile.Name = "BottonePDifficile";
            BottonePDifficile.Size = new Size(75, 23);
            BottonePDifficile.TabIndex = 14;
            BottonePDifficile.Text = "Difficile";
            BottonePDifficile.UseVisualStyleBackColor = true;
            BottonePDifficile.Click += button4_Click;
            // 
            // BottoneCoggetti
            // 
            BottoneCoggetti.Location = new Point(32, 274);
            BottoneCoggetti.Name = "BottoneCoggetti";
            BottoneCoggetti.Size = new Size(75, 23);
            BottoneCoggetti.TabIndex = 17;
            BottoneCoggetti.Text = "Oggetti";
            BottoneCoggetti.UseVisualStyleBackColor = true;
            BottoneCoggetti.Visible = false;
            BottoneCoggetti.Click += BottoneCoggetti_Click;
            // 
            // BottoneCcittà
            // 
            BottoneCcittà.Location = new Point(32, 332);
            BottoneCcittà.Name = "BottoneCcittà";
            BottoneCcittà.Size = new Size(75, 23);
            BottoneCcittà.TabIndex = 18;
            BottoneCcittà.Text = "Città";
            BottoneCcittà.UseVisualStyleBackColor = true;
            BottoneCcittà.Visible = false;
            BottoneCcittà.Click += BottoneCcittà_Click;
            // 
            // BottoneCanimali
            // 
            BottoneCanimali.Location = new Point(32, 303);
            BottoneCanimali.Name = "BottoneCanimali";
            BottoneCanimali.Size = new Size(75, 23);
            BottoneCanimali.TabIndex = 19;
            BottoneCanimali.Text = "Animali";
            BottoneCanimali.UseVisualStyleBackColor = true;
            BottoneCanimali.Visible = false;
            BottoneCanimali.Click += BottoneCanimali_Click;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParola.Location = new Point(342, 303);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(0, 15);
            lblParola.TabIndex = 20;
            // 
            // CasellaInsTxt
            // 
            CasellaInsTxt.Location = new Point(491, 152);
            CasellaInsTxt.Name = "CasellaInsTxt";
            CasellaInsTxt.Size = new Size(237, 23);
            CasellaInsTxt.TabIndex = 21;
            CasellaInsTxt.TextChanged += CasellaInsTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 9);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 22;
            label2.Text = "Gioco Dell'impiccato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 54);
            label3.Name = "label3";
            label3.Size = new Size(258, 15);
            label3.TabIndex = 23;
            label3.Text = "puoi utilizzare il jolly solo una volta attenzione!!!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 120);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 24;
            label4.Text = "inserisci le lettere";
            // 
            // BottonInsertLett
            // 
            BottonInsertLett.Location = new Point(491, 192);
            BottonInsertLett.Name = "BottonInsertLett";
            BottonInsertLett.Size = new Size(121, 25);
            BottonInsertLett.TabIndex = 25;
            BottonInsertLett.Text = "inserisci Lettera";
            BottonInsertLett.UseVisualStyleBackColor = true;
            BottonInsertLett.Click += BottonInsertLett_Click;
            // 
            // LBLparolaErrata
            // 
            LBLparolaErrata.AutoSize = true;
            LBLparolaErrata.Location = new Point(259, 159);
            LBLparolaErrata.Name = "LBLparolaErrata";
            LBLparolaErrata.Size = new Size(0, 15);
            LBLparolaErrata.TabIndex = 26;
            // 
            // lblVittoria
            // 
            lblVittoria.AutoSize = true;
            lblVittoria.Location = new Point(190, 175);
            lblVittoria.Name = "lblVittoria";
            lblVittoria.Size = new Size(0, 15);
            lblVittoria.TabIndex = 27;
            // 
            // LBLtentativi
            // 
            LBLtentativi.AutoSize = true;
            LBLtentativi.Location = new Point(32, 192);
            LBLtentativi.Name = "LBLtentativi";
            LBLtentativi.Size = new Size(0, 15);
            LBLtentativi.TabIndex = 28;
            // 
            // lblPerso
            // 
            lblPerso.AutoSize = true;
            lblPerso.Location = new Point(167, 98);
            lblPerso.Name = "lblPerso";
            lblPerso.Size = new Size(0, 15);
            lblPerso.TabIndex = 29;
            // 
            // lblinizio
            // 
            lblinizio.AutoSize = true;
            lblinizio.Location = new Point(167, 120);
            lblinizio.Name = "lblinizio";
            lblinizio.Size = new Size(462, 15);
            lblinizio.TabIndex = 30;
            lblinizio.Text = "PAPERE prima inserisci la difficoltà poi la categoria e divertiti ricarad hai solo 5 tentativi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(740, 443);
            Controls.Add(lblinizio);
            Controls.Add(lblPerso);
            Controls.Add(LBLtentativi);
            Controls.Add(lblVittoria);
            Controls.Add(LBLparolaErrata);
            Controls.Add(BottonInsertLett);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CasellaInsTxt);
            Controls.Add(lblParola);
            Controls.Add(BottoneCanimali);
            Controls.Add(BottoneCcittà);
            Controls.Add(BottoneCoggetti);
            Controls.Add(BottonePDifficile);
            Controls.Add(BottonePMedie);
            Controls.Add(BottonePSemplici);
            Controls.Add(textBox5);
            Controls.Add(textBox7);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox7;
        private TextBox textBox5;
        private Button BottonePSemplici;
        private Button BottonePMedie;
        private Button BottonePDifficile;
        private Button BottoneCoggetti;
        private Button BottoneCcittà;
        private Button BottoneCanimali;
        private Label lblParola;
        private TextBox CasellaInsTxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BottonInsertLett;
        private Label LBLparolaErrata;
        private Label lblVittoria;
        private Label LBLtentativi;
        private Label lblPerso;
        private Label lblinizio;
    }
}
