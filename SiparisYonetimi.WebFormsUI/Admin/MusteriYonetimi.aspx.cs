using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class MusteriYonetimi : System.Web.UI.Page
    {
        CustomerManager manager = new CustomerManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvMusteriler.DataSource = manager.GetAll();
            dgvMusteriler.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Phone = txtTelefon.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;
            
            try
            {
                manager.Add(customer);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MusteriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu");
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMusteriler.SelectedRow.Cells[1].Text);

            Customer customer = manager.Find(id);
            customer.Phone = txtTelefon.Text;
            customer.Email = txtEmail.Text;
            customer.Name = txtAdi.Text;
            customer.Surname = txtSoyadi.Text;
            customer.Address = txtAdres.Text;
            customer.IsActive = chbDurum.Checked;

            try
            {
                manager.Update(customer);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MusteriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu')</script>");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.SelectedRow.Cells[1].Text);

                var kayit = manager.Find(id);

                manager.Delete(kayit);

                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("MusteriYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu')</script>");
            }
        }

        protected void dgvMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.SelectedRow.Cells[1].Text);

                var kayit = manager.Find(id);

                txtAdi.Text = kayit.Name;
                txtAdres.Text = kayit.Address;
                txtSoyadi.Text = kayit.Surname;
                txtEmail.Text = kayit.Email;
                txtTelefon.Text = kayit.Phone;
                chbDurum.Checked = kayit.IsActive;

                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Hata Oluştu')</script>");
            }
        }
    }
}