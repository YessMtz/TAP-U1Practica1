using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se añade las librerias para usar el form
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Unidad_1_Practica_1
{
    //CLASE "LLAMADA FORM" que HEREDE la clase Form(Ventana 1)
    public class Ventana2 : Form
    {
            

            //CREACION DEL OBJETO BOTON
            public Button Botoncito1;
        
        //CONTRUCTOR DE LA CLASE 

        

            public Ventana2()
            {
                
                Text = "Esta es una ventana";
                BackColor = Color.Beige;
            

                
                Botoncito1 = new Button();
                Botoncito1.Size = new Size(100, 100);
                Botoncito1.Location = new Point(80, 80);
                Botoncito1.Text = "picale aqui!!";
                Botoncito1.BackColor = Color.DarkSalmon;
                Botoncito1.ForeColor = Color.White;
                Botoncito1.Font = new Font(this.Font, FontStyle.Italic);
                Botoncito1.Font = new Font(this.Font, FontStyle.Bold);
                Botoncito1.Click += Botoncito1_Click;
           


            this.Controls.Add(Botoncito1);
            
            }

        private void Botoncito1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta ventana no hace nada");
        }

        //metodo para especificar la aplicacion de windows forms es un contenedor
        [STAThread]

        static void Main(string[] args)
        {
            //aplica los estilos de sistema operativo a la aplicacion
            Application.EnableVisualStyles();

            //instancia de la ventana o formulario de forms para ejecutar
                Application.Run(new Ventana2());
        }
    }
}
