
namespace Serializable {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBSurname = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(409, 233);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(146, 32);
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.Text = "Добавить";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(526, 186);
            this.listBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tBName
            // 
            this.tBName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tBName.Location = new System.Drawing.Point(29, 257);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(132, 20);
            this.tBName.TabIndex = 3;
            this.tBName.Text = "Имя";
            this.tBName.Enter += new System.EventHandler(this.tBName_Enter);
            // 
            // tBSurname
            // 
            this.tBSurname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tBSurname.Location = new System.Drawing.Point(167, 257);
            this.tBSurname.Name = "tBSurname";
            this.tBSurname.Size = new System.Drawing.Size(132, 20);
            this.tBSurname.TabIndex = 3;
            this.tBSurname.Text = "Фамилия";
            this.tBSurname.Enter += new System.EventHandler(this.tBSurname_Enter);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(409, 271);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(146, 32);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 309);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 424);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tBSurname);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBSurname;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
    }
}

