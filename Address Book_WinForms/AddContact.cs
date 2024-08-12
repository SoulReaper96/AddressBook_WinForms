using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book_WinForms
{
    public partial class AddContact : Form
    {
        public ContactClass NewContact { get; set; }

        public AddContact()
        {
            InitializeComponent();
        }


        public AddContact(ContactClass contact) : this()
        {
            if (contact != null)
            {
                FnameAdd_tb.Text = contact.FirstName;
                LnameAdd_tb.Text = contact.LastName;
                PnumbAdd_tb.Text = contact.PhoneNumber;
                AddrAdd_tb.Text = contact.Address;
                EmailAdd_tb.Text = contact.Email;
            }
        }

        private void SaveAdd_btn_Click(object sender, EventArgs e)
        {
            NewContact = new ContactClass
            {
                FirstName = FnameAdd_tb.Text,
                LastName = LnameAdd_tb.Text,
                PhoneNumber = PnumbAdd_tb.Text,
                Address = AddrAdd_tb.Text,
                Email = EmailAdd_tb.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelAdd_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
