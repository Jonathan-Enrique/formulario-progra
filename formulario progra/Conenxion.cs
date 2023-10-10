using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace formulario_progra

{
    class Conenxion
    {


        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

    }
    public Conexion()
    {
        String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBchamba.mdf;Integrated Security=True"
         miConexion.ConnectionString = cadenaConexion;
        miConexion.Open();
    }


    public DataSet obtenerDatos()
    {
        miDs.Clear();
        miComando.Connection = miConexion;

        miComando.CommandText = "select * from DataLibros";
        miAdaptador.SelectCommand = miComando;
        miAdaptador.Fill(miDs, "DataLibros");

        miComando.CommandText = "select * from UserData";
        miAdaptador.SelectCommand = miComando;
        miAdaptador.Fill(miDs, "UserData");

        return miDs;
