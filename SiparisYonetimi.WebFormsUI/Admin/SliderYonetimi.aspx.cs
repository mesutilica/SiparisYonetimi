using SiparisYonetimi.Business.Managers;
using SiparisYonetimi.Entities;
using System;

namespace SiparisYonetimi.WebFormsUI.Admin
{
    public partial class SliderYonetimi : System.Web.UI.Page
    {
        SliderManager manager = new SliderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvSlides.DataSource = manager.GetAll();
            dgvSlides.DataBind();
        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            Slide slide = new Slide();
            slide.Title = txtTitle.Text;
            slide.Description = txtDescription.Text;
            slide.Link = txtLink.Text;
            if (fuImage.HasFile)
            {
                fuImage.SaveAs(Server.MapPath("/Img/Slides/" + fuImage.FileName));
                slide.Image = fuImage.FileName;
            }
            try
            {
                manager.Add(slide);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("SliderYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu!");
            }

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvSlides.SelectedRow.Cells[1].Text);

            Slide slide = manager.Find(id);
            slide.Title = txtTitle.Text;
            slide.Description = txtDescription.Text;
            slide.Link = txtLink.Text;
            if (fuImage.HasFile)
            {
                fuImage.SaveAs(Server.MapPath("/Img/Slides/" + fuImage.FileName));
                slide.Image = fuImage.FileName;
            }
            try
            {
                manager.Update(slide);
                var sonuc = manager.SaveChanges();
                if (sonuc > 0)
                {
                    Response.Redirect("SliderYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu!");
            }
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvSlides.SelectedRow.Cells[1].Text);

                Slide slide = manager.Find(id);

                manager.Delete(slide);

                var sonuc = manager.SaveChanges();

                if (sonuc > 0)
                {
                    Response.Redirect("SliderYonetimi.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu!");
            }
        }

        protected void dgvSlides_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgvSlides.SelectedRow.Cells[1].Text);
                var kayit = manager.Find(id);
                txtDescription.Text = kayit.Description;
                txtLink.Text = kayit.Link;
                txtTitle.Text = kayit.Title;
                Image1.ImageUrl = "/Img/Slides/" + kayit.Image;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            catch (Exception)
            {
                Response.Write("Hata Oluştu!");
            }
        }
    }
}