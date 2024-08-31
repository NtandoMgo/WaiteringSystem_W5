namespace WaiteringSystem.Presentation
{
    partial class EmployeeListingForm
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
            this.list_lbl = new System.Windows.Forms.Label();
            this.empl_lst_view = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // list_lbl
            // 
            this.list_lbl.AutoSize = true;
            this.list_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_lbl.Location = new System.Drawing.Point(375, 26);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(50, 25);
            this.list_lbl.TabIndex = 0;
            this.list_lbl.Text = "List";
            // 
            // empl_lst_view
            // 
            this.empl_lst_view.HideSelection = false;
            this.empl_lst_view.Location = new System.Drawing.Point(50, 65);
            this.empl_lst_view.Name = "empl_lst_view";
            this.empl_lst_view.Size = new System.Drawing.Size(715, 340);
            this.empl_lst_view.TabIndex = 1;
            this.empl_lst_view.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.empl_lst_view);
            this.Controls.Add(this.list_lbl);
            this.Name = "EmployeeListingForm";
            this.Text = "Employee Listing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.ListView empl_lst_view;
    }
}