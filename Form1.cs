using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafic_light_Project
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlTraficLight1.StartTimer();

            ctrlTraficLight2.RedTime = ctrlTraficLight1.GreenTime;
            ctrlTraficLight3.RedTime = ctrlTraficLight1.RedTime;
            ctrlTraficLight4.RedTime = ctrlTraficLight1.GreenTime;

            ctrlTraficLight2.OrangeTime = ctrlTraficLight1.OrangeTime;
            ctrlTraficLight3.OrangeTime = ctrlTraficLight1.OrangeTime;
            ctrlTraficLight4.OrangeTime = ctrlTraficLight1.OrangeTime;

            ctrlTraficLight2.GreenTime = ctrlTraficLight1.RedTime;
            ctrlTraficLight3.GreenTime = ctrlTraficLight1.GreenTime;
            ctrlTraficLight4.GreenTime = ctrlTraficLight1.RedTime;


        }

        private void ctrlTraficLight1_OnGreenLightOn(object sender, ctrlTraficLight.LightOnEventArgs e)
        {
            ctrlTraficLight2.CurrentLight = ctrlTraficLight.LightEnum.Red;
            ctrlTraficLight3.CurrentLight = ctrlTraficLight.LightEnum.Green;
            ctrlTraficLight4.CurrentLight = ctrlTraficLight.LightEnum.Red;

            
            ctrlTraficLight2.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight3.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight4.CurrentTime = ctrlTraficLight1.getCurrentTime();

            ctrlTraficLight2.StartTimer();
            ctrlTraficLight3.StartTimer();
            ctrlTraficLight4.StartTimer();
        }

        private void ctrlTraficLight1_OnOrangeLightOn(object sender, ctrlTraficLight.LightOnEventArgs e)
        {
            ctrlTraficLight2.CurrentLight = ctrlTraficLight.LightEnum.Orange;
            ctrlTraficLight3.CurrentLight = ctrlTraficLight.LightEnum.Orange;
            ctrlTraficLight4.CurrentLight = ctrlTraficLight.LightEnum.Orange;

            ctrlTraficLight2.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight3.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight4.CurrentTime = ctrlTraficLight1.getCurrentTime();

            ctrlTraficLight2.StartTimer();
            ctrlTraficLight3.StartTimer();
            ctrlTraficLight4.StartTimer();
        }

        private void ctrlTraficLight1_OnRedLightOn(object sender, ctrlTraficLight.LightOnEventArgs e)
        {
            ctrlTraficLight2.CurrentLight = ctrlTraficLight.LightEnum.Green;
            ctrlTraficLight3.CurrentLight = ctrlTraficLight.LightEnum.Red;
            ctrlTraficLight4.CurrentLight = ctrlTraficLight.LightEnum.Green;

            ctrlTraficLight2.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight3.CurrentTime = ctrlTraficLight1.getCurrentTime();
            ctrlTraficLight4.CurrentTime = ctrlTraficLight1.getCurrentTime();

            ctrlTraficLight2.StartTimer();
            ctrlTraficLight3.StartTimer();
            ctrlTraficLight4.StartTimer();
        }
    }
}
