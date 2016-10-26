using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

public partial class Vehiculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] == null)
        {
            Response.Redirect("~/Vistas/Usuarios/Login.aspx");
        }

        if (!IsPostBack)
        {
            gv_vehiculos.DataSource = new Vehiculo().buscarTodos();
            gv_vehiculos.DataBind();
        }
    }
}