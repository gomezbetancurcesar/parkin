using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

public partial class Tarjetas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            gv_tarjetas.DataSource = new Tarjeta().buscarTodos();
            gv_tarjetas.DataBind();
        }
    }
}