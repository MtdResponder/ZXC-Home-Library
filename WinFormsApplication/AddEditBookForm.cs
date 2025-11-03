using Microsoft.Data.Sqlite;
using System.Drawing.Drawing2D;

namespace WinFormsApplication;

public partial class AddEditBookForm : Form
{
    private readonly int? _bookId;
    private static readonly string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "library.db");
    private static readonly string connectionString = $"Data Source={databasePath}";

    public AddEditBookForm(int? bookId = null)
    {
        _bookId = bookId;
        InitializeComponent();
        SetupAutoScaling();
        SetupDarkTheme();
        ApplyRoundedCorners();
        LoadStatusOptions();

        if (_bookId.HasValue)
        {
            Text = "Редактирование книги";
            lblFormTitle.Text = "Редактирование книги";
            LoadBookData();
        }
        else
        {
            Text = "Добавление новой книги";
            lblFormTitle.Text = "Добавление книги";
        }
    }

    private void SetupAutoScaling()
    {
        this.AutoScaleMode = AutoScaleMode.Dpi;
        this.AutoSize = false;
        this.MinimumSize = new Size(500, 450);
        this.SizeChanged += AddEditBookForm_SizeChanged;
    }

    private void AddEditBookForm_SizeChanged(object sender, EventArgs e)
    {
        UpdateFormLayout();
        ApplyRoundedCorners();
    }

    private void UpdateFormLayout()
    {
        // Автоматическое масштабирование элементов управления
        ScaleContentControls();
        ScaleControlButtons();
    }

    private void ScaleContentControls()
    {
        if (contentPanel.Width == 0 || contentPanel.Height == 0) return;

        int panelWidth = contentPanel.Width - 40; // учитываем padding
        int controlHeight = 28;
        int rowHeight = 50;
        int labelWidth = 90;
        int controlX = labelWidth + 10;
        int controlWidth = panelWidth - controlX;

        // Позиционируем все элементы
        PositionControl(lblTitle, txtTitle, 0, controlX, controlWidth, controlHeight, rowHeight);
        PositionControl(lblAuthor, txtAuthor, 1, controlX, controlWidth, controlHeight, rowHeight);
        PositionControl(lblYear, numYear, 2, controlX, Math.Min(controlWidth, 150), controlHeight, rowHeight);
        PositionControl(lblGenre, txtGenre, 3, controlX, controlWidth, controlHeight, rowHeight);
        PositionControl(lblStatus, cmbStatus, 4, controlX, controlWidth, controlHeight, rowHeight);
    }

    private void PositionControl(Label label, Control control, int rowIndex, int controlX, int controlWidth, int controlHeight, int rowHeight)
    {
        int baseY = 10;
        int rowY = baseY + rowIndex * rowHeight;

        label.Location = new Point(20, rowY + (controlHeight - label.Height) / 2);
        control.Location = new Point(controlX, rowY);
        control.Width = controlWidth;

        if (control is NumericUpDown numeric)
        {
            numeric.Height = controlHeight;
        }
        else if (control is ComboBox combo)
        {
            combo.Height = controlHeight;
        }
    }

    private void ScaleControlButtons()
    {
        if (controlPanel.Width == 0) return;

        int buttonWidth = 150;
        int buttonHeight = 40;
        int spacing = 20;

        // Адаптивная ширина кнопок
        if (controlPanel.Width < 400)
        {
            buttonWidth = (controlPanel.Width - spacing - 40) / 2;
        }

        btnSave.Size = new Size(buttonWidth, buttonHeight);
        btnCancel.Size = new Size(buttonWidth, buttonHeight);

        int totalWidth = buttonWidth * 2 + spacing;
        int startX = (controlPanel.Width - totalWidth) / 2;
        int buttonY = (controlPanel.Height - buttonHeight) / 2;

        btnSave.Location = new Point(startX, buttonY);
        btnCancel.Location = new Point(startX + buttonWidth + spacing, buttonY);
    }

    private void SetupDarkTheme()
    {
        // Настройка стилей для текстовых полей
        foreach (Control control in contentPanel.Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.BackColor = Color.FromArgb(23, 23, 23);
                textBox.ForeColor = Color.FromArgb(200, 200, 200);
                textBox.BorderStyle = BorderStyle.None;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.BackColor = Color.FromArgb(23, 23, 23);
                comboBox.ForeColor = Color.FromArgb(200, 200, 200);
                comboBox.FlatStyle = FlatStyle.Flat;
            }
            else if (control is NumericUpDown numeric)
            {
                numeric.BackColor = Color.FromArgb(23, 23, 23);
                numeric.ForeColor = Color.FromArgb(200, 200, 200);
                numeric.BorderStyle = BorderStyle.None;
            }
        }

        // Настройка тултипов
        toolTip.SetToolTip(btnSave, "Сохранить книгу");
        toolTip.SetToolTip(btnCancel, "Отменить изменения");
        toolTip.SetToolTip(txtTitle, "Введите название книги");
        toolTip.SetToolTip(txtAuthor, "Введите автора книги");
        toolTip.SetToolTip(numYear, "Введите год издания");
        toolTip.SetToolTip(txtGenre, "Введите жанр книги");
        toolTip.SetToolTip(cmbStatus, "Выберите статус книги");
    }

    private void ApplyRoundedCorners()
    {
        RoundControlCorners(contentPanel, 16);
        RoundControlCorners(btnSave, 12);
        RoundControlCorners(btnCancel, 12);

        // Округление для текстовых полей и комбобоксов
        foreach (Control control in contentPanel.Controls)
        {
            if (control is TextBox || control is ComboBox || control is NumericUpDown)
            {
                RoundControlCorners(control, 8);
            }
        }
    }

    private void RoundControlCorners(Control control, int radius)
    {
        if (control.Width == 0 || control.Height == 0) return;

        var path = new GraphicsPath();
        path.AddLine(radius, 0, control.Width - radius, 0);
        path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
        path.AddLine(control.Width, radius, control.Width, control.Height - radius);
        path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
        path.AddLine(control.Width - radius, control.Height, radius, control.Height);
        path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
        path.AddLine(0, control.Height - radius, 0, radius);
        path.AddArc(0, 0, radius, radius, 180, 90);

        control.Region = new Region(path);
    }

    private void LoadStatusOptions()
    {
        cmbStatus.Items.AddRange(new[] { "в наличии", "прочитана", "отдана" });
        cmbStatus.SelectedIndex = 0;
    }

    private void LoadBookData()
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        string query = "SELECT title, author, year, genre, status FROM books WHERE id = @id";
        using var command = new SqliteCommand(query, connection);
        command.Parameters.AddWithValue("@id", _bookId.Value);

        using var reader = command.ExecuteReader();
        if (reader.Read())
        {
            txtTitle.Text = reader["title"].ToString();
            txtAuthor.Text = reader["author"].ToString();
            numYear.Value = reader["year"] != DBNull.Value ? Convert.ToInt32(reader["year"]) : 2024;
            txtGenre.Text = reader["genre"].ToString();
            cmbStatus.Text = reader["status"].ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTitle.Text))
        {
            MessageBox.Show("Введите название книги", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTitle.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(txtAuthor.Text))
        {
            MessageBox.Show("Введите автора книги", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtAuthor.Focus();
            return;
        }

        try
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            if (_bookId.HasValue)
            {
                // Обновление существующей книги
                string updateQuery = """
                    UPDATE books 
                    SET title = @title, author = @author, year = @year, genre = @genre, status = @status 
                    WHERE id = @id
                    """;
                using var command = new SqliteCommand(updateQuery, connection);
                SetCommandParameters(command);
                command.Parameters.AddWithValue("@id", _bookId.Value);
                command.ExecuteNonQuery();
            }
            else
            {
                // Добавление новой книги
                string insertQuery = """
                    INSERT INTO books (title, author, year, genre, status) 
                    VALUES (@title, @author, @year, @genre, @status)
                    """;
                using var command = new SqliteCommand(insertQuery, connection);
                SetCommandParameters(command);
                command.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetCommandParameters(SqliteCommand command)
    {
        command.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
        command.Parameters.AddWithValue("@author", txtAuthor.Text.Trim());
        command.Parameters.AddWithValue("@year", numYear.Value > 0 ? (int)numYear.Value : DBNull.Value);
        command.Parameters.AddWithValue("@genre", string.IsNullOrWhiteSpace(txtGenre.Text) ? DBNull.Value : txtGenre.Text.Trim());
        command.Parameters.AddWithValue("@status", string.IsNullOrWhiteSpace(cmbStatus.Text) ? "в наличии" : cmbStatus.Text);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}