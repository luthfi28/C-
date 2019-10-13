SHA256 encrypt = SHA256.Create();
string VARIABEL_HASIL_ENKRIPSI = GetHash(encrypt, STRING_YANG_AKAN_DI_ENKRIPSI);

// BUAT FUNCTION
private static string GetHash(HashAlgorithm hashAlgorithm, string input)
{

    byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

    var sBuilder = new StringBuilder();

    for (int i = 0; i < data.Length; i++)
    {
        sBuilder.Append(data[i].ToString("x2"));
    }

    return sBuilder.ToString();
}
