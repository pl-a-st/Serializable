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
            int lastNotRemovedIndex = GetLastNotRemovedIndex(ProgramData.Entries);
            ProgramData.Entries.Insert(lastNotRemovedIndex, entry);
            PushListBox();
        }
        private static int GetLastNotRemovedIndex(Entries entries) {
            int lastNotRemovedIndex = 0;
            for (int i = 0; i < entries.Count; i++) {
                if (entries[i].Actions[entries[i].Actions.Count - 1].TypeChange == TypeChange.Removal) {
                    lastNotRemovedIndex = i;
                    break;
                }
                lastNotRemovedIndex = i+1;
            }
            return lastNotRemovedIndex;
        }
        private void PushListBox() {
            listBox1.Items.Clear();
            foreach (Entry entry in ProgramData.Entries) {
                if(entry.Actions[entry.Actions.Count-1].TypeChange != TypeChange.Removal) {
                    listBox1.Items.Add($"{entry.Person.Name} {entry.Person.Surname} {entry.Person.Birthday} \t {entry.Actions[entry.Actions.Count - 1].DateAction}");
                }
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

        private void btnDelete_Click(object sender, EventArgs e) {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1) {
                return;
            }
            var entry = ProgramData.Entries[selectedIndex];
            ProgramData.Entries[selectedIndex].AddAction(TypeChange.Removal);
            ProgramData.Entries.RemoveAt(selectedIndex);
            ProgramData.Entries.Add(entry);
            PushListBox();
            listBox1.SelectedIndex = selectedIndex-1;
        }
    }
}
