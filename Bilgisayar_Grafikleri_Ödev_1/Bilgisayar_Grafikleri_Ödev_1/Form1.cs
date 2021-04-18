using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Bilgisayar_Grafikleri_Ödev_1
{
    public partial class Form1 : Form
    {
        float x = 0;
        float y = 0;
        float z = 0;
        float w = 0;
        float q = 0;
        float t = 0;
        float p = 0;
        float r = 0;

        public Form1()
        {
            InitializeComponent();
            OpenGlControl.InitializeContexts();
            //OpenGl ilk işlemler
            Gl.glClearColor(0.1f, 0.2f, 0.2f, 1.0f); //Ekranı mavi bir renk ile sileceğim demek
            Gl.glMatrixMode(Gl.GL_PROJECTION); //Projeksiyon matriksine geçip
            Gl.glLoadIdentity(); //Projeksiyon matriksini LoadIdentity ile sıfırlıyorum
            Gl.glOrtho(0.0, 1.0, 0.0, 1.0, -1.0, 1.0); //Sonra da böyle bir projeksiyon görüntüsü, kamera kullandırıyorum.x sıfırdan bire, y sıfırdan bire, z eksi birden bire değişecek diye ilk değerleri atamış olduk
            /*Projeksiyon matriksini "Gl.glMatrixMode(Gl.GL_PROJECTION);" böyle doldurduktan sonra
             *onu hemen model matriksine dönüştürmek lazım aslında. Ya da drow(sanırım öyle dedi)
             *kısmını ona muhakkak çeviriyoruz. Projeksiyon matriksinde bırakmayın */
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(x, 0, 0, 1);
            Gl.glTranslatef(-0.5f, -0.5f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(1.0f, 0.5f, 0.7f);
            Gl.glVertex3f(0.010f, 0.65f, 0.0f);//3
            Gl.glColor3f(0.4f, 0.8f, 0.2f);
            Gl.glVertex3f(0.23f, 0.65f, 0.0f);//4                     //Kare
            Gl.glColor3f(0.3f, 0.9f, 0.5f);
            Gl.glVertex3f(0.23f, 0.98f, 0.0f);//2
            Gl.glColor3f(1.0f, 0.6f, 0.5f);
            Gl.glVertex3f(0.010f, 0.98f, 0.0f);//1
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.2f, 0.3f, 0);
            Gl.glRotatef(y, 0, 0, 1);
            Gl.glTranslatef(-0.22f, -0.4f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);                            //Altıgen
            Gl.glColor3f(0.9f, 0.4f, 0.3f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(0.3f, 0.8f, 0.0f);
            Gl.glColor3f(0.6f, 1.4f, 0.3f);
            Gl.glVertex3f(0.15f, 0.80f, 0.0f);
            Gl.glColor3f(1.9f, 0.4f, 1.3f);
            Gl.glVertex3f(0.10f, 0.6f, 0.0f);
            Gl.glColor3f(0.1f, 1.4f, 3.3f);
            Gl.glVertex3f(0.15f, 0.4f, 0.0f);
            Gl.glColor3f(0.9f, 0.0f, 2.3f);
            Gl.glVertex3f(0.3f, 0.40f, 0.0f);
            Gl.glColor3f(1.5f, 0.6f, 0.3f);
            Gl.glVertex3f(0.36f, 0.60f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(z, 0, 0, 1);
            Gl.glTranslatef(-0.3f, -0.3f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(2.0f, 0.0f, 0.0f);
            Gl.glVertex3f(-0.08f, -0.18f, 0.0f);                     //Beşgen
            Gl.glColor3f(1.0f, 1.2f, 3.6f);
            Gl.glVertex3f(0.18f, -0.18f, 0.0f);
            Gl.glColor3f(2.7f, 0.3f, 5.5f);
            Gl.glVertex3f(0.12f, 0.15f, 0.0f);
            Gl.glColor3f(0.1f, 0.0f, 0.8f);
            Gl.glVertex3f(-0.03f, 0.15f, 0.0f);//
            Gl.glColor3f(0.0f, 0.6f, 0.7f);
            Gl.glVertex3f(0.30f, -0.9f, 0.0f);
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(w, 0, 0, 1);
            Gl.glTranslatef(-0.5f, -0.5f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0.8f, 0.4f, 0.3f);
            Gl.glVertex3f(0.45f, 0.60f, 0.0f);//2
            Gl.glColor3f(0.2f, 1.0f, 0.6f);
            Gl.glVertex3f(0.6f, 0.95f, 0.0f);//3 vb                //İlk Üçgen
            Gl.glColor3f(0.8f, 0.4f, 0.6f);
            Gl.glVertex3f(0.30f, 0.85f, 0.0f);//1
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(q, 0, 0, 1);
            Gl.glTranslatef(-0.5f, -0.5f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3f(0.8f, 1.0f, 0.9f);
            Gl.glVertex3f(0.55f, 0.79f, 0.0f);//2
            Gl.glColor3f(0.2f, 0.9f, 0.9f);
            Gl.glVertex3f(0.68f, 0.53f, 0.0f);//3 vb                //İkinci Üçgen
            Gl.glColor3f(0.4f, 0.4f, 0.9f);
            Gl.glVertex3f(0.39f, 0.40f, 0.0f);//1
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(t, 0, 0, 1);
            Gl.glTranslatef(-0.5f, -0.5f, 0);
            Gl.glColor3f(122.0f, 0.0f, 0.0f);                       //Kırmızı Çizgi
            Gl.glLineWidth(10);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(0.95f, 1.0f);
            Gl.glVertex2f(0.95f, -0.80f);
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0.5f, 0.5f, 0);
            Gl.glRotatef(p, 0, 0, 1);
            Gl.glTranslatef(-0.3f, -0.3f, 0);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glColor3f(0.8f, 1.0f, 0.5f);
            Gl.glVertex2f(0.70f, -0.080f);                          //Paralelkenar
            Gl.glColor3f(0.2f, 1.0f, 0.4f);
            Gl.glVertex2f(0.6f, 0.060f);
            Gl.glColor3f(1.0f, 0.6f, 0.0f);
            Gl.glVertex2f(0.2f, 0.060f);
            Gl.glColor3f(0.8f, 1.0f, 0.2f);
            Gl.glVertex2f(0.30f, -0.080f);
            Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(1.0f, 0.8f, 0);
            Gl.glRotatef(r, 0, 0, 1);
            Gl.glTranslatef(-0.22f, -0.01f, 0);                               //Elips
            //Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glColor3f(0.3f, 0.6f, 0.3f);
            Gl.glBegin(Gl.GL_POLYGON);
            double radyan = 0;
            int aci = 0;
            for (aci = 0; aci <= 360; aci++)
            {
                radyan = aci * 3.1416 / 180;

                Gl.glVertex2f((float)(Math.Cos(radyan) * 0.15), (float)(Math.Sin(radyan) * 0.15));
            }
            Gl.glEnd();
            Gl.glPopMatrix();
        }

        private void buttonDondur1_Click(object sender, EventArgs e)
        {
            x = (x + 15) % 360;
            OpenGlControl.Refresh(); 
        }

        private void buttonDondur2_Click(object sender, EventArgs e)
        {
            y = (y + 50) % 360;
            OpenGlControl.Refresh(); 
        }

        private void buttonDondur3_Click(object sender, EventArgs e)
        {
            z = (z + 25) % 360;
            OpenGlControl.Refresh(); 
        }

        private void buttonDondur4_Click(object sender, EventArgs e)
        {
            w = (w + 5) % 360;
            OpenGlControl.Refresh(); 
        }

        private void buttonDondur5_Click(object sender, EventArgs e)
        {
            q = (q + 35) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonDondur6_Click(object sender, EventArgs e)
        {
            r = (r + 120) % 360;
            OpenGlControl.Refresh(); 
        }

        private void buttonDondur7_Click(object sender, EventArgs e)
        {
            p = (p + 55) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonDondur8_Click(object sender, EventArgs e)
        {
            t = (t + 60) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonDondur9_Click(object sender, EventArgs e)
        {
            x = (x + 15) % 360;
            OpenGlControl.Refresh();
            y = (y + 50) % 360;
            OpenGlControl.Refresh();
            z = (z + 25) % 360;
            OpenGlControl.Refresh();
            w = (w + 5) % 360;
            OpenGlControl.Refresh();
            q = (q + 35) % 360;
            OpenGlControl.Refresh();
            r = (r + 120) % 360;
            OpenGlControl.Refresh();
            p = (p + 55) % 360;
            OpenGlControl.Refresh();
        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                x = (x - 55) % 360;
            if (e.KeyCode == Keys.B)
                x = (x + 35) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.C)
                y = (y - 25) % 360;
            if (e.KeyCode == Keys.D)
                y = (y + 65) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.E)
                z = (z - 25) % 360;
            if (e.KeyCode == Keys.F)
                z = (z + 75) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.G)
                w = (w - 35) % 360;
            if (e.KeyCode == Keys.H)
                w = (w + 105) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.I)
                q = (q - 65) % 360;
            if (e.KeyCode == Keys.J)
                q = (q + 15) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.K)
                p = (p - 85) % 360;
            if (e.KeyCode == Keys.L)
                p = (p + 15) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.M)
                r = (r - 55) % 360;
            if (e.KeyCode == Keys.N)
                r = (r + 35) % 360;
            OpenGlControl.Refresh();
            if (e.KeyCode == Keys.F10)
            {
                this.Close();
            }
        }
    }
}
