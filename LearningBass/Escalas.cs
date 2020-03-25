using System.Collections.Generic;
using System.Windows.Forms;

namespace LearningBass
{
    public class Escalas
    {
        public static IList<int> PadraoEscalaMenor { get; } = new List<int>() { 2, 1, 2, 2, 1, 2, 2 };

        public static List<int> PadraoEscalaMaior { get; } = new List<int>() { 2, 2, 1, 2, 2, 2, 1 };

        public static IList<string> SequenciaNotasSustenidos { get; } =
            new List<string>() { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B",
                                 "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        public static IList<string> SequenciaNotasBemois { get; } =
            new List<string>() { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B",
                                 "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };


        static string str = string.Empty;




        public static string GetEscala(string Tonica, string TipoEscala)
        {
            IList<string> ListaNotas = GetSequenciaDeNotas(Tonica);
            IList<int> tipoEscala = GetTipoEscala(TipoEscala);

            int first = ListaNotas.IndexOf(Tonica);
            str = Tonica + ", ";

            foreach (int item in tipoEscala)
            {
                first += item;
                str += ListaNotas[first].ToString() + ", ";
            }
            MessageBox.Show(str.Substring(0, str.Length - 2));

            return str.Substring(0, str.Length - 2);
        }

        private static IList<int> GetTipoEscala(string tipoEscala)
        {
            IList<int> PadraoEscala = new List<int>();
            switch (tipoEscala)
            {
                case "Menor":
                    PadraoEscala = PadraoEscalaMenor;
                    break;
                case "Maior":
                    PadraoEscala = PadraoEscalaMaior;
                    break;
            }
            return PadraoEscala;
        }

        private static IList<string> GetSequenciaDeNotas(string notacao)
        {

            if (notacao.Contains("#"))
            {
                return SequenciaNotasSustenidos;
            }
            else
            {
                return SequenciaNotasBemois;
            }
        }
    }
}
