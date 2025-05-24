using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using trafic_light_Project.Properties;


namespace trafic_light_Project
{
    
    public partial class ctrlTraficLight: UserControl
    {
        public class LightOnEventArgs : EventArgs
        {
            public LightEnum CurrentLight { get; }
            public int Duration { get; }
            

            public LightOnEventArgs(LightEnum CurrentLight, int Duration)
            {
                this.CurrentLight = CurrentLight;
                this.Duration = Duration;
            }
        }

        public event EventHandler<LightOnEventArgs> OnRedLightOn;
        public void RaiseRedOnLightOn()
        {
            RaiseRedOnLightOn(new LightOnEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseRedOnLightOn(LightOnEventArgs e)
        {
            OnRedLightOn?.Invoke(this, e);
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////
        /// </summary>
        public event EventHandler<LightOnEventArgs> OnOrangeLightOn;
        public void RaiseOrangeOnLightOn()
        {
            RaiseOrangeOnLightOn(new LightOnEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeOnLightOn(LightOnEventArgs e)
        {
            OnOrangeLightOn?.Invoke(this, e);
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////
        /// </summary>
        public event EventHandler<LightOnEventArgs> OnGreenLightOn;
        public void RaiseGreenOnLightOn()
        {
            RaiseGreenOnLightOn(new LightOnEventArgs(LightEnum.Green, _GreenTime));
        }
        protected virtual void RaiseGreenOnLightOn(LightOnEventArgs e)
        {
            OnGreenLightOn?.Invoke(this, e);
        }







        public enum LightEnum { Red = 0, Orange = 1, Green = 2 }
        private LightEnum _CurrentLight = LightEnum.Red;
        public LightEnum CurrentLight
        {
            get { return _CurrentLight; }
            set
            {
                _CurrentLight = value;

                if(_CurrentLight == LightEnum.Red)
                {
                    pbTraficLight.Image = Resources.Red;
                    lblTimer.ForeColor = Color.Red;
                    lblTimer.Text = _RedTime.ToString();
                }
                else if(_CurrentLight == LightEnum.Orange)
                {
                    pbTraficLight.Image = Resources.Orange;
                    lblTimer.ForeColor = Color.Orange;
                    lblTimer.Text = _OrangeTime.ToString();
                }
                else
                {
                    pbTraficLight.Image = Resources.Green;
                    lblTimer.ForeColor = Color.Green;
                    lblTimer.Text = _GreenTime.ToString();
                }
            }
        }

        private int _RedTime;
        private int _OrangeTime;
        private int _GreenTime;

        public int RedTime
        {
            get { return _RedTime; }
            set
            {
                _RedTime = value;
            }
        }

        public int OrangeTime
        {
            get { return _OrangeTime; }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GreenTime
        {
            get { return _GreenTime; }
            set
            {
                _GreenTime = value;
            }
        }

        public int getCurrentTime()
        {
            if (_CurrentLight == LightEnum.Red)
                return _RedTime;
            else if (_CurrentLight == LightEnum.Orange)
                return _OrangeTime;
            else
                return _GreenTime;
        }

        private int _CurrentTime;
        public int CurrentTime
        {
            get { return _CurrentTime; }
            set { _CurrentTime = value; }
        }

        private LightEnum _PreviesLight;
        public void ChangeLight()
        {
            if(this.CurrentLight == LightEnum.Red || this.CurrentLight == LightEnum.Green)
            {
                _PreviesLight = this._CurrentLight;
                this.CurrentLight = LightEnum.Orange;
                _CurrentTime = getCurrentTime();

            }
            else
            {
                if (_PreviesLight == LightEnum.Green)
                    this.CurrentLight = LightEnum.Red;
                else
                    this.CurrentLight = LightEnum.Green;

                _CurrentTime = getCurrentTime();

            }

            switch(this.CurrentLight)
            {
                case LightEnum.Red:
                    RaiseRedOnLightOn();
                    break;
                case LightEnum.Orange:
                    RaiseOrangeOnLightOn();
                    break;
                case LightEnum.Green:
                    RaiseGreenOnLightOn();
                    break;
                default:
                    RaiseRedOnLightOn();
                    break;
            }
        }
        

        public ctrlTraficLight()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _CurrentTime--;
            lblTimer.Text = _CurrentTime.ToString();
            if(_CurrentTime == 0)
            {
                ChangeLight();
            }

        }

        private void ctrlTraficLight_Load(object sender, EventArgs e)
        {
            _CurrentTime = getCurrentTime();
        }

        public void StartTimer()
        {
            timer1.Start();
        }
        public void StopTimer()
        {
            timer1.Stop();
        }
    }
}
