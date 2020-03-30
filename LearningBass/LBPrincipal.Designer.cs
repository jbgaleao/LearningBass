namespace LearningBass
{
    partial class LBPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlFuncionalidades = new System.Windows.Forms.TabControl();
            this.tabMapeamentoBraco = new System.Windows.Forms.TabPage();
            this.gridNotas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboxInstrumentos = new System.Windows.Forms.GroupBox();
            this._38 = new System.Windows.Forms.RadioButton();
            this._37 = new System.Windows.Forms.RadioButton();
            this._35 = new System.Windows.Forms.RadioButton();
            this._34 = new System.Windows.Forms.RadioButton();
            this._33 = new System.Windows.Forms.RadioButton();
            this._06 = new System.Windows.Forms.RadioButton();
            this._05 = new System.Windows.Forms.RadioButton();
            this._03 = new System.Windows.Forms.RadioButton();
            this._02 = new System.Windows.Forms.RadioButton();
            this._01 = new System.Windows.Forms.RadioButton();
            this.gboxConfiguraNotacao = new System.Windows.Forms.GroupBox();
            this.cboxAtivaLocalizarNota = new System.Windows.Forms.CheckBox();
            this.rbBemois = new System.Windows.Forms.RadioButton();
            this.rbSustenidos = new System.Windows.Forms.RadioButton();
            this.cmbNota = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.btnLimpaGrid = new System.Windows.Forms.Button();
            this.btnMontarGrid = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbQtdCordas = new System.Windows.Forms.ComboBox();
            this.cmbQtdCasas = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.tabEscalas = new System.Windows.Forms.TabPage();
            this.btTocarNotas = new System.Windows.Forms.Button();
            this.gridEscala = new System.Windows.Forms.DataGridView();
            this.pnEscalas = new System.Windows.Forms.Panel();
            this.gboxEscala = new System.Windows.Forms.GroupBox();
            this.btnGerarEscala = new System.Windows.Forms.Button();
            this.cmbTipoEscala = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOitava = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNotaTonica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEscalaBemol = new System.Windows.Forms.RadioButton();
            this.rbEscalaSustenido = new System.Windows.Forms.RadioButton();
            this.tabAcordes = new System.Windows.Forms.TabPage();
            this.tabDitadoMusical = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlFuncionalidades.SuspendLayout();
            this.tabMapeamentoBraco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.gboxInstrumentos.SuspendLayout();
            this.gboxConfiguraNotacao.SuspendLayout();
            this.tabEscalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEscala)).BeginInit();
            this.pnEscalas.SuspendLayout();
            this.gboxEscala.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFuncionalidades
            // 
            this.tabControlFuncionalidades.Controls.Add(this.tabMapeamentoBraco);
            this.tabControlFuncionalidades.Controls.Add(this.tabEscalas);
            this.tabControlFuncionalidades.Controls.Add(this.tabAcordes);
            this.tabControlFuncionalidades.Controls.Add(this.tabDitadoMusical);
            this.tabControlFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlFuncionalidades.Location = new System.Drawing.Point(12, 12);
            this.tabControlFuncionalidades.Name = "tabControlFuncionalidades";
            this.tabControlFuncionalidades.SelectedIndex = 0;
            this.tabControlFuncionalidades.Size = new System.Drawing.Size(1526, 594);
            this.tabControlFuncionalidades.TabIndex = 0;
            // 
            // tabMapeamentoBraco
            // 
            this.tabMapeamentoBraco.Controls.Add(this.gridNotas);
            this.tabMapeamentoBraco.Controls.Add(this.panel1);
            this.tabMapeamentoBraco.Location = new System.Drawing.Point(4, 27);
            this.tabMapeamentoBraco.Name = "tabMapeamentoBraco";
            this.tabMapeamentoBraco.Size = new System.Drawing.Size(1518, 563);
            this.tabMapeamentoBraco.TabIndex = 4;
            this.tabMapeamentoBraco.Text = "Mapeamento Braço";
            this.tabMapeamentoBraco.UseVisualStyleBackColor = true;
            // 
            // gridNotas
            // 
            this.gridNotas.AllowUserToAddRows = false;
            this.gridNotas.AllowUserToDeleteRows = false;
            this.gridNotas.AllowUserToResizeColumns = false;
            this.gridNotas.AllowUserToResizeRows = false;
            this.gridNotas.BackgroundColor = System.Drawing.Color.White;
            this.gridNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridNotas.ColumnHeadersHeight = 42;
            this.gridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNotas.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridNotas.EnableHeadersVisualStyles = false;
            this.gridNotas.Location = new System.Drawing.Point(16, 276);
            this.gridNotas.Name = "gridNotas";
            this.gridNotas.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridNotas.RowHeadersWidth = 60;
            this.gridNotas.RowTemplate.Height = 36;
            this.gridNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridNotas.ShowEditingIcon = false;
            this.gridNotas.Size = new System.Drawing.Size(1480, 273);
            this.gridNotas.TabIndex = 143;
            this.gridNotas.TabStop = false;
            this.gridNotas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridNotas_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gboxInstrumentos);
            this.panel1.Controls.Add(this.gboxConfiguraNotacao);
            this.panel1.Controls.Add(this.btnLimpaGrid);
            this.panel1.Controls.Add(this.btnMontarGrid);
            this.panel1.Controls.Add(this.label65);
            this.panel1.Controls.Add(this.cmbQtdCordas);
            this.panel1.Controls.Add(this.cmbQtdCasas);
            this.panel1.Controls.Add(this.label64);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 245);
            this.panel1.TabIndex = 142;
            // 
            // gboxInstrumentos
            // 
            this.gboxInstrumentos.Controls.Add(this._38);
            this.gboxInstrumentos.Controls.Add(this._37);
            this.gboxInstrumentos.Controls.Add(this._35);
            this.gboxInstrumentos.Controls.Add(this._34);
            this.gboxInstrumentos.Controls.Add(this._33);
            this.gboxInstrumentos.Controls.Add(this._06);
            this.gboxInstrumentos.Controls.Add(this._05);
            this.gboxInstrumentos.Controls.Add(this._03);
            this.gboxInstrumentos.Controls.Add(this._02);
            this.gboxInstrumentos.Controls.Add(this._01);
            this.gboxInstrumentos.Location = new System.Drawing.Point(476, 15);
            this.gboxInstrumentos.Name = "gboxInstrumentos";
            this.gboxInstrumentos.Size = new System.Drawing.Size(812, 214);
            this.gboxInstrumentos.TabIndex = 151;
            this.gboxInstrumentos.TabStop = false;
            this.gboxInstrumentos.Text = " Instrumentos ";
            // 
            // _38
            // 
            this._38.AutoSize = true;
            this._38.Location = new System.Drawing.Point(447, 163);
            this._38.Name = "_38";
            this._38.Size = new System.Drawing.Size(158, 22);
            this._38.TabIndex = 9;
            this._38.TabStop = true;
            this._38.Text = "Baixo eletrico slap 2";
            this._38.UseVisualStyleBackColor = true;
            // 
            // _37
            // 
            this._37.AutoSize = true;
            this._37.Location = new System.Drawing.Point(447, 133);
            this._37.Name = "_37";
            this._37.Size = new System.Drawing.Size(158, 22);
            this._37.TabIndex = 8;
            this._37.TabStop = true;
            this._37.Text = "Baixo eletrico slap 1";
            this._37.UseVisualStyleBackColor = true;
            // 
            // _35
            // 
            this._35.AutoSize = true;
            this._35.Location = new System.Drawing.Point(447, 103);
            this._35.Name = "_35";
            this._35.Size = new System.Drawing.Size(166, 22);
            this._35.TabIndex = 7;
            this._35.TabStop = true;
            this._35.Text = "Baixo eletrico palheta";
            this._35.UseVisualStyleBackColor = true;
            // 
            // _34
            // 
            this._34.AutoSize = true;
            this._34.Location = new System.Drawing.Point(447, 73);
            this._34.Name = "_34";
            this._34.Size = new System.Drawing.Size(182, 22);
            this._34.TabIndex = 6;
            this._34.TabStop = true;
            this._34.Text = "Baixo eletrico dedilhado";
            this._34.UseVisualStyleBackColor = true;
            // 
            // _33
            // 
            this._33.AutoSize = true;
            this._33.Location = new System.Drawing.Point(447, 43);
            this._33.Name = "_33";
            this._33.Size = new System.Drawing.Size(174, 22);
            this._33.TabIndex = 5;
            this._33.TabStop = true;
            this._33.Text = "DoubleBass dedilhado";
            this._33.UseVisualStyleBackColor = true;
            // 
            // _06
            // 
            this._06.AutoSize = true;
            this._06.Location = new System.Drawing.Point(28, 163);
            this._06.Name = "_06";
            this._06.Size = new System.Drawing.Size(97, 22);
            this._06.TabIndex = 4;
            this._06.TabStop = true;
            this._06.Text = "Piano DX7";
            this._06.UseVisualStyleBackColor = true;
            // 
            // _05
            // 
            this._05.AutoSize = true;
            this._05.Location = new System.Drawing.Point(28, 133);
            this._05.Name = "_05";
            this._05.Size = new System.Drawing.Size(170, 22);
            this._05.TabIndex = 3;
            this._05.TabStop = true;
            this._05.Text = "Piano Fender Rhodes";
            this._05.UseVisualStyleBackColor = true;
            // 
            // _03
            // 
            this._03.AutoSize = true;
            this._03.Location = new System.Drawing.Point(28, 103);
            this._03.Name = "_03";
            this._03.Size = new System.Drawing.Size(173, 22);
            this._03.TabIndex = 2;
            this._03.TabStop = true;
            this._03.Text = "Piano electro acustico";
            this._03.UseVisualStyleBackColor = true;
            // 
            // _02
            // 
            this._02.AutoSize = true;
            this._02.Location = new System.Drawing.Point(28, 73);
            this._02.Name = "_02";
            this._02.Size = new System.Drawing.Size(76, 22);
            this._02.TabIndex = 1;
            this._02.TabStop = true;
            this._02.Text = "Piano 2";
            this._02.UseVisualStyleBackColor = true;
            // 
            // _01
            // 
            this._01.AutoSize = true;
            this._01.Location = new System.Drawing.Point(28, 43);
            this._01.Name = "_01";
            this._01.Size = new System.Drawing.Size(76, 22);
            this._01.TabIndex = 0;
            this._01.TabStop = true;
            this._01.Text = "Piano 1";
            this._01.UseVisualStyleBackColor = true;
            // 
            // gboxConfiguraNotacao
            // 
            this.gboxConfiguraNotacao.Controls.Add(this.cboxAtivaLocalizarNota);
            this.gboxConfiguraNotacao.Controls.Add(this.rbBemois);
            this.gboxConfiguraNotacao.Controls.Add(this.rbSustenidos);
            this.gboxConfiguraNotacao.Controls.Add(this.cmbNota);
            this.gboxConfiguraNotacao.Controls.Add(this.label68);
            this.gboxConfiguraNotacao.Location = new System.Drawing.Point(14, 84);
            this.gboxConfiguraNotacao.Name = "gboxConfiguraNotacao";
            this.gboxConfiguraNotacao.Size = new System.Drawing.Size(445, 145);
            this.gboxConfiguraNotacao.TabIndex = 149;
            this.gboxConfiguraNotacao.TabStop = false;
            this.gboxConfiguraNotacao.Text = " Notação ";
            // 
            // cboxAtivaLocalizarNota
            // 
            this.cboxAtivaLocalizarNota.AutoSize = true;
            this.cboxAtivaLocalizarNota.Location = new System.Drawing.Point(323, 67);
            this.cboxAtivaLocalizarNota.Name = "cboxAtivaLocalizarNota";
            this.cboxAtivaLocalizarNota.Size = new System.Drawing.Size(63, 22);
            this.cboxAtivaLocalizarNota.TabIndex = 152;
            this.cboxAtivaLocalizarNota.Text = "Ativar";
            this.cboxAtivaLocalizarNota.UseVisualStyleBackColor = true;
            this.cboxAtivaLocalizarNota.CheckedChanged += new System.EventHandler(this.CboxAtivaLocalizarNota_CheckedChanged);
            // 
            // rbBemois
            // 
            this.rbBemois.AutoSize = true;
            this.rbBemois.Location = new System.Drawing.Point(18, 33);
            this.rbBemois.Name = "rbBemois";
            this.rbBemois.Size = new System.Drawing.Size(99, 22);
            this.rbBemois.TabIndex = 150;
            this.rbBemois.Text = "Bemóis (b)";
            this.rbBemois.UseVisualStyleBackColor = true;
            // 
            // rbSustenidos
            // 
            this.rbSustenidos.AutoSize = true;
            this.rbSustenidos.Checked = true;
            this.rbSustenidos.Location = new System.Drawing.Point(18, 64);
            this.rbSustenidos.Name = "rbSustenidos";
            this.rbSustenidos.Size = new System.Drawing.Size(122, 22);
            this.rbSustenidos.TabIndex = 150;
            this.rbSustenidos.TabStop = true;
            this.rbSustenidos.Text = "Sustenidos (#)";
            this.rbSustenidos.UseVisualStyleBackColor = true;
            // 
            // cmbNota
            // 
            this.cmbNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNota.Enabled = false;
            this.cmbNota.FormattingEnabled = true;
            this.cmbNota.Location = new System.Drawing.Point(323, 95);
            this.cmbNota.Name = "cmbNota";
            this.cmbNota.Size = new System.Drawing.Size(106, 26);
            this.cmbNota.TabIndex = 143;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Enabled = false;
            this.label68.Location = new System.Drawing.Point(196, 99);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(120, 18);
            this.label68.TabIndex = 144;
            this.label68.Text = "Localizar a Nota:";
            // 
            // btnLimpaGrid
            // 
            this.btnLimpaGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaGrid.ForeColor = System.Drawing.Color.Red;
            this.btnLimpaGrid.Location = new System.Drawing.Point(1317, 26);
            this.btnLimpaGrid.Name = "btnLimpaGrid";
            this.btnLimpaGrid.Size = new System.Drawing.Size(134, 28);
            this.btnLimpaGrid.TabIndex = 147;
            this.btnLimpaGrid.Text = "Limpar Grid";
            this.btnLimpaGrid.UseVisualStyleBackColor = true;
            // 
            // btnMontarGrid
            // 
            this.btnMontarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontarGrid.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMontarGrid.Location = new System.Drawing.Point(1317, 60);
            this.btnMontarGrid.Name = "btnMontarGrid";
            this.btnMontarGrid.Size = new System.Drawing.Size(134, 28);
            this.btnMontarGrid.TabIndex = 147;
            this.btnMontarGrid.Text = "Montar Grid";
            this.btnMontarGrid.UseVisualStyleBackColor = true;
            this.btnMontarGrid.Click += new System.EventHandler(this.BtnMontarGrid_Click);
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(211, 56);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(119, 18);
            this.label65.TabIndex = 145;
            this.label65.Text = "Número Cordas:";
            // 
            // cmbQtdCordas
            // 
            this.cmbQtdCordas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQtdCordas.FormattingEnabled = true;
            this.cmbQtdCordas.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cmbQtdCordas.Location = new System.Drawing.Point(337, 52);
            this.cmbQtdCordas.Name = "cmbQtdCordas";
            this.cmbQtdCordas.Size = new System.Drawing.Size(106, 26);
            this.cmbQtdCordas.TabIndex = 141;
            // 
            // cmbQtdCasas
            // 
            this.cmbQtdCasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQtdCasas.FormattingEnabled = true;
            this.cmbQtdCasas.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbQtdCasas.Location = new System.Drawing.Point(337, 20);
            this.cmbQtdCasas.Name = "cmbQtdCasas";
            this.cmbQtdCasas.Size = new System.Drawing.Size(106, 26);
            this.cmbQtdCasas.TabIndex = 142;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(211, 24);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(113, 18);
            this.label64.TabIndex = 146;
            this.label64.Text = "Número Casas:";
            // 
            // tabEscalas
            // 
            this.tabEscalas.BackColor = System.Drawing.Color.White;
            this.tabEscalas.Controls.Add(this.btTocarNotas);
            this.tabEscalas.Controls.Add(this.gridEscala);
            this.tabEscalas.Controls.Add(this.pnEscalas);
            this.tabEscalas.Location = new System.Drawing.Point(4, 27);
            this.tabEscalas.Name = "tabEscalas";
            this.tabEscalas.Padding = new System.Windows.Forms.Padding(15);
            this.tabEscalas.Size = new System.Drawing.Size(1518, 563);
            this.tabEscalas.TabIndex = 1;
            this.tabEscalas.Text = "Escalas";
            // 
            // btTocarNotas
            // 
            this.btTocarNotas.Location = new System.Drawing.Point(1394, 193);
            this.btTocarNotas.Name = "btTocarNotas";
            this.btTocarNotas.Size = new System.Drawing.Size(106, 51);
            this.btTocarNotas.TabIndex = 160;
            this.btTocarNotas.Text = "Executar Escala";
            this.btTocarNotas.UseVisualStyleBackColor = true;
            this.btTocarNotas.Click += new System.EventHandler(this.BtTocarNotas_Click);
            // 
            // gridEscala
            // 
            this.gridEscala.AllowUserToAddRows = false;
            this.gridEscala.AllowUserToDeleteRows = false;
            this.gridEscala.AllowUserToResizeColumns = false;
            this.gridEscala.AllowUserToResizeRows = false;
            this.gridEscala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEscala.BackgroundColor = System.Drawing.Color.White;
            this.gridEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEscala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridEscala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridEscala.ColumnHeadersHeight = 42;
            this.gridEscala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEscala.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridEscala.EnableHeadersVisualStyles = false;
            this.gridEscala.Location = new System.Drawing.Point(18, 193);
            this.gridEscala.Name = "gridEscala";
            this.gridEscala.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEscala.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridEscala.RowHeadersVisible = false;
            this.gridEscala.RowHeadersWidth = 60;
            this.gridEscala.RowTemplate.DividerHeight = 10;
            this.gridEscala.RowTemplate.Height = 60;
            this.gridEscala.RowTemplate.ReadOnly = true;
            this.gridEscala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridEscala.ShowEditingIcon = false;
            this.gridEscala.Size = new System.Drawing.Size(1325, 105);
            this.gridEscala.TabIndex = 154;
            this.gridEscala.TabStop = false;
            // 
            // pnEscalas
            // 
            this.pnEscalas.Controls.Add(this.gboxEscala);
            this.pnEscalas.Controls.Add(this.groupBox1);
            this.pnEscalas.Location = new System.Drawing.Point(18, 18);
            this.pnEscalas.Name = "pnEscalas";
            this.pnEscalas.Padding = new System.Windows.Forms.Padding(10);
            this.pnEscalas.Size = new System.Drawing.Size(1482, 157);
            this.pnEscalas.TabIndex = 151;
            // 
            // gboxEscala
            // 
            this.gboxEscala.Controls.Add(this.btnGerarEscala);
            this.gboxEscala.Controls.Add(this.cmbTipoEscala);
            this.gboxEscala.Controls.Add(this.label2);
            this.gboxEscala.Controls.Add(this.cmbOitava);
            this.gboxEscala.Controls.Add(this.label3);
            this.gboxEscala.Controls.Add(this.cmbNotaTonica);
            this.gboxEscala.Controls.Add(this.label1);
            this.gboxEscala.Location = new System.Drawing.Point(256, 13);
            this.gboxEscala.Name = "gboxEscala";
            this.gboxEscala.Size = new System.Drawing.Size(616, 131);
            this.gboxEscala.TabIndex = 151;
            this.gboxEscala.TabStop = false;
            this.gboxEscala.Text = " Escala ";
            // 
            // btnGerarEscala
            // 
            this.btnGerarEscala.Location = new System.Drawing.Point(489, 30);
            this.btnGerarEscala.Name = "btnGerarEscala";
            this.btnGerarEscala.Size = new System.Drawing.Size(106, 31);
            this.btnGerarEscala.TabIndex = 156;
            this.btnGerarEscala.Text = "Gerar Escala";
            this.btnGerarEscala.UseVisualStyleBackColor = true;
            this.btnGerarEscala.Click += new System.EventHandler(this.btnGerarEscala_Click);
            // 
            // cmbTipoEscala
            // 
            this.cmbTipoEscala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEscala.FormattingEnabled = true;
            this.cmbTipoEscala.Items.AddRange(new object[] {
            "Menor Natural",
            "Maior Natural",
            "Diminuta",
            "Dominante"});
            this.cmbTipoEscala.Location = new System.Drawing.Point(81, 70);
            this.cmbTipoEscala.Name = "cmbTipoEscala";
            this.cmbTipoEscala.Size = new System.Drawing.Size(514, 26);
            this.cmbTipoEscala.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 155;
            this.label2.Text = "Tipo:";
            // 
            // cmbOitava
            // 
            this.cmbOitava.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOitava.FormattingEnabled = true;
            this.cmbOitava.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbOitava.Location = new System.Drawing.Point(285, 32);
            this.cmbOitava.Name = "cmbOitava";
            this.cmbOitava.Size = new System.Drawing.Size(106, 26);
            this.cmbOitava.TabIndex = 154;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 155;
            this.label3.Text = "Oitava:";
            // 
            // cmbNotaTonica
            // 
            this.cmbNotaTonica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotaTonica.FormattingEnabled = true;
            this.cmbNotaTonica.Location = new System.Drawing.Point(81, 32);
            this.cmbNotaTonica.Name = "cmbNotaTonica";
            this.cmbNotaTonica.Size = new System.Drawing.Size(106, 26);
            this.cmbNotaTonica.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 155;
            this.label1.Text = "Tônica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEscalaBemol);
            this.groupBox1.Controls.Add(this.rbEscalaSustenido);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 131);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Notação ";
            // 
            // rbEscalaBemol
            // 
            this.rbEscalaBemol.AutoSize = true;
            this.rbEscalaBemol.Location = new System.Drawing.Point(18, 33);
            this.rbEscalaBemol.Name = "rbEscalaBemol";
            this.rbEscalaBemol.Size = new System.Drawing.Size(99, 22);
            this.rbEscalaBemol.TabIndex = 150;
            this.rbEscalaBemol.Text = "Bemóis (b)";
            this.rbEscalaBemol.UseVisualStyleBackColor = true;
            this.rbEscalaBemol.CheckedChanged += new System.EventHandler(this.RbEscalaBemol_CheckedChanged);
            // 
            // rbEscalaSustenido
            // 
            this.rbEscalaSustenido.AutoSize = true;
            this.rbEscalaSustenido.Checked = true;
            this.rbEscalaSustenido.Location = new System.Drawing.Point(18, 71);
            this.rbEscalaSustenido.Name = "rbEscalaSustenido";
            this.rbEscalaSustenido.Size = new System.Drawing.Size(122, 22);
            this.rbEscalaSustenido.TabIndex = 150;
            this.rbEscalaSustenido.TabStop = true;
            this.rbEscalaSustenido.Text = "Sustenidos (#)";
            this.rbEscalaSustenido.UseVisualStyleBackColor = true;
            this.rbEscalaSustenido.CheckedChanged += new System.EventHandler(this.RbEscalaSustenido_CheckedChanged);
            // 
            // tabAcordes
            // 
            this.tabAcordes.BackColor = System.Drawing.Color.Gray;
            this.tabAcordes.Location = new System.Drawing.Point(4, 27);
            this.tabAcordes.Name = "tabAcordes";
            this.tabAcordes.Size = new System.Drawing.Size(1518, 563);
            this.tabAcordes.TabIndex = 3;
            this.tabAcordes.Text = "Acordes";
            // 
            // tabDitadoMusical
            // 
            this.tabDitadoMusical.BackColor = System.Drawing.Color.Silver;
            this.tabDitadoMusical.Location = new System.Drawing.Point(4, 27);
            this.tabDitadoMusical.Name = "tabDitadoMusical";
            this.tabDitadoMusical.Size = new System.Drawing.Size(1518, 563);
            this.tabDitadoMusical.TabIndex = 2;
            this.tabDitadoMusical.Text = "Ditado Musical";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LBPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 616);
            this.Controls.Add(this.tabControlFuncionalidades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LBPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bass Learn Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlFuncionalidades.ResumeLayout(false);
            this.tabMapeamentoBraco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxInstrumentos.ResumeLayout(false);
            this.gboxInstrumentos.PerformLayout();
            this.gboxConfiguraNotacao.ResumeLayout(false);
            this.gboxConfiguraNotacao.PerformLayout();
            this.tabEscalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEscala)).EndInit();
            this.pnEscalas.ResumeLayout(false);
            this.gboxEscala.ResumeLayout(false);
            this.gboxEscala.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFuncionalidades;
        private System.Windows.Forms.TabPage tabAcordes;
        private System.Windows.Forms.TabPage tabDitadoMusical;
        private System.Windows.Forms.TabPage tabEscalas;
        private System.Windows.Forms.TabPage tabMapeamentoBraco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpaGrid;
        private System.Windows.Forms.Button btnMontarGrid;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cmbQtdCordas;
        private System.Windows.Forms.ComboBox cmbQtdCasas;
        private System.Windows.Forms.ComboBox cmbNota;
        private System.Windows.Forms.GroupBox gboxConfiguraNotacao;
        private System.Windows.Forms.RadioButton rbBemois;
        private System.Windows.Forms.RadioButton rbSustenidos;
        private System.Windows.Forms.GroupBox gboxInstrumentos;
        private System.Windows.Forms.DataGridView gridNotas;
        private System.Windows.Forms.RadioButton _38;
        private System.Windows.Forms.RadioButton _37;
        private System.Windows.Forms.RadioButton _35;
        private System.Windows.Forms.RadioButton _34;
        private System.Windows.Forms.RadioButton _33;
        private System.Windows.Forms.RadioButton _06;
        private System.Windows.Forms.RadioButton _05;
        private System.Windows.Forms.RadioButton _03;
        private System.Windows.Forms.RadioButton _02;
        private System.Windows.Forms.RadioButton _01;
        private System.Windows.Forms.CheckBox cboxAtivaLocalizarNota;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnEscalas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEscalaBemol;
        private System.Windows.Forms.RadioButton rbEscalaSustenido;
        private System.Windows.Forms.GroupBox gboxEscala;
        private System.Windows.Forms.ComboBox cmbNotaTonica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoEscala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridEscala;
        private System.Windows.Forms.Button btTocarNotas;
        private System.Windows.Forms.Button btnGerarEscala;
        private System.Windows.Forms.ComboBox cmbOitava;
        private System.Windows.Forms.Label label3;
    }
}
