using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menedzer_Biblioteki
{
    // struktura reprezentująca książkę
    public struct Ksiazka
    {
        public string tytul;
        public string autor;
        public int rokWydania;
        public bool czyWypozyczona;
    }

    public partial class Menedzer : Form
    {
        private Ksiazka[] biblioteka = new Ksiazka[100];
        private int liczbaKsiazek = 0;

        // inicjalizacja komponentów formularza
        public Menedzer()
        {
            InitializeComponent();
            cmbSortuj.Items.Clear();
            cmbSortuj.Items.Add("autor-ros");
            cmbSortuj.Items.Add("autor-mal");
            cmbSortuj.Items.Add("tytul-ros");
            cmbSortuj.Items.Add("tytul-mal");
            cmbSortuj.Items.Add("rok-ros");
            cmbSortuj.Items.Add("rok-mal");
        }

        // wyświetla listę książek w zależności od wybranego filtru
        private void AktualizujListe()
        {
            lstKsiazki.Items.Clear();
            for (int i = 0; i < liczbaKsiazek; i++)
            {
                string status = biblioteka[i].czyWypozyczona ? "Wypożyczona" : "Dostępna";
                lstKsiazki.Items.Add($"{biblioteka[i].tytul} - {biblioteka[i].autor} ({biblioteka[i].rokWydania}) - {status}");
            }
        }

        // dodaje nową książkę do listy
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            if (liczbaKsiazek < biblioteka.Length)
            {
                string tytul = txtTytul.Text;
                string autor = txtAutor.Text;

                // sprawdzenie poprawności danych
                if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor))
                {
                    MessageBox.Show("Wypełnij wszystkie pola!");
                    return;
                }

                // konwersja roku z zabezpieczeniem przed błędami
                if (int.TryParse(txtRok.Text, out int rok))
                {
                    biblioteka[liczbaKsiazek].tytul = tytul;
                    biblioteka[liczbaKsiazek].autor = autor;
                    biblioteka[liczbaKsiazek].rokWydania = rok;
                    biblioteka[liczbaKsiazek].czyWypozyczona = false;
                    liczbaKsiazek++;
                    AktualizujListe();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy rok.");
                }
            }
            else
            {
                MessageBox.Show("Osiągnięto maksymalną liczbę książek.");
            }
        }
        
        //zmiana statusu wypożyczenia książki
        private void btnStatus_Click_1(object sender, EventArgs e)
        {
            if (lstKsiazki.SelectedIndex >= 0)
            {
                int indeks = lstKsiazki.SelectedIndex;
                biblioteka[indeks].czyWypozyczona = !biblioteka[indeks].czyWypozyczona;
                AktualizujListe();
            }
        }

        //usunięcie książki z listy
        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (lstKsiazki.SelectedIndex >= 0)
            {
                int indeks = lstKsiazki.SelectedIndex;
                for (int i = indeks; i < liczbaKsiazek - 1; i++)
                {
                    biblioteka[i] = biblioteka[i + 1];
                }
                liczbaKsiazek--;
                AktualizujListe();
            }
            else
            {
                MessageBox.Show("Wybierz książkę do usunięcia.");
            }
        }
        
        //Zapisz listę jako... [userinput.txt]
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    for (int i = 0; i < liczbaKsiazek; i++)
                    {
                        sw.WriteLine($"{biblioteka[i].tytul}|{biblioteka[i].autor}|{biblioteka[i].rokWydania}|{biblioteka[i].czyWypozyczona}");
                    }
                }
                MessageBox.Show("Lista została zapisana pomyślnie!");
            }
        }

        //Wczytaj listę z pliku .txt
        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                liczbaKsiazek = 0;
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        biblioteka[liczbaKsiazek].tytul = parts[0];
                        biblioteka[liczbaKsiazek].autor = parts[1];
                        biblioteka[liczbaKsiazek].rokWydania = int.Parse(parts[2]);
                        biblioteka[liczbaKsiazek].czyWypozyczona = bool.Parse(parts[3]);
                        liczbaKsiazek++;
                    }
                }
                AktualizujListe();
                MessageBox.Show("Lista została wczytana pomyślnie!");
            }
        }

        //Sortuj listę
        private void btnSortuj_Click(object sender, EventArgs e)
        {
            if (cmbSortuj.SelectedItem == null)
            {
                MessageBox.Show("Wybierz kryterium sortowania.");
                return;
            }

            switch (cmbSortuj.SelectedItem.ToString().ToLower())
            {
                case "autor-ros":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (string.Compare(biblioteka[j].autor, biblioteka[j + 1].autor) > 0)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;

                case "autor-mal":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (string.Compare(biblioteka[j].autor, biblioteka[j + 1].autor) < 0)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;

                case "tytul-ros":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (string.Compare(biblioteka[j].tytul, biblioteka[j + 1].tytul) > 0)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;

                case "tytul-mal":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (string.Compare(biblioteka[j].tytul, biblioteka[j + 1].tytul) < 0)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;

                case "rok-ros":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (biblioteka[j].rokWydania > biblioteka[j + 1].rokWydania)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;

                case "rok-mal":
                    for (int i = 0; i < liczbaKsiazek - 1; i++)
                        for (int j = 0; j < liczbaKsiazek - 1 - i; j++)
                            if (biblioteka[j].rokWydania < biblioteka[j + 1].rokWydania)
                            {
                                var temp = biblioteka[j];
                                biblioteka[j] = biblioteka[j + 1];
                                biblioteka[j + 1] = temp;
                            }
                    break;
            }
            AktualizujListe();
        }

        //Szukanie książki z listy po tytule
        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            string szukanyTytul = txtSzukaj.Text.ToLower();
            if (string.IsNullOrEmpty(szukanyTytul))
            {
                MessageBox.Show("Wprowadź tytuł książki.");
                return;
            }

            bool znaleziono = false;
            lstKsiazki.Items.Clear();

            for (int i = 0; i < liczbaKsiazek; i++)
            {
                if (biblioteka[i].tytul.ToLower().Contains(szukanyTytul))
                {
                    string status = biblioteka[i].czyWypozyczona ? "Wypożyczona" : "Dostępna";
                    lstKsiazki.Items.Add($"{biblioteka[i].tytul} - {biblioteka[i].autor} ({biblioteka[i].rokWydania}) - {status}");
                    znaleziono = true;
                }
            }

            if (!znaleziono)
            {
                MessageBox.Show("Nie znaleziono książki.");
                AktualizujListe();
            }
        }
    }
}