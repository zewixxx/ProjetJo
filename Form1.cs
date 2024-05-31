using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JeuxOlympiques
{
    public partial class Page : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=127.0.0.1;port=3306;database=jeuxolympiques;uid=root;password=";

        public Page()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            InitializeComboBoxPaysSpecifique(); // Ajout de cette ligne
            btnAjouterAthlete.Click += new EventHandler(btnAjouterAthlete_Click);
            InitializeComboBoxAnneOlympique();
            buttonRechercheAthlete.Click += new EventHandler(buttonRechercheAthlete_Click);
            
            this.Load += new EventHandler(page_Load);
            ChargerPaysDansComboBox();
        }


        private void page_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            InitializeTriComboBox.SelectedIndexChanged += new EventHandler(InitializeTriComboBox_SelectedIndexChanged);
            ChargerAthletes();
            ChargerDisciplinesAvecAnnees();
            ChargerAnnees();
        }

        private void InitializeComboBoxes()
        {
            // Ajouter des éléments aux comboBoxGenre si elle est vide
            if (comboBoxGenre.Items.Count == 0)
            {
                comboBoxGenre.Items.AddRange(new string[] { "Homme", "Femme" });
                comboBoxGenre.SelectedIndex = 0;
            }

            // Ajouter des éléments aux comboBoxGenreEvenement1 si elle est vide
            if (comboBoxGenreEvenement1.Items.Count == 0)
            {
                comboBoxGenreEvenement1.Items.AddRange(new string[] { "Homme", "Femme" });
                comboBoxGenreEvenement1.SelectedIndex = 0;
            }

            

            // Ajouter des éléments aux comboBoxSport si elle est vide
            if (comboBoxSport.Items.Count == 0)
            {
                comboBoxSport.Items.AddRange(new string[] {
                    "athlétisme", "natation", "football", "basketball", "volleyball", "gymnastique", "escrime", "tennis de table", "taekwondo", "haltérophilie", "cyclisme", "aviron", "boxe", "judo", "badminton", "rugby à sept", "handball", "water-polo", "tir à l'arc", "voile", "triathlon", "athlétisme paralympique"
                });
            }

            // Ajouter des éléments aux comboBoxTypeMedaille si elle est vide
            if (comboBoxTypeMedaille.Items.Count == 0)
            {
                comboBoxTypeMedaille.Items.AddRange(new string[] {
                    "médaille d'or", "médaille d'argent", "médaille de bronze"
                });
            }

            // Ajouter des éléments aux comboBoxTri si elle est vide
            if (InitializeTriComboBox.Items.Count == 0)
            {
                InitializeTriComboBox.Items.AddRange(new string[] { "Nom", "Prénom"});
                InitializeTriComboBox.SelectedIndex = 0;
            }
        }


        /// <summary>
        /// ////////////////////////////////
        /// </summary

        private void ChargerAthletes()
        {
            try
            {
                string query = "SELECT id, CONCAT(nom, ' ', prenom) AS NomComplet FROM athlete";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        comboBoxAthlete.DataSource = dt;
                        comboBoxAthlete.DisplayMember = "NomComplet";
                        comboBoxAthlete.ValueMember = "id";
                        comboBoxNomAthleteDiscipline.DataSource = dt;
                        comboBoxNomAthleteDiscipline.DisplayMember = "NomComplet";
                        comboBoxNomAthleteDiscipline.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des athlètes : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void ChargerDisciplinesAvecAnnees()
        {
            try
            {
                string query = @"
            SELECT e.disciplinne, GROUP_CONCAT(DISTINCT ao.annee ORDER BY ao.annee SEPARATOR ', ') AS annees
            FROM evenement e
            JOIN anneolympique ao ON e.idAnneOlympique = ao.id
            GROUP BY e.disciplinne";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        comboBoxNomDiscipline.DataSource = dt;
                        comboBoxNomDiscipline.DisplayMember = "disciplinne";
                        comboBoxNomDiscipline.ValueMember = "annees";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des disciplines avec les années : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void ChargerAnnees()
        {
            try
            {
                string query = "SELECT DISTINCT annee FROM anneolympique";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        comboBoxAnneeDiscipline.DataSource = dt;
                        comboBoxAnneeDiscipline.DisplayMember = "annee";
                        comboBoxAnneeDiscipline.ValueMember = "annee";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des années : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void comboBoxNomAthleteDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cette méthode peut rester vide ou être utilisée pour d'autres logiques en fonction des besoins
        }

        private void comboBoxNomDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNomDiscipline.SelectedValue != null)
            {
                string annees = comboBoxNomDiscipline.SelectedValue.ToString();
                comboBoxAnneeDiscipline.DataSource = annees.Split(',').Select(x => x.Trim()).ToList();
            }
        }


        private void comboBoxAnneeDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mettez à jour les dates disponibles en fonction de la discipline et de l'année sélectionnées
            if (comboBoxNomDiscipline.SelectedValue != null && comboBoxAnneeDiscipline.SelectedValue != null)
            {
                string disciplineId = comboBoxNomDiscipline.SelectedValue.ToString();
                string annee = comboBoxAnneeDiscipline.SelectedValue.ToString();
                ChargerDatesEvenement(disciplineId, annee);
            }
        }

        private void ChargerAnneesDiscipline(string disciplineId)
        {
            try
            {
                string query = @"
            SELECT DISTINCT ao.annee 
            FROM evenement e
            JOIN anneolympique ao ON e.idAnneOlympique = ao.id
            WHERE e.disciplinne = @disciplineId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@disciplineId", disciplineId);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        comboBoxAnneeDiscipline.DataSource = dt;
                        comboBoxAnneeDiscipline.DisplayMember = "annee";
                        comboBoxAnneeDiscipline.ValueMember = "annee";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des années pour la discipline : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void ChargerDatesEvenement(string disciplineId, string annee)
        {
            
        }

        private void buttonInscrire_Click(object sender, EventArgs e)
        {
            if (comboBoxNomAthleteDiscipline.SelectedValue == null || comboBoxNomDiscipline.SelectedValue == null || comboBoxAnneeDiscipline.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un athlète, une discipline et une année.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            string athleteId = comboBoxNomAthleteDiscipline.SelectedValue.ToString();
            string discipline = comboBoxNomDiscipline.Text; // Récupérer la discipline à partir du texte sélectionné
            string annee = comboBoxAnneeDiscipline.SelectedValue.ToString();

            try
            {
                // Requête SQL pour récupérer l'ID de l'événement
                string evenementIdQuery = @"
            SELECT e.id 
            FROM evenement e 
            JOIN anneolympique ao ON e.idAnneOlympique = ao.id 
            WHERE e.disciplinne = @discipline AND ao.annee = @annee";

                using (MySqlCommand idCommand = new MySqlCommand(evenementIdQuery, connection))
                {
                    idCommand.Parameters.AddWithValue("@discipline", discipline);
                    idCommand.Parameters.AddWithValue("@annee", annee);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    object result = idCommand.ExecuteScalar();
                    if (result != null)
                    {
                        string evenementId = result.ToString();

                        // Inscrire l'athlète à l'événement
                        string query = "INSERT INTO participer (idAthlete, idEvenement) VALUES (@athleteId, @evenementId)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@athleteId", athleteId);
                            command.Parameters.AddWithValue("@evenementId", evenementId);

                            int rowsAffected = command.ExecuteNonQuery();

                         

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Athlète ajouté à l'événement avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("L'athlète est déjà inscrit à cet événement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucun événement trouvé pour la discipline et l'année sélectionnées.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'athlète à l'événement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }






        /// <summary>
        /// ////////////////
        /// </summary>



        private void btnAjouterEvenement_Click(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(textBoxNomEvenement.Text) || comboBoxGenreEvenement1.SelectedIndex == -1 || comboBoxAnnéeEvement.SelectedIndex == -1)
    {
        MessageBox.Show("Veuillez remplir tous les champs de l'événement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    try
    {
        string nomEvenement = textBoxNomEvenement.Text;
        string genre = comboBoxGenreEvenement1.SelectedItem.ToString();
        string année = comboBoxAnnéeEvement.SelectedItem.ToString();

        string query = "INSERT INTO evenement (disciplinne, genre, idAnneOlympique) VALUES (@nomEvenement, @genre, (SELECT id FROM anneolympique WHERE annee = @annee))";

        using (MySqlCommand command = new MySqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@nomEvenement", nomEvenement);
            command.Parameters.AddWithValue("@genre", genre);
            command.Parameters.AddWithValue("@annee", année);

            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Événement ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aucun enregistrement n'a été ajouté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Erreur lors de l'ajout de l'événement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
    }
}








        private void AfficherComboBoxPaysSpecifique_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AfficherComboBoxPaysSpecifique.SelectedItem != null)
            {
                string selectedCountry = AfficherComboBoxPaysSpecifique.SelectedItem.ToString();
                ChargerAthletesParPays(selectedCountry); // Charge uniquement les athlètes du pays sélectionné
            }
        }

        private void ChargerAthletesParPays(string selectedCountry)
        {
            try
            {
                string query = "SELECT id, CONCAT(nom, ' ', prenom) AS NomComplet, prenom FROM athlete WHERE pays = @pays";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pays", selectedCountry);
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        comboBoxnomrecherche.DataSource = dt;
                        comboBoxnomrecherche.DisplayMember = "NomComplet";
                        comboBoxnomrecherche.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des athlètes dans la combobox : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private void InitializeComboBoxAnneOlympique()
        {
            try
            {
                string query = "SELECT annee FROM anneolympique";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxAnnéeEvement.Items.Add(reader["annee"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des années : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void buttonRechercheAthlete_Click(object sender, EventArgs e)
        {
            // Récupérer l'ID de l'athlète sélectionné dans la comboBox
            if (comboBoxnomrecherche.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un athlète.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idRecherche = (int)comboBoxnomrecherche.SelectedValue;

            try
            {
                connection.Open(); // Ouvrir la connexion à la base de données

                // Exécuter la requête SQL pour récupérer les informations de l'athlète, de l'événement et de la médaille avec l'ID correspondant
                string query = @"
            SELECT a.id, a.nom AS nomAthlete, a.prenom AS prenomAthlete, a.pays, a.dateDeNaissance, a.genre, a.sport,
                   e.disciplinne AS disciplineEvenement, ao.annee AS anneeEvenement,
                   m.typeMedaille
            FROM athlete a
            LEFT JOIN participer p ON a.id = p.idAthlete
            LEFT JOIN evenement e ON p.idEvenement = e.id
            LEFT JOIN anneolympique ao ON e.idAnneOlympique = ao.id
            LEFT JOIN medaille m ON a.id = m.idAthlete
            WHERE a.id = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idRecherche);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Affichage des informations de l'athlète, de l'événement et de la médaille
                            labelNom.Text = "Nom: " + reader["nomAthlete"].ToString();
                            labelPrenom.Text = "Prénom: " + reader["prenomAthlete"].ToString();
                            labelPays.Text = "Pays: " + reader["pays"].ToString();
                            labelDateDeNaissance.Text = "Date de Naissance: " + reader["dateDeNaissance"].ToString();
                            labelGenre.Text = "Genre: " + reader["genre"].ToString();
                            labelSport.Text = "Sport: " + reader["sport"].ToString();
                            labelDiscipline.Text = "Discipline: " + reader["disciplineEvenement"].ToString();
                            labelAnnéeEvenement.Text = "Année de l'événement: " + reader["anneeEvenement"].ToString();
                            labelMedaille.Text = "Médaille: " + reader["typeMedaille"].ToString();
                        }
                        else
                        {
                            // Aucun athlète trouvé avec cet ID
                            MessageBox.Show("Aucun athlète trouvé avec cet ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche de l'athlète : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // Fermer la connexion à la base de données
            }
        }


        private void btnAjouterAthlete_Click(object sender, EventArgs e)
        {
            AjouterAthlete();
        }

        private void AjouterAthlete()
        {
            if (string.IsNullOrEmpty(textBoxPrenom.Text) ||
                comboBoxPaysAthlete.SelectedIndex == -1 ||
                comboBoxGenre.SelectedIndex == -1 ||
                comboBoxSport.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nom = textBoxNom.Text;
                string prenom = textBoxPrenom.Text;
                string pays = comboBoxPaysAthlete.SelectedItem.ToString();
                DateTime dateDeNaissance = dateTimePickerDateNaissance.Value;
                string genre = comboBoxGenre.SelectedItem.ToString();
                string sport = comboBoxSport.SelectedItem.ToString();

                string query = "INSERT INTO athlete (prenom, pays, dateDeNaissance, genre, sport, nom) VALUES (@prenom, @pays, @dateDeNaissance, @genre, @sport, @nom)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@pays", pays);
                    command.Parameters.AddWithValue("@dateDeNaissance", dateDeNaissance);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@sport", sport);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Athlète ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement n'a été ajouté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'athlète : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        // Gestionnaire d'événement pour le changement de sélection dans la ComboBox de tri
        private void InitializeTriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var athletes = comboBoxnomrecherche.DataSource as DataTable;

            if (athletes != null)
            {
                string tri = InitializeTriComboBox.SelectedItem.ToString();

                switch (tri)
                {
                    case "Nom":
                        athletes.DefaultView.Sort = "NomComplet ASC";
                        break;
                    case "Prénom":
                        athletes.DefaultView.Sort = "prenom ASC";
                        break;


                }
            }
        }

        private void comboBoxnomrecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxnomrecherche.SelectedItem != null)
            {
                string selectedCountry = comboBoxnomrecherche.SelectedItem.ToString();
                if (selectedCountry != "Tous les pays") // Vérifie si un pays est sélectionné
                {
                    AfficherComboBoxPaysSpecifique1(true); // Affiche la nouvelle ComboBox
                }
                else
                {
                    AfficherComboBoxPaysSpecifique1(false); // Cache la nouvelle ComboBox si "Tous les pays" est sélectionné
                }
            }
        }

        private void AfficherComboBoxPaysSpecifique1(bool isVisible)
        {
        }

        

        private void InitializeComboBoxPaysSpecifique()
        {
            try
            {
                string query = "SELECT DISTINCT pays FROM athlete";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AfficherComboBoxPaysSpecifique.Items.Add(reader["pays"].ToString());
                            comboBoxPaysAthlete.Items.Add(reader["pays"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des pays : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void ChargerPaysDansComboBox()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = "SELECT DISTINCT pays FROM athlete";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des pays : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void btnAjouterMedaille_Click(object sender, EventArgs e)
        {
            // Vérifiez si toutes les informations nécessaires sont remplies
            if (comboBoxAthlete.SelectedValue == null || comboBoxTypeMedaille.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs pour ajouter une médaille.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Récupérez l'ID de l'athlète à partir de la valeur sélectionnée dans le ComboBox
                int idAthlete = (int)comboBoxAthlete.SelectedValue;
                string typeMedaille = comboBoxTypeMedaille.SelectedItem.ToString();

                // Construisez la requête SQL pour ajouter une médaille
                string query = "INSERT INTO medaille (idAthlete, typeMedaille) VALUES (@idAthlete, @typeMedaille)";

                // Exécutez la requête SQL en utilisant MySqlCommand
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idAthlete", idAthlete);
                    command.Parameters.AddWithValue("@typeMedaille", typeMedaille);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Médaille ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Aucun enregistrement n'a été ajouté.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la médaille : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }









        // Placeholders for event handlers not implemented yet
        private void dataGridViewAthletes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridViewMedals_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBoxPrenom_TextChanged(object sender, EventArgs e) { }
        private void textBoxNom_TextChanged(object sender, EventArgs e) { }
        private void comboBoxPaysAthlete_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePickerDateNaissance_ValueChanged(object sender, EventArgs e) { }
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxSport_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxDisciplineEvenement_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBoxIdAthlete_TextChanged(object sender, EventArgs e) { }
        private void comboBoxTypeMedaille_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxGenreEvenement_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBoxNomEvenement_TextChanged(object sender, EventArgs e) { }
        private void comboBoxAthlete_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxGenreEvenement1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridViewMedals_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void comboBoxDisciplineEvenement_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void comboBoxAnnéeEvement_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBoxNomRechercheAthlete_TextChanged(object sender, EventArgs e) { }
        private void labelNom_Click(object sender, EventArgs e) { }
        private void labelPrenom_Click(object sender, EventArgs e) { }
        private void labelDateDeNaissance_Click(object sender, EventArgs e) { }
        private void labelPays_Click(object sender, EventArgs e) { }
        private void labelGenre_Click(object sender, EventArgs e) { }
        private void labelSport_Click(object sender, EventArgs e) { }

        private void textBoxNom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxNomEvenement_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelDiscipline_Click(object sender, EventArgs e)
        {

        }

        private void labelAnnéeEvenement_Click(object sender, EventArgs e)
        {

        }

        private void labelMedaille_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAthlete_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterAthlete_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxPaysAthlete_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
