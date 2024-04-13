using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UyeEkle : Form
    {
        private string databasePath = "database.db"; 

        public UyeEkle()
        {
            InitializeComponent();

     
            if (!File.Exists(databasePath))
            {
                SQLiteConnection.CreateFile(databasePath); 
                CreateTable(); 
            }

            
            Form2_Load(this, EventArgs.Empty);
        }

        private void CreateTable()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    // Uyeler tablosunu oluştur
                    cmd.CommandText = @"CREATE TABLE Uyeler (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Ad TEXT,
                                        Soyad TEXT,
                                        DogumTarihi TEXT,
                                        Cinsiyet TEXT,
                                        Telefon TEXT,
                                        Tc TEXT UNIQUE)";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Uyeler", conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void butonEkleUye_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Uyeler (Ad, Soyad, DogumTarihi, Cinsiyet, Telefon, Tc) VALUES (@ad, @soyad, @dogumTarihi, @cinsiyet, @telefon, @tc)";
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox5.Text);
                    cmd.Parameters.AddWithValue("@dogumTarihi", textBox4.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", textBox2.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tc", textBox6.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            VerileriYukle();
        }

        private void butonSilUye_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "DELETE FROM Uyeler WHERE Tc = @tc";
                    cmd.Parameters.AddWithValue("@tc", textBox6.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            VerileriYukle();
        }

        private void butonGuncelleUye_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + databasePath + ";Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "UPDATE Uyeler SET Ad = @ad, Soyad = @soyad, DogumTarihi = @dogumTarihi, Cinsiyet = @cinsiyet, Telefon = @telefon WHERE Tc = @tc";
                    cmd.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox5.Text);
                    cmd.Parameters.AddWithValue("@dogumTarihi", textBox4.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", textBox2.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tc", textBox6.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            VerileriYukle();
        }
    }
}
