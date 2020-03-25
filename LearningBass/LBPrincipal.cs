using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace LearningBass
{
    public partial class LBPrincipal : Form
    {
        private bool LocalizarNota = false;
        private DataGridViewRow row = new DataGridViewRow();

        string NotaProcurada = "";
        List<string> ListaSustenidos = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        List<string> ListaBemois = new List<string> { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
        int NumLinhaCelulaSelecionada, NumColunaCelulaSelecionada;

        public LBPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNota.DataSource = ListaSustenidos;
            cmbSelecaoNotaEscala.DataSource = ListaSustenidos;

            cmbSelecaoNotaEscala.SelectedIndex = 0;
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

        private void btnLimpaGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarEscala_Click(object sender, EventArgs e)
        {
            txtEscala.Text = Escalas.GetEscala(cmbSelecaoNotaEscala.Text, cmbTipoEscala.Text);
        }


        private void rbEscalaBemol_CheckedChanged(object sender, EventArgs e)
        {
            cmbSelecaoNotaEscala.DataSource = ListaBemois;
        }

        private void rbEscalaSustenido_CheckedChanged(object sender, EventArgs e)
        {
            cmbSelecaoNotaEscala.DataSource = ListaSustenidos;
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            row.DefaultCellStyle.SelectionForeColor = Color.White;
            row.DefaultCellStyle.SelectionBackColor = Color.White;

            timer1.Stop();
        }
    }
}
