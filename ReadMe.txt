	KULLANILAN TEKNOLOJÝLER:

	- Microsoft Sql Server 2014
	- Visual Studio Enterprise 2015
	- Entity Framework
	- c# Programlama Dili
	- .net Framework

	PROGRAMIN AMACI :

	- Bu program, hastanede çalýþan memurlarýn internetsiz bir ortamda gerekli tüm hasta, doktor, randevu iþlemleri yapabilmesi için yazýlmýþtýr.

	PROGRAMIN KULLANIM AÞAMALARI:
	
	Ýlk olarak DB klasörü altýndaki HastaneTakipOtomasyonYG.bak backup dosyasýný veritabanýnýza aktarmalýsýnýz. Daha sonra progrmaý çalýþtýrýnýz.

	Program çalýþtýrýldýðýnda ilk olarak KULLANICI GÝRÝÞÝ ekraný karþýmýza çýkar. Burada bu formun formLoad eventinde otomatik olarak email ve þifre atanmýþtýr. Bu hazýr gelen bilgiler ile giriþ yapýlabilineceði gibi kullanýcýlar veri tabanýndaki diðer kullanýcýlarýn bilgileriyle de giriþ yapýlabilir. Ýki textbox da dolu ise enter tuþuna basarak anasayfa formuna giriþ yapabilirsiniz.	
	
	Ayarlar menüsü sisteme giriþ yapan otomasyon kullanýcýsýnýn yetki düzeyi 5 ve üzeri ise eriþilebilmektedir. Eðer bu alt menüyü açabilme yetkiniz var ise bu kýsým kullanýcý(memur) ekleme silme veya bilgileri güncellemeye yaramaktadýr. Yetki düzeyi kullanýcýlar tablosunda YetkiDüzeyi alanýnda tutulur ve buradan çekilerek program kodu içinde kontrol gerçekleþtirilir. Hazýr olarak gelen ak@gmail.com adresinin yetki düzeyi bu ayarlara girebilmek için yeterlidir.

	Baþarýlý bir þekilde giriiþ yapýldýktan sonra karþýmýza anasayfa çýkar. Burada menustrip ile birçok iþleme ulaþabiliriz. Sað üst köþede 3 adet picturebox bulunmaktadýr. Üzerlerine týkladýnðýnda geliþtiricinin ( YASEMÝN GÖKTAÞ ) kullanýcý belirtilen web adreslerine yönlenmiþ olur.

	Ekle/ Güncelle/ Sil Ýþlemleri MenuStrip'inde Hasta, Doktor, Hemþire, Bölüm veri tabanlarýna CRUD iþlemleri uygulanmak amacýyla hazýrlanmýþ formlar bulunur. Hasta ve Doktor'un profill resimleri eklenmiþtir fakat Hasta randevu alýrken gerçek hayatta sisteme bir fotoðraf yüklemeyeceði için Hasta formunda resim iþlemleri kullanýlmamasý tercih edilmiþtir. Diðer CRUD iþlemleri her form için geçerlidir.

	Randevu formunda da CRUD iþlemleri mevuttur. Burada ek olarak Comboboxlarýn textchange eventleri ile birbirleri arasýnda baðlantý vardýr. Ayrýca ödevde istenen seçilen doktor adýna göre tabloda bölüm adýnýn otomatik olarak gelmesi iþlemi de baþarýlý bir þekilde linq komutlarý kullanarak gerçekleþtirilmiþtir. Detaylý bilgi için kodlarý inceleyebilirsiniz. Kod içinde yorum satýrý olarak bir kaç açýklama daha mevcuttur. Burada randevu tarihi seçilebileceði gibi saati de seçilmektedir. Saat kontrolü için ayrý bir tablo oluþturulmuþ ve Durum ismindeki bir kolonda saattlerin müsait olma durumlarý 1 ve 0 ile ifade edilmiþtir. bu 1 ve 0 deðerleri formda yapýlan iþleme göre dinamik olarak güncelenmektedir. Bu randevu saati combobox'ýný dolduran metod2daki linq komuttu ile gerçekleþmiþtir. Detaylý bilgi için kodlarý inceleyebilirsiniz.