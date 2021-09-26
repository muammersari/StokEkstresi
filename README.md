# StokEkstresi
Stok ekstresi tarih aralığı ve kritere göre stok hesaplama uygulaması

Proje store prosedürleri ' StoreProcedür ' kalsörünün altında .txt dosyası olarak bulunmaktadır

* Proje c# winform ve MSSQL ile geliştirmiştir.
* Projede kullanılan paketler :
	- System.Data.SqlClient
* Projede kullanılan referanslar :
	- Interop.Microsoft.Office.Interop.Excel

* Proje özellikleri :
	- Tarih aralığı ve kriter seçilmezse tüm veriler getirilir.
	- Tarih aralığı seçilir ve kriter seçilmezse, tarih aralığına göre kritere bakılmaksızın veriler getirilir.
	- Tarih aralığı seçilmez ve kriter seçilirse, kritere göre tarihe bakılmaksızın veriler getirilir.
	- Arama yapılacak kriter mal kodu ise prosedür ile sadece mal kodları getirilir.
	- Arama yapılacak kriter mal adı ise prosedür ile he mal kodu hem mal adı getirilir.
	  Daha sonra mal adına göre mal kodu bulunur ve hesaplama için prosedüre gönderilir.

* Store Prosedür özellikleri : 
	- 2 adet prosedür yazılmıştır.
	- sp_GetMalKoduAndAdi isimli prosedürde mal kodu istenirse sadece mal kodları döndürülür.
	  mal adi istenirse hem mal kodu hem mal adı döndürülür.
	- sp_stokHesaplama isimli prosedürde gönderilen tarih aralığı ve kritere göre filtreleme ve hesaplama yapılır ve geriye tablo döndürülür.

* Excel çıktısı özellikleri : 
	- excel çıktısı almak için interop.excel referansı kullanılmıştır.
	- excel çıktısı alırken excel dosyasının kayıt yapılacağı dosya seçilebilmektedir.
	- seçilen dosyaya istenilen isimde excel çıktısı alınabilmektedir.
