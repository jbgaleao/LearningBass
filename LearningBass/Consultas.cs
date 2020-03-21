using System;
using System.Data;
using System.Data.SqlClient;

namespace LearningBass
{
    public class Consultas
    {
        public static DataTable RetornaNotasDoBraco(String afinacao, int numCasas)
        {
            DataTable dt = new DataTable();
            try
            {
                DBConnection.Instance.Close();
                DBConnection.openConnection();
                String str = String.Format(@"select * from CompleteBassNotes where CIFRA in ({0}) and CASA <= {1}", afinacao, numCasas);
                SqlCommand cmd = new SqlCommand(str, DBConnection.Instance);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.ToString());
            }
            finally
            {
                DBConnection.Instance.Close();
            }
            return dt;
        }

        public static DataTable RetornaNotasPorCifraECasas(String afinacao, int numCasas)
        {
            DataTable dt = new DataTable();
            try
            {
                DBConnection.Instance.Close();
                DBConnection.openConnection();
                String str = String.Format(@"select c.NOMENOTA from CompleteBassNotes c where CIFRA in ({0}) and CASA <= {1}", afinacao, numCasas);
                SqlCommand cmd = new SqlCommand(str, DBConnection.Instance);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.ToString());
            }
            finally
            {
                DBConnection.Instance.Close();
            }
            return dt;
        }

        public static DataTable RetornaInstrumentos()
        {
            DataTable dt = new DataTable();
            try
            {
                DBConnection.Instance.Close();
                DBConnection.openConnection();
                String str = String.Format(@"select i.CodInstrumento, i.NomeInstrumento from Instrumentos i");
                SqlCommand cmd = new SqlCommand(str, DBConnection.Instance);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.ToString());
            }
            finally
            {
                DBConnection.Instance.Close();
            }
            return dt;
        }
    }    
}
   

