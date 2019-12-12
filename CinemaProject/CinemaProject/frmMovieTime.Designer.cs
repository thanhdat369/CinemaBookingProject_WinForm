namespace CinemaProject
{
    partial class frmMovieTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.dtpkEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpkStartTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Time";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(16, 209);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbRoom);
            this.panel1.Controls.Add(this.cmbMovie);
            this.panel1.Controls.Add(this.dtpkEndTime);
            this.panel1.Controls.Add(this.dtpkStartTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpkDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(29, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 289);
            this.panel1.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(108, 206);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbRoom.TabIndex = 9;
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(108, 16);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(121, 21);
            this.cmbMovie.TabIndex = 8;
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.CmbMovie_SelectedIndexChanged);
            // 
            // dtpkEndTime
            // 
            this.dtpkEndTime.CustomFormat = "HH:mm";
            this.dtpkEndTime.Enabled = false;
            this.dtpkEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkEndTime.Location = new System.Drawing.Point(108, 155);
            this.dtpkEndTime.Name = "dtpkEndTime";
            this.dtpkEndTime.ShowUpDown = true;
            this.dtpkEndTime.Size = new System.Drawing.Size(88, 20);
            this.dtpkEndTime.TabIndex = 7;
            this.dtpkEndTime.ValueChanged += new System.EventHandler(this.DtpkDate_ValueChanged);
            // 
            // dtpkStartTime
            // 
            this.dtpkStartTime.CustomFormat = "HH:mm";
            this.dtpkStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkStartTime.Location = new System.Drawing.Point(108, 116);
            this.dtpkStartTime.Name = "dtpkStartTime";
            this.dtpkStartTime.ShowUpDown = true;
            this.dtpkStartTime.Size = new System.Drawing.Size(88, 20);
            this.dtpkStartTime.TabIndex = 6;
            this.dtpkStartTime.ValueChanged += new System.EventHandler(this.DtpkDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CustomFormat = "";
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDate.Location = new System.Drawing.Point(108, 69);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(88, 20);
            this.dtpkDate.TabIndex = 4;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.DtpkDate_ValueChanged);
            // 
            // frmMovieTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmMovieTime";
            this.Text = "frmMovieTime";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.DateTimePicker dtpkStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.DateTimePicker dtpkEndTime;
    }
}