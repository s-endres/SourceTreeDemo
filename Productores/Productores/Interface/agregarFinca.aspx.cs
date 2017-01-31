using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Productores.DA;
using Productores.Logic;

namespace Productores.Interface
{
    public partial class agregarFinca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Finca finca = new Finca();
            finca.nombre = txtNombre.Text;
            finca.area = Int32.Parse(txtArea.Text);
            finca.idProductor = Int32.Parse(txtIdProductor.Text);

            FincaDA.Agregar(finca);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("listarFincas.aspx");
        }
    }
}