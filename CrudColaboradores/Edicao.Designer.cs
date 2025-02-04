﻿namespace CrudColaboradores
{
    partial class Edicao
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
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.groupEstado = new System.Windows.Forms.GroupBox();
            this.radioInativo = new System.Windows.Forms.RadioButton();
            this.radioAtivo = new System.Windows.Forms.RadioButton();
            this.groupCategoria = new System.Windows.Forms.GroupBox();
            this.radioGerente = new System.Windows.Forms.RadioButton();
            this.radioSuporte = new System.Windows.Forms.RadioButton();
            this.radioTester = new System.Windows.Forms.RadioButton();
            this.radioDesenvolvedor = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.groupEstado.SuspendLayout();
            this.groupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(113, 437);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(109, 25);
            this.botaoCancelar.TabIndex = 14;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // groupEstado
            // 
            this.groupEstado.Controls.Add(this.radioInativo);
            this.groupEstado.Controls.Add(this.radioAtivo);
            this.groupEstado.Location = new System.Drawing.Point(67, 200);
            this.groupEstado.Name = "groupEstado";
            this.groupEstado.Size = new System.Drawing.Size(200, 70);
            this.groupEstado.TabIndex = 13;
            this.groupEstado.TabStop = false;
            this.groupEstado.Text = "Estado";
            // 
            // radioInativo
            // 
            this.radioInativo.AutoSize = true;
            this.radioInativo.Location = new System.Drawing.Point(36, 42);
            this.radioInativo.Name = "radioInativo";
            this.radioInativo.Size = new System.Drawing.Size(57, 17);
            this.radioInativo.TabIndex = 1;
            this.radioInativo.TabStop = true;
            this.radioInativo.Text = "Inativo";
            this.radioInativo.UseVisualStyleBackColor = true;
            // 
            // radioAtivo
            // 
            this.radioAtivo.AutoSize = true;
            this.radioAtivo.Location = new System.Drawing.Point(36, 19);
            this.radioAtivo.Name = "radioAtivo";
            this.radioAtivo.Size = new System.Drawing.Size(49, 17);
            this.radioAtivo.TabIndex = 0;
            this.radioAtivo.TabStop = true;
            this.radioAtivo.Text = "Ativo";
            this.radioAtivo.UseVisualStyleBackColor = true;
            // 
            // groupCategoria
            // 
            this.groupCategoria.Controls.Add(this.radioGerente);
            this.groupCategoria.Controls.Add(this.radioSuporte);
            this.groupCategoria.Controls.Add(this.radioTester);
            this.groupCategoria.Controls.Add(this.radioDesenvolvedor);
            this.groupCategoria.Location = new System.Drawing.Point(67, 77);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Size = new System.Drawing.Size(200, 117);
            this.groupCategoria.TabIndex = 12;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "Categoria";
            // 
            // radioGerente
            // 
            this.radioGerente.AutoSize = true;
            this.radioGerente.Location = new System.Drawing.Point(37, 89);
            this.radioGerente.Name = "radioGerente";
            this.radioGerente.Size = new System.Drawing.Size(63, 17);
            this.radioGerente.TabIndex = 3;
            this.radioGerente.TabStop = true;
            this.radioGerente.Text = "Gerente";
            this.radioGerente.UseVisualStyleBackColor = true;
            // 
            // radioSuporte
            // 
            this.radioSuporte.AutoSize = true;
            this.radioSuporte.Location = new System.Drawing.Point(37, 66);
            this.radioSuporte.Name = "radioSuporte";
            this.radioSuporte.Size = new System.Drawing.Size(62, 17);
            this.radioSuporte.TabIndex = 2;
            this.radioSuporte.TabStop = true;
            this.radioSuporte.Text = "Suporte";
            this.radioSuporte.UseVisualStyleBackColor = true;
            // 
            // radioTester
            // 
            this.radioTester.AutoSize = true;
            this.radioTester.Location = new System.Drawing.Point(37, 43);
            this.radioTester.Name = "radioTester";
            this.radioTester.Size = new System.Drawing.Size(55, 17);
            this.radioTester.TabIndex = 1;
            this.radioTester.TabStop = true;
            this.radioTester.Text = "Tester";
            this.radioTester.UseVisualStyleBackColor = true;
            // 
            // radioDesenvolvedor
            // 
            this.radioDesenvolvedor.AutoSize = true;
            this.radioDesenvolvedor.Location = new System.Drawing.Point(37, 20);
            this.radioDesenvolvedor.Name = "radioDesenvolvedor";
            this.radioDesenvolvedor.Size = new System.Drawing.Size(97, 17);
            this.radioDesenvolvedor.TabIndex = 0;
            this.radioDesenvolvedor.TabStop = true;
            this.radioDesenvolvedor.Text = "Desenvolvedor";
            this.radioDesenvolvedor.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(67, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(173, 20);
            this.txtNome.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome do colaborador :";
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(113, 338);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(109, 54);
            this.botaoSalvar.TabIndex = 9;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // Edicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 492);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.groupEstado);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoSalvar);
            this.Name = "Edicao";
            this.Text = "Edicao";
            this.groupEstado.ResumeLayout(false);
            this.groupEstado.PerformLayout();
            this.groupCategoria.ResumeLayout(false);
            this.groupCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.GroupBox groupEstado;
        private System.Windows.Forms.RadioButton radioInativo;
        private System.Windows.Forms.RadioButton radioAtivo;
        private System.Windows.Forms.GroupBox groupCategoria;
        private System.Windows.Forms.RadioButton radioGerente;
        private System.Windows.Forms.RadioButton radioSuporte;
        private System.Windows.Forms.RadioButton radioTester;
        private System.Windows.Forms.RadioButton radioDesenvolvedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoSalvar;
    }
}