using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {

            SqlCommand komut1 = new SqlCommand("insert into TblOgrenci(OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Numara);
            komut1.Parameters.AddWithValue("@p4", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p5", parametre.Sifre);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From TBLOgrenci", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(dr["OgrID"].ToString());
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Fotograf = dr["OgrFoto"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"].ToString());                
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TblOgrenci where OgrID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From TBLOgrenci where OgrID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                
                ent.Ad = dr["OgrAd"].ToString();
                ent.Soyad = dr["OgrSoyad"].ToString();
                ent.Numara = dr["OgrNumara"].ToString();
                ent.Fotograf = dr["OgrFoto"].ToString();
                ent.Sifre = dr["OgrSifre"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OgrBakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TblOgrenci Set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSifre=@p5 where OgrID=@p6", Baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.Ad);
            komut5.Parameters.AddWithValue("@p2", deger.Soyad);
            komut5.Parameters.AddWithValue("@p3", deger.Numara);
            komut5.Parameters.AddWithValue("@p4", deger.Fotograf);
            komut5.Parameters.AddWithValue("@p5", deger.Sifre);
            komut5.Parameters.AddWithValue("@p6", deger.Id);
            return komut5.ExecuteNonQuery() > 0;
        }
    }
}
