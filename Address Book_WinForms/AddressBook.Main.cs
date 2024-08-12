using System;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Linq;

namespace Address_Book_WinForms
{
    public partial class AddressBookMain : Form
    {
        //private DataTable contactsTable = new();
        private List<ContactClass> contacts;

        public AddressBookMain()
        {
            InitializeComponent();
            contacts = new List<ContactClass>();
        }

        private void AddressBookMain_Load(object sender, EventArgs e)
        {
            InitializeContactsTable();
        }

        private void InitializeContactsTable()
        {
            DisplayContacts_dgv.DataSource = new BindingList<ContactClass>(contacts);
            DisplayContacts_dgv.AutoGenerateColumns = true;
            DisplayContacts_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisplayContacts_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void RefreshContactsTable()
        {
            DisplayContacts_dgv.DataSource = new BindingList<ContactClass>(contacts);
        }

        private void Add_toolbtn_Click(object sender, EventArgs e)
        {
            AddContact addContact = new AddContact();
            if (addContact.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(addContact.NewContact);
                RefreshContactsTable();
                Status_toollbl.Text = $"Total contacts: {contacts.Count}";
            }
        }

        private void Edit_toolbtn_Click(object sender, EventArgs e)
        {
            if (DisplayContacts_dgv.SelectedRows.Count > 0)
            {
                int selectedIndex = DisplayContacts_dgv.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < contacts.Count)
                {
                    ContactClass contactClass = contacts[selectedIndex];
                    AddContact addContact = new AddContact(contactClass);

                    if (addContact.ShowDialog() == DialogResult.OK)
                    {
                        contacts[selectedIndex] = addContact.NewContact;
                        RefreshContactsTable();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a valid contact to edit.");
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to edit.");
            }
        }

        private void Delete_toolbtn_Click(object sender, EventArgs e)
        {
            if (DisplayContacts_dgv.SelectedRows.Count > 0)
            {
                int selectedIndex = DisplayContacts_dgv.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < contacts.Count)
                {
                    contacts.RemoveAt(selectedIndex);
                    RefreshContactsTable();
                    Status_toollbl.Text = $"Total contacts: {contacts.Count}";
                }
                else
                {
                    MessageBox.Show("Invalid selection. Please select a valid contact to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a contact to delete.", "No Contact Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Save_toolbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Contacts";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (ContactClass contact in contacts)
                    {
                        writer.WriteLine($"{contact.FirstName},{contact.LastName},{contact.PhoneNumber},{contact.Address},{contact.Email}");
                    }
                }
            }
        }

        private void Search_toolbtn_Click(object sender, EventArgs e)
        {
            string searchTerm = Search_tooltb.Text;

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                List<ContactClass> filteredList = contacts
                    .Where(item => item.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                   item.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                   item.PhoneNumber.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                   item.Address.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                   item.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (filteredList.Any())
                {
                    DisplayContacts_dgv.DataSource = new BindingList<ContactClass>(filteredList);
                }
                else
                {
                    MessageBox.Show("No contacts found matching the search term.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayContacts_dgv.DataSource = new BindingList<ContactClass>(contacts); // Reset to all contacts
                }
            }
            else
            {
                DisplayContacts_dgv.DataSource = new BindingList<ContactClass>(contacts);
            }
        }
    }
}
