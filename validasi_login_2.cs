// MEMBUAT STRING YANG ISINYA PERINTAH QUERY UNTUK MENGHITUNG DATA YANG SAMA DENGAN DAT ALOGIN
string query = "SELECT * FROM namaTabel WHERE Username=@username AND Password=@password;";

// MEMBUAT PERINTAH SQL
SqlCommand cek = new SqlCommand(query, KONEKSI_DATABASE);

// MEMBUAT PARAMETER @username UNTUK QUERY DIATAS DAN MENGISI PARAMETER TSB DENGAN txtUsername.Text
cek.Parameters.AddWithValue("@username", txtUsername.Text);

// MEMBUAT PARAMETER @password UNTUK QUERY DIATAS DAN MENGISI PARAMETER TSB DENGAN txtPassword.Text
cek.Parameters.AddWithValue("@password", txtPassword.Text);

// MEMBUKA KONEKSI DATABASE
KONEKSI_DATABASE.Open();

// MENGEKSEKUSI QUERY SQL DAN MEMASUKKANNYA KE VARIABEL result DENGAN TIPEDATA INT32
var result = cek.ExecuteReader();

// MENGECEK APAKAH DATA YANG SESUAI DENGAN LOGIN ADA ATAU TIDAK
if (result.HasRows)
{
    MessageBox.Show("Username dan Password benar!");
}
else
{
    MessageBox.Show("Username / Password salah!");
}

// MENUTUP KONEKSI DATABASE
KONEKSI_DATABASE.Close();
