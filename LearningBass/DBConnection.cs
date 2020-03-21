using System.Data;
using System.Data.SqlClient;

namespace LearningBass
{
    public class DBConnection
    {
        private static SqlConnection instance;
        public DBConnection() { }
        public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                                AttachDbFilename=C:\Users\jbgal\source\repos\BassLearnSimulator\LearningBass\DBLearningBass.mdf;
                                                                Integrated Security=True");






        public static SqlConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlConnection(DBConnection.conn.ConnectionString);
                }
                return instance;
            }
        }
        public static void openConnection()
        {
            if (DBConnection.Instance.State != ConnectionState.Open)
            {
                DBConnection.Instance.Open();
            }
        }
    }
}
