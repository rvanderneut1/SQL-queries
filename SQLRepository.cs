using Microsoft.Data.SqlClient;


public class SQLRepository 
{
    public string ConnectionString = "Server=NB221707\\SQLEXPRESS;Database=SQL4;Trusted_Connection=True;TrustServerCertificate=True;";

    public void InsertMangaComics(string name, int volume, bool isRead)
    {
        using(SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            using(SqlCommand command = connection.CreateCommand()){
                command.CommandText = "Insert Into MangaComics(Name, Volume, IsRead)"+
                "Values(@name, @age, @isRead)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", volume);
                command.Parameters.AddWithValue("@isRead", isRead);

                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public List<MangaComics> SelectMangaComics(){
        List<MangaComics> mangaComicsResultList = new List<MangaComics>();
        using(SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            //gedeelte dat de query uitvoert
            using(SqlCommand command = connection.CreateCommand()){
                command.CommandText = "Select * From MangaComics";
                //gedeelte dat het resultaat vanuit de DB ophaalt
                using(SqlDataReader reader = command.ExecuteReader()){
                    while(reader.Read()){
                        mangaComicsResultList.Add(
                            new MangaComics
                            (
                                reader.GetInt32(0), // id kolom is 0
                                reader.GetString(1),// name kolom is 1
                                reader.GetInt32(2), // volume kolom is 2
                                reader.GetBoolean(3) // isread is 3
                            )
                        );

                    }
                }
            }
            connection.Close();
        } 

        return mangaComicsResultList;  
    }

}