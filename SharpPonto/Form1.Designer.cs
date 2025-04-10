namespace SharpPonto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnRegistrar = new Button();
            btnExportar = new Button();
            btnExcluir = new Button();
            textData = new MaskedTextBox();
            textEntrada = new MaskedTextBox();
            textAlmoco = new MaskedTextBox();
            textRetorno = new MaskedTextBox();
            textSaida = new MaskedTextBox();
            btnInserir = new Button();
            lblPath = new Label();
            gridData = new DataGridViewTextBoxColumn();
            gridEntrada = new DataGridViewTextBoxColumn();
            gridAlmoco = new DataGridViewTextBoxColumn();
            gridRetorno = new DataGridViewTextBoxColumn();
            gridSaida = new DataGridViewTextBoxColumn();
            gridManha = new DataGridViewTextBoxColumn();
            gridTarde = new DataGridViewTextBoxColumn();
            gridTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gridData, gridEntrada, gridAlmoco, gridRetorno, gridSaida, gridManha, gridTarde, gridTotal });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonShadow;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = Color.DimGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(892, 400);
            dataGridView1.TabIndex = 9;
            dataGridView1.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRegistrar.Location = new Point(12, 415);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(278, 62);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.TabStop = false;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExportar.Location = new Point(308, 415);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(278, 62);
            btnExportar.TabIndex = 7;
            btnExportar.TabStop = false;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExcluir.Location = new Point(602, 415);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(278, 62);
            btnExcluir.TabIndex = 8;
            btnExcluir.TabStop = false;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // textData
            // 
            textData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textData.Location = new Point(12, 500);
            textData.Mask = "00/00/0000";
            textData.Name = "textData";
            textData.Size = new Size(136, 29);
            textData.TabIndex = 0;
            textData.TextAlign = HorizontalAlignment.Center;
            textData.ValidatingType = typeof(DateTime);
            // 
            // textEntrada
            // 
            textEntrada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textEntrada.Location = new Point(154, 500);
            textEntrada.Mask = "00:00";
            textEntrada.Name = "textEntrada";
            textEntrada.ResetOnPrompt = false;
            textEntrada.ResetOnSpace = false;
            textEntrada.Size = new Size(136, 29);
            textEntrada.TabIndex = 1;
            textEntrada.TextAlign = HorizontalAlignment.Center;
            textEntrada.ValidatingType = typeof(DateTime);
            // 
            // textAlmoco
            // 
            textAlmoco.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textAlmoco.Location = new Point(296, 500);
            textAlmoco.Mask = "00:00";
            textAlmoco.Name = "textAlmoco";
            textAlmoco.ResetOnPrompt = false;
            textAlmoco.ResetOnSpace = false;
            textAlmoco.Size = new Size(136, 29);
            textAlmoco.TabIndex = 2;
            textAlmoco.TextAlign = HorizontalAlignment.Center;
            textAlmoco.ValidatingType = typeof(DateTime);
            // 
            // textRetorno
            // 
            textRetorno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textRetorno.Location = new Point(438, 500);
            textRetorno.Mask = "00:00";
            textRetorno.Name = "textRetorno";
            textRetorno.ResetOnPrompt = false;
            textRetorno.ResetOnSpace = false;
            textRetorno.Size = new Size(136, 29);
            textRetorno.TabIndex = 3;
            textRetorno.TextAlign = HorizontalAlignment.Center;
            textRetorno.ValidatingType = typeof(DateTime);
            // 
            // textSaida
            // 
            textSaida.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textSaida.Location = new Point(580, 500);
            textSaida.Mask = "00:00";
            textSaida.Name = "textSaida";
            textSaida.ResetOnPrompt = false;
            textSaida.ResetOnSpace = false;
            textSaida.Size = new Size(136, 29);
            textSaida.TabIndex = 4;
            textSaida.TextAlign = HorizontalAlignment.Center;
            textSaida.ValidatingType = typeof(DateTime);
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnInserir.Location = new Point(722, 491);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(158, 44);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblPath
            // 
            lblPath.AutoSize = true;
            lblPath.Location = new Point(12, 544);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(0, 20);
            lblPath.TabIndex = 10;
            // 
            // gridData
            // 
            gridData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridData.DataPropertyName = "Data";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            gridData.DefaultCellStyle = dataGridViewCellStyle3;
            gridData.FillWeight = 40.60913F;
            gridData.Frozen = true;
            gridData.HeaderText = "Data";
            gridData.MaxInputLength = 10;
            gridData.MinimumWidth = 110;
            gridData.Name = "gridData";
            gridData.ReadOnly = true;
            gridData.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridData.Width = 110;
            // 
            // gridEntrada
            // 
            gridEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridEntrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            gridEntrada.DefaultCellStyle = dataGridViewCellStyle4;
            gridEntrada.FillWeight = 183.871628F;
            gridEntrada.Frozen = true;
            gridEntrada.HeaderText = "Entrada";
            gridEntrada.MaxInputLength = 5;
            gridEntrada.MinimumWidth = 110;
            gridEntrada.Name = "gridEntrada";
            gridEntrada.ReadOnly = true;
            gridEntrada.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridEntrada.Width = 110;
            // 
            // gridAlmoco
            // 
            gridAlmoco.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridAlmoco.DataPropertyName = "Almoco";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle5.Format = "t";
            dataGridViewCellStyle5.NullValue = null;
            gridAlmoco.DefaultCellStyle = dataGridViewCellStyle5;
            gridAlmoco.FillWeight = 159.814377F;
            gridAlmoco.Frozen = true;
            gridAlmoco.HeaderText = "Almoço";
            gridAlmoco.MaxInputLength = 5;
            gridAlmoco.MinimumWidth = 110;
            gridAlmoco.Name = "gridAlmoco";
            gridAlmoco.ReadOnly = true;
            gridAlmoco.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridAlmoco.Width = 110;
            // 
            // gridRetorno
            // 
            gridRetorno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridRetorno.DataPropertyName = "Retorno";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            gridRetorno.DefaultCellStyle = dataGridViewCellStyle6;
            gridRetorno.FillWeight = 11.7430735F;
            gridRetorno.Frozen = true;
            gridRetorno.HeaderText = "Retorno";
            gridRetorno.MaxInputLength = 5;
            gridRetorno.MinimumWidth = 110;
            gridRetorno.Name = "gridRetorno";
            gridRetorno.ReadOnly = true;
            gridRetorno.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridRetorno.Width = 110;
            // 
            // gridSaida
            // 
            gridSaida.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridSaida.DataPropertyName = "Saida";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            gridSaida.DefaultCellStyle = dataGridViewCellStyle7;
            gridSaida.FillWeight = 158.092163F;
            gridSaida.Frozen = true;
            gridSaida.HeaderText = "Saída";
            gridSaida.MaxInputLength = 5;
            gridSaida.MinimumWidth = 110;
            gridSaida.Name = "gridSaida";
            gridSaida.ReadOnly = true;
            gridSaida.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridSaida.Width = 110;
            // 
            // gridManha
            // 
            gridManha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridManha.DataPropertyName = "Manha";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            gridManha.DefaultCellStyle = dataGridViewCellStyle8;
            gridManha.FillWeight = 120.6781F;
            gridManha.Frozen = true;
            gridManha.HeaderText = "Manhã";
            gridManha.MaxInputLength = 5;
            gridManha.MinimumWidth = 110;
            gridManha.Name = "gridManha";
            gridManha.ReadOnly = true;
            gridManha.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridManha.Width = 110;
            // 
            // gridTarde
            // 
            gridTarde.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridTarde.DataPropertyName = "Tarde";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            gridTarde.DefaultCellStyle = dataGridViewCellStyle9;
            gridTarde.FillWeight = 3.86393428F;
            gridTarde.Frozen = true;
            gridTarde.HeaderText = "Tarde";
            gridTarde.MaxInputLength = 5;
            gridTarde.MinimumWidth = 110;
            gridTarde.Name = "gridTarde";
            gridTarde.ReadOnly = true;
            gridTarde.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridTarde.Width = 110;
            // 
            // gridTotal
            // 
            gridTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridTotal.DataPropertyName = "TotalDia";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            gridTotal.DefaultCellStyle = dataGridViewCellStyle10;
            gridTotal.FillWeight = 121.327545F;
            gridTotal.HeaderText = "Total de Horas";
            gridTotal.MaxInputLength = 5;
            gridTotal.MinimumWidth = 130;
            gridTotal.Name = "gridTotal";
            gridTotal.ReadOnly = true;
            gridTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 569);
            Controls.Add(lblPath);
            Controls.Add(btnInserir);
            Controls.Add(textSaida);
            Controls.Add(textRetorno);
            Controls.Add(textAlmoco);
            Controls.Add(textEntrada);
            Controls.Add(textData);
            Controls.Add(btnExcluir);
            Controls.Add(btnExportar);
            Controls.Add(btnRegistrar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SharpPonto";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRegistrar;
        private Button btnExportar;
        private Button btnExcluir;
        private MaskedTextBox textData;
        private MaskedTextBox textEntrada;
        private MaskedTextBox textAlmoco;
        private MaskedTextBox textRetorno;
        private MaskedTextBox textSaida;
        private Button btnInserir;
        private Label lblPath;
        private DataGridViewTextBoxColumn gridData;
        private DataGridViewTextBoxColumn gridEntrada;
        private DataGridViewTextBoxColumn gridAlmoco;
        private DataGridViewTextBoxColumn gridRetorno;
        private DataGridViewTextBoxColumn gridSaida;
        private DataGridViewTextBoxColumn gridManha;
        private DataGridViewTextBoxColumn gridTarde;
        private DataGridViewTextBoxColumn gridTotal;
    }
}
