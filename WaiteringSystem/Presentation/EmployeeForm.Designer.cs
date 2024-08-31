namespace WaiteringSystem.Presentation
{
    partial class EmployeeForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.HwRbtn = new System.Windows.Forms.RadioButton();
            this.waiterRbtn = new System.Windows.Forms.RadioButton();
            this.runnerRbtn = new System.Windows.Forms.RadioButton();
            this.id_tbx = new System.Windows.Forms.TextBox();
            this.eml_ID_tbx = new System.Windows.Forms.TextBox();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.phone_tbx = new System.Windows.Forms.TextBox();
            this.pay_tbx = new System.Windows.Forms.TextBox();
            this.hrx_tbx = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.empl_id_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.pay_lbl = new System.Windows.Forms.Label();
            this.hrz_lbl = new System.Windows.Forms.Label();
            this.tips_lbl = new System.Windows.Forms.Label();
            this.tips_tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.Red;
            this.cancel_btn.Location = new System.Drawing.Point(387, 385);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 0;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.BackColor = System.Drawing.Color.Lime;
            this.sub_btn.Location = new System.Drawing.Point(487, 385);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(75, 23);
            this.sub_btn.TabIndex = 1;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = false;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Cyan;
            this.exit_btn.Location = new System.Drawing.Point(596, 385);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // HwRbtn
            // 
            this.HwRbtn.AutoSize = true;
            this.HwRbtn.Location = new System.Drawing.Point(137, 52);
            this.HwRbtn.Name = "HwRbtn";
            this.HwRbtn.Size = new System.Drawing.Size(82, 17);
            this.HwRbtn.TabIndex = 3;
            this.HwRbtn.TabStop = true;
            this.HwRbtn.Text = "HeadWaiter";
            this.HwRbtn.UseVisualStyleBackColor = true;
            this.HwRbtn.CheckedChanged += new System.EventHandler(this.HwRbtn_CheckedChanged);
            // 
            // waiterRbtn
            // 
            this.waiterRbtn.AutoSize = true;
            this.waiterRbtn.Location = new System.Drawing.Point(330, 52);
            this.waiterRbtn.Name = "waiterRbtn";
            this.waiterRbtn.Size = new System.Drawing.Size(56, 17);
            this.waiterRbtn.TabIndex = 4;
            this.waiterRbtn.TabStop = true;
            this.waiterRbtn.Text = "Waiter";
            this.waiterRbtn.UseVisualStyleBackColor = true;
            this.waiterRbtn.CheckedChanged += new System.EventHandler(this.waiterRbtn_CheckedChanged);
            // 
            // runnerRbtn
            // 
            this.runnerRbtn.AutoSize = true;
            this.runnerRbtn.Location = new System.Drawing.Point(515, 52);
            this.runnerRbtn.Name = "runnerRbtn";
            this.runnerRbtn.Size = new System.Drawing.Size(60, 17);
            this.runnerRbtn.TabIndex = 5;
            this.runnerRbtn.TabStop = true;
            this.runnerRbtn.Text = "Runner";
            this.runnerRbtn.UseVisualStyleBackColor = true;
            this.runnerRbtn.CheckedChanged += new System.EventHandler(this.runnerRbtn_CheckedChanged);
            // 
            // id_tbx
            // 
            this.id_tbx.Location = new System.Drawing.Point(137, 113);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(126, 20);
            this.id_tbx.TabIndex = 6;
            // 
            // eml_ID_tbx
            // 
            this.eml_ID_tbx.Location = new System.Drawing.Point(378, 113);
            this.eml_ID_tbx.Name = "eml_ID_tbx";
            this.eml_ID_tbx.Size = new System.Drawing.Size(128, 20);
            this.eml_ID_tbx.TabIndex = 7;
            // 
            // name_tbx
            // 
            this.name_tbx.Location = new System.Drawing.Point(137, 171);
            this.name_tbx.Name = "name_tbx";
            this.name_tbx.Size = new System.Drawing.Size(213, 20);
            this.name_tbx.TabIndex = 8;
            // 
            // phone_tbx
            // 
            this.phone_tbx.Location = new System.Drawing.Point(137, 218);
            this.phone_tbx.Name = "phone_tbx";
            this.phone_tbx.Size = new System.Drawing.Size(144, 20);
            this.phone_tbx.TabIndex = 9;
            // 
            // pay_tbx
            // 
            this.pay_tbx.Location = new System.Drawing.Point(137, 272);
            this.pay_tbx.Name = "pay_tbx";
            this.pay_tbx.Size = new System.Drawing.Size(100, 20);
            this.pay_tbx.TabIndex = 10;
            // 
            // hrx_tbx
            // 
            this.hrx_tbx.Location = new System.Drawing.Point(137, 319);
            this.hrx_tbx.Name = "hrx_tbx";
            this.hrx_tbx.Size = new System.Drawing.Size(100, 20);
            this.hrx_tbx.TabIndex = 11;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(57, 116);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(18, 13);
            this.id_lbl.TabIndex = 12;
            this.id_lbl.Text = "ID";
            // 
            // empl_id_lbl
            // 
            this.empl_id_lbl.AutoSize = true;
            this.empl_id_lbl.Location = new System.Drawing.Point(305, 116);
            this.empl_id_lbl.Name = "empl_id_lbl";
            this.empl_id_lbl.Size = new System.Drawing.Size(67, 13);
            this.empl_id_lbl.TabIndex = 13;
            this.empl_id_lbl.Text = "Employee ID";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(51, 174);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 14;
            this.name_lbl.Text = "Name";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Location = new System.Drawing.Point(54, 221);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(38, 13);
            this.phone_lbl.TabIndex = 15;
            this.phone_lbl.Text = "Phone";
            // 
            // pay_lbl
            // 
            this.pay_lbl.AutoSize = true;
            this.pay_lbl.Location = new System.Drawing.Point(54, 275);
            this.pay_lbl.Name = "pay_lbl";
            this.pay_lbl.Size = new System.Drawing.Size(48, 13);
            this.pay_lbl.TabIndex = 16;
            this.pay_lbl.Text = "Payment";
            // 
            // hrz_lbl
            // 
            this.hrz_lbl.AutoSize = true;
            this.hrz_lbl.Location = new System.Drawing.Point(57, 322);
            this.hrz_lbl.Name = "hrz_lbl";
            this.hrz_lbl.Size = new System.Drawing.Size(35, 13);
            this.hrz_lbl.TabIndex = 17;
            this.hrz_lbl.Text = "Hours";
            // 
            // tips_lbl
            // 
            this.tips_lbl.AutoSize = true;
            this.tips_lbl.Location = new System.Drawing.Point(57, 371);
            this.tips_lbl.Name = "tips_lbl";
            this.tips_lbl.Size = new System.Drawing.Size(27, 13);
            this.tips_lbl.TabIndex = 18;
            this.tips_lbl.Text = "Tips";
            // 
            // tips_tbx
            // 
            this.tips_tbx.Location = new System.Drawing.Point(137, 368);
            this.tips_tbx.Name = "tips_tbx";
            this.tips_tbx.Size = new System.Drawing.Size(100, 20);
            this.tips_tbx.TabIndex = 19;
            // 
            // EmployeeForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 417);
            this.Controls.Add(this.tips_tbx);
            this.Controls.Add(this.tips_lbl);
            this.Controls.Add(this.hrz_lbl);
            this.Controls.Add(this.pay_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.empl_id_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.hrx_tbx);
            this.Controls.Add(this.pay_tbx);
            this.Controls.Add(this.phone_tbx);
            this.Controls.Add(this.name_tbx);
            this.Controls.Add(this.eml_ID_tbx);
            this.Controls.Add(this.id_tbx);
            this.Controls.Add(this.runnerRbtn);
            this.Controls.Add(this.waiterRbtn);
            this.Controls.Add(this.HwRbtn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.cancel_btn);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Activated += new System.EventHandler(this.EmployeeForm_Activated);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.RadioButton HwRbtn;
        private System.Windows.Forms.RadioButton waiterRbtn;
        private System.Windows.Forms.RadioButton runnerRbtn;
        private System.Windows.Forms.TextBox id_tbx;
        private System.Windows.Forms.TextBox eml_ID_tbx;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.TextBox phone_tbx;
        private System.Windows.Forms.TextBox pay_tbx;
        private System.Windows.Forms.TextBox hrx_tbx;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label empl_id_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label pay_lbl;
        private System.Windows.Forms.Label hrz_lbl;
        private System.Windows.Forms.Label tips_lbl;
        private System.Windows.Forms.TextBox tips_tbx;
    }
}