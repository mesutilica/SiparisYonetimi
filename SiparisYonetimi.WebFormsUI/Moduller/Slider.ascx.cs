using SiparisYonetimi.Business.Managers;
using System;

namespace SiparisYonetimi.WebFormsUI.Moduller
{
    public partial class Slider : System.Web.UI.UserControl
    {
        SliderManager manager = new SliderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptSlider.DataSource = manager.GetAll();
            rptSlider.DataBind();
        }
    }
}