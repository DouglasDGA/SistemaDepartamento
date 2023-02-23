
namespace SistemaDepartamento
{
    partial class Form1
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
            this.tbPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.btnLimpeza = new System.Windows.Forms.Button();
            this.btnLeitura = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lboPessoas = new System.Windows.Forms.ListBox();
            this.tpErros = new System.Windows.Forms.TabPage();
            this.tlpErro = new System.Windows.Forms.TableLayoutPanel();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnErro = new System.Windows.Forms.Button();
            this.tbPrincipal.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            this.tpErros.SuspendLayout();
            this.tlpErro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.tpPrincipal);
            this.tbPrincipal.Controls.Add(this.tpErros);
            this.tbPrincipal.Depth = 0;
            this.tbPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbPrincipal.Multiline = true;
            this.tbPrincipal.Name = "tbPrincipal";
            this.tbPrincipal.SelectedIndex = 0;
            this.tbPrincipal.Size = new System.Drawing.Size(611, 405);
            this.tbPrincipal.TabIndex = 2;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.AutoScroll = true;
            this.tpPrincipal.BackColor = System.Drawing.Color.Olive;
            this.tpPrincipal.Controls.Add(this.btnLimpeza);
            this.tpPrincipal.Controls.Add(this.btnLeitura);
            this.tpPrincipal.Controls.Add(this.btnEditar);
            this.tpPrincipal.Controls.Add(this.btnRemover);
            this.tpPrincipal.Controls.Add(this.btnAdd);
            this.tpPrincipal.Controls.Add(this.lblEmail);
            this.tpPrincipal.Controls.Add(this.lblTelefone);
            this.tpPrincipal.Controls.Add(this.lblDtNasc);
            this.tpPrincipal.Controls.Add(this.lblEndereco);
            this.tpPrincipal.Controls.Add(this.lblNome);
            this.tpPrincipal.Controls.Add(this.dtpNascimento);
            this.tpPrincipal.Controls.Add(this.txtEmail);
            this.tpPrincipal.Controls.Add(this.txtTelefone);
            this.tpPrincipal.Controls.Add(this.txtEndereco);
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.lboPessoas);
            this.tpPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(603, 379);
            this.tpPrincipal.TabIndex = 0;
            this.tpPrincipal.Text = "Principal";
            // 
            // btnLimpeza
            // 
            this.btnLimpeza.BackColor = System.Drawing.Color.White;
            this.btnLimpeza.FlatAppearance.BorderSize = 0;
            this.btnLimpeza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpeza.ForeColor = System.Drawing.Color.Black;
            this.btnLimpeza.Location = new System.Drawing.Point(253, 312);
            this.btnLimpeza.Name = "btnLimpeza";
            this.btnLimpeza.Size = new System.Drawing.Size(339, 44);
            this.btnLimpeza.TabIndex = 34;
            this.btnLimpeza.TabStop = false;
            this.btnLimpeza.Text = "Limpar Lista";
            this.btnLimpeza.UseVisualStyleBackColor = false;
            // 
            // btnLeitura
            // 
            this.btnLeitura.BackColor = System.Drawing.Color.White;
            this.btnLeitura.FlatAppearance.BorderSize = 0;
            this.btnLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitura.ForeColor = System.Drawing.Color.Black;
            this.btnLeitura.Location = new System.Drawing.Point(8, 312);
            this.btnLeitura.Name = "btnLeitura";
            this.btnLeitura.Size = new System.Drawing.Size(239, 44);
            this.btnLeitura.TabIndex = 34;
            this.btnLeitura.TabStop = false;
            this.btnLeitura.Text = "Inserir Dados";
            this.btnLeitura.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(483, 261);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 38);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.Black;
            this.btnRemover.Location = new System.Drawing.Point(368, 261);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(109, 38);
            this.btnRemover.TabIndex = 33;
            this.btnRemover.TabStop = false;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(253, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 38);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblEmail.Location = new System.Drawing.Point(253, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 32;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Blue;
            this.lblTelefone.Location = new System.Drawing.Point(253, 161);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(85, 24);
            this.lblTelefone.TabIndex = 32;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.ForeColor = System.Drawing.Color.Blue;
            this.lblDtNasc.Location = new System.Drawing.Point(253, 113);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(179, 24);
            this.lblDtNasc.TabIndex = 32;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.ForeColor = System.Drawing.Color.Blue;
            this.lblEndereco.Location = new System.Drawing.Point(253, 64);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(94, 24);
            this.lblEndereco.TabIndex = 32;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(253, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 32;
            this.lblNome.Text = "Nome";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dtpNascimento.Location = new System.Drawing.Point(253, 139);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(337, 20);
            this.dtpNascimento.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(253, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Tag = "3";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.White;
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.Location = new System.Drawing.Point(253, 187);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(337, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.Tag = "2";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.White;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.ForeColor = System.Drawing.Color.White;
            this.txtEndereco.Location = new System.Drawing.Point(253, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(337, 20);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Tag = "1";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(253, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "0";
            // 
            // lboPessoas
            // 
            this.lboPessoas.BackColor = System.Drawing.Color.White;
            this.lboPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboPessoas.ForeColor = System.Drawing.Color.Black;
            this.lboPessoas.FormattingEnabled = true;
            this.lboPessoas.ItemHeight = 20;
            this.lboPessoas.Location = new System.Drawing.Point(8, 18);
            this.lboPessoas.Name = "lboPessoas";
            this.lboPessoas.Size = new System.Drawing.Size(239, 280);
            this.lboPessoas.TabIndex = 26;
            this.lboPessoas.TabStop = false;
            // 
            // tpErros
            // 
            this.tpErros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tpErros.Controls.Add(this.tlpErro);
            this.tpErros.Location = new System.Drawing.Point(4, 22);
            this.tpErros.Name = "tpErros";
            this.tpErros.Padding = new System.Windows.Forms.Padding(3);
            this.tpErros.Size = new System.Drawing.Size(634, 434);
            this.tpErros.TabIndex = 1;
            this.tpErros.Text = "Erros";
            // 
            // tlpErro
            // 
            this.tlpErro.BackColor = System.Drawing.Color.Red;
            this.tlpErro.ColumnCount = 1;
            this.tlpErro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpErro.Controls.Add(this.lblErro, 0, 0);
            this.tlpErro.Controls.Add(this.btnErro, 0, 1);
            this.tlpErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpErro.Location = new System.Drawing.Point(3, 3);
            this.tlpErro.Name = "tlpErro";
            this.tlpErro.RowCount = 2;
            this.tlpErro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpErro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpErro.Size = new System.Drawing.Size(628, 428);
            this.tlpErro.TabIndex = 1;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(3, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 55);
            this.lblErro.TabIndex = 0;
            // 
            // btnErro
            // 
            this.btnErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnErro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnErro.FlatAppearance.BorderSize = 0;
            this.btnErro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.btnErro.ForeColor = System.Drawing.Color.Black;
            this.btnErro.Location = new System.Drawing.Point(3, 217);
            this.btnErro.Name = "btnErro";
            this.btnErro.Size = new System.Drawing.Size(622, 208);
            this.btnErro.TabIndex = 1;
            this.btnErro.Text = "OK";
            this.btnErro.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 405);
            this.Controls.Add(this.tbPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbPrincipal.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            this.tpErros.ResumeLayout(false);
            this.tlpErro.ResumeLayout(false);
            this.tlpErro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbPrincipal;
        private System.Windows.Forms.TabPage tpPrincipal;
        private System.Windows.Forms.Button btnLimpeza;
        private System.Windows.Forms.Button btnLeitura;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lboPessoas;
        private System.Windows.Forms.TabPage tpErros;
        private System.Windows.Forms.TableLayoutPanel tlpErro;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnErro;
    }
}

