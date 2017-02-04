namespace Compromissos.telas
{
    partial class Inserir
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
            this.LblTituloForm = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.LblAssunto = new System.Windows.Forms.Label();
            this.LblDataHora = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.DtPickerDataHora = new System.Windows.Forms.DateTimePicker();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTituloForm
            // 
            this.LblTituloForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTituloForm.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloForm.Location = new System.Drawing.Point(12, 9);
            this.LblTituloForm.Name = "LblTituloForm";
            this.LblTituloForm.Size = new System.Drawing.Size(443, 25);
            this.LblTituloForm.TabIndex = 0;
            this.LblTituloForm.Text = "Inserir Compromisso";
            this.LblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(26, 53);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(44, 18);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Título";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricao.Location = new System.Drawing.Point(26, 93);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(80, 18);
            this.LblDescricao.TabIndex = 2;
            this.LblDescricao.Text = "Descrição";
            // 
            // LblAssunto
            // 
            this.LblAssunto.AutoSize = true;
            this.LblAssunto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAssunto.Location = new System.Drawing.Point(26, 135);
            this.LblAssunto.Name = "LblAssunto";
            this.LblAssunto.Size = new System.Drawing.Size(64, 18);
            this.LblAssunto.TabIndex = 3;
            this.LblAssunto.Text = "Assunto";
            // 
            // LblDataHora
            // 
            this.LblDataHora.AutoSize = true;
            this.LblDataHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataHora.Location = new System.Drawing.Point(26, 177);
            this.LblDataHora.Name = "LblDataHora";
            this.LblDataHora.Size = new System.Drawing.Size(88, 18);
            this.LblDataHora.TabIndex = 4;
            this.LblDataHora.Text = "Data / Hora";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitulo.Location = new System.Drawing.Point(143, 50);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(312, 26);
            this.TxtTitulo.TabIndex = 5;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.Location = new System.Drawing.Point(143, 90);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(312, 26);
            this.TxtDescricao.TabIndex = 6;
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAssunto.Location = new System.Drawing.Point(143, 132);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(312, 26);
            this.TxtAssunto.TabIndex = 7;
            // 
            // DtPickerDataHora
            // 
            this.DtPickerDataHora.CustomFormat = "dd/MM/yyyy hh:mm";
            this.DtPickerDataHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPickerDataHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtPickerDataHora.Location = new System.Drawing.Point(143, 171);
            this.DtPickerDataHora.Name = "DtPickerDataHora";
            this.DtPickerDataHora.Size = new System.Drawing.Size(312, 26);
            this.DtPickerDataHora.TabIndex = 8;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(143, 233);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 30);
            this.BtnSalvar.TabIndex = 9;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(249, 233);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.DtPickerDataHora);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.LblDataHora);
            this.Controls.Add(this.LblAssunto);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblTituloForm);
            this.MaximizeBox = false;
            this.Name = "Inserir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloForm;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblAssunto;
        private System.Windows.Forms.Label LblDataHora;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.DateTimePicker DtPickerDataHora;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}