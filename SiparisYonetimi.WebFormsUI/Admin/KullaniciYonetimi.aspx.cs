using SiparisYonetimi.Business.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class KullaniciYonetimi : System.Web.UI.Page
    {
        UserManager manager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();
            dgvKullanicilar.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {

        }

        protected void dgvKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}