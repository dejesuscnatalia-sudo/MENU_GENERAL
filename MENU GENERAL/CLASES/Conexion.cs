using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_GENERAL.CLASES
{
    internal class Conexion
    {
        private string sentencia1;//es un 1 al final
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd;


        //metodos execute nonquery

        public Conexion() { }

        public Conexion(string sentencia)
        {
            sentencia1 = sentencia;
        }
        //me chute

        public string EJECUTAR()//NOMBRE DEL MÉTODO
        { //PA GRABAR, MODIF Y ELIM
            conn.ConnectionString = CLASES.Global.miconexion;
            if(conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            cmd=new SqlCommand ();
            cmd.Connection = conn;
            cmd.CommandText = sentencia1;
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Operación exitosa"; 
        }
        public DataSet CONSULTAR()
        {
            DataSet datos=new DataSet();
            conn=new SqlConnection(CLASES.Global.miconexion);
            if (conn.State != ConnectionState.Open)
            {  conn.Close(); conn.Open(); }

            SqlDataAdapter resp= new SqlDataAdapter(sentencia1, conn);
            resp.Fill(datos, "Tabla");
            conn.Close();
            return datos;
        }

        public static string Esc(string s)
        {
            return (s ?? "").Replace("'", "''");
        }

        // Usa la sentencia del constructor: la 1ª columna es el valor, la 2ª el texto
        public void LlenarCombo(ComboBox cmb, string valor, string texto)
        {
            DataSet ds = CONSULTAR();
            cmb.DataSource = null;
            cmb.Items.Clear();
            cmb.DisplayMember = texto;
            cmb.ValueMember = valor;
            cmb.DataSource = ds.Tables["Tabla"];
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = -1;
        }
    }
}
