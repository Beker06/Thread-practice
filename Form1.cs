using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;

namespace PracticaHilos
{
    public partial class Form1 : Form
    {
        int pauseState;
        bool carrera = true;
        int p = 0;
        int a = 639;
        int b = 639;
        int c = 639;
        int d = 649;
        int e = 658;

        Stream Sonido;
        SoundPlayer player;


        Thread proceso_1;
        Thread proceso_2;
        Thread proceso_3;
        Thread proceso_4;
        Thread proceso_5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pauseState = 1;

            CheckForIllegalCrossThreadCalls = false;

            proceso_1 = new Thread(new ThreadStart(funcion_1));
            proceso_2 = new Thread(new ThreadStart(funcion_2));
            proceso_3 = new Thread(new ThreadStart(funcion_3));
            proceso_4 = new Thread(new ThreadStart(funcion_4));
            proceso_5 = new Thread(new ThreadStart(funcion_5));
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Sonido = PracticaHilos.Properties.Resources.Disparo;
            player = new SoundPlayer(Sonido);
            player.Play();
            proceso_1 = new Thread(new ThreadStart(funcion_1));
            proceso_2 = new Thread(new ThreadStart(funcion_2));
            proceso_3 = new Thread(new ThreadStart(funcion_3));
            proceso_4 = new Thread(new ThreadStart(funcion_4));
            proceso_5 = new Thread(new ThreadStart(funcion_5));

            timer1.Start();

            btnIniciar.Visible = false;
            btnRestart.Visible = true;
            btnPause.Visible = true;
            try
            {
                proceso_1.Start();
                proceso_2.Start();
                proceso_3.Start();
                proceso_4.Start();
                proceso_5.Start();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (pauseState == 1)
            {
                pauseState = 2;
                btnPause.BackgroundImage = PracticaHilos.Properties.Resources.play;
                Suspender();
            }
            else
            {
                pauseState = 1;
                btnPause.BackgroundImage = PracticaHilos.Properties.Resources.pause;
                Reanudar();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if(pauseState == 1)
            {
                proceso_1.Abort();
                proceso_2.Abort();
                proceso_3.Abort();
                proceso_4.Abort();
                proceso_5.Abort();

                CrearHilos();

                btnIniciar.Visible = true;
                btnRestart.Visible = false;
                btnPause.Visible = false;

                ReiniciarPersonajes();
            }
            else
            {
                Reanudar();

                proceso_1.Abort();
                proceso_2.Abort();
                proceso_3.Abort();
                proceso_4.Abort();
                proceso_5.Abort();

                CrearHilos();

                btnIniciar.Visible = true;
                btnRestart.Visible = false;
                btnPause.Visible = false;

                ReiniciarPersonajes();
            }
        }

        public void funcion_1()
        {
            while (true)
            {
                if (personaje1.Left <= a)
                {
                    Random r = new Random();
                    Thread.Sleep(r.Next(53, 300));
                    Random r2 = new Random();

                    personaje1.Left = personaje1.Left + r2.Next(2, 10);
                }
                else
                {
                    p = 1;
                    carrera = false;
                }
            }
        }

        public void funcion_2()
        {
            while (true)
            {
                if (personaje2.Left <= b)
                {
                    Random r = new Random();
                    Thread.Sleep(r.Next(53, 300));
                    Random r2 = new Random();

                    personaje2.Left = personaje2.Left + r2.Next(2, 10);
                }
                else
                {
                    p = 2;
                    carrera = false;
                }
            }
        }

        public void funcion_3()
        {
            while (true)
            {
                if (personaje3.Left <= c)
                {
                    Random r = new Random();
                    Thread.Sleep(r.Next(53, 300));
                    Random r2 = new Random();

                    personaje3.Left = personaje3.Left + r2.Next(2, 10);
                }
                else
                {
                    p = 3;
                    carrera = false;
                }
            }
        }

        public void funcion_4()
        {
            while (true)
            {
                if(personaje4.Left <= d)
                {
                    Random r = new Random();
                    Thread.Sleep(r.Next(53, 300));
                    Random r2 = new Random();

                    personaje4.Left = personaje4.Left + r2.Next(2, 10);
                }
                else 
                {
                    p = 4;
                    carrera = false;
                }
            }
        }

        public void funcion_5()
        {
            while (true)
            {
                if(personaje5.Left <= e)
                {
                    Random r = new Random();
                    Thread.Sleep(r.Next(53, 300));
                    Random r2 = new Random();

                    personaje5.Left = personaje5.Left + r2.Next(2, 10);
                }
                else
                {
                    p = 5;
                    carrera = false;
                }
            }
        }

        public void CrearHilos()
        {
            Thread proceso_1;
            Thread proceso_2;
            Thread proceso_3;
            Thread proceso_4;
            Thread proceso_5;
        }

        public void ReiniciarPersonajes()
        {
            personaje1.Left = 39;
            personaje2.Left = 39;
            personaje3.Left = 39;
            personaje4.Left = 49;
            personaje5.Left = 58;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            player.Stop();
            p = 0;
            carrera = true;

            lblGanador.Visible = false;
            pbGanador.Visible = false;
            btnAceptar.Visible = false;
            btnRestart.Visible = false;
            btnPause.Visible = false;
            btnIniciar.Visible = true;

            ReiniciarPersonajes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (carrera == false)
            {
                Suspender();
                Sonido = PracticaHilos.Properties.Resources.Ganador;
                player = new SoundPlayer(Sonido);
                player.Play();

                lblGanador.Visible = true;
                pbGanador.Visible = true;
                btnAceptar.Visible = true;
                btnRestart.Visible = false;
                btnPause.Visible = false;

                if (p == 1)
                {
                    pbGanador.BackgroundImage = PracticaHilos.Properties.Resources.gary;
                }
                else if(p == 2)
                {
                    pbGanador.BackgroundImage = PracticaHilos.Properties.Resources.mario;
                }
                else if (p == 3)
                {
                    pbGanador.BackgroundImage = PracticaHilos.Properties.Resources.shrek;
                }
                else if (p == 4)
                {
                    pbGanador.BackgroundImage = PracticaHilos.Properties.Resources.cheems1;
                }
                else if (p == 5)
                {
                    pbGanador.BackgroundImage = PracticaHilos.Properties.Resources.creeper;
                }

                timer1.Stop();
            }
        }

        public void Suspender()
        {
            proceso_1.Suspend();
            proceso_2.Suspend();
            proceso_3.Suspend();
            proceso_4.Suspend();
            proceso_5.Suspend();
        }

        public void Reanudar()
        {
            proceso_1.Resume();
            proceso_2.Resume();
            proceso_3.Resume();
            proceso_4.Resume();
            proceso_5.Resume();
        }
    }
}
