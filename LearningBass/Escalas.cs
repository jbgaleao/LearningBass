using System;
using System.Collections.Generic;
using System.Data;

namespace LearningBass
{
    public class Escalas
    {
        #region Variaveis da classe

        //public static IList<string> SequenciaNotasSustenidos { get; } =
        //    new List<string>() { "B0",
        //                                "C1",   "Cs1",  "D1",   "Ds1",  "E1",   "F1",   "Fs1",  "G1",   "Gs1",  "A1",   "As1",  "B1",
        //                                "C2",   "Cs2",  "D2",   "Ds2",  "E2",   "F2",   "Fs2",  "G2",   "Gs2",  "A2",   "As2",  "B2",
        //                                "C3",   "Cs3",  "D3",   "Ds3",  "E3",   "F3",   "Fs3",  "G3",   "Gs3",  "A3",   "As3",  "B3",
        //                                "C4",   "Cs4",  "D4",   "Ds4",  "E4",   "F4",   "Fs4",  "G4",   "Gs4",  "A4",   "As4",  "B4",
        //                                "C5"};

        //public static IList<string> SequenciaNotasBemois { get; } =
        //    new List<string>() { "B0",
        //                                "C1",   "Db1",  "D1",   "Eb1",  "E1",   "F1",   "Gb1",  "G1",   "Ab1",  "A1",   "Bb1",  "B1",
        //                                "C2",   "Db2",  "D2",   "Eb2",  "E2",   "F2",   "Gb2",  "G2",   "Ab2",  "A2",   "Bb2",  "B2",
        //                                "C3",   "Db3",  "D3",   "Eb3",  "E3",   "F3",   "Gb3",  "G3",   "Ab3",  "A3",   "Bb3",  "B3",
        //                                "C4",   "Db4",  "D4",   "Eb4",  "E4",   "F4",   "Gb4",  "G4",   "Ab4",  "A4",   "Bb4",  "B4",
        //                                "C5" };




        public static IList<string> SequenciaNotasSustenidos { get; } =
            new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B",
                                 "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public static IList<string> SequenciaNotasBemois { get; } =
            new List<string>() { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B",
                                 "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };

        static string str = string.Empty;
        #endregion


        public static string GetEscala(string Tonica, DataTable dt, bool rbSustenido)
        {
            //DataTable dt = Consultas.RetornaEscala(TipoEscala);
            string strEscala = dt.Rows[0][0].ToString();

            string[] aux = strEscala.Split(',');
            List<int> ListaPadraoEscala = new List<int>();

            int i = 0;
            foreach (string itemEscala in aux)
            {
                ListaPadraoEscala.Add(Convert.ToInt16(itemEscala));
                i++;
            }

            IList<string> ListaSequenciaNotas = GetSequenciaDeNotas(rbSustenido);

            int first = ListaSequenciaNotas.IndexOf(Tonica);
            str = Tonica + ", ";

            foreach (int item in ListaPadraoEscala)
            {
                first += item;
                str += ListaSequenciaNotas[first].ToString() + ", ";
            }
            //MessageBox.Show(str.Substring(0, str.Length - 2));

            str = str.Substring(0, str.Length - 2);

            //LBPrincipal lbprincipal = new LBPrincipal();
            //lbprincipal.MontaGridEscala(str, ListaPadraoEscala);

            return str;
        }


        private static IList<string> GetSequenciaDeNotas(bool Sustenidos)
        {
            return (Sustenidos) ? SequenciaNotasSustenidos : SequenciaNotasBemois;
        }
    }
}
