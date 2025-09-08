using guia2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona nuevaPersona;
        Modal modalPersona;
        Servicio servicio = new Servicio();

        private void ActualizarLista()
        {
            listBox1.Items.Clear();
            for (int n = 0; n < servicio.Vercantidadpersonas(); n++)
            {
                Persona p = servicio.Verpersona(n);
                listBox1.Items.Add(p.Describir());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modal modalPersona = new Modal();
            if (modalPersona.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(modalPersona.tbdni.Text);
                string nombre = modalPersona.tbnombre.Text;

                Persona nueva = new Persona(dni, nombre);
                if (servicio.Agregarpersona(nueva) == true)
                {
                    MessageBox.Show("Persona agregada.");
                }
                else
                {
                    MessageBox.Show("DNI ya existente");
                }
                ActualizarLista();
            }
        }

        private void bttnver_Click(object sender, EventArgs e)
        {
            Modal modalPersona = new Modal();
            if (modalPersona.ShowDialog() == DialogResult.OK)
            {
                if (modalPersona.ShowDialog() == DialogResult.OK)
                {
                    int dni = Convert.ToInt32(modalPersona.tbdni.Text);
                    if (servicio.Verpersonapordni(dni) != null)
                    {
                        MessageBox.Show($"DNI: {dni}   -   Nombre: {servicio.Verpersonapordni(dni).Nombre}");
                    }
                    else
                    {
                        MessageBox.Show("Persona no encontrada");
                    }
                }

            }
        }

        private void bttnmodificar_Click(object sender, EventArgs e)
        {
           Modal modalPersona = new Modal();
           modalPersona.tbdni.Enabled = false;
           modalPersona.tbnombre.Enabled = true;
           Persona persona = servicio.Verpersona(listBox1.SelectedIndex);
            if (persona != null)
            {
                modalPersona.tbdni.Text = persona.Dni.ToString();
                modalPersona.tbnombre.Text = persona.Nombre;
                

                if (modalPersona.ShowDialog() == DialogResult.OK)
                {
                    string nombre = modalPersona.tbnombre.Text;

                    persona.Nombre = nombre;
                    MessageBox.Show("Se ha modifico los datos de la persona");
                }
            }
            else
            {
                MessageBox.Show("Error, no se ha selccionado una persona del listado (fallo la búsqueda)");
            }

            ActualizarLista();
        }

        private void bttneliminar_Click(object sender, EventArgs e)
        {
            Modal modalPersona = new Modal();
            Persona persona = servicio.Verpersona(listBox1.SelectedIndex);
            if (persona != null)
            {
                servicio.Eliminarpersonas(persona);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
