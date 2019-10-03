// MEMBUAT STRING YANG ISINYA PERINTAH QUERY UNTUK MENGHITUNG DATA YANG SAMA DENGAN DAT ALOGIN
string query = "SELECT COUNT(*) FROM employee WHERE Username=@username AND Password=@password;";

// MEMBUAT PERINTAH SQL
SqlCommand cek = new SqlCommand(query, KONEKSI_DATABASE);

// MEMBUAT PARAMETER @username UNTUK QUERY DIATAS DAN MENGISI PARAMETER TSB DENGAN txtUsername.Text
cek.Parameters.AddWithValue("@username", txtUsername.Text);

// MEMBUAT PARAMETER @password UNTUK QUERY DIATAS DAN MENGISI PARAMETER TSB DENGAN txtPassword.Text
cek.Parameters.AddWithValue("@password", encryptedPass);

// MEMBUKA KONEKSI DATABASE
KONEKSI_DATABASE.Open();

// MENGEKSEKUSI QUERY SQL DAN MEMASUKKANNYA KE VARIABEL result DENGAN TIPEDATA INT32
Int32 result = Convert.ToInt32(cek.ExecuteScalar());

// MENUTUP KONEKSI DATABASE
KONEKSI_DATABASE.Close();

// MENGECEK APAKAH DATA YANG SESUAI DENGAN LOGIN ADA ATAU TIDAK
if (result > 0)
{
    MessageBox.Show("Username dan Password benar!");
}
else
{
    MessageBox.Show("Username / Password salah!");
}
