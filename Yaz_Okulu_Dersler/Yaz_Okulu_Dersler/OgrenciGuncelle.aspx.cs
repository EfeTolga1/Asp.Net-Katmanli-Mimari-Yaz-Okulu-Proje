using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;


public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["OgrID"].ToString());
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;

        if(Page.IsPostBack == false)
        {
             EntityOgrenci ent = new EntityOgrenci();
            List<EntityOgrenci> ogrList = BLLOgrenci.BLLDetay(x);
            TxtAd.Text = ogrList[0].Ad.ToString();
            TxtSoyad.Text = ogrList[0].Soyad.ToString();
            TxtNumara.Text = ogrList[0].Numara.ToString();
            TxtFoto.Text = ogrList[0].Fotograf.ToString();
            TxtSifre.Text = ogrList[0].Sifre.ToString();
        }


        
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Sifre = TxtSifre.Text;
        ent.Numara = TxtNumara.Text;
        ent.Fotograf = TxtFoto.Text;
        ent.Id = Convert.ToInt32(TxtID.Text);
        BLLOgrenci.OgrenciEkleBLL(ent);
        Response.Redirect("OgrenciListesi.Aspx");
    }
}