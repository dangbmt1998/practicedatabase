using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsbyDang.classmanagement {
    public partial class List : Form {
        public List() {
            InitializeComponent();
        }

        private void list_Load(object sender, EventArgs e) {
            this.ShowClassList();
        }
        private void ShowClassList() {
            var db = new K22T_CSEntities();
            this.lstClass.DataSource = db.Classes.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            var form = new addClassStudent();
            form.Show();
            this.ShowClassList();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            this.ShowClassList();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            var db = new K22T_CSEntities();
            for (int i = 0; i < this.lstClass.SelectedRows.Count; i++) {
                var row = this.lstClass.SelectedRows[i];
                var item = (Class)row.DataBoundItem;
                try {
                    var @class = db.Classes.Find(item.id);
                    db.Classes.Remove(@class);
                    db.SaveChanges();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lstClass_DoubleClick(object sender, EventArgs e) {
            if (this.lstClass.SelectedRows.Count == 1) {
                var row = this.lstClass.SelectedRows[0];
                var item = (Class)row.DataBoundItem;

                var form = new Edit(item);
                form.ShowDialog();
                this.ShowClassList();

            }
        }

    }
}
