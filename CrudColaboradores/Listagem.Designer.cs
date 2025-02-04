namespace CrudColaboradores
{
    partial class Listagem
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
            this.dataColaboradores = new System.Windows.Forms.DataGridView();
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.checkCategoria = new System.Windows.Forms.CheckedListBox();
            this.checkSituacao = new System.Windows.Forms.CheckedListBox();
            this.botaoPesquisarNome = new System.Windows.Forms.Button();
            this.botaoPesquisarCodigo = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.txtCodigoPesquisa = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataColaboradores
            // 
            this.dataColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Categoria,
            this.Situacao});
            this.dataColaboradores.Location = new System.Drawing.Point(51, 122);
            this.dataColaboradores.Name = "dataColaboradores";
            this.dataColaboradores.Size = new System.Drawing.Size(355, 528);
            this.dataColaboradores.TabIndex = 0;
            this.dataColaboradores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botaoFiltrar
            // 
            this.botaoFiltrar.Location = new System.Drawing.Point(428, 122);
            this.botaoFiltrar.Name = "botaoFiltrar";
            this.botaoFiltrar.Size = new System.Drawing.Size(128, 44);
            this.botaoFiltrar.TabIndex = 1;
            this.botaoFiltrar.Text = "Filtrar";
            this.botaoFiltrar.UseVisualStyleBackColor = true;
            this.botaoFiltrar.Click += new System.EventHandler(this.botaoFiltrar_Click);
            // 
            // checkCategoria
            // 
            this.checkCategoria.CheckOnClick = true;
            this.checkCategoria.FormattingEnabled = true;
            this.checkCategoria.Items.AddRange(new object[] {
            "Tester",
            "Desenvolvedor",
            "Gerente",
            "Suporte"});
            this.checkCategoria.Location = new System.Drawing.Point(428, 12);
            this.checkCategoria.Name = "checkCategoria";
            this.checkCategoria.Size = new System.Drawing.Size(128, 64);
            this.checkCategoria.TabIndex = 2;
            this.checkCategoria.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // checkSituacao
            // 
            this.checkSituacao.CheckOnClick = true;
            this.checkSituacao.FormattingEnabled = true;
            this.checkSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.checkSituacao.Location = new System.Drawing.Point(428, 82);
            this.checkSituacao.Name = "checkSituacao";
            this.checkSituacao.Size = new System.Drawing.Size(128, 34);
            this.checkSituacao.TabIndex = 3;
            // 
            // botaoPesquisarNome
            // 
            this.botaoPesquisarNome.Location = new System.Drawing.Point(51, 12);
            this.botaoPesquisarNome.Name = "botaoPesquisarNome";
            this.botaoPesquisarNome.Size = new System.Drawing.Size(137, 44);
            this.botaoPesquisarNome.TabIndex = 4;
            this.botaoPesquisarNome.Text = "Pesquisar por Nome";
            this.botaoPesquisarNome.UseVisualStyleBackColor = true;
            this.botaoPesquisarNome.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoPesquisarCodigo
            // 
            this.botaoPesquisarCodigo.Location = new System.Drawing.Point(51, 73);
            this.botaoPesquisarCodigo.Name = "botaoPesquisarCodigo";
            this.botaoPesquisarCodigo.Size = new System.Drawing.Size(137, 43);
            this.botaoPesquisarCodigo.TabIndex = 5;
            this.botaoPesquisarCodigo.Text = "Pesquisar por Codigo";
            this.botaoPesquisarCodigo.UseVisualStyleBackColor = true;
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(195, 27);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(123, 20);
            this.txtNomePesquisa.TabIndex = 6;
            // 
            // txtCodigoPesquisa
            // 
            this.txtCodigoPesquisa.Location = new System.Drawing.Point(195, 85);
            this.txtCodigoPesquisa.Name = "txtCodigoPesquisa";
            this.txtCodigoPesquisa.Size = new System.Drawing.Size(123, 20);
            this.txtCodigoPesquisa.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(428, 172);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(128, 51);
            this.botaoExcluir.TabIndex = 8;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(428, 231);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(128, 51);
            this.botaoEditar.TabIndex = 9;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 662);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.txtCodigoPesquisa);
            this.Controls.Add(this.txtNomePesquisa);
            this.Controls.Add(this.botaoPesquisarCodigo);
            this.Controls.Add(this.botaoPesquisarNome);
            this.Controls.Add(this.checkSituacao);
            this.Controls.Add(this.checkCategoria);
            this.Controls.Add(this.botaoFiltrar);
            this.Controls.Add(this.dataColaboradores);
            this.Name = "Listagem";
            this.Text = "Listagem";
            this.Load += new System.EventHandler(this.Listagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataColaboradores;
        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.CheckedListBox checkCategoria;
        private System.Windows.Forms.CheckedListBox checkSituacao;
        private System.Windows.Forms.Button botaoPesquisarNome;
        private System.Windows.Forms.Button botaoPesquisarCodigo;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        public System.Windows.Forms.TextBox txtCodigoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoEditar;
    }
}