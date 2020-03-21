using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace LearningBass
{

    public partial class frmBLSPrincipal : Form
    {
        private bool LocalizarNota = false;
        string NotaProcurada = "";
        List<string> ListaSustenidos = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        List<string> ListaBemois = new List<string> { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
        int NumLinhaCelulaSelecionada, NumColunaCelulaSelecionada;

        public bool LocalizarNota1 { get => LocalizarNota; set => LocalizarNota = value; }

        public frmBLSPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregaComboNotacao(ListaSustenidos);
            cmbQtdCordas.SelectedIndex = 1;
            cmbQtdCasas.SelectedIndex = 1;
            cmbNota.SelectedIndex = 0;
        }

        private void CarregaComboNotacao(List<string> listaSustenidos)
        {
            cmbNota.DataSource = listaSustenidos;
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Mouse_DoubleClick(object sender, MouseEventArgs e)
        {
            (sender as Label).BackColor = Color.Gold;
        }

        private void BtnMontarGrid_Click(object sender, EventArgs e)
        {
            VerificaCombos();

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

        private void VerificaCombos()
        {
            if (cmbQtdCordas.Text == "< Selecione >")
            {
                MessageBox.Show("Selecionar Quantidade de Casas");
                return;
            }
            if (cmbQtdCasas.Text == "< Selecione >")
            {
                MessageBox.Show("Selecionar Quantidade de Cordas");
                return;
            }
            //if (cmbNota.Text == "< Selecione >")
            //{
            //    MessageBox.Show("Selecionar uma Nota Musical");
            //    return;
            //}
        }


        private void GridNotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gridNotas.Rows[e.RowIndex];
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

            row.DefaultCellStyle.SelectionBackColor = Color.Black;
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



        private void Timer1_Tick(object sender, EventArgs e)
        {
            DataGridViewRow row = gridNotas.Rows[NumLinhaCelulaSelecionada];
            row.DefaultCellStyle.SelectionBackColor = Color.White;
            row.DefaultCellStyle.SelectionForeColor = Color.White;

            timer1.Stop();
        }
    }
}
