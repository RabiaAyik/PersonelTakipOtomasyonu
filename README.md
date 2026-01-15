# 🏙 Personel Takip Otomasyonu
Şirket takip işlerini kolaylaştıran bir masaüstü uygulamasıdır.Bu proje şirketteki çalışanların izin talebi oluşturmasını,insan kaynaklarının personellere puan vermesini ,izin onaylayıp reddetmesini yöneticinin ise raporları görmesini sağlar.
# 📌 Proje Özellikleri
- **Giriş,Yönetici,İK ve Normal Kullanıcı Panelleri**: Kullanıcı doğrulaması ve işlevleri.
- **Personel Ekleme,Silme**: İnsan Kaynakları çalışanı kaydeder. 
- **İzin talebi**: Onaylanır veya reddedilirse kullanıcı ekranına gelir.
- **Maaş Raporları**: Departmandaki personellerin ortalama,toplam,en yüksek,en düşük maaşını getirir.
- **Performans Raporları**: En yüksek,en düşük performanslı personeli getirir.
- **Departman Raporları**: Departman bazlı personel sayısını gösterir.
# 📁 Kullanılan Teknolojiler
- **C#**: (.NET Framework)
- **Windows Forms**:Masaüstü uygulama tasarımı
- **MySQL**: Veritabanı
- **Layer**: Katmanlı mimari (DAL, Service, Entity)
- **Responsive Tasarım**: Sade,şık ve kullanıcı dostu arayüz.
# ⛓ Proje Yapısı
- **DAL (Data Access Layer)**: Veritabanı işlemleri.
- **SERVİCE Layer**: İş mantığı.
- **UI (User Interface)**: Windows Forms kullanıcı arayüzü.
- **MySQL**: Veritabanı bağlantı ve sorguları.

# 📷 Ekran Görüntüleri
## *Giriş Ekranı*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/91e3d4ab32f7c1c7b85321405704cb9da4bbc400/GirisEkran%C4%B1.PNG)
Bu ekranda kullanıcı adı ve şifresini giren kişinin rolüne göre aşağıdaki ekranlardan biri açılır.<br/>

## *İnsan Kaynakları Ekranı*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/7a23da2cb36075fd09e867371ee8e778c576861f/insanKaynaklar%C4%B1Ekran%C4%B1.PNG)
Bu ekranda yapılacak işlemler şöyledir:<br/>

*Personel Silme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/23acdeeffa001723f5717386fb1380bd4d04c76f/PersonelSil.PNG) 
Seçili personel artık çalışmıyordur.<br/>

*Personel Ekleme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/405f89a521e536b083836a5aec2733274872b87d/PersonelEkleme.PNG)
Yeni personel kaydı yapılır.<br/>

*Personel Güncelleme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/405f89a521e536b083836a5aec2733274872b87d/PersonelGuncelle.PNG)
Personel seçilerek bilgilerinin değişimi sağlanır.<br/>

*İzin Onaylama/Reddetme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/405f89a521e536b083836a5aec2733274872b87d/IzinOnayla.PNG)
Beklemede olan izinler bu ekrana gelir.<br/>

*Performans Puanlama*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/405f89a521e536b083836a5aec2733274872b87d/Puan%20verme.PNG)
Her personele yılda bir kez ik puan verir.Yönetici bunları görüntüler.

## *Normal Kullanıcı Ekranı*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/d50d1ba117c475d5e077fe5200b3142e092e0061/NormalKullan%C4%B1c%C4%B1Ekran%C4%B1.PNG)
Bu ekranda yapılacak işlemler şöyledir:<br/>

*İzin Talep Etme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/b304679f7b9db5c9c89628d9357bd2dbe4f117fb/IzinAlma.PNG)
Kullanıcı belirli şartlar altında izin ister.<br/>

*Alınan İzinleri Görme*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/b304679f7b9db5c9c89628d9357bd2dbe4f117fb/IzinGorme.PNG)
Kullanıcı kendi beklemede olan veya geçmiş reddedilmiş,onaylanmış izinlerini görür. 
## *Yönetici Ekranı*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/9a521996df9c6a9fc14224451b675117ed97b346/YoneticiEkran%C4%B1.PNG)
Bu ekranda yapılacak işlemler izin onaylama ve personelleri görmenin yanı sıra şöyledir:<br/>

*Maas Raporları*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/23716734dbd2c1b710d44f681e8b568f70a080a0/MaasRapor.PNG)
Her bir departmanın toplam-ortalama maaş yükünü,en yüksek ve en düşük maaş alan personelleri gösterir.<br/>

*Performans Raporu*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/23716734dbd2c1b710d44f681e8b568f70a080a0/PerformansRaporu.PNG)
Yıllara göre yüksekten düşüğe ,düşükten yükseğe puan grafiği.<br/>

*Departman Raporu*
![image alt](https://github.com/RabiaAyik/PersonelTakipOtomasyonu/blob/23716734dbd2c1b710d44f681e8b568f70a080a0/DepRapor.PNG)
Her bir departmanda kaç kişi çalışıyor gösterir.<br/>
# 🎯 Proje Hedefleri
- Şirketin yapacağı işlemleri dijitalleştirip kolaylaştırmak.
- Sade bir arayüzle kullanıcıyı yapacağı işleme yönlendirmek.
- Farklı raporlamalar yaparak yönetime bilgi sunmak
# 📧 İletişim
Herhangi bir soru için iletişim bilgisi:
- **E-posta**: rabiaayik089@gmail.com
# 🎬 Youtube tanıtımı
Youtube proje tanıtım videosu izlemek için [tıklayın](https://youtu.be/4rCcFxtojmw?si=NitYVDRL_mFci3Z-)



