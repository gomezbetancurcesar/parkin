using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

public partial class Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Usuario usuario = new Usuario();
        usuario.nombres = txt_nom_us.Text;
        string[] rutSeparado = txt_rut_us.Text.Split('-');
        usuario.rut = Int32.Parse(rutSeparado[0]);
        usuario.password = txt_pass_us.Text;
    }
}