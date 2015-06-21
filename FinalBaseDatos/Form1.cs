﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBaseDatos
{
    public partial class Form1 : Form
    {
        private string cadenaCon = "Data Source=.;Initial Catalog=FinalBaseDatos;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            LlamarPuestos();
            LlamarEmpleados();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grpDatos.Visible = true;
            ShowGroupBox(true);
        }

        private void ShowGroupBox(bool nuevo)
        {
            if (nuevo)
            {
                btnOkNuevo.Visible = true;
                btnOkEditar.Visible = false;
                txtEdad.Text = String.Empty;
                txtNombre.Text = String.Empty;
            }
            else
            {
                btnOkNuevo.Visible = false;
                btnOkEditar.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grpDatos.Visible = true;
            ShowGroupBox(false);
            int index = cmbEmpleado.SelectedIndex;
            int id = Empleado.lstEmpleados[index].Id;
            LlenarGrouBox(id);
            SelectPuesto();
        }

        private void btnOkEditar_Click(object sender, EventArgs e)
        {
            grpDatos.Visible = false;
        }

        private void btnOkNuevo_Click(object sender, EventArgs e)
        {
            grpDatos.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void LlamarEmpleados()
        {
            SqlConnection con = new SqlConnection(cadenaCon);
            string proc = "proc_getEmpleados";
            SqlCommand com = new SqlCommand(proc, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            
            Empleado.lstEmpleados.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Empleado emp = new Empleado();
                emp.Id = Convert.ToInt32(dt.Rows[i][0]);
                emp.Nombre = dt.Rows[i][1].ToString();
                Empleado.lstEmpleados.Add(emp);
            }
            cmbEmpleado.Items.Clear();
            foreach (Empleado item in Empleado.lstEmpleados)
            {
                cmbEmpleado.Items.Add(item.Nombre);
                cmbEmpleado2.Items.Add(item.Nombre);
            }
        }
        private void LlenarGrouBox(int id)
        {
            SqlConnection con = new SqlConnection(cadenaCon);
            string proc = "proc_getDatosEmpleado";
            SqlCommand com = new SqlCommand(proc, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("id", id);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            Empleado.empleadoActual.Nombre = dt.Rows[0][0].ToString();

            int idPuesto = Convert.ToInt32(dt.Rows[0][1]);
            foreach (Puesto item in Puesto.lstPuestos)
                if (idPuesto == item.Id)
                    Empleado.empleadoActual.Puesto = item;

            Empleado.empleadoActual.Edad = Convert.ToInt32(dt.Rows[0][2]);
            Empleado.empleadoActual.Id = id;

            txtNombre.Text = Empleado.empleadoActual.Nombre;
            txtEdad.Text = Empleado.empleadoActual.Edad.ToString();
        }
        private void LlamarPuestos()
        {
            SqlConnection con = new SqlConnection(cadenaCon);
            string proc = "proc_getPuestos";
            SqlCommand com = new SqlCommand(proc, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Puesto puesto = new Puesto();
                puesto.Id = Convert.ToInt32(dt.Rows[i][0]);
                puesto.Nombre = dt.Rows[i][1].ToString();
                Puesto.lstPuestos.Add(puesto);
            }
            foreach (Puesto item in Puesto.lstPuestos)
            {
                cmbPuestos.Items.Add(item.Nombre);
            }
        }

        private void SelectPuesto()
        {
            int index = 0;
            for (int i = 0; i < Puesto.lstPuestos.Count; i++)
            {
                if (Puesto.lstPuestos[i].Id == Empleado.empleadoActual.Puesto.Id)
                    index = i;
            }
            cmbPuestos.SelectedIndex = index;
        }

        private void cmbEmpleado2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cadenaCon);
            string proc = "proc_getSalarioBase";
            SqlCommand com = new SqlCommand(proc, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            
        }
    }
}
