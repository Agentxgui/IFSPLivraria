namespace IFSPLivraria.App.Cadastro
{
    partial class CadastroLivro
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAutor = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtTitulo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAnoProdrucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboEditora = new ReaLTaiizor.Controls.MaterialComboBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Location = new Point(3, 113);
            materialTabControl.Margin = new Padding(3, 5, 3, 5);
            materialTabControl.Size = new Size(908, 482);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboEditora);
            tabPageCadastro.Controls.Add(txtAnoProdrucao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(txtAutor);
            tabPageCadastro.Controls.Add(txtTitulo);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(900, 447);
            tabPageCadastro.Controls.SetChildIndex(txtTitulo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAutor, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAnoProdrucao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboEditora, 0);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(865, 430);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(769, 31);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(102, 48);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtAutor
            // 
            txtAutor.AnimateReadOnly = false;
            txtAutor.AutoCompleteMode = AutoCompleteMode.None;
            txtAutor.AutoCompleteSource = AutoCompleteSource.None;
            txtAutor.BackgroundImageLayout = ImageLayout.None;
            txtAutor.CharacterCasing = CharacterCasing.Normal;
            txtAutor.Depth = 0;
            txtAutor.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAutor.HideSelection = true;
            txtAutor.Hint = "Autor";
            txtAutor.LeadingIcon = null;
            txtAutor.Location = new Point(26, 103);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.MaxLength = 32767;
            txtAutor.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAutor.Name = "txtAutor";
            txtAutor.PasswordChar = '\0';
            txtAutor.PrefixSuffixText = null;
            txtAutor.ReadOnly = false;
            txtAutor.RightToLeft = RightToLeft.No;
            txtAutor.SelectedText = "";
            txtAutor.SelectionLength = 0;
            txtAutor.SelectionStart = 0;
            txtAutor.ShortcutsEnabled = true;
            txtAutor.Size = new Size(715, 48);
            txtAutor.TabIndex = 2;
            txtAutor.TabStop = false;
            txtAutor.TextAlign = HorizontalAlignment.Left;
            txtAutor.TrailingIcon = null;
            txtAutor.UseSystemPasswordChar = false;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.AutoCompleteMode = AutoCompleteMode.None;
            txtTitulo.AutoCompleteSource = AutoCompleteSource.None;
            txtTitulo.BackgroundImageLayout = ImageLayout.None;
            txtTitulo.CharacterCasing = CharacterCasing.Normal;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.HideSelection = true;
            txtTitulo.Hint = "Titulo";
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(26, 31);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.MaxLength = 32767;
            txtTitulo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.PasswordChar = '\0';
            txtTitulo.PrefixSuffixText = null;
            txtTitulo.ReadOnly = false;
            txtTitulo.RightToLeft = RightToLeft.No;
            txtTitulo.SelectedText = "";
            txtTitulo.SelectionLength = 0;
            txtTitulo.SelectionStart = 0;
            txtTitulo.ShortcutsEnabled = true;
            txtTitulo.Size = new Size(715, 48);
            txtTitulo.TabIndex = 0;
            txtTitulo.TabStop = false;
            txtTitulo.TextAlign = HorizontalAlignment.Left;
            txtTitulo.TrailingIcon = null;
            txtTitulo.UseSystemPasswordChar = false;
            // 
            // txtAnoProdrucao
            // 
            txtAnoProdrucao.AllowPromptAsInput = true;
            txtAnoProdrucao.AnimateReadOnly = false;
            txtAnoProdrucao.AsciiOnly = false;
            txtAnoProdrucao.BackgroundImageLayout = ImageLayout.None;
            txtAnoProdrucao.BeepOnError = false;
            txtAnoProdrucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoProdrucao.Depth = 0;
            txtAnoProdrucao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAnoProdrucao.HidePromptOnLeave = false;
            txtAnoProdrucao.HideSelection = true;
            txtAnoProdrucao.Hint = "Ano de Produção:";
            txtAnoProdrucao.InsertKeyMode = InsertKeyMode.Default;
            txtAnoProdrucao.LeadingIcon = null;
            txtAnoProdrucao.Location = new Point(26, 188);
            txtAnoProdrucao.Margin = new Padding(3, 4, 3, 4);
            txtAnoProdrucao.Mask = "9999";
            txtAnoProdrucao.MaxLength = 32767;
            txtAnoProdrucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAnoProdrucao.Name = "txtAnoProdrucao";
            txtAnoProdrucao.PasswordChar = '\0';
            txtAnoProdrucao.PrefixSuffixText = null;
            txtAnoProdrucao.PromptChar = '_';
            txtAnoProdrucao.ReadOnly = false;
            txtAnoProdrucao.RejectInputOnFirstFailure = false;
            txtAnoProdrucao.ResetOnPrompt = true;
            txtAnoProdrucao.ResetOnSpace = true;
            txtAnoProdrucao.RightToLeft = RightToLeft.No;
            txtAnoProdrucao.SelectedText = "";
            txtAnoProdrucao.SelectionLength = 0;
            txtAnoProdrucao.SelectionStart = 0;
            txtAnoProdrucao.ShortcutsEnabled = true;
            txtAnoProdrucao.Size = new Size(208, 48);
            txtAnoProdrucao.SkipLiterals = true;
            txtAnoProdrucao.TabIndex = 3;
            txtAnoProdrucao.TabStop = false;
            txtAnoProdrucao.TextAlign = HorizontalAlignment.Left;
            txtAnoProdrucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAnoProdrucao.TrailingIcon = null;
            txtAnoProdrucao.UseSystemPasswordChar = false;
            txtAnoProdrucao.ValidatingType = null;
            // 
            // cboEditora
            // 
            cboEditora.AutoResize = false;
            cboEditora.BackColor = Color.FromArgb(255, 255, 255);
            cboEditora.Depth = 0;
            cboEditora.DrawMode = DrawMode.OwnerDrawVariable;
            cboEditora.DropDownHeight = 174;
            cboEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditora.DropDownWidth = 121;
            cboEditora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEditora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEditora.FormattingEnabled = true;
            cboEditora.Hint = "Editora";
            cboEditora.IntegralHeight = false;
            cboEditora.ItemHeight = 43;
            cboEditora.Location = new Point(26, 277);
            cboEditora.Margin = new Padding(3, 4, 3, 4);
            cboEditora.MaxDropDownItems = 4;
            cboEditora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEditora.Name = "cboEditora";
            cboEditora.Size = new Size(346, 49);
            cboEditora.StartIndex = 0;
            cboEditora.TabIndex = 4;
            // 
            // CadastroLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastroLivro";
            Padding = new Padding(3, 113, 3, 5);
            Text = "CadastroLivro";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtAutor;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtTitulo;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAnoProdrucao;
        private ReaLTaiizor.Controls.MaterialComboBox cboEditora;
    }
}