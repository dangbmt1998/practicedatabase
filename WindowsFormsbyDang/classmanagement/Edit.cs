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
    public partial class Edit : Form {
        public Edit(Class @class) {
            InitializeComponent();
            this.@class = @class;
        }
        private Class @class;
        private void Edit_Load(object sender, EventArgs e) {
            this.tbEdit.Text = @class.Name;

        }

        private void tbEdit_TextChanged(object sender, EventArgs e) {

        }

        private void btneditsave_Click(object sender, EventArgs e) {
            var db = new K22T_CSEntities();
            Class newClass = db.Classes.Find(@class.id);
            try {
                newClass.Name = this.tbEdit.Text;
                db.Entry(newClass).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();// Do-it
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnEditCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
