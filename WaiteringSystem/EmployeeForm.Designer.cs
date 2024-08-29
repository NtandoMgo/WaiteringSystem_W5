namespace WaiteringSystem
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
            this.HW_rad_btn = new System.Windows.Forms.RadioButton();
            this.W_rad_btn = new System.Windows.Forms.RadioButton();
            this.run_rd_btn = new System.Windows.Forms.RadioButton();
            this.id_tbx = new System.Windows.Forms.TextBox();
            this.e_id_tbx = new System.Windows.Forms.TextBox();
            this.name_tbx = new System.Windows.Forms.TextBox();
            this.phone_tbx = new System.Windows.Forms.TextBox();
            this.pay_tbx = new System.Windows.Forms.TextBox();
            this.hours_tbx = new System.Windows.Forms.TextBox();
            this.tips_tbx = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.emplID_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.pay_lbl = new System.Windows.Forms.Label();
            this.hrz_lbl = new System.Windows.Forms.Label();
            this.tips_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HW_rad_btn
            // 
            this.HW_rad_btn.AutoSize = true;
            this.HW_rad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HW_rad_btn.Location = new System.Drawing.Point(87, 45);
            this.HW_rad_btn.Name = "HW_rad_btn";
            this.HW_rad_btn.Size = new System.Drawing.Size(112, 20);
            this.HW_rad_btn.TabIndex = 0;
            this.HW_rad_btn.TabStop = true;
            this.HW_rad_btn.Text = "Head Waiter";
            this.HW_rad_btn.UseVisualStyleBackColor = true;
            this.HW_rad_btn.CheckedChanged += new System.EventHandler(this.HW_rad_btn_CheckedChanged);
            // 
            // W_rad_btn
            // 
            this.W_rad_btn.AutoSize = true;
            this.W_rad_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.W_rad_btn.Location = new System.Drawing.Point(301, 45);
            this.W_rad_btn.Name = "W_rad_btn";
            this.W_rad_btn.Size = new System.Drawing.Size(70, 20);
            this.W_rad_btn.TabIndex = 1;
            this.W_rad_btn.TabStop = true;
            this.W_rad_btn.Text = "Waiter";
            this.W_rad_btn.UseVisualStyleBackColor = true;
            this.W_rad_btn.CheckedChanged += new System.EventHandler(this.W_rad_btn_CheckedChanged);
            // 
            // run_rd_btn
            // 
            this.run_rd_btn.AutoSize = true;
            this.run_rd_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run_rd_btn.Location = new System.Drawing.Point(521, 45);
            this.run_rd_btn.Name = "run_rd_btn";
            this.run_rd_btn.Size = new System.Drawing.Size(78, 20);
            this.run_rd_btn.TabIndex = 2;
            this.run_rd_btn.TabStop = true;
            this.run_rd_btn.Text = " Runner";
            this.run_rd_btn.UseVisualStyleBackColor = true;
            this.run_rd_btn.CheckedChanged += new System.EventHandler(this.run_rd_btn_CheckedChanged);
            // 
            // id_tbx
            // 
            this.id_tbx.Location = new System.Drawing.Point(136, 129);
            this.id_tbx.Name = "id_tbx";
            this.id_tbx.Size = new System.Drawing.Size(133, 20);
            this.id_tbx.TabIndex = 3;
            // 
            // e_id_tbx
            // 
            this.e_id_tbx.Location = new System.Drawing.Point(422, 128);
            this.e_id_tbx.Name = "e_id_tbx";
            this.e_id_tbx.Size = new System.Drawing.Size(149, 20);
            this.e_id_tbx.TabIndex = 4;
            // 
            // name_tbx
            // 
            this.name_tbx.Location = new System.Drawing.Point(179, 190);
            this.name_tbx.Name = "name_tbx";
            this.name_tbx.Size = new System.Drawing.Size(287, 20);
            this.name_tbx.TabIndex = 5;
            // 
            // phone_tbx
            // 
            this.phone_tbx.Location = new System.Drawing.Point(179, 231);
            this.phone_tbx.Name = "phone_tbx";
            this.phone_tbx.Size = new System.Drawing.Size(168, 20);
            this.phone_tbx.TabIndex = 6;
            // 
            // pay_tbx
            // 
            this.pay_tbx.Location = new System.Drawing.Point(179, 272);
            this.pay_tbx.Name = "pay_tbx";
            this.pay_tbx.Size = new System.Drawing.Size(100, 20);
            this.pay_tbx.TabIndex = 7;
            // 
            // hours_tbx
            // 
            this.hours_tbx.Location = new System.Drawing.Point(179, 320);
            this.hours_tbx.Name = "hours_tbx";
            this.hours_tbx.Size = new System.Drawing.Size(100, 20);
            this.hours_tbx.TabIndex = 8;
            // 
            // tips_tbx
            // 
            this.tips_tbx.Location = new System.Drawing.Point(179, 372);
            this.tips_tbx.Name = "tips_tbx";
            this.tips_tbx.Size = new System.Drawing.Size(100, 20);
            this.tips_tbx.TabIndex = 9;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lbl.Location = new System.Drawing.Point(61, 133);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(22, 16);
            this.id_lbl.TabIndex = 10;
            this.id_lbl.Text = "ID";
            // 
            // emplID_lbl
            // 
            this.emplID_lbl.AutoSize = true;
            this.emplID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplID_lbl.Location = new System.Drawing.Point(298, 129);
            this.emplID_lbl.Name = "emplID_lbl";
            this.emplID_lbl.Size = new System.Drawing.Size(96, 16);
            this.emplID_lbl.TabIndex = 11;
            this.emplID_lbl.Text = "Employee ID";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(64, 194);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(48, 16);
            this.name_lbl.TabIndex = 12;
            this.name_lbl.Text = "Name";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(64, 231);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(51, 16);
            this.phone_lbl.TabIndex = 13;
            this.phone_lbl.Text = "Phone";
            // 
            // pay_lbl
            // 
            this.pay_lbl.AutoSize = true;
            this.pay_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_lbl.Location = new System.Drawing.Point(64, 276);
            this.pay_lbl.Name = "pay_lbl";
            this.pay_lbl.Size = new System.Drawing.Size(67, 16);
            this.pay_lbl.TabIndex = 14;
            this.pay_lbl.Text = "Payment";
            // 
            // hrz_lbl
            // 
            this.hrz_lbl.AutoSize = true;
            this.hrz_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrz_lbl.Location = new System.Drawing.Point(64, 324);
            this.hrz_lbl.Name = "hrz_lbl";
            this.hrz_lbl.Size = new System.Drawing.Size(48, 16);
            this.hrz_lbl.TabIndex = 15;
            this.hrz_lbl.Text = "Hours";
            // 
            // tips_lbl
            // 
            this.tips_lbl.AutoSize = true;
            this.tips_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tips_lbl.Location = new System.Drawing.Point(67, 376);
            this.tips_lbl.Name = "tips_lbl";
            this.tips_lbl.Size = new System.Drawing.Size(38, 16);
            this.tips_lbl.TabIndex = 16;
            this.tips_lbl.Text = "Tips";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(451, 407);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 17;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_btn.Location = new System.Drawing.Point(564, 407);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(75, 23);
            this.sub_btn.TabIndex = 18;
            this.sub_btn.Text = "Submit";
            this.sub_btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(688, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.tips_lbl);
            this.Controls.Add(this.hrz_lbl);
            this.Controls.Add(this.pay_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.emplID_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.tips_tbx);
            this.Controls.Add(this.hours_tbx);
            this.Controls.Add(this.pay_tbx);
            this.Controls.Add(this.phone_tbx);
            this.Controls.Add(this.name_tbx);
            this.Controls.Add(this.e_id_tbx);
            this.Controls.Add(this.id_tbx);
            this.Controls.Add(this.run_rd_btn);
            this.Controls.Add(this.W_rad_btn);
            this.Controls.Add(this.HW_rad_btn);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton HW_rad_btn;
        private System.Windows.Forms.RadioButton W_rad_btn;
        private System.Windows.Forms.RadioButton run_rd_btn;
        private System.Windows.Forms.TextBox id_tbx;
        private System.Windows.Forms.TextBox e_id_tbx;
        private System.Windows.Forms.TextBox name_tbx;
        private System.Windows.Forms.TextBox phone_tbx;
        private System.Windows.Forms.TextBox pay_tbx;
        private System.Windows.Forms.TextBox hours_tbx;
        private System.Windows.Forms.TextBox tips_tbx;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label emplID_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label pay_lbl;
        private System.Windows.Forms.Label hrz_lbl;
        private System.Windows.Forms.Label tips_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button button3;
    }
}