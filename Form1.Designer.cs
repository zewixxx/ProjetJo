namespace JeuxOlympiques
{
    partial class Page
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxPaysAthlete = new System.Windows.Forms.ComboBox();
            this.comboBoxSport = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeMedaille = new System.Windows.Forms.ComboBox();
            this.comboBoxAthlete = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNomEvenement = new System.Windows.Forms.TextBox();
            this.btnAjouterAthlete = new System.Windows.Forms.Button();
            this.btnAjouterEvenement = new System.Windows.Forms.Button();
            this.btnAjouterMedaille = new System.Windows.Forms.Button();
            this.comboBoxGenreEvenement1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAnnéeEvement = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonRechercheAthlete = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelDateDeNaissance = new System.Windows.Forms.Label();
            this.labelPays = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelSport = new System.Windows.Forms.Label();
            this.comboBoxnomrecherche = new System.Windows.Forms.ComboBox();
            this.InitializeTriComboBox = new System.Windows.Forms.ComboBox();
            this.AfficherComboBoxPaysSpecifique = new System.Windows.Forms.ComboBox();
            this.comboBoxNomDiscipline = new System.Windows.Forms.ComboBox();
            this.comboBoxAnneeDiscipline = new System.Windows.Forms.ComboBox();
            this.comboBoxNomAthleteDiscipline = new System.Windows.Forms.ComboBox();
            this.buttonInscrire = new System.Windows.Forms.Button();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelAnnéeEvenement = new System.Windows.Forms.Label();
            this.labelMedaille = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Location = new System.Drawing.Point(401, 242);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(126, 24);
            this.comboBoxGenre.TabIndex = 17;
            this.comboBoxGenre.Text = "Sexe";
            // 
            // comboBoxPaysAthlete
            // 
            this.comboBoxPaysAthlete.Location = new System.Drawing.Point(401, 159);
            this.comboBoxPaysAthlete.Name = "comboBoxPaysAthlete";
            this.comboBoxPaysAthlete.Size = new System.Drawing.Size(126, 24);
            this.comboBoxPaysAthlete.TabIndex = 16;
            this.comboBoxPaysAthlete.Text = "Pays";
            // 
            // comboBoxSport
            // 
            this.comboBoxSport.Location = new System.Drawing.Point(406, 281);
            this.comboBoxSport.Name = "comboBoxSport";
            this.comboBoxSport.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSport.TabIndex = 15;
            this.comboBoxSport.Text = "Sport";
            // 
            // comboBoxTypeMedaille
            // 
            this.comboBoxTypeMedaille.Location = new System.Drawing.Point(706, 445);
            this.comboBoxTypeMedaille.Name = "comboBoxTypeMedaille";
            this.comboBoxTypeMedaille.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTypeMedaille.TabIndex = 13;
            this.comboBoxTypeMedaille.Text = "Type médaille";
            // 
            // comboBoxAthlete
            // 
            this.comboBoxAthlete.Location = new System.Drawing.Point(706, 475);
            this.comboBoxAthlete.Name = "comboBoxAthlete";
            this.comboBoxAthlete.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAthlete.TabIndex = 12;
            this.comboBoxAthlete.Text = "Athlète";
            this.comboBoxAthlete.SelectedIndexChanged += new System.EventHandler(this.comboBoxAthlete_SelectedIndexChanged_1);
            // 
            // dateTimePickerDateNaissance
            // 
            this.dateTimePickerDateNaissance.Location = new System.Drawing.Point(369, 201);
            this.dateTimePickerDateNaissance.Name = "dateTimePickerDateNaissance";
            this.dateTimePickerDateNaissance.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateNaissance.TabIndex = 11;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(401, 128);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(126, 22);
            this.textBoxPrenom.TabIndex = 6;
            this.textBoxPrenom.Text = "Prénom";
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.textBoxPrenom_TextChanged_1);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(401, 98);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(126, 22);
            this.textBoxNom.TabIndex = 5;
            this.textBoxNom.Text = "Nom";
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged_1);
            // 
            // textBoxNomEvenement
            // 
            this.textBoxNomEvenement.Location = new System.Drawing.Point(684, 145);
            this.textBoxNomEvenement.Name = "textBoxNomEvenement";
            this.textBoxNomEvenement.Size = new System.Drawing.Size(154, 22);
            this.textBoxNomEvenement.TabIndex = 4;
            this.textBoxNomEvenement.Text = "Nom de la discipline";
            this.textBoxNomEvenement.TextChanged += new System.EventHandler(this.textBoxNomEvenement_TextChanged_1);
            // 
            // btnAjouterAthlete
            // 
            this.btnAjouterAthlete.Location = new System.Drawing.Point(426, 319);
            this.btnAjouterAthlete.Name = "btnAjouterAthlete";
            this.btnAjouterAthlete.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAthlete.TabIndex = 3;
            this.btnAjouterAthlete.Text = "Ajouter";
            // 
            // btnAjouterEvenement
            // 
            this.btnAjouterEvenement.Location = new System.Drawing.Point(719, 231);
            this.btnAjouterEvenement.Name = "btnAjouterEvenement";
            this.btnAjouterEvenement.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterEvenement.TabIndex = 2;
            this.btnAjouterEvenement.Text = "Ajouter";
            this.btnAjouterEvenement.Click += new System.EventHandler(this.btnAjouterEvenement_Click);
            // 
            // btnAjouterMedaille
            // 
            this.btnAjouterMedaille.Location = new System.Drawing.Point(731, 505);
            this.btnAjouterMedaille.Name = "btnAjouterMedaille";
            this.btnAjouterMedaille.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterMedaille.TabIndex = 1;
            this.btnAjouterMedaille.Text = "Ajouter";
            this.btnAjouterMedaille.Click += new System.EventHandler(this.btnAjouterMedaille_Click);
            // 
            // comboBoxGenreEvenement1
            // 
            this.comboBoxGenreEvenement1.FormattingEnabled = true;
            this.comboBoxGenreEvenement1.Location = new System.Drawing.Point(684, 173);
            this.comboBoxGenreEvenement1.Name = "comboBoxGenreEvenement1";
            this.comboBoxGenreEvenement1.Size = new System.Drawing.Size(154, 24);
            this.comboBoxGenreEvenement1.TabIndex = 18;
            this.comboBoxGenreEvenement1.Text = "Sexe";
            this.comboBoxGenreEvenement1.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenreEvenement1_SelectedIndexChanged);
            // 
            // comboBoxAnnéeEvement
            // 
            this.comboBoxAnnéeEvement.FormattingEnabled = true;
            this.comboBoxAnnéeEvement.Location = new System.Drawing.Point(684, 204);
            this.comboBoxAnnéeEvement.Name = "comboBoxAnnéeEvement";
            this.comboBoxAnnéeEvement.Size = new System.Drawing.Size(154, 24);
            this.comboBoxAnnéeEvement.TabIndex = 19;
            this.comboBoxAnnéeEvement.Text = "Année";
            this.comboBoxAnnéeEvement.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnnéeEvement_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonRechercheAthlete
            // 
            this.buttonRechercheAthlete.Location = new System.Drawing.Point(79, 260);
            this.buttonRechercheAthlete.Name = "buttonRechercheAthlete";
            this.buttonRechercheAthlete.Size = new System.Drawing.Size(138, 28);
            this.buttonRechercheAthlete.TabIndex = 22;
            this.buttonRechercheAthlete.Text = "Rechercher";
            this.buttonRechercheAthlete.UseVisualStyleBackColor = true;
            this.buttonRechercheAthlete.Click += new System.EventHandler(this.buttonRechercheAthlete_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(76, 308);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(36, 16);
            this.labelNom.TabIndex = 23;
            this.labelNom.Text = "Nom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(76, 336);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(54, 16);
            this.labelPrenom.TabIndex = 24;
            this.labelPrenom.Text = "Prénom";
            this.labelPrenom.Click += new System.EventHandler(this.labelPrenom_Click);
            // 
            // labelDateDeNaissance
            // 
            this.labelDateDeNaissance.AutoSize = true;
            this.labelDateDeNaissance.Location = new System.Drawing.Point(76, 363);
            this.labelDateDeNaissance.Name = "labelDateDeNaissance";
            this.labelDateDeNaissance.Size = new System.Drawing.Size(120, 16);
            this.labelDateDeNaissance.TabIndex = 25;
            this.labelDateDeNaissance.Text = "Date de naissance";
            this.labelDateDeNaissance.Click += new System.EventHandler(this.labelDateDeNaissance_Click);
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Location = new System.Drawing.Point(76, 389);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(38, 16);
            this.labelPays.TabIndex = 26;
            this.labelPays.Text = "Pays";
            this.labelPays.Click += new System.EventHandler(this.labelPays_Click);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(76, 415);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(44, 16);
            this.labelGenre.TabIndex = 27;
            this.labelGenre.Text = "Genre";
            this.labelGenre.Click += new System.EventHandler(this.labelGenre_Click);
            // 
            // labelSport
            // 
            this.labelSport.AutoSize = true;
            this.labelSport.Location = new System.Drawing.Point(76, 441);
            this.labelSport.Name = "labelSport";
            this.labelSport.Size = new System.Drawing.Size(39, 16);
            this.labelSport.TabIndex = 28;
            this.labelSport.Text = "Sport";
            this.labelSport.Click += new System.EventHandler(this.labelSport_Click);
            // 
            // comboBoxnomrecherche
            // 
            this.comboBoxnomrecherche.Location = new System.Drawing.Point(79, 220);
            this.comboBoxnomrecherche.Name = "comboBoxnomrecherche";
            this.comboBoxnomrecherche.Size = new System.Drawing.Size(121, 24);
            this.comboBoxnomrecherche.TabIndex = 29;
            this.comboBoxnomrecherche.SelectedIndexChanged += new System.EventHandler(this.comboBoxnomrecherche_SelectedIndexChanged);
            // 
            // InitializeTriComboBox
            // 
            this.InitializeTriComboBox.FormattingEnabled = true;
            this.InitializeTriComboBox.Location = new System.Drawing.Point(79, 159);
            this.InitializeTriComboBox.Name = "InitializeTriComboBox";
            this.InitializeTriComboBox.Size = new System.Drawing.Size(121, 24);
            this.InitializeTriComboBox.TabIndex = 30;
            this.InitializeTriComboBox.SelectedIndexChanged += new System.EventHandler(this.InitializeTriComboBox_SelectedIndexChanged);
            // 
            // AfficherComboBoxPaysSpecifique
            // 
            this.AfficherComboBoxPaysSpecifique.FormattingEnabled = true;
            this.AfficherComboBoxPaysSpecifique.Location = new System.Drawing.Point(79, 98);
            this.AfficherComboBoxPaysSpecifique.Name = "AfficherComboBoxPaysSpecifique";
            this.AfficherComboBoxPaysSpecifique.Size = new System.Drawing.Size(121, 24);
            this.AfficherComboBoxPaysSpecifique.TabIndex = 31;
            this.AfficherComboBoxPaysSpecifique.SelectedIndexChanged += new System.EventHandler(this.AfficherComboBoxPaysSpecifique_SelectedIndexChanged);
            // 
            // comboBoxNomDiscipline
            // 
            this.comboBoxNomDiscipline.FormattingEnabled = true;
            this.comboBoxNomDiscipline.Location = new System.Drawing.Point(398, 495);
            this.comboBoxNomDiscipline.Name = "comboBoxNomDiscipline";
            this.comboBoxNomDiscipline.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNomDiscipline.TabIndex = 32;
            this.comboBoxNomDiscipline.Text = "Discipline";
            this.comboBoxNomDiscipline.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomDiscipline_SelectedIndexChanged);
            // 
            // comboBoxAnneeDiscipline
            // 
            this.comboBoxAnneeDiscipline.FormattingEnabled = true;
            this.comboBoxAnneeDiscipline.Location = new System.Drawing.Point(398, 525);
            this.comboBoxAnneeDiscipline.Name = "comboBoxAnneeDiscipline";
            this.comboBoxAnneeDiscipline.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAnneeDiscipline.TabIndex = 33;
            this.comboBoxAnneeDiscipline.Text = "Année";
            this.comboBoxAnneeDiscipline.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnneeDiscipline_SelectedIndexChanged);
            // 
            // comboBoxNomAthleteDiscipline
            // 
            this.comboBoxNomAthleteDiscipline.FormattingEnabled = true;
            this.comboBoxNomAthleteDiscipline.Location = new System.Drawing.Point(398, 465);
            this.comboBoxNomAthleteDiscipline.Name = "comboBoxNomAthleteDiscipline";
            this.comboBoxNomAthleteDiscipline.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNomAthleteDiscipline.TabIndex = 34;
            this.comboBoxNomAthleteDiscipline.Text = "Athlète";
            this.comboBoxNomAthleteDiscipline.SelectedIndexChanged += new System.EventHandler(this.comboBoxNomAthleteDiscipline_SelectedIndexChanged);
            // 
            // buttonInscrire
            // 
            this.buttonInscrire.Location = new System.Drawing.Point(416, 555);
            this.buttonInscrire.Name = "buttonInscrire";
            this.buttonInscrire.Size = new System.Drawing.Size(75, 23);
            this.buttonInscrire.TabIndex = 35;
            this.buttonInscrire.Text = "Ajouter";
            this.buttonInscrire.Click += new System.EventHandler(this.buttonInscrire_Click);
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(76, 466);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(66, 16);
            this.labelDiscipline.TabIndex = 36;
            this.labelDiscipline.Text = "Discipline";
            this.labelDiscipline.Click += new System.EventHandler(this.labelDiscipline_Click);
            // 
            // labelAnnéeEvenement
            // 
            this.labelAnnéeEvenement.AutoSize = true;
            this.labelAnnéeEvenement.Location = new System.Drawing.Point(76, 493);
            this.labelAnnéeEvenement.Name = "labelAnnéeEvenement";
            this.labelAnnéeEvenement.Size = new System.Drawing.Size(141, 16);
            this.labelAnnéeEvenement.TabIndex = 37;
            this.labelAnnéeEvenement.Text = "Année de participation";
            this.labelAnnéeEvenement.Click += new System.EventHandler(this.labelAnnéeEvenement_Click);
            // 
            // labelMedaille
            // 
            this.labelMedaille.AutoSize = true;
            this.labelMedaille.Location = new System.Drawing.Point(76, 520);
            this.labelMedaille.Name = "labelMedaille";
            this.labelMedaille.Size = new System.Drawing.Size(59, 16);
            this.labelMedaille.TabIndex = 38;
            this.labelMedaille.Text = "Médaille";
            this.labelMedaille.Click += new System.EventHandler(this.labelMedaille_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Trier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Pays de l\'athlète";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nom Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ajouter athlète";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Participation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Ajouter une discipline";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(715, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ajouter médaille";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMedaille);
            this.Controls.Add(this.labelAnnéeEvenement);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.buttonInscrire);
            this.Controls.Add(this.comboBoxNomAthleteDiscipline);
            this.Controls.Add(this.comboBoxAnneeDiscipline);
            this.Controls.Add(this.comboBoxNomDiscipline);
            this.Controls.Add(this.AfficherComboBoxPaysSpecifique);
            this.Controls.Add(this.InitializeTriComboBox);
            this.Controls.Add(this.comboBoxnomrecherche);
            this.Controls.Add(this.labelSport);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPays);
            this.Controls.Add(this.labelDateDeNaissance);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonRechercheAthlete);
            this.Controls.Add(this.comboBoxAnnéeEvement);
            this.Controls.Add(this.comboBoxGenreEvenement1);
            this.Controls.Add(this.btnAjouterMedaille);
            this.Controls.Add(this.btnAjouterEvenement);
            this.Controls.Add(this.btnAjouterAthlete);
            this.Controls.Add(this.textBoxNomEvenement);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.dateTimePickerDateNaissance);
            this.Controls.Add(this.comboBoxAthlete);
            this.Controls.Add(this.comboBoxTypeMedaille);
            this.Controls.Add(this.comboBoxSport);
            this.Controls.Add(this.comboBoxPaysAthlete);
            this.Controls.Add(this.comboBoxGenre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Page";
            this.Text = "Jeux Olympiques";
            this.Load += new System.EventHandler(this.page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxPaysAthlete;
        private System.Windows.Forms.ComboBox comboBoxSport;
        private System.Windows.Forms.ComboBox comboBoxTypeMedaille;
        private System.Windows.Forms.ComboBox comboBoxAthlete;
        private System.Windows.Forms.ComboBox comboBoxGenreEvenement;
        private System.Windows.Forms.TreeView treeViewDisciplines;
        private System.Windows.Forms.ComboBox comboBoxPays;
        private System.Windows.Forms.ListBox listBoxTypesMedailles;


        private System.Windows.Forms.DateTimePicker dateTimePickerDateNaissance;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAnneeEvenement;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNomEvenement;
        private System.Windows.Forms.Button btnAjouterAthlete;
        private System.Windows.Forms.Button btnAjouterEvenement;
        private System.Windows.Forms.Button btnAjouterMedaille;
        private System.Windows.Forms.ComboBox comboBoxGenreEvenement1;
        private System.Windows.Forms.ComboBox comboBoxAnnéeEvement;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonRechercheAthlete;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelDateDeNaissance;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelSport;
        private System.Windows.Forms.ComboBox comboBoxnomrecherche;
        private System.Windows.Forms.ComboBox InitializeTriComboBox;
        private System.Windows.Forms.ComboBox AfficherComboBoxPaysSpecifique;
        private System.Windows.Forms.ComboBox comboBoxNomDiscipline;
        private System.Windows.Forms.ComboBox comboBoxAnneeDiscipline;
        private System.Windows.Forms.ComboBox comboBoxNomAthleteDiscipline;
        private System.Windows.Forms.Button buttonInscrire;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelAnnéeEvenement;
        private System.Windows.Forms.Label labelMedaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}