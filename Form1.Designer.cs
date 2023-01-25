
namespace PracticaHilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.personaje4 = new System.Windows.Forms.PictureBox();
            this.personaje3 = new System.Windows.Forms.PictureBox();
            this.personaje2 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.personaje1 = new System.Windows.Forms.PictureBox();
            this.personaje5 = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.pbGanador = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personaje4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // personaje4
            // 
            this.personaje4.BackColor = System.Drawing.Color.Transparent;
            this.personaje4.BackgroundImage = global::PracticaHilos.Properties.Resources.cheems1;
            this.personaje4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personaje4.Location = new System.Drawing.Point(49, 413);
            this.personaje4.Name = "personaje4";
            this.personaje4.Size = new System.Drawing.Size(97, 94);
            this.personaje4.TabIndex = 0;
            this.personaje4.TabStop = false;
            // 
            // personaje3
            // 
            this.personaje3.BackColor = System.Drawing.Color.Transparent;
            this.personaje3.BackgroundImage = global::PracticaHilos.Properties.Resources.shrek;
            this.personaje3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personaje3.Location = new System.Drawing.Point(39, 466);
            this.personaje3.Name = "personaje3";
            this.personaje3.Size = new System.Drawing.Size(94, 99);
            this.personaje3.TabIndex = 1;
            this.personaje3.TabStop = false;
            // 
            // personaje2
            // 
            this.personaje2.BackColor = System.Drawing.Color.Transparent;
            this.personaje2.BackgroundImage = global::PracticaHilos.Properties.Resources.mario;
            this.personaje2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personaje2.Location = new System.Drawing.Point(39, 513);
            this.personaje2.Name = "personaje2";
            this.personaje2.Size = new System.Drawing.Size(88, 90);
            this.personaje2.TabIndex = 2;
            this.personaje2.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.White;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnIniciar.FlatAppearance.BorderSize = 2;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnIniciar.Image = global::PracticaHilos.Properties.Resources.bullet__2_;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(397, 320);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(242, 86);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = " Iniciar";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // personaje1
            // 
            this.personaje1.BackColor = System.Drawing.Color.Transparent;
            this.personaje1.BackgroundImage = global::PracticaHilos.Properties.Resources.gary;
            this.personaje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personaje1.Location = new System.Drawing.Point(39, 591);
            this.personaje1.Name = "personaje1";
            this.personaje1.Size = new System.Drawing.Size(79, 60);
            this.personaje1.TabIndex = 4;
            this.personaje1.TabStop = false;
            // 
            // personaje5
            // 
            this.personaje5.BackColor = System.Drawing.Color.Transparent;
            this.personaje5.BackgroundImage = global::PracticaHilos.Properties.Resources.creeper;
            this.personaje5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personaje5.Location = new System.Drawing.Point(58, 352);
            this.personaje5.Name = "personaje5";
            this.personaje5.Size = new System.Drawing.Size(88, 108);
            this.personaje5.TabIndex = 5;
            this.personaje5.TabStop = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::PracticaHilos.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(73, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 6;
            this.btnPause.TabStop = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = global::PracticaHilos.Properties.Resources.restart;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Location = new System.Drawing.Point(12, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(50, 50);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.TabStop = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.BackColor = System.Drawing.Color.Transparent;
            this.lblGanador.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblGanador.Location = new System.Drawing.Point(317, 30);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(410, 117);
            this.lblGanador.TabIndex = 8;
            this.lblGanador.Text = "GANADOR";
            this.lblGanador.Visible = false;
            // 
            // pbGanador
            // 
            this.pbGanador.BackColor = System.Drawing.Color.Transparent;
            this.pbGanador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGanador.Location = new System.Drawing.Point(318, 138);
            this.pbGanador.Name = "pbGanador";
            this.pbGanador.Size = new System.Drawing.Size(422, 438);
            this.pbGanador.TabIndex = 9;
            this.pbGanador.TabStop = false;
            this.pbGanador.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAceptar.Location = new System.Drawing.Point(457, 591);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(134, 45);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PracticaHilos.Properties.Resources.fondocarrera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1088, 692);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbGanador);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.personaje1);
            this.Controls.Add(this.personaje2);
            this.Controls.Add(this.personaje3);
            this.Controls.Add(this.personaje4);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.personaje5);
            this.Controls.Add(this.btnIniciar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreritas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personaje4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaje5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox personaje4;
        private System.Windows.Forms.PictureBox personaje3;
        private System.Windows.Forms.PictureBox personaje2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox personaje1;
        private System.Windows.Forms.PictureBox personaje5;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.PictureBox pbGanador;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Timer timer1;
    }
}

