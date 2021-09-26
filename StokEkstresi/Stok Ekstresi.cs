using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace StokEkstresi
{
    public partial class Stok_Ekstresi : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=MUAMMER\\SQLEXPRESS;Initial catalog=Test;Integrated Security=True");
        public Stok_Ekstresi()
        {
            InitializeComponent();
        }

        private void Stok_Ekstresi_Load(object sender, EventArgs e)
        {
            // sayfa açıldığında otomatik olarak startDate ve endDate datepicker leri false yapıyoruz
            startDate.Checked = false; 
            endDate.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open(); //bağlantı açıldı
            SqlCommand komut = new SqlCommand();
            komut.Connection = connection;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "sp_StokHesaplama"; // store prosedür ismi
            //mal kodu parametresini belirtiyoruz. 0. index ise Mal koduna Göre, 1. index ise Mal adına göre verileri getiriyor
            komut.Parameters.Add("MalKodu", SqlDbType.NVarChar, 100).Value = selectKriter.Text.ToString();
            if (startDate.Checked == true || endDate.Checked == true)
            {
                //başlangıç tarihi parametresini belirtiyoruz
                komut.Parameters.Add("BaslangicTarihi", SqlDbType.Int).Value = Convert.ToInt32(Convert.ToDateTime(startDate.Text).ToOADate());
                //Bitiş Tarihi Paremetresini belirtiyoruz
                komut.Parameters.Add("BitisTarihi", SqlDbType.Int).Value = Convert.ToInt32(Convert.ToDateTime(endDate.Text).ToOADate());
            }
            else
            {
                //başlangıç tarihi parametresini belirtiyoruz
                komut.Parameters.Add("BaslangicTarihi", SqlDbType.Int).Value = 0;
                //Bitiş Tarihi Paremetresini belirtiyoruz
                komut.Parameters.Add("BitisTarihi", SqlDbType.Int).Value = 0;
            }
            komut.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(); // gelen tablo verisini datagridview e aktarıyoruz
            da.SelectCommand = komut;
            DataSet ds = new DataSet();
            da.Fill(ds, "Table");
            Table.DataSource = ds.Tables[0];

            connection.Close();

        }
        //  mal adına göre veri arandığında mal kodlarını bu listeye atıyoruz.
        ArrayList MalKoduList = new ArrayList();
        private void cbKriter_SelectedIndexChanged(object sender, EventArgs e) //Hangi Kritere göre arama yapılacağını belirtiyoruz
        {
            cbProduct.Items.Clear();
            MalKoduList.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = connection;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "sp_GetMalKoduAndAdi"; // prosedür ismi
            //arama kriteri parametresini belirtiyoruz. 0. index ise Mal koduna Göre 1. index ise Mal adına göre verileri getiriyor
            komut.Parameters.Add("AramaKriteri", SqlDbType.Int).Value = cbKriter.SelectedIndex;
            komut.ExecuteNonQuery();
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read()) // gelen verileri comboboxa yazdırıyoruz
            {
                if (cbKriter.SelectedIndex == 0)
                {
                    cbProduct.Items.Add(read["MalKodu"].ToString());
                }
                else
                {
                    cbProduct.Items.Add(read["MalAdi"].ToString());
                    // seçilen kriter mal adı ise mal kodlarını liseye atıyoruz.
                    MalKoduList.Add(read["MalKodu"].ToString());
                }
            }
            read.Close();
            connection.Close();
        }

        private void cbProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbKriter.SelectedIndex == 0) // seçilen kriter mal kodu ise direk seçilen değeri yazdırıyoruz
            {
                selectKriter.Text = cbProduct.Text;
            }
            else // seçilen kriter mal adı ise listeden mal adının mal kodunu buluyoruz.
            {
                selectKriter.Text = MalKoduList[cbProduct.SelectedIndex].ToString();
            }
        }

        private void btn_ExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // excel dosyasının kayıt yapılacağı yer seçimi için
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel Dışa Aktarım"; //excel  sayfa ismi
                for (int i = 1; i < Table.Columns.Count + 1; i++) //tablo başlıklarının verileri alınıyor
                {
                    worksheet.Cells[1, i] = Table.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < Table.Rows.Count - 1; i++) //tablonun içeriği satır satır okunup yazdırılıyor.
                {
                    for (int j = 0; j < Table.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = Table.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //tüm veriler excel dosyasına kayıt ediliyor
                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
        }
    }
}
