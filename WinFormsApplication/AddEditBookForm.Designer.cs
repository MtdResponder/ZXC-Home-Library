namespace WinFormsApplication
{
    partial class AddEditBookForm
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
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblGenre = new Label();
            txtGenre = new TextBox();
            lblYear = new Label();
            numYear = new NumericUpDown();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            controlPanel = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            headerPanel = new Panel();
            lblFormTitle = new Label();
            toolTip = new ToolTip(components);
            mainPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            controlPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(18, 18, 18);
            mainPanel.Controls.Add(contentPanel);
            mainPanel.Controls.Add(controlPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(32, 24, 32, 24);
            mainPanel.Size = new Size(500, 450);
            mainPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(30, 30, 30);
            contentPanel.Controls.Add(lblStatus);
            contentPanel.Controls.Add(cmbStatus);
            contentPanel.Controls.Add(lblGenre);
            contentPanel.Controls.Add(txtGenre);
            contentPanel.Controls.Add(lblYear);
            contentPanel.Controls.Add(numYear);
            contentPanel.Controls.Add(lblAuthor);
            contentPanel.Controls.Add(txtAuthor);
            contentPanel.Controls.Add(lblTitle);
            contentPanel.Controls.Add(txtTitle);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(32, 80);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(436, 266);
            contentPanel.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(180, 180, 180);
            lblStatus.Location = new Point(23, 200);
            lblStatus.Margin = new Padding(3, 0, 3, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbStatus.BackColor = Color.FromArgb(23, 23, 23);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 11F);
            cmbStatus.ForeColor = Color.FromArgb(200, 200, 200);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(120, 197);
            cmbStatus.Margin = new Padding(3, 3, 3, 15);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(293, 28);
            cmbStatus.TabIndex = 9;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGenre.ForeColor = Color.FromArgb(180, 180, 180);
            lblGenre.Location = new Point(23, 150);
            lblGenre.Margin = new Padding(3, 0, 3, 8);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(54, 20);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Жанр:";
            // 
            // txtGenre
            // 
            txtGenre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGenre.BackColor = Color.FromArgb(23, 23, 23);
            txtGenre.BorderStyle = BorderStyle.None;
            txtGenre.Font = new Font("Segoe UI", 11F);
            txtGenre.ForeColor = Color.FromArgb(200, 200, 200);
            txtGenre.Location = new Point(120, 153);
            txtGenre.Margin = new Padding(3, 3, 3, 15);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(293, 20);
            txtGenre.TabIndex = 7;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblYear.ForeColor = Color.FromArgb(180, 180, 180);
            lblYear.Location = new Point(23, 100);
            lblYear.Margin = new Padding(3, 0, 3, 8);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(42, 20);
            lblYear.TabIndex = 4;
            lblYear.Text = "Год:";
            // 
            // numYear
            // 
            numYear.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            numYear.BackColor = Color.FromArgb(23, 23, 23);
            numYear.BorderStyle = BorderStyle.None;
            numYear.Font = new Font("Segoe UI", 11F);
            numYear.ForeColor = Color.FromArgb(200, 200, 200);
            numYear.Location = new Point(120, 103);
            numYear.Margin = new Padding(3, 3, 3, 15);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(150, 23);
            numYear.TabIndex = 5;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.FromArgb(180, 180, 180);
            lblAuthor.Location = new Point(23, 50);
            lblAuthor.Margin = new Padding(3, 0, 3, 8);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Автор:";
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAuthor.BackColor = Color.FromArgb(23, 23, 23);
            txtAuthor.BorderStyle = BorderStyle.None;
            txtAuthor.Font = new Font("Segoe UI", 11F);
            txtAuthor.ForeColor = Color.FromArgb(200, 200, 200);
            txtAuthor.Location = new Point(120, 53);
            txtAuthor.Margin = new Padding(3, 3, 3, 15);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(293, 20);
            txtAuthor.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(180, 180, 180);
            lblTitle.Location = new Point(23, 0);
            lblTitle.Margin = new Padding(3, 0, 3, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Название:";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.BackColor = Color.FromArgb(23, 23, 23);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 11F);
            txtTitle.ForeColor = Color.FromArgb(200, 200, 200);
            txtTitle.Location = new Point(120, 3);
            txtTitle.Margin = new Padding(3, 3, 3, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(293, 20);
            txtTitle.TabIndex = 1;
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.Transparent;
            controlPanel.Controls.Add(btnCancel);
            controlPanel.Controls.Add(btnSave);
            controlPanel.Dock = DockStyle.Bottom;
            controlPanel.Location = new Point(32, 346);
            controlPanel.Margin = new Padding(0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(436, 80);
            controlPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(80, 80, 80);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(240, 20);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(23, 23, 23);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(40, 20);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(lblFormTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(32, 24);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(436, 56);
            headerPanel.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(240, 240, 240);
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Margin = new Padding(0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(237, 37);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Добавление книги";
            // 
            // AddEditBookForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(18, 18, 18);
            CancelButton = btnCancel;
            ClientSize = new Size(500, 450);
            Controls.Add(mainPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(200, 200, 200);
            MinimumSize = new Size(516, 489);
            Name = "AddEditBookForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Добавление книги";
            mainPanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            controlPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel contentPanel;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblGenre;
        private TextBox txtGenre;
        private Label lblYear;
        private NumericUpDown numYear;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblTitle;
        private TextBox txtTitle;
        private Panel controlPanel;
        private Button btnCancel;
        private Button btnSave;
        private Panel headerPanel;
        private Label lblFormTitle;
        private ToolTip toolTip;
    }
}