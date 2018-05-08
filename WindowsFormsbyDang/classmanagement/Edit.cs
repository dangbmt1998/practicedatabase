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

        }
    }
}
