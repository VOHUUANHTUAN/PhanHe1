namespace PhanHe1
{
    partial class ListRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListRolelv = new System.Windows.Forms.ListView();
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manageRolelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListRolelv
            // 
            this.ListRolelv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.role});
            this.ListRolelv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ListRolelv.HideSelection = false;
            this.ListRolelv.Location = new System.Drawing.Point(60, 74);
            this.ListRolelv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListRolelv.Name = "ListRolelv";
            this.ListRolelv.Size = new System.Drawing.Size(427, 398);
            this.ListRolelv.TabIndex = 3;
            this.ListRolelv.UseCompatibleStateImageBehavior = false;
            this.ListRolelv.View = System.Windows.Forms.View.Details;
            this.ListRolelv.SelectedIndexChanged += new System.EventHandler(this.ListRolelv_SelectedIndexChanged);
            // 
            // role
            // 
            this.role.Text = "Role";
            this.role.Width = 475;
            // 
            // manageRolelabel
            // 
            this.manageRolelabel.AutoSize = true;
            this.manageRolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.manageRolelabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.manageRolelabel.Location = new System.Drawing.Point(123, 25);
            this.manageRolelabel.Name = "manageRolelabel";
            this.manageRolelabel.Size = new System.Drawing.Size(280, 36);
            this.manageRolelabel.TabIndex = 4;
            this.manageRolelabel.Text = "DANH SÁCH ROLE";
            this.manageRolelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 515);
            this.Controls.Add(this.ListRolelv);
            this.Controls.Add(this.manageRolelabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListRolelv;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.Label manageRolelabel;
    }
}