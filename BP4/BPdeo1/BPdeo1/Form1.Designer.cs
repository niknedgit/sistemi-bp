namespace BPdeo1
{
    partial class Form1
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
            this.btnPrikaziGrupu = new System.Windows.Forms.Button();
            this.btnNapraviKlijenta = new System.Windows.Forms.Button();
            this.btnGdePripada = new System.Windows.Forms.Button();
            this.btnSobeHotela = new System.Windows.Forms.Button();
            this.btnUslugaSoba = new System.Windows.Forms.Button();
            this.Jednokrevetna = new System.Windows.Forms.Button();
            this.Dvokrevetna = new System.Windows.Forms.Button();
            this.KreirajHotel = new System.Windows.Forms.Button();
            this.ucitajKlijenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RezSoba = new System.Windows.Forms.Button();
            this.RezApartman = new System.Windows.Forms.Button();
            this.MedTretmanKreiraj = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.KreirajSport = new System.Windows.Forms.Button();
            this.dodatneUslugeKreiraj = new System.Windows.Forms.Button();
            this.KreirajDete = new System.Windows.Forms.Button();
            this.Ucitajapartman = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.KreirajApartman = new System.Windows.Forms.Button();
            this.kreirajGrupu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.KreirajMedT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikaziGrupu
            // 
            this.btnPrikaziGrupu.Location = new System.Drawing.Point(12, 99);
            this.btnPrikaziGrupu.Name = "btnPrikaziGrupu";
            this.btnPrikaziGrupu.Size = new System.Drawing.Size(190, 23);
            this.btnPrikaziGrupu.TabIndex = 0;
            this.btnPrikaziGrupu.Text = "grupa i klijenti (hasMany)";
            this.btnPrikaziGrupu.UseVisualStyleBackColor = true;
            this.btnPrikaziGrupu.Click += new System.EventHandler(this.btnPrikaziGrupu_Click);
            // 
            // btnNapraviKlijenta
            // 
            this.btnNapraviKlijenta.Location = new System.Drawing.Point(12, 70);
            this.btnNapraviKlijenta.Name = "btnNapraviKlijenta";
            this.btnNapraviKlijenta.Size = new System.Drawing.Size(190, 23);
            this.btnNapraviKlijenta.TabIndex = 1;
            this.btnNapraviKlijenta.Text = "Napravi klijenta";
            this.btnNapraviKlijenta.UseVisualStyleBackColor = true;
            this.btnNapraviKlijenta.Click += new System.EventHandler(this.btnNapraviKlijenta_Click);
            // 
            // btnGdePripada
            // 
            this.btnGdePripada.Location = new System.Drawing.Point(12, 128);
            this.btnGdePripada.Name = "btnGdePripada";
            this.btnGdePripada.Size = new System.Drawing.Size(190, 23);
            this.btnGdePripada.TabIndex = 2;
            this.btnGdePripada.Text = "Dete i njegov roditelj";
            this.btnGdePripada.UseVisualStyleBackColor = true;
            this.btnGdePripada.Click += new System.EventHandler(this.btnGdePripada_Click);
            // 
            // btnSobeHotela
            // 
            this.btnSobeHotela.Location = new System.Drawing.Point(12, 157);
            this.btnSobeHotela.Name = "btnSobeHotela";
            this.btnSobeHotela.Size = new System.Drawing.Size(190, 23);
            this.btnSobeHotela.TabIndex = 3;
            this.btnSobeHotela.Text = "Prikazi sobe hotela";
            this.btnSobeHotela.UseVisualStyleBackColor = true;
            this.btnSobeHotela.Click += new System.EventHandler(this.btnSobeHotela_Click);
            // 
            // btnUslugaSoba
            // 
            this.btnUslugaSoba.Location = new System.Drawing.Point(208, 70);
            this.btnUslugaSoba.Name = "btnUslugaSoba";
            this.btnUslugaSoba.Size = new System.Drawing.Size(190, 23);
            this.btnUslugaSoba.TabIndex = 4;
            this.btnUslugaSoba.Text = "Usluga-Soba";
            this.btnUslugaSoba.UseVisualStyleBackColor = true;
            this.btnUslugaSoba.Click += new System.EventHandler(this.btnUslugaSoba_Click);
            // 
            // Jednokrevetna
            // 
            this.Jednokrevetna.Location = new System.Drawing.Point(12, 247);
            this.Jednokrevetna.Name = "Jednokrevetna";
            this.Jednokrevetna.Size = new System.Drawing.Size(190, 26);
            this.Jednokrevetna.TabIndex = 5;
            this.Jednokrevetna.Text = "Kreiranje jednokrevetne sobe";
            this.Jednokrevetna.UseVisualStyleBackColor = true;
            this.Jednokrevetna.Click += new System.EventHandler(this.Jednokrevetna_Click);
            // 
            // Dvokrevetna
            // 
            this.Dvokrevetna.Location = new System.Drawing.Point(208, 246);
            this.Dvokrevetna.Name = "Dvokrevetna";
            this.Dvokrevetna.Size = new System.Drawing.Size(190, 26);
            this.Dvokrevetna.TabIndex = 6;
            this.Dvokrevetna.Text = "Kreiranje dvokrevetne sobe";
            this.Dvokrevetna.UseVisualStyleBackColor = true;
            this.Dvokrevetna.Click += new System.EventHandler(this.Dvokrevetna_Click);
            // 
            // KreirajHotel
            // 
            this.KreirajHotel.Location = new System.Drawing.Point(12, 186);
            this.KreirajHotel.Name = "KreirajHotel";
            this.KreirajHotel.Size = new System.Drawing.Size(190, 26);
            this.KreirajHotel.TabIndex = 7;
            this.KreirajHotel.Text = "Kreiranje hotela ";
            this.KreirajHotel.UseVisualStyleBackColor = true;
            this.KreirajHotel.Click += new System.EventHandler(this.KreirajHotel_Click);
            // 
            // ucitajKlijenta
            // 
            this.ucitajKlijenta.Location = new System.Drawing.Point(12, 41);
            this.ucitajKlijenta.Name = "ucitajKlijenta";
            this.ucitajKlijenta.Size = new System.Drawing.Size(190, 23);
            this.ucitajKlijenta.TabIndex = 8;
            this.ucitajKlijenta.Text = "Ucitavanje podataka o klijentu";
            this.ucitajKlijenta.UseVisualStyleBackColor = true;
            this.ucitajKlijenta.Click += new System.EventHandler(this.UcitajKlijenta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RezSoba
            // 
            this.RezSoba.Location = new System.Drawing.Point(208, 41);
            this.RezSoba.Name = "RezSoba";
            this.RezSoba.Size = new System.Drawing.Size(190, 23);
            this.RezSoba.TabIndex = 10;
            this.RezSoba.Text = "Rezervisi sobu";
            this.RezSoba.UseVisualStyleBackColor = true;
            this.RezSoba.Click += new System.EventHandler(this.RezSoba_Click);
            // 
            // RezApartman
            // 
            this.RezApartman.Location = new System.Drawing.Point(208, 157);
            this.RezApartman.Name = "RezApartman";
            this.RezApartman.Size = new System.Drawing.Size(190, 23);
            this.RezApartman.TabIndex = 11;
            this.RezApartman.Text = "Rezervisi apartman";
            this.RezApartman.UseVisualStyleBackColor = true;
            this.RezApartman.Click += new System.EventHandler(this.RezApartman_Click);
            // 
            // MedTretmanKreiraj
            // 
            this.MedTretmanKreiraj.Location = new System.Drawing.Point(208, 99);
            this.MedTretmanKreiraj.Name = "MedTretmanKreiraj";
            this.MedTretmanKreiraj.Size = new System.Drawing.Size(190, 23);
            this.MedTretmanKreiraj.TabIndex = 12;
            this.MedTretmanKreiraj.Text = "Many to many med tretman";
            this.MedTretmanKreiraj.UseVisualStyleBackColor = true;
            this.MedTretmanKreiraj.Click += new System.EventHandler(this.MedTretmanKreiraj_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(208, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Ucitavanje sportskih aktivnosti hotela";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // KreirajSport
            // 
            this.KreirajSport.Location = new System.Drawing.Point(208, 217);
            this.KreirajSport.Name = "KreirajSport";
            this.KreirajSport.Size = new System.Drawing.Size(190, 23);
            this.KreirajSport.TabIndex = 14;
            this.KreirajSport.Text = "Kreiranje sportskih aktivnosti";
            this.KreirajSport.UseVisualStyleBackColor = true;
            this.KreirajSport.Click += new System.EventHandler(this.KreirajSport_Click);
            // 
            // dodatneUslugeKreiraj
            // 
            this.dodatneUslugeKreiraj.Location = new System.Drawing.Point(208, 188);
            this.dodatneUslugeKreiraj.Name = "dodatneUslugeKreiraj";
            this.dodatneUslugeKreiraj.Size = new System.Drawing.Size(190, 23);
            this.dodatneUslugeKreiraj.TabIndex = 15;
            this.dodatneUslugeKreiraj.Text = "Dodatne usluge okruzenja";
            this.dodatneUslugeKreiraj.UseVisualStyleBackColor = true;
            this.dodatneUslugeKreiraj.Click += new System.EventHandler(this.DodatneUslugeKreiraj_Click);
            // 
            // KreirajDete
            // 
            this.KreirajDete.Location = new System.Drawing.Point(12, 279);
            this.KreirajDete.Name = "KreirajDete";
            this.KreirajDete.Size = new System.Drawing.Size(190, 23);
            this.KreirajDete.TabIndex = 16;
            this.KreirajDete.Text = "Kreiranje deteta";
            this.KreirajDete.UseVisualStyleBackColor = true;
            this.KreirajDete.Click += new System.EventHandler(this.KreirajDete_Click);
            // 
            // Ucitajapartman
            // 
            this.Ucitajapartman.Location = new System.Drawing.Point(208, 278);
            this.Ucitajapartman.Name = "Ucitajapartman";
            this.Ucitajapartman.Size = new System.Drawing.Size(190, 23);
            this.Ucitajapartman.TabIndex = 17;
            this.Ucitajapartman.Text = "Ucitavanje apartmana (Sa kuhinjom)";
            this.Ucitajapartman.UseVisualStyleBackColor = true;
            this.Ucitajapartman.Click += new System.EventHandler(this.Ucitajapartman_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 218);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(190, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "Ucitavanje hotela";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // KreirajApartman
            // 
            this.KreirajApartman.Location = new System.Drawing.Point(12, 308);
            this.KreirajApartman.Name = "KreirajApartman";
            this.KreirajApartman.Size = new System.Drawing.Size(190, 23);
            this.KreirajApartman.TabIndex = 19;
            this.KreirajApartman.Text = "Kreiranje apartmana (garsonjere)";
            this.KreirajApartman.UseVisualStyleBackColor = true;
            this.KreirajApartman.Click += new System.EventHandler(this.KreirajApartman_Click);
            // 
            // kreirajGrupu
            // 
            this.kreirajGrupu.Location = new System.Drawing.Point(12, 12);
            this.kreirajGrupu.Name = "kreirajGrupu";
            this.kreirajGrupu.Size = new System.Drawing.Size(190, 23);
            this.kreirajGrupu.TabIndex = 20;
            this.kreirajGrupu.Text = "Kreiranje grupe";
            this.kreirajGrupu.UseVisualStyleBackColor = true;
            this.kreirajGrupu.Click += new System.EventHandler(this.KreirajGrupu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Usluge hotel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // KreirajMedT
            // 
            this.KreirajMedT.Location = new System.Drawing.Point(208, 307);
            this.KreirajMedT.Name = "KreirajMedT";
            this.KreirajMedT.Size = new System.Drawing.Size(190, 23);
            this.KreirajMedT.TabIndex = 22;
            this.KreirajMedT.Text = "Kreiranje medicinskog tretmana";
            this.KreirajMedT.UseVisualStyleBackColor = true;
            this.KreirajMedT.Click += new System.EventHandler(this.KreirajMedT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 338);
            this.Controls.Add(this.KreirajMedT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kreirajGrupu);
            this.Controls.Add(this.KreirajApartman);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Ucitajapartman);
            this.Controls.Add(this.KreirajDete);
            this.Controls.Add(this.dodatneUslugeKreiraj);
            this.Controls.Add(this.KreirajSport);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.MedTretmanKreiraj);
            this.Controls.Add(this.RezApartman);
            this.Controls.Add(this.RezSoba);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ucitajKlijenta);
            this.Controls.Add(this.KreirajHotel);
            this.Controls.Add(this.Dvokrevetna);
            this.Controls.Add(this.Jednokrevetna);
            this.Controls.Add(this.btnUslugaSoba);
            this.Controls.Add(this.btnSobeHotela);
            this.Controls.Add(this.btnGdePripada);
            this.Controls.Add(this.btnNapraviKlijenta);
            this.Controls.Add(this.btnPrikaziGrupu);
            this.Name = "Form1";
            this.Text = "Ucitavanje sportskih aktivnosti hotela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziGrupu;
        private System.Windows.Forms.Button btnNapraviKlijenta;
        private System.Windows.Forms.Button btnGdePripada;
        private System.Windows.Forms.Button btnSobeHotela;
        private System.Windows.Forms.Button btnUslugaSoba;
        private System.Windows.Forms.Button Jednokrevetna;
        private System.Windows.Forms.Button Dvokrevetna;
        private System.Windows.Forms.Button KreirajHotel;
        private System.Windows.Forms.Button ucitajKlijenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RezSoba;
        private System.Windows.Forms.Button RezApartman;
        private System.Windows.Forms.Button MedTretmanKreiraj;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button KreirajSport;
        private System.Windows.Forms.Button dodatneUslugeKreiraj;
        private System.Windows.Forms.Button KreirajDete;
        private System.Windows.Forms.Button Ucitajapartman;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button KreirajApartman;
        private System.Windows.Forms.Button kreirajGrupu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button KreirajMedT;
    }
}

