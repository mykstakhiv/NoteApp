using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NoteApp.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteApp
{
    public partial class MainMenu : Form
    {
        //list with NoteBook objects
        public List<NoteBook> NoteBooks;

        private NoteBook NoteBookData;
        private const string FilePath = "person.json";

        public MainMenu()
        {
            InitializeComponent();
            NoteBooks = LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("PLease enter the name of the Note Book");
                return;
            }


            if (ListsDropDown.Items != null)
            {

                foreach (string notebook in ListsDropDown.Items)
                {
                    if (textBox1.Text == notebook)
                    {
                        MessageBox.Show("Note Book already excites");
                        textBox1.Text = null;
                        return;
                    }
                }
            }
            else
            {
                return;
            }

            NoteBook noteBook = new NoteBook(textBox1.Text);
            NoteBooks.Add(noteBook);

            ListsDropDown.Items.Add(noteBook.Name);

            ListsDropDown.Text = textBox1.Text;
            textBox1.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        //I have made feature from the bag(when you press select it can create new note book automatically)
        {
            if (ListsDropDown.Text == "")
            {
                MessageBox.Show("PLease create the note");
                return;
            }

            var noteBook = NoteBooks.Where(noteBook => noteBook.Name == ListsDropDown.Text).First();


            using var form1 = new Form1(noteBook);
            form1.ShowDialog();

        }

        private void CreateButton(object sender, EventArgs e)
        {
            string selectedNoteBookName = ListsDropDown.ToString();

            if (ListsDropDown.Text == "")
            {
                MessageBox.Show("PLease enter the name");
                return;
            }
            //var noteBook = NoteBooks.Where(x => string.Equals(x.Name, selectedNoteBookName, StringComparison.InvariantCultureIgnoreCase)).First();

            var noteBook = NoteBooks.Where(noteBook => noteBook.Name == ListsDropDown.Text).First();


            var editForm = new Form1(noteBook);
            var response = editForm.ShowDialog();

        }

        private void SaveData()
        {
            try
            {
                NoteBookData.Names.Clear();
                foreach (var item in ListsDropDown.Items)
                {
                    NoteBookData.Names.Add(item.ToString());
                }
                string json = JsonSerializer.Serialize(NoteBookData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        private List<NoteBook> LoadData()
        {
            var collection = new List<NoteBook>();
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    collection = JsonSerializer.Deserialize<List<NoteBook>>(json);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            return collection;
        }

        private void CloseButton(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }
    }
}
