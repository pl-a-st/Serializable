using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializable {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void btnAddEntry_Click(object sender, EventArgs e) {
            Person person = new Person(tBName.Text, tBSurname.Text, dateTimePicker1.Value);
            Entry entry = new Entry(person);
            ProgramData.Entries.Add(entry);
            PushListBox();
        }
        private void PushListBox() {
            listBox1.Items.Clear();

            foreach (Entry entry1 in ProgramData.Entries) {
                listBox1.Items.Add($"{entry1.Person.Name} {entry1.Person.Surname} {entry1.Person.Birthday} \t {entry1.Actions[entry1.Actions.Count-1].DateAction}");
            }
            if (Serializable.binWriteObjectToFile(ProgramData.Entries, "ProgramData.bin") == MethodResultStatus.Fault) {
                MessageBox.Show("Файл не записался.");
            }

        }
        private void tBName_Enter(object sender, EventArgs e) {
            tBName.Text = null;
            tBName.ForeColor = Color.Black;
        }
        private void tBSurname_Enter(object sender, EventArgs e) {
            tBSurname.Text = null;
            tBSurname.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e) {
            PushListBox();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1) {
                return;
            }
            Person person = new Person(tBName.Text, tBSurname.Text, dateTimePicker1.Value);
            ProgramData.Entries[listBox1.SelectedIndex].SetPerson(person);
            ProgramData.Entries[listBox1.SelectedIndex].AddAction(TypeChange.Change);
            PushListBox();
            listBox1.SelectedIndex = selectedIndex;
        }
    }
}
