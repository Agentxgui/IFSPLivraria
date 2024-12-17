namespace IFSPLivraria.App.Cadastro
{
    partial class CadastroEmprestimo
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
            txtDataDevolucao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox1 = new GroupBox();
            btnAdcionar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridViewLivros = new DataGridView();
            cboLivro = new ReaLTaiizor.Controls.MaterialComboBox();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataEmprestimo = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            materialTabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl
            // 
            materialTabControl.Location = new Point(3, 113);
            materialTabControl.Margin = new Padding(3, 5, 3, 5);
            materialTabControl.Size = new Size(908, 651);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtDataEmprestimo);
            tabPageCadastro.Controls.Add(groupBox1);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtDataDevolucao);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(900, 616);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataDevolucao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(groupBox1, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataEmprestimo, 0);
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
            txtId.Location = new Point(814, 8);
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
            txtId.Size = new Size(61, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtDataDevolucao
            // 
            txtDataDevolucao.AllowPromptAsInput = true;
            txtDataDevolucao.AnimateReadOnly = false;
            txtDataDevolucao.AsciiOnly = false;
            txtDataDevolucao.BackgroundImageLayout = ImageLayout.None;
            txtDataDevolucao.BeepOnError = false;
            txtDataDevolucao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.Depth = 0;
            txtDataDevolucao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataDevolucao.HidePromptOnLeave = false;
            txtDataDevolucao.HideSelection = true;
            txtDataDevolucao.Hint = "Data De Devolucao";
            txtDataDevolucao.InsertKeyMode = InsertKeyMode.Default;
            txtDataDevolucao.LeadingIcon = null;
            txtDataDevolucao.Location = new Point(264, 32);
            txtDataDevolucao.Margin = new Padding(3, 4, 3, 4);
            txtDataDevolucao.Mask = "99/99/9999";
            txtDataDevolucao.MaxLength = 32767;
            txtDataDevolucao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataDevolucao.Name = "txtDataDevolucao";
            txtDataDevolucao.PasswordChar = '\0';
            txtDataDevolucao.PrefixSuffixText = null;
            txtDataDevolucao.PromptChar = '_';
            txtDataDevolucao.ReadOnly = false;
            txtDataDevolucao.RejectInputOnFirstFailure = false;
            txtDataDevolucao.ResetOnPrompt = true;
            txtDataDevolucao.ResetOnSpace = true;
            txtDataDevolucao.RightToLeft = RightToLeft.No;
            txtDataDevolucao.SelectedText = "";
            txtDataDevolucao.SelectionLength = 0;
            txtDataDevolucao.SelectionStart = 0;
            txtDataDevolucao.ShortcutsEnabled = true;
            txtDataDevolucao.Size = new Size(286, 48);
            txtDataDevolucao.SkipLiterals = true;
            txtDataDevolucao.TabIndex = 1;
            txtDataDevolucao.TabStop = false;
            txtDataDevolucao.Text = "  /  /";
            txtDataDevolucao.TextAlign = HorizontalAlignment.Left;
            txtDataDevolucao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataDevolucao.TrailingIcon = null;
            txtDataDevolucao.UseSystemPasswordChar = false;
            txtDataDevolucao.ValidatingType = null;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(7, 117);
            cboCliente.Margin = new Padding(3, 4, 3, 4);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(309, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdcionar);
            groupBox1.Controls.Add(dataGridViewLivros);
            groupBox1.Controls.Add(cboLivro);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Location = new Point(7, 208);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(883, 349);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Emprestimo";
            // 
            // btnAdcionar
            // 
            btnAdcionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdcionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdcionar.Depth = 0;
            btnAdcionar.HighEmphasis = true;
            btnAdcionar.Icon = null;
            btnAdcionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdcionar.Location = new Point(623, 41);
            btnAdcionar.Margin = new Padding(5, 8, 5, 8);
            btnAdcionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdcionar.Name = "btnAdcionar";
            btnAdcionar.NoAccentTextColor = Color.Empty;
            btnAdcionar.Size = new Size(94, 36);
            btnAdcionar.TabIndex = 2;
            btnAdcionar.Text = "Adcionar";
            btnAdcionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdcionar.UseAccentColor = false;
            btnAdcionar.UseVisualStyleBackColor = true;
            btnAdcionar.Click += btnAdcionar_Click;
            // 
            // dataGridViewLivros
            // 
            dataGridViewLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivros.Location = new Point(7, 101);
            dataGridViewLivros.Margin = new Padding(3, 4, 3, 4);
            dataGridViewLivros.Name = "dataGridViewLivros";
            dataGridViewLivros.RowHeadersWidth = 51;
            dataGridViewLivros.RowTemplate.Height = 25;
            dataGridViewLivros.Size = new Size(861, 240);
            dataGridViewLivros.TabIndex = 2;
            // 
            // cboLivro
            // 
            cboLivro.AutoResize = false;
            cboLivro.BackColor = Color.FromArgb(255, 255, 255);
            cboLivro.Depth = 0;
            cboLivro.DrawMode = DrawMode.OwnerDrawVariable;
            cboLivro.DropDownHeight = 174;
            cboLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLivro.DropDownWidth = 121;
            cboLivro.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLivro.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLivro.FormattingEnabled = true;
            cboLivro.Hint = "Livro";
            cboLivro.IntegralHeight = false;
            cboLivro.ItemHeight = 43;
            cboLivro.Location = new Point(37, 28);
            cboLivro.Margin = new Padding(3, 4, 3, 4);
            cboLivro.MaxDropDownItems = 4;
            cboLivro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboLivro.Name = "cboLivro";
            cboLivro.Size = new Size(289, 49);
            cboLivro.StartIndex = 0;
            cboLivro.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Quantidade";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(426, 28);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(157, 48);
            txtQuantidade.TabIndex = 1;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtDataEmprestimo
            // 
            txtDataEmprestimo.AllowPromptAsInput = true;
            txtDataEmprestimo.AnimateReadOnly = false;
            txtDataEmprestimo.AsciiOnly = false;
            txtDataEmprestimo.BackgroundImageLayout = ImageLayout.None;
            txtDataEmprestimo.BeepOnError = false;
            txtDataEmprestimo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.Depth = 0;
            txtDataEmprestimo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataEmprestimo.HidePromptOnLeave = false;
            txtDataEmprestimo.HideSelection = true;
            txtDataEmprestimo.Hint = "DataEmprestimo";
            txtDataEmprestimo.InsertKeyMode = InsertKeyMode.Default;
            txtDataEmprestimo.LeadingIcon = null;
            txtDataEmprestimo.Location = new Point(14, 32);
            txtDataEmprestimo.Margin = new Padding(3, 4, 3, 4);
            txtDataEmprestimo.Mask = "99/99/9999";
            txtDataEmprestimo.MaxLength = 32767;
            txtDataEmprestimo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataEmprestimo.Name = "txtDataEmprestimo";
            txtDataEmprestimo.PasswordChar = '\0';
            txtDataEmprestimo.PrefixSuffixText = null;
            txtDataEmprestimo.PromptChar = '_';
            txtDataEmprestimo.ReadOnly = false;
            txtDataEmprestimo.RejectInputOnFirstFailure = false;
            txtDataEmprestimo.ResetOnPrompt = true;
            txtDataEmprestimo.ResetOnSpace = true;
            txtDataEmprestimo.RightToLeft = RightToLeft.No;
            txtDataEmprestimo.SelectedText = "";
            txtDataEmprestimo.SelectionLength = 0;
            txtDataEmprestimo.SelectionStart = 0;
            txtDataEmprestimo.ShortcutsEnabled = true;
            txtDataEmprestimo.Size = new Size(181, 48);
            txtDataEmprestimo.SkipLiterals = true;
            txtDataEmprestimo.TabIndex = 0;
            txtDataEmprestimo.TabStop = false;
            txtDataEmprestimo.Text = "  /  /";
            txtDataEmprestimo.TextAlign = HorizontalAlignment.Left;
            txtDataEmprestimo.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataEmprestimo.TrailingIcon = null;
            txtDataEmprestimo.UseSystemPasswordChar = false;
            txtDataEmprestimo.ValidatingType = null;
            // 
            // CadastroEmprestimo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 769);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastroEmprestimo";
            Padding = new Padding(3, 113, 3, 5);
            Text = "CadastroEmprestimo";
            materialTabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataDevolucao;
        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialComboBox cboLivro;
        private DataGridView dataGridViewLivros;
        private ReaLTaiizor.Controls.MaterialButton btnAdcionar;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataEmprestimo;
    }
}