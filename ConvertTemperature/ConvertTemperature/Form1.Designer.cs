namespace ConvertTemperature
{
    partial class Form1
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
            this.rad_cel = new System.Windows.Forms.RadioButton();
            this.rad_kel = new System.Windows.Forms.RadioButton();
            this.rad_fah = new System.Windows.Forms.RadioButton();
            this.rad_tocel = new System.Windows.Forms.RadioButton();
            this.rad_tokel = new System.Windows.Forms.RadioButton();
            this.rad_tofah = new System.Windows.Forms.RadioButton();
            this.btn_convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_fnum = new System.Windows.Forms.TextBox();
            this.txtbox_lnum = new System.Windows.Forms.TextBox();
            this.grpbox_f = new System.Windows.Forms.GroupBox();
            this.grpbox_l = new System.Windows.Forms.GroupBox();
            this.grpbox_f.SuspendLayout();
            this.grpbox_l.SuspendLayout();
            this.SuspendLayout();
            // 
            // rad_cel
            // 
            this.rad_cel.AutoSize = true;
            this.rad_cel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_cel.Location = new System.Drawing.Point(91, 67);
            this.rad_cel.Name = "rad_cel";
            this.rad_cel.Size = new System.Drawing.Size(78, 24);
            this.rad_cel.TabIndex = 0;
            this.rad_cel.TabStop = true;
            this.rad_cel.Text = "Celsius";
            this.rad_cel.UseVisualStyleBackColor = true;
            // 
            // rad_kel
            // 
            this.rad_kel.AutoSize = true;
            this.rad_kel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_kel.Location = new System.Drawing.Point(91, 121);
            this.rad_kel.Name = "rad_kel";
            this.rad_kel.Size = new System.Drawing.Size(68, 24);
            this.rad_kel.TabIndex = 1;
            this.rad_kel.TabStop = true;
            this.rad_kel.Text = "Kelvin";
            this.rad_kel.UseVisualStyleBackColor = true;
            // 
            // rad_fah
            // 
            this.rad_fah.AutoSize = true;
            this.rad_fah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_fah.Location = new System.Drawing.Point(91, 176);
            this.rad_fah.Name = "rad_fah";
            this.rad_fah.Size = new System.Drawing.Size(122, 24);
            this.rad_fah.TabIndex = 2;
            this.rad_fah.TabStop = true;
            this.rad_fah.Text = "Fahrenheight";
            this.rad_fah.UseVisualStyleBackColor = true;
            // 
            // rad_tocel
            // 
            this.rad_tocel.AutoSize = true;
            this.rad_tocel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tocel.Location = new System.Drawing.Point(57, 67);
            this.rad_tocel.Name = "rad_tocel";
            this.rad_tocel.Size = new System.Drawing.Size(78, 24);
            this.rad_tocel.TabIndex = 3;
            this.rad_tocel.TabStop = true;
            this.rad_tocel.Text = "Celsius";
            this.rad_tocel.UseVisualStyleBackColor = true;
            // 
            // rad_tokel
            // 
            this.rad_tokel.AutoSize = true;
            this.rad_tokel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tokel.Location = new System.Drawing.Point(57, 121);
            this.rad_tokel.Name = "rad_tokel";
            this.rad_tokel.Size = new System.Drawing.Size(68, 24);
            this.rad_tokel.TabIndex = 4;
            this.rad_tokel.TabStop = true;
            this.rad_tokel.Text = "Kelvin";
            this.rad_tokel.UseVisualStyleBackColor = true;
            // 
            // rad_tofah
            // 
            this.rad_tofah.AutoSize = true;
            this.rad_tofah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_tofah.Location = new System.Drawing.Point(57, 176);
            this.rad_tofah.Name = "rad_tofah";
            this.rad_tofah.Size = new System.Drawing.Size(122, 24);
            this.rad_tofah.TabIndex = 5;
            this.rad_tofah.TabStop = true;
            this.rad_tofah.Text = "Fahrenheight";
            this.rad_tofah.UseVisualStyleBackColor = true;
            // 
            // btn_convert
            // 
            this.btn_convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.Location = new System.Drawing.Point(353, 345);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 40);
            this.btn_convert.TabIndex = 6;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.Btn_convert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "To";
            // 
            // txtbox_fnum
            // 
            this.txtbox_fnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_fnum.Location = new System.Drawing.Point(91, 240);
            this.txtbox_fnum.Name = "txtbox_fnum";
            this.txtbox_fnum.Size = new System.Drawing.Size(122, 26);
            this.txtbox_fnum.TabIndex = 10;
            // 
            // txtbox_lnum
            // 
            this.txtbox_lnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_lnum.Location = new System.Drawing.Point(57, 240);
            this.txtbox_lnum.Name = "txtbox_lnum";
            this.txtbox_lnum.Size = new System.Drawing.Size(122, 26);
            this.txtbox_lnum.TabIndex = 11;
            // 
            // grpbox_f
            // 
            this.grpbox_f.Controls.Add(this.rad_cel);
            this.grpbox_f.Controls.Add(this.rad_kel);
            this.grpbox_f.Controls.Add(this.txtbox_fnum);
            this.grpbox_f.Controls.Add(this.rad_fah);
            this.grpbox_f.Location = new System.Drawing.Point(12, 12);
            this.grpbox_f.Name = "grpbox_f";
            this.grpbox_f.Size = new System.Drawing.Size(345, 312);
            this.grpbox_f.TabIndex = 12;
            this.grpbox_f.TabStop = false;
            this.grpbox_f.Text = "TempFirst";
            // 
            // grpbox_l
            // 
            this.grpbox_l.Controls.Add(this.rad_tofah);
            this.grpbox_l.Controls.Add(this.rad_tocel);
            this.grpbox_l.Controls.Add(this.txtbox_lnum);
            this.grpbox_l.Controls.Add(this.rad_tokel);
            this.grpbox_l.Location = new System.Drawing.Point(425, 12);
            this.grpbox_l.Name = "grpbox_l";
            this.grpbox_l.Size = new System.Drawing.Size(345, 312);
            this.grpbox_l.TabIndex = 13;
            this.grpbox_l.TabStop = false;
            this.grpbox_l.Text = "TempLast";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbox_l);
            this.Controls.Add(this.grpbox_f);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpbox_f.ResumeLayout(false);
            this.grpbox_f.PerformLayout();
            this.grpbox_l.ResumeLayout(false);
            this.grpbox_l.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_cel;
        private System.Windows.Forms.RadioButton rad_kel;
        private System.Windows.Forms.RadioButton rad_fah;
        private System.Windows.Forms.RadioButton rad_tocel;
        private System.Windows.Forms.RadioButton rad_tokel;
        private System.Windows.Forms.RadioButton rad_tofah;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_fnum;
        private System.Windows.Forms.TextBox txtbox_lnum;
        private System.Windows.Forms.GroupBox grpbox_f;
        private System.Windows.Forms.GroupBox grpbox_l;
    }
}

