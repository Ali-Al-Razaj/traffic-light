namespace trafic_light_Project
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
            this.ctrlTraficLight1 = new trafic_light_Project.ctrlTraficLight();
            this.ctrlTraficLight2 = new trafic_light_Project.ctrlTraficLight();
            this.ctrlTraficLight3 = new trafic_light_Project.ctrlTraficLight();
            this.ctrlTraficLight4 = new trafic_light_Project.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.CurrentLight = trafic_light_Project.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight1.CurrentTime = 5;
            this.ctrlTraficLight1.GreenTime = 4;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(12, 12);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.OrangeTime = 3;
            this.ctrlTraficLight1.RedTime = 2;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(104, 271);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.OnRedLightOn += new System.EventHandler<trafic_light_Project.ctrlTraficLight.LightOnEventArgs>(this.ctrlTraficLight1_OnRedLightOn);
            this.ctrlTraficLight1.OnOrangeLightOn += new System.EventHandler<trafic_light_Project.ctrlTraficLight.LightOnEventArgs>(this.ctrlTraficLight1_OnOrangeLightOn);
            this.ctrlTraficLight1.OnGreenLightOn += new System.EventHandler<trafic_light_Project.ctrlTraficLight.LightOnEventArgs>(this.ctrlTraficLight1_OnGreenLightOn);
            // 
            // ctrlTraficLight2
            // 
            this.ctrlTraficLight2.CurrentLight = trafic_light_Project.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight2.CurrentTime = 10;
            this.ctrlTraficLight2.GreenTime = 7;
            this.ctrlTraficLight2.Location = new System.Drawing.Point(122, 12);
            this.ctrlTraficLight2.Name = "ctrlTraficLight2";
            this.ctrlTraficLight2.OrangeTime = 5;
            this.ctrlTraficLight2.RedTime = 10;
            this.ctrlTraficLight2.Size = new System.Drawing.Size(104, 271);
            this.ctrlTraficLight2.TabIndex = 1;
            // 
            // ctrlTraficLight3
            // 
            this.ctrlTraficLight3.CurrentLight = trafic_light_Project.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight3.CurrentTime = 10;
            this.ctrlTraficLight3.GreenTime = 7;
            this.ctrlTraficLight3.Location = new System.Drawing.Point(232, 12);
            this.ctrlTraficLight3.Name = "ctrlTraficLight3";
            this.ctrlTraficLight3.OrangeTime = 5;
            this.ctrlTraficLight3.RedTime = 10;
            this.ctrlTraficLight3.Size = new System.Drawing.Size(104, 271);
            this.ctrlTraficLight3.TabIndex = 2;
            // 
            // ctrlTraficLight4
            // 
            this.ctrlTraficLight4.CurrentLight = trafic_light_Project.ctrlTraficLight.LightEnum.Red;
            this.ctrlTraficLight4.CurrentTime = 10;
            this.ctrlTraficLight4.GreenTime = 7;
            this.ctrlTraficLight4.Location = new System.Drawing.Point(342, 12);
            this.ctrlTraficLight4.Name = "ctrlTraficLight4";
            this.ctrlTraficLight4.OrangeTime = 5;
            this.ctrlTraficLight4.RedTime = 10;
            this.ctrlTraficLight4.Size = new System.Drawing.Size(104, 271);
            this.ctrlTraficLight4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.ctrlTraficLight4);
            this.Controls.Add(this.ctrlTraficLight3);
            this.Controls.Add(this.ctrlTraficLight2);
            this.Controls.Add(this.ctrlTraficLight1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trafic light";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
        private ctrlTraficLight ctrlTraficLight2;
        private ctrlTraficLight ctrlTraficLight3;
        private ctrlTraficLight ctrlTraficLight4;
    }
}

