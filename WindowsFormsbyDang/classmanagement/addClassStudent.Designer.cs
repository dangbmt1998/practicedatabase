namespace WindowsFormsbyDang.classmanagement {
    partial class addClassStudent {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbClassname = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbClassname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbClassname
            // 
            this.lbClassname.AutoSize = true;
            this.lbClassname.Location = new System.Drawing.Point(13, 30);
            this.lbClassname.Name = "lbClassname";
            this.lbClassname.Size = new System.Drawing.Size(61, 13);
            this.lbClassname.TabIndex = 0;
            this.lbClassname.Text = "Class name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 53);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 53);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbClassname
            // 
            this.tbClassname.Location = new System.Drawing.Point(91, 27);
            this.tbClassname.Name = "tbClassname";
            this.tbClassname.Size = new System.Drawing.Size(172, 20);
            this.tbClassname.TabIndex = 3;
            // 
            // addClassStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 93);
            this.Controls.Add(this.tbClassname);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbClassname);
            this.Name = "addClassStudent";
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.addClassStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClassname;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbClassname;

    }
}