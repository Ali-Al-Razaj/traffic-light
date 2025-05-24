namespace trafic_light_Project
{
    partial class ctrlTraficLight
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTraficLight = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTraficLight
            // 
            this.pbTraficLight.Image = global::trafic_light_Project.Properties.Resources.Red;
            this.pbTraficLight.Location = new System.Drawing.Point(3, 3);
            this.pbTraficLight.Name = "pbTraficLight";
            this.pbTraficLight.Size = new System.Drawing.Size(100, 231);
            this.pbTraficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTraficLight.TabIndex = 0;
            this.pbTraficLight.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(30, 237);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(32, 24);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "??";
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbTraficLight);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(104, 271);
            this.Load += new System.EventHandler(this.ctrlTraficLight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTraficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbTraficLight;
        private System.Windows.Forms.Label lblTimer;
    }
}
