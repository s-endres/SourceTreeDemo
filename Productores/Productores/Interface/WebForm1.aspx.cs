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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Productor productor = new Productor();
            productor.id = Int32.Parse(txtId.Text);
            productor.nombre = txtNombre.Text;
            productor.email = txtEmail.Text;
            productor.telefono = txtTelefono.Text;

            ProductorDA.Agregar(productor);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("listarProductores.aspx");
        }
    }
}