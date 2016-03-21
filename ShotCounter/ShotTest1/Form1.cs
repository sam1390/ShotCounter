using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HockeyEditor;

namespace ShotTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MemoryEditor.Init(false);
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static int ShotCounterR = 0, ShotCounterB = 0;
        static Boolean shot = false;
        static float Posx=0, Posy=0, Posz=0;
        static Boolean wrote = false;

        static string Puckonnet()
        {
            float Velx = Puck.Position.X - Posx;
            float Vely = Puck.Position.Y - Posy;
            float Velz = Puck.Position.Z - Posz;
            Posx = Puck.Position.X;
            Posy = Puck.Position.Y;
            Posz = Puck.Position.Z;

            float Time = 0, x = 0, y = 0;
            String ShotOnNet = "false";
            int red = 0;
            if (Velz < 0)
            {
                Time = (4 - Puck.Position.Z) / Velz;
                red = 1; // blue
            }

            if (Velz > 0)
            {
                Time = (57 - Puck.Position.Z) / Velz;
                red = 2; // red
            }


            x = Puck.Position.X + Velx * Time;
            y = Puck.Position.Y + Vely * Time;
            if (x > 13.65 && x < 16.35 && red == 1) // blue
            {
                if (y < .85)
                {
                    ShotOnNet = "true";
                    if (Puck.Position.Z < 8 && Puck.Position.Z > 3 && Puck.Position.X < 19 && Puck.Position.X > 11)
                    {
                        if (shot == false && GameInfo.GameTime > 0 && GameInfo.StopTime == 0)
                        {
                            ShotCounterB++;
                            shot = true;
                        }
                    }
                }
            }
            else if (x > 13.65 && x < 16.35 && red == 2) // red
            {
                if (y < .85)
                {
                    ShotOnNet = "true";
                    if (Puck.Position.Z > 53 && Puck.Position.Z < 58 && Puck.Position.X < 19 && Puck.Position.X > 11)
                    {
                        if (shot == false && GameInfo.GameTime > 0 && GameInfo.StopTime == 0)
                        {
                            ShotCounterR++;
                            shot = true;
                        }
                    }
                }
            }
            else
            {
                ShotOnNet = "False";
                shot = false;
            }
            
                return ShotOnNet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PuckPos.Text = "PuckPos: " + (string)Puck.Position.ToString();
            PuckVel.Text = "GameTime: " + PlayerManager.LocalPlayer.StickPosition;
            Slope.Text = "Shot On Net: " + Puckonnet();
            Shots.Text = "Blue Shots: " + ShotCounterR;
            Shot2.Text = "Red Shots: " + ShotCounterB;
            if (GameInfo.Period == 0)
            {
                ShotCounterB = 0;
                ShotCounterR = 0;
                wrote = false;
            }
            if (GameInfo.GameOver == 1 && wrote == false)
            {
                Writer write = new Writer();
                write.WriteFile("Red Shots: " + ShotCounterR + " Blue Shots: " + ShotCounterB);
                wrote = true;
            }
        }




    }
}
