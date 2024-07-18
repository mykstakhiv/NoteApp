using System.Text.Json;
using static NoteApp.MainMenu;


namespace NoteApp
{
    public partial class Form1 : Form
    {
        public NoteBook NoteBook { get; set; }

        private NoteBook NoteBookData;
        private const string FilePath = "person.json";

        public Form1(NoteBook noteBook)
        {
            NoteBook = noteBook;

            InitializeComponent();
            LoadData();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (noteBook.Notes != null)
            {
                for (int i = 0; i < noteBook.Notes.Count; i++)
                {
                    checkedListBox1.Items.Add(noteBook.Notes[i]);
                }
            }
        }

        private void Submit(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please ebter the note");
                return;
            }

            checkedListBox1.Items.Add(textBox1.Text);

            string a = textBox1.Text;

            if (NoteBook.Notes is null)
            {
                NoteBook.Notes = new();
            }
            NoteBook.Notes.Add(a);

            textBox1.Text = null;
        }

        private void ClearList(object sender, EventArgs e)
        {

            if (checkedListBox1.Items.Count == 0)
            {

            }
            else
            {
                checkedListBox1.Items.Clear();
                NoteBook.Notes.Clear();
            }

        }

        private void AddNote(object sender, EventArgs e)
        {

        }

        public void Notes(object sender, EventArgs e)
        {

        }

        private void DeleteAll(object sender, EventArgs e)
        {
            var noteBook = NoteBook;

            if (checkedListBox1.CheckedItems.Count != 0)
            {

                foreach (var item in checkedListBox1.CheckedItems.OfType<string>().ToList())
                {
                    checkedListBox1.Items.Remove(item);
                    noteBook.Notes.Remove(item);
                }

            }
        }


        private void SaveButton(object sender, EventArgs e)
        {
            //SaveData();
            this.Close();
        }

        private void SaveData()
        {
            try
            {
                NoteBookData.Notes.Clear();
                foreach (var item in checkedListBox1.Items)
                {
                    NoteBookData.Notes.Add(item.ToString());
                }
                string json = JsonSerializer.Serialize(NoteBookData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    NoteBookData = JsonSerializer.Deserialize<NoteBook>(json);
                    checkedListBox1.Items.Clear();
                    foreach (var item in NoteBookData.Notes)
                    {
                        checkedListBox1.Items.Add(item);
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
    }
}

