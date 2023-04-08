namespace SerialComm
{
    partial class SerialComm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialComm));
            this.informacniRadek = new System.Windows.Forms.TextBox();
            this.dtr_zapnuto = new System.Windows.Forms.RadioButton();
            this.dtr_vypnuto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rts_zapnuto = new System.Windows.Forms.RadioButton();
            this.rts_vypnuto = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.par_licha = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.par_zadna = new System.Windows.Forms.RadioButton();
            this.par_suda = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hs_zapnuto = new System.Windows.Forms.RadioButton();
            this.hs_vypnuto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.porty = new System.Windows.Forms.ComboBox();
            this.rychlosti = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pripojit = new System.Windows.Forms.Button();
            this.odpojit = new System.Windows.Forms.Button();
            this.odesilaciRadek = new System.Windows.Forms.TextBox();
            this.vycistit = new System.Windows.Forms.Button();
            this.autoscroll = new System.Windows.Forms.CheckBox();
            this.vstup = new System.Windows.Forms.TextBox();
            this.poslat = new System.Windows.Forms.Button();
            this.newlinePovolen = new System.Windows.Forms.CheckBox();
            this.jeOtevren = new System.Windows.Forms.Label();
            this.jeZavren = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // informacniRadek
            // 
            this.informacniRadek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informacniRadek.Location = new System.Drawing.Point(12, 12);
            this.informacniRadek.Name = "informacniRadek";
            this.informacniRadek.ReadOnly = true;
            this.informacniRadek.Size = new System.Drawing.Size(960, 38);
            this.informacniRadek.TabIndex = 0;
            // 
            // dtr_zapnuto
            // 
            this.dtr_zapnuto.AutoSize = true;
            this.dtr_zapnuto.Location = new System.Drawing.Point(6, 23);
            this.dtr_zapnuto.Name = "dtr_zapnuto";
            this.dtr_zapnuto.Size = new System.Drawing.Size(63, 17);
            this.dtr_zapnuto.TabIndex = 1;
            this.dtr_zapnuto.TabStop = true;
            this.dtr_zapnuto.Text = "zapnuto";
            this.dtr_zapnuto.UseVisualStyleBackColor = true;
            // 
            // dtr_vypnuto
            // 
            this.dtr_vypnuto.AutoSize = true;
            this.dtr_vypnuto.Location = new System.Drawing.Point(6, 46);
            this.dtr_vypnuto.Name = "dtr_vypnuto";
            this.dtr_vypnuto.Size = new System.Drawing.Size(63, 17);
            this.dtr_vypnuto.TabIndex = 2;
            this.dtr_vypnuto.TabStop = true;
            this.dtr_vypnuto.Text = "vypnuto";
            this.dtr_vypnuto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DTR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtr_zapnuto);
            this.groupBox1.Controls.Add(this.dtr_vypnuto);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rts_zapnuto);
            this.groupBox2.Controls.Add(this.rts_vypnuto);
            this.groupBox2.Location = new System.Drawing.Point(105, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(87, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RTS";
            // 
            // rts_zapnuto
            // 
            this.rts_zapnuto.AutoSize = true;
            this.rts_zapnuto.Location = new System.Drawing.Point(6, 23);
            this.rts_zapnuto.Name = "rts_zapnuto";
            this.rts_zapnuto.Size = new System.Drawing.Size(63, 17);
            this.rts_zapnuto.TabIndex = 1;
            this.rts_zapnuto.TabStop = true;
            this.rts_zapnuto.Text = "zapnuto";
            this.rts_zapnuto.UseVisualStyleBackColor = true;
            // 
            // rts_vypnuto
            // 
            this.rts_vypnuto.AutoSize = true;
            this.rts_vypnuto.Location = new System.Drawing.Point(6, 46);
            this.rts_vypnuto.Name = "rts_vypnuto";
            this.rts_vypnuto.Size = new System.Drawing.Size(63, 17);
            this.rts_vypnuto.TabIndex = 2;
            this.rts_vypnuto.TabStop = true;
            this.rts_vypnuto.Text = "vypnuto";
            this.rts_vypnuto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.par_licha);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.par_zadna);
            this.groupBox3.Controls.Add(this.par_suda);
            this.groupBox3.Location = new System.Drawing.Point(198, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(80, 92);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // par_licha
            // 
            this.par_licha.AutoSize = true;
            this.par_licha.Location = new System.Drawing.Point(6, 69);
            this.par_licha.Name = "par_licha";
            this.par_licha.Size = new System.Drawing.Size(47, 17);
            this.par_licha.TabIndex = 4;
            this.par_licha.TabStop = true;
            this.par_licha.Text = "lichá";
            this.par_licha.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PARITA";
            // 
            // par_zadna
            // 
            this.par_zadna.AutoSize = true;
            this.par_zadna.Location = new System.Drawing.Point(6, 23);
            this.par_zadna.Name = "par_zadna";
            this.par_zadna.Size = new System.Drawing.Size(54, 17);
            this.par_zadna.TabIndex = 1;
            this.par_zadna.TabStop = true;
            this.par_zadna.Text = "žádná";
            this.par_zadna.UseVisualStyleBackColor = true;
            // 
            // par_suda
            // 
            this.par_suda.AutoSize = true;
            this.par_suda.Location = new System.Drawing.Point(6, 46);
            this.par_suda.Name = "par_suda";
            this.par_suda.Size = new System.Drawing.Size(48, 17);
            this.par_suda.TabIndex = 2;
            this.par_suda.TabStop = true;
            this.par_suda.Text = "sudá";
            this.par_suda.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.hs_zapnuto);
            this.groupBox4.Controls.Add(this.hs_vypnuto);
            this.groupBox4.Location = new System.Drawing.Point(284, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 68);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "HANSHAKE";
            // 
            // hs_zapnuto
            // 
            this.hs_zapnuto.AutoSize = true;
            this.hs_zapnuto.Location = new System.Drawing.Point(6, 23);
            this.hs_zapnuto.Name = "hs_zapnuto";
            this.hs_zapnuto.Size = new System.Drawing.Size(63, 17);
            this.hs_zapnuto.TabIndex = 1;
            this.hs_zapnuto.TabStop = true;
            this.hs_zapnuto.Text = "zapnuto";
            this.hs_zapnuto.UseVisualStyleBackColor = true;
            // 
            // hs_vypnuto
            // 
            this.hs_vypnuto.AutoSize = true;
            this.hs_vypnuto.Location = new System.Drawing.Point(6, 46);
            this.hs_vypnuto.Name = "hs_vypnuto";
            this.hs_vypnuto.Size = new System.Drawing.Size(63, 17);
            this.hs_vypnuto.TabIndex = 2;
            this.hs_vypnuto.TabStop = true;
            this.hs_vypnuto.Text = "vypnuto";
            this.hs_vypnuto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(434, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "PORT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // porty
            // 
            this.porty.AllowDrop = true;
            this.porty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.porty.FormattingEnabled = true;
            this.porty.Location = new System.Drawing.Point(404, 79);
            this.porty.Name = "porty";
            this.porty.Size = new System.Drawing.Size(121, 24);
            this.porty.Sorted = true;
            this.porty.TabIndex = 7;
            this.porty.DropDown += new System.EventHandler(this.porty_DropDown);
            this.porty.SelectedIndexChanged += new System.EventHandler(this.porty_SelectedIndexChanged);
            // 
            // rychlosti
            // 
            this.rychlosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rychlosti.FormattingEnabled = true;
            this.rychlosti.Location = new System.Drawing.Point(543, 79);
            this.rychlosti.Name = "rychlosti";
            this.rychlosti.Size = new System.Drawing.Size(121, 24);
            this.rychlosti.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(551, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "RYCHLOST";
            // 
            // pripojit
            // 
            this.pripojit.BackColor = System.Drawing.Color.LightGreen;
            this.pripojit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pripojit.Location = new System.Drawing.Point(688, 56);
            this.pripojit.Name = "pripojit";
            this.pripojit.Size = new System.Drawing.Size(109, 80);
            this.pripojit.TabIndex = 10;
            this.pripojit.Text = "PŘIPOJIT";
            this.pripojit.UseVisualStyleBackColor = false;
            this.pripojit.Click += new System.EventHandler(this.pripojit_Click);
            // 
            // odpojit
            // 
            this.odpojit.BackColor = System.Drawing.Color.LightCoral;
            this.odpojit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odpojit.Location = new System.Drawing.Point(832, 56);
            this.odpojit.Name = "odpojit";
            this.odpojit.Size = new System.Drawing.Size(109, 80);
            this.odpojit.TabIndex = 11;
            this.odpojit.Text = "ODPOJIT";
            this.odpojit.UseVisualStyleBackColor = false;
            this.odpojit.Click += new System.EventHandler(this.odpojit_Click);
            // 
            // odesilaciRadek
            // 
            this.odesilaciRadek.AcceptsTab = true;
            this.odesilaciRadek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odesilaciRadek.Location = new System.Drawing.Point(12, 154);
            this.odesilaciRadek.MaxLength = 256;
            this.odesilaciRadek.Name = "odesilaciRadek";
            this.odesilaciRadek.Size = new System.Drawing.Size(836, 38);
            this.odesilaciRadek.TabIndex = 12;
            this.odesilaciRadek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.odesilaciRadek_KeyPress);
            // 
            // vycistit
            // 
            this.vycistit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vycistit.Location = new System.Drawing.Point(12, 726);
            this.vycistit.Name = "vycistit";
            this.vycistit.Size = new System.Drawing.Size(75, 23);
            this.vycistit.TabIndex = 13;
            this.vycistit.Text = "vyčistit";
            this.vycistit.UseVisualStyleBackColor = true;
            this.vycistit.Click += new System.EventHandler(this.vycistit_Click);
            // 
            // autoscroll
            // 
            this.autoscroll.AutoSize = true;
            this.autoscroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoscroll.Location = new System.Drawing.Point(115, 728);
            this.autoscroll.Name = "autoscroll";
            this.autoscroll.Size = new System.Drawing.Size(186, 20);
            this.autoscroll.TabIndex = 14;
            this.autoscroll.Text = "automatické skrolování";
            this.autoscroll.UseVisualStyleBackColor = true;
            this.autoscroll.CheckedChanged += new System.EventHandler(this.autoscroll_CheckedChanged);
            // 
            // vstup
            // 
            this.vstup.BackColor = System.Drawing.Color.PowderBlue;
            this.vstup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vstup.Location = new System.Drawing.Point(12, 217);
            this.vstup.Multiline = true;
            this.vstup.Name = "vstup";
            this.vstup.ReadOnly = true;
            this.vstup.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.vstup.Size = new System.Drawing.Size(960, 492);
            this.vstup.TabIndex = 15;
            // 
            // poslat
            // 
            this.poslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poslat.Location = new System.Drawing.Point(854, 154);
            this.poslat.Name = "poslat";
            this.poslat.Size = new System.Drawing.Size(118, 38);
            this.poslat.TabIndex = 16;
            this.poslat.Text = "POSLAT";
            this.poslat.UseVisualStyleBackColor = true;
            this.poslat.Click += new System.EventHandler(this.poslat_Click);
            // 
            // newlinePovolen
            // 
            this.newlinePovolen.AutoSize = true;
            this.newlinePovolen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newlinePovolen.Location = new System.Drawing.Point(339, 728);
            this.newlinePovolen.Name = "newlinePovolen";
            this.newlinePovolen.Size = new System.Drawing.Size(241, 20);
            this.newlinePovolen.TabIndex = 17;
            this.newlinePovolen.Text = "automaticky odesílat \"new line\"";
            this.newlinePovolen.UseVisualStyleBackColor = true;
            // 
            // jeOtevren
            // 
            this.jeOtevren.AutoSize = true;
            this.jeOtevren.BackColor = System.Drawing.SystemColors.Control;
            this.jeOtevren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jeOtevren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jeOtevren.ForeColor = System.Drawing.Color.Lime;
            this.jeOtevren.Location = new System.Drawing.Point(688, 722);
            this.jeOtevren.Name = "jeOtevren";
            this.jeOtevren.Size = new System.Drawing.Size(204, 26);
            this.jeOtevren.TabIndex = 18;
            this.jeOtevren.Text = "PORT JE OTEVŘEN";
            // 
            // jeZavren
            // 
            this.jeZavren.AutoSize = true;
            this.jeZavren.BackColor = System.Drawing.SystemColors.Control;
            this.jeZavren.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.jeZavren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jeZavren.ForeColor = System.Drawing.Color.Red;
            this.jeZavren.Location = new System.Drawing.Point(688, 722);
            this.jeZavren.Name = "jeZavren";
            this.jeZavren.Size = new System.Drawing.Size(188, 26);
            this.jeZavren.TabIndex = 19;
            this.jeZavren.Text = "PORT JE ZAVŘEN";
            // 
            // SerialComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.jeZavren);
            this.Controls.Add(this.jeOtevren);
            this.Controls.Add(this.newlinePovolen);
            this.Controls.Add(this.poslat);
            this.Controls.Add(this.vstup);
            this.Controls.Add(this.autoscroll);
            this.Controls.Add(this.vycistit);
            this.Controls.Add(this.odesilaciRadek);
            this.Controls.Add(this.odpojit);
            this.Controls.Add(this.pripojit);
            this.Controls.Add(this.rychlosti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.porty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.informacniRadek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "SerialComm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SerialComm";
            this.Load += new System.EventHandler(this.SerialComm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox informacniRadek;
        private System.Windows.Forms.RadioButton dtr_zapnuto;
        private System.Windows.Forms.RadioButton dtr_vypnuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rts_zapnuto;
        private System.Windows.Forms.RadioButton rts_vypnuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton par_licha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton par_zadna;
        private System.Windows.Forms.RadioButton par_suda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton hs_zapnuto;
        private System.Windows.Forms.RadioButton hs_vypnuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox porty;
        private System.Windows.Forms.ComboBox rychlosti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button pripojit;
        private System.Windows.Forms.Button odpojit;
        private System.Windows.Forms.TextBox odesilaciRadek;
        private System.Windows.Forms.Button vycistit;
        private System.Windows.Forms.CheckBox autoscroll;
        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.Button poslat;
        private System.Windows.Forms.CheckBox newlinePovolen;
        private System.Windows.Forms.Label jeOtevren;
        private System.Windows.Forms.Label jeZavren;
    }
}

