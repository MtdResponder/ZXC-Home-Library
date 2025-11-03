using Microsoft.Data.Sqlite;
using System.Drawing.Drawing2D;

namespace WinFormsApplication;

public partial class MainForm : Form
{
    private static readonly string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "library.db");
    private static readonly string connectionString = $"Data Source={databasePath}";
    private List<Book> allBooks = new List<Book>();

    public MainForm()
    {
        InitializeComponent();
        SetupDarkTheme();
        ApplyRoundedCorners();
        SetupAutoScaling();
    }

    private void SetupAutoScaling()
    {
        this.AutoScaleMode = AutoScaleMode.Dpi;
        this.AutoSize = false;
        this.MinimumSize = new Size(800, 600);
        this.SizeChanged += MainForm_SizeChanged;
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        // Пересчитываем позиции элементов фильтров
        UpdateFilterPanelLayout();
        ApplyRoundedCorners();
    }

    private void UpdateFilterPanelLayout()
    {
        if (filterPanel.Width == 0 || filterPanel.Height == 0) return;

        int panelWidth = filterPanel.Width;
        int panelHeight = filterPanel.Height;

        // Фиксированные отступы и размеры
        int margin = 20;
        int controlHeight = 28;
        int comboWidth = 200;
        int labelSpacing = 5;
        int controlSpacing = 15;

        // Позиционирование слева направо
        int currentX = margin;

        // Поиск
        label1.Location = new Point(currentX, (panelHeight - label1.Height) / 2);
        currentX += label1.Width + labelSpacing;

        // Вычисляем доступную ширину для поиска
        int availableSearchWidth = panelWidth - margin * 2 - (comboWidth * 2) - (controlSpacing * 2) - label1.Width - label2.Width - label3.Width - labelSpacing * 3;
        int searchWidth = Math.Max(250, availableSearchWidth);

        txtSearch.Location = new Point(currentX, (panelHeight - controlHeight) / 2);
        txtSearch.Width = searchWidth;
        currentX += txtSearch.Width + controlSpacing;

        // Жанр
        label2.Location = new Point(currentX, (panelHeight - label2.Height) / 2);
        currentX += label2.Width + labelSpacing;

        cmbFilterGenre.Location = new Point(currentX, (panelHeight - controlHeight) / 2);
        cmbFilterGenre.Width = comboWidth;
        currentX += cmbFilterGenre.Width + controlSpacing;

        // Статус
        label3.Location = new Point(currentX, (panelHeight - label3.Height) / 2);
        currentX += label3.Width + labelSpacing;

        cmbFilterStatus.Location = new Point(currentX, (panelHeight - controlHeight) / 2);

        // Автоматически подстраиваем ширину комбобокса статуса под оставшееся пространство
        int statusComboWidth = Math.Max(150, panelWidth - currentX - margin);
        cmbFilterStatus.Width = statusComboWidth;
    }

    private void SetupDarkTheme()
    {
        dataGridViewBooks.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
        dataGridViewBooks.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
        dataGridViewBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
        dataGridViewBooks.DefaultCellStyle.SelectionForeColor = Color.FromArgb(240, 240, 240);
        dataGridViewBooks.DefaultCellStyle.Font = new Font("Segoe UI", 11F);

        dataGridViewBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
        dataGridViewBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 180, 180);
        dataGridViewBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        dataGridViewBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        dataGridViewBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);

        toolTip.SetToolTip(btnAddBook, "Добавить новую книгу");
        toolTip.SetToolTip(btnEditBook, "Редактировать выбранную книгу");
        toolTip.SetToolTip(btnDeleteBook, "Удалить выбранную книгу");
        toolTip.SetToolTip(txtSearch, "Поиск по названию и автору");
    }

    private void ApplyRoundedCorners()
    {
        RoundControlCorners(contentPanel, 16);
        RoundControlCorners(filterPanel, 12);
        RoundControlCorners(btnAddBook, 12);
        RoundControlCorners(btnEditBook, 12);
        RoundControlCorners(btnDeleteBook, 12);
        RoundControlCorners(cmbFilterGenre, 8);
        RoundControlCorners(cmbFilterStatus, 8);
        RoundControlCorners(txtSearch, 8);
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

    private void MainForm_Load(object sender, EventArgs e)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        string createTableQuery = """
            CREATE TABLE IF NOT EXISTS books (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT NOT NULL,
                author TEXT NOT NULL,
                year INTEGER,
                genre TEXT,
                status TEXT DEFAULT 'в наличии',
                created_at DATETIME DEFAULT CURRENT_TIMESTAMP
            );
            """;
        using var createCommand = new SqliteCommand(createTableQuery, connection);
        createCommand.ExecuteNonQuery();

        string checkDataQuery = "SELECT COUNT(*) FROM books";
        using var checkCommand = new SqliteCommand(checkDataQuery, connection);
        var count = Convert.ToInt64(checkCommand.ExecuteScalar());

        if (count == 0)
        {
            string insertValuesQuery = """
                INSERT INTO books (title, author, year, genre, status) VALUES
                ('Мастер и Маргарита', 'Булгаков М.А.', 1966, 'Роман', 'прочитана'),
                ('Преступление и наказание', 'Достоевский Ф.М.', 1866, 'Роман', 'в наличии'),
                ('Война и мир', 'Толстой Л.Н.', 1869, 'Роман', 'прочитана'),
                ('1984', 'Оруэлл Джордж', 1949, 'Антиутопия', 'в наличии'),
                ('Гарри Поттер и философский камень', 'Роулинг Дж.К.', 1997, 'Фэнтези', 'в наличии'),
                ('Маленький принц', 'Сент-Экзюпери А.', 1943, 'Притча', 'прочитана'),
                ('Три товарища', 'Ремарк Э.М.', 1936, 'Роман', 'в наличии'),
                ('Шерлок Холмс', 'Конан Дойл А.', 1892, 'Детектив', 'отдана'),
                ('Анна Каренина', 'Толстой Л.Н.', 1877, 'Роман', 'в наличии'),
                ('Сто лет одиночества', 'Маркес Г.Г.', 1967, 'Роман', 'прочитана');
                """;
            using var insertCommand = new SqliteCommand(insertValuesQuery, connection);
            insertCommand.ExecuteNonQuery();
        }

        LoadBooks();
        LoadFilterOptions();
        UpdateFilterPanelLayout(); // Инициализация позиций при загрузке
    }

    private void LoadBooks()
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        string query = "SELECT id, title, author, year, genre, status, created_at FROM books ORDER BY title";
        using var command = new SqliteCommand(query, connection);
        using var reader = command.ExecuteReader();

        allBooks.Clear();
        var displayBooks = new List<Book>();

        while (reader.Read())
        {
            var book = new Book
            {
                Id = Convert.ToInt32(reader["id"]),
                Title = reader["title"].ToString() ?? string.Empty,
                Author = reader["author"].ToString() ?? string.Empty,
                Year = reader["year"] != DBNull.Value ? Convert.ToInt32(reader["year"]) : null,
                Genre = reader["genre"] != DBNull.Value ? reader["genre"].ToString() : string.Empty,
                Status = reader["status"].ToString() ?? "в наличии"
            };

            if (reader["created_at"] != DBNull.Value)
            {
                book.CreatedAt = Convert.ToDateTime(reader["created_at"]);
            }
            else
            {
                book.CreatedAt = DateTime.Now;
            }

            allBooks.Add(book);
            displayBooks.Add(book);
        }

        dataGridViewBooks.DataSource = displayBooks;
        ApplySearchFilter();
    }

    private void LoadFilterOptions()
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        string genreQuery = "SELECT DISTINCT genre FROM books WHERE genre IS NOT NULL ORDER BY genre";
        using var genreCommand = new SqliteCommand(genreQuery, connection);
        using var genreReader = genreCommand.ExecuteReader();

        cmbFilterGenre.Items.Clear();
        cmbFilterGenre.Items.Add("Все жанры");

        while (genreReader.Read())
        {
            cmbFilterGenre.Items.Add(genreReader["genre"]);
        }
        cmbFilterGenre.SelectedIndex = 0;

        string statusQuery = "SELECT DISTINCT status FROM books WHERE status IS NOT NULL ORDER BY status";
        using var statusCommand = new SqliteCommand(statusQuery, connection);
        using var statusReader = statusCommand.ExecuteReader();

        cmbFilterStatus.Items.Clear();
        cmbFilterStatus.Items.Add("Все статусы");

        while (statusReader.Read())
        {
            cmbFilterStatus.Items.Add(statusReader["status"]);
        }
        cmbFilterStatus.SelectedIndex = 0;
    }

    private void ApplySearchFilter()
    {
        if (dataGridViewBooks.DataSource == null) return;

        var filteredBooks = allBooks.Where(book =>
            (string.IsNullOrEmpty(txtSearch.Text) ||
             book.Title.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
             book.Author.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)) &&
            (cmbFilterGenre.SelectedIndex <= 0 || cmbFilterGenre.Text == "Все жанры" || book.Genre == cmbFilterGenre.Text) &&
            (cmbFilterStatus.SelectedIndex <= 0 || cmbFilterStatus.Text == "Все статусы" || book.Status == cmbFilterStatus.Text)
        ).ToList();

        dataGridViewBooks.DataSource = filteredBooks;
        UpdateRowColors();
    }

    private void UpdateRowColors()
    {
        foreach (DataGridViewRow row in dataGridViewBooks.Rows)
        {
            var status = row.Cells["colStatus"].Value?.ToString();
            if (status == "прочитана")
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(72, 187, 120);
            }
            else if (status == "отдана")
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(248, 113, 113);
            }
            else
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        ApplySearchFilter();
    }

    private void cmbFilterGenre_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplySearchFilter();
    }

    private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplySearchFilter();
    }

    private void btnAddBook_Click(object sender, EventArgs e)
    {
        using var addForm = new AddEditBookForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {
            LoadBooks();
            LoadFilterOptions();
        }
    }

    private void btnEditBook_Click(object sender, EventArgs e)
    {
        if (dataGridViewBooks.CurrentRow == null)
        {
            MessageBox.Show("Выберите книгу для редактирования", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var bookId = Convert.ToInt32(dataGridViewBooks.CurrentRow.Cells["colId"].Value);
        using var editForm = new AddEditBookForm(bookId);
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            LoadBooks();
        }
    }

    private void btnDeleteBook_Click(object sender, EventArgs e)
    {
        if (dataGridViewBooks.CurrentRow == null)
        {
            MessageBox.Show("Выберите книгу для удаления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var bookId = Convert.ToInt32(dataGridViewBooks.CurrentRow.Cells["colId"].Value);
        var bookTitle = dataGridViewBooks.CurrentRow.Cells["colTitle"].Value.ToString();

        var result = MessageBox.Show($"Вы уверены, что хотите удалить книгу \"{bookTitle}\"?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM books WHERE id = @id";
            using var command = new SqliteCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@id", bookId);
            command.ExecuteNonQuery();

            LoadBooks();
            LoadFilterOptions();
        }
    }

    private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
    {
        bool hasSelection = dataGridViewBooks.CurrentRow != null;
        btnEditBook.Enabled = hasSelection;
        btnDeleteBook.Enabled = hasSelection;

        btnEditBook.BackColor = hasSelection ? Color.FromArgb(108, 117, 125) : Color.FromArgb(80, 80, 80);
        btnDeleteBook.BackColor = hasSelection ? Color.FromArgb(220, 53, 69) : Color.FromArgb(80, 80, 80);
    }

    private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void filterPanel_Paint(object sender, PaintEventArgs e)
    {

    }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int? Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}