namespace CinemaProject.CinemaUser
{
    partial class MovieShowPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblNameContext = new System.Windows.Forms.Label();
            this.pictrureBoxFilm = new System.Windows.Forms.PictureBox();
            this.lblDescriptionContext = new System.Windows.Forms.Label();
            this.lblDurationContext = new System.Windows.Forms.Label();
            this.flowPanelBooking = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictrureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(176, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(176, 57);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(347, 57);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(55, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration";
            // 
            // lblNameContext
            // 
            this.lblNameContext.AutoSize = true;
            this.lblNameContext.Location = new System.Drawing.Point(235, 16);
            this.lblNameContext.Name = "lblNameContext";
            this.lblNameContext.Size = new System.Drawing.Size(81, 13);
            this.lblNameContext.TabIndex = 4;
            this.lblNameContext.Text = "lblNameContext";
            // 
            // pictrureBoxFilm
            // 
            this.pictrureBoxFilm.Location = new System.Drawing.Point(20, 16);
            this.pictrureBoxFilm.Name = "pictrureBoxFilm";
            this.pictrureBoxFilm.Size = new System.Drawing.Size(150, 225);
            this.pictrureBoxFilm.TabIndex = 5;
            this.pictrureBoxFilm.TabStop = false;
            // 
            // lblDescriptionContext
            // 
            this.lblDescriptionContext.Location = new System.Drawing.Point(180, 80);
            this.lblDescriptionContext.Name = "lblDescriptionContext";
            this.lblDescriptionContext.Size = new System.Drawing.Size(420, 90);
            this.lblDescriptionContext.TabIndex = 6;
            this.lblDescriptionContext.Text = "label2";
            // 
            // lblDurationContext
            // 
            this.lblDurationContext.AutoSize = true;
            this.lblDurationContext.Location = new System.Drawing.Point(421, 57);
            this.lblDurationContext.Name = "lblDurationContext";
            this.lblDurationContext.Size = new System.Drawing.Size(35, 13);
            this.lblDurationContext.TabIndex = 7;
            this.lblDurationContext.Text = "label3";
            // 
            // flowPanelBooking
            // 
            this.flowPanelBooking.Location = new System.Drawing.Point(183, 173);
            this.flowPanelBooking.Name = "flowPanelBooking";
            this.flowPanelBooking.Size = new System.Drawing.Size(403, 68);
            this.flowPanelBooking.TabIndex = 8;
            // 
            // MovieShowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flowPanelBooking);
            this.Controls.Add(this.lblDurationContext);
            this.Controls.Add(this.lblDescriptionContext);
            this.Controls.Add(this.pictrureBoxFilm);
            this.Controls.Add(this.lblNameContext);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "MovieShowPanel";
            this.Size = new System.Drawing.Size(603, 262);
            ((System.ComponentModel.ISupportInitialize)(this.pictrureBoxFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblNameContext;
        private System.Windows.Forms.PictureBox pictrureBoxFilm;
        private System.Windows.Forms.Label lblDescriptionContext;
        private System.Windows.Forms.Label lblDurationContext;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBooking;
    }
}
