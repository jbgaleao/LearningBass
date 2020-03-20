namespace BassLearnSimulator
{
    partial class frmBLSPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.cmbQtdCordas = new System.Windows.Forms.ComboBox();
            this.cmbQtdCasas = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.tabEscalas = new System.Windows.Forms.TabPage();
            this.tabAcordes = new System.Windows.Forms.TabPage();
            this.tabDitadoMusical = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlFuncionalidades.SuspendLayout();
            this.tabMapeamentoBraco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.gboxInstrumentos.SuspendLayout();
            this.gboxConfiguraNotacao.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNotas.ColumnHeadersHeight = 42;
            this.gridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridNotas.EnableHeadersVisualStyles = false;
            this.gridNotas.Location = new System.Drawing.Point(16, 276);
            this.gridNotas.Name = "gridNotas";
            this.gridNotas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.panel1.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(1317, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 148;
            this.button1.Text = "Checar";
            this.button1.UseVisualStyleBackColor = true;
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
            "< Selecione >",
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
            "< Selecione >",
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
            this.tabEscalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabEscalas.Location = new System.Drawing.Point(4, 27);
            this.tabEscalas.Name = "tabEscalas";
            this.tabEscalas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscalas.Size = new System.Drawing.Size(1518, 563);
            this.tabEscalas.TabIndex = 1;
            this.tabEscalas.Text = "Escalas";
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
            // frmBLSPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 616);
            this.Controls.Add(this.tabControlFuncionalidades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBLSPrincipal";
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
        private System.Windows.Forms.Button button1;
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
    }
}

