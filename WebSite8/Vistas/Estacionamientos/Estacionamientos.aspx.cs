﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;

public partial class Estacionamientos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] == null){
            Response.Redirect("~/Vistas/Usuarios/Login.aspx");
        }

        if (!IsPostBack)
        {
            gv_estacionamientos.DataSource = new Estacionamiento().buscarTodos(0, true);
            gv_estacionamientos.DataBind();
        }
    }
    protected void gv_estacionamientos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        GridViewRow row = gv_estacionamientos.Rows[rowIndex];
        int codigoEstacionamiento = (int)gv_estacionamientos.DataKeys[rowIndex].Value;
        Session["cod_estacionamiento"] = codigoEstacionamiento;

        switch (e.CommandName)
        {
            case "CambiarEstado":
                Response.Redirect("~/Vistas/Estacionamientos/EstacionamientoCambiarEstado.aspx");
                break;
            case "Editar":
                Response.Redirect("~/Vistas/Estacionamientos/EstacionamientoEditar.aspx");
                break;
            case "Eliminar":
                //Response.Redirect("~/Vistas/Estacionamientos/EstacionamientoEliminar.aspx");
                break;
        }
    }
}