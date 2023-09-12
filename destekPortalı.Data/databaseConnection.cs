using Oracle.ManagedDataAccess.Client; // Oracle veritabanı bağlantısı için gerekli kütüphane
using System.Data;

class Program
{
    static void Main()
    {
        // Oracle veritabanı bağlantı dizesini oluşturun
        string connectionString = "User Id=C##_aysegul;Password=minik;Data Source=localhost";

        // Bağlantıyı oluşturun
        OracleConnection connection = new OracleConnection(connectionString);

        try
        {
            // Bağlantıyı açın
            connection.Open();

            // Burada veritabanı işlemlerini gerçekleştirebilirsiniz

            Console.WriteLine("Bağlantı başarılı!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bağlantı hatası: " + ex.Message);
        }
        finally
        {
            // Bağlantıyı kapatın
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
