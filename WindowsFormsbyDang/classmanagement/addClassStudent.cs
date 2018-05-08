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
    public partial class addClassStudent : Form {
        public addClassStudent() {
            InitializeComponent();
        }

        private void addClassStudent_Load(object sender, EventArgs e) {
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {
            Class @class = new Class();
            @class.Name = tbClassname.Text;
            try {
                var db = new K22T_CSEntities();
                db.Classes.Add(@class);
                db.SaveChanges(); // Do it
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
