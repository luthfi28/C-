// KONEKSI UNTUK SQL SERVER
// MEMANGGIL NAMESPACE SQL SERVER CLIENT DIBAGIAN PALING ATAS KODE
using System.Data.SqlClient;

// MEMBUAT KONEKSI DENGAN NAMA "conn"
SqlConnection conn = new SqlConnection("DISINI_STRING_KONEKSI");


// KONEKSI UNTUK MYSQL SERVER
// MEMANGGIL NAMESPACE MYSQL CLIENT (JANGAN LUPA ADD REFERENCES DULU)
using Mysql.Data.MySqlClient;

// MEMBUAT KONEKSI DENGAN NAMA "conn"
MySqlConnection conn = new MySqlConnection("SERVER = SERVER; DATABASE = NAMA_DB; UID = USER_DB; PWD = PASS_DB; ");