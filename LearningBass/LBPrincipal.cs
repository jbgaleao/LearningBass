using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace LearningBass
{
    public partial class LBPrincipal : Form
    {
        #region Variaveis da Classe
        private bool LocalizarNota = false;
        private DataGridViewRow row = new DataGridViewRow();
        int NumLinhaCelulaSelecionada;
        int NumColunaCelulaSelecionada;
        string NotaProcurada = "";

        string[] vetNotasDaEscala = new string[] { };
        string[] vetFormulaEscala = new string[] { };
        string[] vetGridEscala = new string[] { };

        List<string> ListaSustenidos = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        List<string> ListaBemois = new List<string> { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
        List<string> ListaTiposEscalas = new List<string>()
        {
            "Escala Maior","Escala Menor Natural","Escala Menor Harmônica","Escala Menor Melódica",
            "Escala Cromática","Escala Diminuta","Pentatônica Menor","Pentatônica Maior","Pentablues"
        };

        ExecSom exSom;
        Stream streamNota;
        string NotaExecutada;

        #endregion

        public LBPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNota.DataSource = ListaSustenidos;
            cmbNotaTonica.DataSource = ListaSustenidos;
            cmbTipoEscala.DataSource = ListaTiposEscalas;

            cmbNotaTonica.SelectedIndex = 0;
            cmbOitava.SelectedIndex = 0;
            cmbTipoEscala.SelectedIndex = 0;

            cmbQtdCasas.SelectedIndex = 0;
            cmbQtdCordas.SelectedIndex = 0;
            cmbNota.SelectedIndex = 0;
        }

        private void BtnMontarGrid_Click(object sender, EventArgs e)
        {
            #region Variaveis
            int qtdCasas = int.Parse(cmbQtdCasas.Text);
            int qtdCordas = int.Parse(cmbQtdCordas.Text);
            string notaMusical = cmbNota.Text;
            string afinacao = Util.StrAfinacao(qtdCordas);
            string notacao = (rbSustenidos.Checked) ? "Sustenidos (#)" : "Bemois";
            List<string[]> listaNotas = new List<string[]>();
            List<string> listaTemp = new List<string>();
            #endregion

            DataTable dt = Consultas.RetornaNotasDoBraco(afinacao, qtdCasas);

            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listaTemp.Add(dt.Rows[i][4].ToString());

                if (listaTemp.Count == dt.Rows.Count / qtdCordas)
                {
                    Util.FormataNotacaoSustenidoBemol(listaTemp, notacao);
                    listaNotas.Add(listaTemp.ToArray());
                    listaTemp.Clear();
                }
            }

            DataTable ListaConvertidaEmDataTable = Util.ConvertListToDataTable(listaNotas);
            gridNotas.DataSource = ListaConvertidaEmDataTable;
            Util.FormataGridNotas(gridNotas, qtdCasas.ToString());

            gridNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Wingdings", 11F);
            gridNotas.ClearSelection();

        }

        private void GridNotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = gridNotas.Rows[e.RowIndex];
            NumLinhaCelulaSelecionada = e.RowIndex;
            NumColunaCelulaSelecionada = e.ColumnIndex;


            if (cboxAtivaLocalizarNota.Checked)
            {
                NotaProcurada = cmbNota.Text;

                string NotaClicada = row.Cells[e.ColumnIndex].Value.ToString();
                NotaClicada = NotaClicada.Substring(0, NotaClicada.Length - 1);

                if (NotaProcurada == NotaClicada)
                {
                    FormataCelulaSelecionadaOKeTreino(e, row);
                }
                else
                {
                    Stream strErr = (Stream)Properties.Resources.ResourceManager.GetObject("err");
                    SoundPlayer Sonido = new SoundPlayer(strErr);
                    Sonido.Play();
                    timer1.Enabled = true;

                    row.DefaultCellStyle.SelectionForeColor = Color.Red;
                    row.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
                }
            }
            else
            {
                FormataCelulaSelecionadaOKeTreino(e, row);
            }
        }

        private static void FormataCelulaSelecionadaOKeTreino(DataGridViewCellMouseEventArgs e, DataGridViewRow row)
        {
            Stream strOK = (Stream)Properties.Resources.ResourceManager.GetObject(row.Cells[e.ColumnIndex].Value.ToString().Replace("#", "s"), null);
            SoundPlayer SonidoOK = new SoundPlayer(strOK);
            SonidoOK.Play();

            row.DefaultCellStyle.SelectionForeColor = Color.Black;
            row.DefaultCellStyle.SelectionBackColor = Color.Lavender;
        }

        private void CboxAtivaLocalizarNota_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxAtivaLocalizarNota.Checked)
            {
                cmbNota.Enabled = true;
                cmbNota.SelectedIndex = 0;
                label68.Enabled = true;
                LocalizarNota = true;
                if (rbSustenidos.Checked)
                {
                    cmbNota.DataSource = ListaSustenidos;
                }
                else
                {
                    cmbNota.DataSource = ListaBemois;
                }
            }
            else
            {
                cmbNota.Enabled = false;
                cmbNota.SelectedIndex = 0;
                label68.Enabled = false;
                LocalizarNota = false;
            }
        }

        private void btnGerarEscala_Click(object sender, EventArgs e)
        {
            bool notacao = rbEscalaSustenido.Checked ? true : false;
            DataTable dt = Consultas.RetornaEscala(cmbTipoEscala.Text);

            string Oitava = cmbNotaTonica.Text + cmbOitava.Text;

            switch (Oitava)
            {
                case "B1":
                    Oitava = "B0";
                    break;
                case "B2":
                    Oitava = "B1";
                    break;
                case "B3":
                    Oitava = "B2";
                    break;
                case "B4":
                    Oitava = "B3";
                    break;
            }

            if (Oitava.Contains("4") && (Oitava != "C4"))
            {
                MessageBox.Show("Para a 4ª Oitava, a nota tônica selecionada deve ser exclusivamente C (Dó).");
                return;
            }

            string NotasDaEscala = Escalas.GetEscala(Oitava, dt, notacao);

            // vet-NotasDaEscala = C,D,E,F,G,A,B
            // vet-FormulaEscala = 2,2,1,2,2,2,1

            vetNotasDaEscala = NotasDaEscala.Split(',');
            vetFormulaEscala = dt.Rows[0][0].ToString().Split(',');


            // Calcula o numero de colunas para serem criadas dinamicamente
            DataTable dtGridEscala = new DataTable();
            int TotalDeColunas = 1;
            foreach (string item in vetFormulaEscala)
            {
                TotalDeColunas += Math.Abs(Convert.ToInt32(item));
            }
            // -------------------------------------------------------------

            vetGridEscala = new string[TotalDeColunas];

            vetGridEscala[0] = vetNotasDaEscala[0].ToString();
            int j = 0;
            int k = 1;

            for (int i = 0; i < vetFormulaEscala.Length; i++)
            {
                j += Convert.ToInt16(vetFormulaEscala[i]);
                vetGridEscala[j] = vetNotasDaEscala[k].ToString();
                k++;
            }


            // cria a qtd de colunas calculada acima
            for (int cont = 1; cont <= TotalDeColunas; cont++)
            {
                dtGridEscala.Columns.Add(cont.ToString(), typeof(string));
            }
            // -------------------------------------------------------------


            dtGridEscala.Rows.Add(vetGridEscala);
            gridEscala.DataSource = dtGridEscala;

            gridEscala.ClearSelection();
            btTocarNotas.Enabled = true;
        }

        private void RbEscalaBemol_CheckedChanged(object sender, EventArgs e)
        {
            cmbNotaTonica.DataSource = ListaBemois;
        }

        private void RbEscalaSustenido_CheckedChanged(object sender, EventArgs e)
        {
            cmbNotaTonica.DataSource = ListaSustenidos;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            row.DefaultCellStyle.SelectionForeColor = Color.White;
            row.DefaultCellStyle.SelectionBackColor = Color.White;

            timer1.Stop();
        }

        private void BtTocarNotas_Click(object sender, EventArgs e)
        {
            decimal intervalo = numUpDown.Value;
            int NumeroRepeticoes = Convert.ToInt16(NumRepeticoesUpDown.Value);

            for (int i = 0; i < NumeroRepeticoes; i++)
            {
                foreach (string item in vetNotasDaEscala)
                {
                    NotaExecutada = item;
                    exSom = new ExecSom(Som.Exec);
                    streamNota = (Stream)Properties.Resources.ResourceManager.GetObject(item, null);
                    exSom(streamNota);
                    Thread.Sleep(Convert.ToInt16(intervalo));
                }
                exSom = new ExecSom(Som.Exec);
                streamNota = (Stream)Properties.Resources.ResourceManager.GetObject("ding", null);
                exSom(streamNota);
                Thread.Sleep(Convert.ToInt16(intervalo * 2));
            }
        }
    }
}
