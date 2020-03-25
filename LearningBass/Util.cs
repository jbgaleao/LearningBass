using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LearningBass
{
    public class Util
    {
        public static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;

        }

        internal static void FormataNotacaoSustenidoBemol(List<string> listaTemp, string notacao)
        {
            for (int i = 0; i < listaTemp.Count; i++)
            {
                if (listaTemp[i].Contains("#")) //  D#4/Eb4
                {
                    if (notacao == "Sustenidos (#)")
                    {
                        listaTemp[i] = listaTemp[i].ToString().Substring(0, 3);
                    }
                    else
                    {
                        listaTemp[i] = listaTemp[i].ToString().Substring(4, 3);
                    }
                }
            }
        }

        internal static void FormataGridNotas(DataGridView gridNotas, string QtdCasas)
        {
            gridNotas.RowHeadersVisible = false;

            for (int i = 0; i < gridNotas.ColumnCount; i++)
            {
                gridNotas.Columns[i].HeaderText = string.Empty;
                gridNotas.Columns[i].Width = 60;
            }

            gridNotas.Columns[0].HeaderText = "n";
            gridNotas.Columns[3].HeaderText = "n";
            gridNotas.Columns[5].HeaderText = "n";
            gridNotas.Columns[7].HeaderText = "n";
            gridNotas.Columns[9].HeaderText = "n";
            gridNotas.Columns[12].HeaderText = "nn";
            gridNotas.Columns[15].HeaderText = "n";
            gridNotas.Columns[17].HeaderText = "n";
            gridNotas.Columns[19].HeaderText = "n";

           
            gridNotas.Columns[0].Width = 30;

            if ((QtdCasas == "21") || (QtdCasas == "22") || (QtdCasas == "23"))
            {
                gridNotas.Columns[21].HeaderText = "n";
            }
            if (QtdCasas == "24")
            {
                gridNotas.Columns[21].HeaderText = "n";
                gridNotas.Columns[24].HeaderText = "nn";
            }

            foreach (DataGridViewColumn coluna in gridNotas.Columns)
                coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        internal static string StrAfinacao(int qtdCordas)
        {
            string StrAfinacao = "";

            switch (qtdCordas)
            {
                case 4:
                    StrAfinacao = "'G','D','A','E'";
                    break;
                case 5:
                    StrAfinacao = "'B','G','D','A','E'";
                    break;
                case 6:
                    StrAfinacao = "'B','G','D','A','E','C'";
                    break;
            }

            return StrAfinacao;
        }
    }
}
