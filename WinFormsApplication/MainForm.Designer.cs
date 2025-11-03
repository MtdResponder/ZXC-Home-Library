namespace WinFormsApplication
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainPanel = new Panel();
            contentPanel = new Panel();
            dataGridViewBooks = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colAuthor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colGenre = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            controlPanel = new Panel();
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            filterPanel = new Panel();
            cmbFilterStatus = new ComboBox();
            label3 = new Label();
            cmbFilterGenre = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            headerPanel = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            toolTip = new ToolTip(components);
            mainPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            controlPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(18, 18, 18);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(32, 24, 32, 24);
            mainPanel.Size = new Size(1200, 800);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(30, 30, 30);
            contentPanel.Controls.Add(dataGridViewBooks);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(32, 200);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(2);
            contentPanel.Size = new Size(1136, 432);
            contentPanel.TabIndex = 3;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks.BackgroundColor = Color.FromArgb(23, 23, 23);
            dataGridViewBooks.BorderStyle = BorderStyle.None;
            dataGridViewBooks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBooks.ColumnHeadersHeight = 52;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colAuthor, colYear, colGenre, colStatus });
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.GridColor = Color.FromArgb(23, 23, 23);
            dataGridViewBooks.Location = new Point(2, 2);
            dataGridViewBooks.Margin = new Padding(0);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersVisible = false;
            dataGridViewBooks.RowHeadersWidth = 40;
            dataGridViewBooks.RowTemplate.Height = 44;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(1132, 428);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick;
            dataGridViewBooks.SelectionChanged += dataGridViewBooks_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colTitle
            // 
            colTitle.DataPropertyName = "title";
            colTitle.FillWeight = 30F;
            colTitle.HeaderText = "Название";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colAuthor
            // 
            colAuthor.DataPropertyName = "author";
            colAuthor.FillWeight = 25F;
            colAuthor.HeaderText = "Автор";
            colAuthor.Name = "colAuthor";
            colAuthor.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.DataPropertyName = "year";
            colYear.FillWeight = 15F;
            colYear.HeaderText = "Год";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colGenre
            // 
            colGenre.DataPropertyName = "genre";
            colGenre.FillWeight = 20F;
            colGenre.HeaderText = "Жанр";
            colGenre.Name = "colGenre";
            colGenre.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "status";
            colStatus.FillWeight = 10F;
            colStatus.HeaderText = "Статус";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.Transparent;
            controlPanel.Controls.Add(btnDeleteBook);
            controlPanel.Controls.Add(btnEditBook);
            controlPanel.Controls.Add(btnAddBook);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(32, 632);
            controlPanel.Margin = new Padding(0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1136, 144);
            controlPanel.TabIndex = 2;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteBook.BackColor = Color.IndianRed;
            btnDeleteBook.Enabled = false;
            btnDeleteBook.FlatAppearance.BorderSize = 0;
            btnDeleteBook.FlatStyle = FlatStyle.Flat;
            btnDeleteBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(896, 44);
            btnDeleteBook.Margin = new Padding(0);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(240, 56);
            btnDeleteBook.TabIndex = 2;
            btnDeleteBook.Text = "Удалить";
            btnDeleteBook.UseVisualStyleBackColor = false;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditBook.BackColor = Color.FromArgb(23, 23, 23);
            btnEditBook.Enabled = false;
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditBook.ForeColor = Color.White;
            btnEditBook.Location = new Point(636, 44);
            btnEditBook.Margin = new Padding(0);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(240, 56);
            btnEditBook.TabIndex = 1;
            btnEditBook.Text = "Изменить";
            btnEditBook.UseVisualStyleBackColor = false;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBook.BackColor = Color.FromArgb(23, 23, 23);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(376, 44);
            btnAddBook.Margin = new Padding(0);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(240, 56);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Добавить книгу";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.FromArgb(23, 23, 23);
            filterPanel.Controls.Add(cmbFilterStatus);
            filterPanel.Controls.Add(label3);
            filterPanel.Controls.Add(cmbFilterGenre);
            filterPanel.Controls.Add(label2);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(label1);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(32, 112);
            filterPanel.Margin = new Padding(0);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1136, 88);
            filterPanel.TabIndex = 1;
            filterPanel.Paint += filterPanel_Paint;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterStatus.BackColor = Color.FromArgb(23, 23, 23);
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.FlatStyle = FlatStyle.Flat;
            cmbFilterStatus.Font = new Font("Segoe UI", 11F);
            cmbFilterStatus.ForeColor = Color.FromArgb(200, 200, 200);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(850, 28);
            cmbFilterStatus.Margin = new Padding(0);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(240, 28);
            cmbFilterStatus.TabIndex = 5;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoEllipsis = true;
            label3.BackColor = Color.FromArgb(23, 23, 23);
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(180, 180, 180);
            label3.Location = new Point(769, 32);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 4;
            label3.Text = "Статус:";
            // 
            // cmbFilterGenre
            // 
            cmbFilterGenre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterGenre.BackColor = Color.FromArgb(23, 23, 23);
            cmbFilterGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterGenre.FlatStyle = FlatStyle.Flat;
            cmbFilterGenre.Font = new Font("Segoe UI", 11F);
            cmbFilterGenre.ForeColor = Color.FromArgb(200, 200, 200);
            cmbFilterGenre.FormattingEnabled = true;
            cmbFilterGenre.Location = new Point(494, 28);
            cmbFilterGenre.Margin = new Padding(0);
            cmbFilterGenre.Name = "cmbFilterGenre";
            cmbFilterGenre.Size = new Size(240, 28);
            cmbFilterGenre.TabIndex = 3;
            cmbFilterGenre.SelectedIndexChanged += cmbFilterGenre_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(23, 23, 23);
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(180, 180, 180);
            label2.Location = new Point(440, 31);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Жанр:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(23, 23, 23);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(200, 200, 200);
            txtSearch.Location = new Point(96, 30);
            txtSearch.Margin = new Padding(0);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по названию или автору...";
            txtSearch.Size = new Size(360, 22);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(180, 180, 180);
            label1.Location = new Point(0, 31);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Поиск:";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(32, 24);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1136, 88);
            headerPanel.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 13F);
            lblSubtitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblSubtitle.Location = new Point(0, 56);
            lblSubtitle.Margin = new Padding(0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(345, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Управление вашей книжной коллекцией";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(240, 240, 240);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(451, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Домашняя библиотека";
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1200, 800);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(200, 200, 200);
            MinimumSize = new Size(800, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Домашняя библиотека";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            mainPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            controlPanel.ResumeLayout(false);
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel headerPanel;
        private Label lblTitle;
        private Panel filterPanel;
        private TextBox txtSearch;
        private Label label1;
        private Panel controlPanel;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private Panel contentPanel;
        private DataGridView dataGridViewBooks;
        private ComboBox cmbFilterStatus;
        private Label label3;
        private ComboBox cmbFilterGenre;
        private Label label2;
        private Label lblSubtitle;
        private ToolTip toolTip;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colAuthor;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colGenre;
        private DataGridViewTextBoxColumn colStatus;
    }
}