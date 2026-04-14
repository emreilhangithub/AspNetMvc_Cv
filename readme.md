# AspNet_SinavNotSistemi

## 🚀 Proje Özeti

Bu proje, kişisel CV (özgeçmiş) yönetimini sağlayan bir web tabanlı yönetim paneli ve vitrin uygulamasıdır.
Kullanıcılar admin paneli üzerinden deneyim, eğitim, yetenek, sertifika gibi bilgileri yönetebilir; ziyaretçiler ise bu bilgileri modern bir arayüz üzerinden görüntüleyebilir.

Proje, katmanlı mimari yaklaşımı ve Generic Repository pattern kullanılarak geliştirilmiştir.

# 🧰 Kullanılan Teknolojiler #
- 💻 ASP.NET MVC (Framework 4.7.2)
- 🗄️ Entity Framework (Database First)
- 🧱 Generic Repository Pattern
- 🔐 Forms Authentication (Login sistemi)
- 🎨 AdminLTE (Admin Panel UI)
- 🌐 HTML / CSS / Bootstrap
- ⚙️ LINQ

# 🏗️ Proje Mimarisi #

Proje temel olarak 2 ana yapıdan oluşur:

1. Admin Paneli
CRUD işlemleri (Ekle, Sil, Güncelle, Listele)
Tüm içerik yönetimi buradan yapılır

2. Vitrin (Public UI)
Kullanıcının CV’sinin ziyaretçilere gösterildiği alan
Partial View yapısı ile modüler şekilde oluşturulmuştur

# 📦 Modüller ve Açıklamaları #

- 🔐 Login Modülü = 
Admin giriş işlemleri yapılır FormsAuthentication kullanılmıştır Session ile kullanıcı bilgisi tutulur

- 🧑‍💼 Hakkımda Modülü = 
Kullanıcının kişisel bilgileri yönetilir Ad, soyad, adres, mail, telefon, açıklama vb.

- 💼 Deneyim Modülü = 
İş deneyimleri eklenir ve düzenlenir Başlık, alt başlık, tarih ve açıklama alanları içerir

- 🎓 Eğitim Modülü =
Eğitim bilgileri yönetilir Model validation (ModelState) kullanılmıştır

- 🧠 Yetenekler Modülü =
Kullanıcının yetenekleri ve oranları girilir Örn: C# %80

- 📜 Sertifika Modülü =
Sertifikalar listelenir, eklenir ve güncellenir

- 🎯 Hobiler Modülü =
Kullanıcının hobileri eklenir ve düzenlenir

- 🌐 Sosyal Medya Modülü =
Sosyal medya hesapları eklenir Soft delete (Durum = false) uygulanmıştır

- 📩 İletişim Modülü =
Ziyaretçiler mesaj gönderir Admin panelinde mesajlar listelenir ve silinir

- 🧾 Admin Yönetimi =
Yeni admin ekleme Admin düzenleme ve silme işlemleri

- ❗ Hata Yönetimi =
404 ve genel hata sayfaları (ErrorController) Custom error handling yapılmıştır

# 🧩 Teknik Detaylar #
🔁 Generic Repository Kullanımı
Tüm CRUD işlemleri ortak bir yapı üzerinden yönetilmektedir:
- List() → Listeleme
- TAdd() → Ekleme
- TDelete() → Silme
- TUpdate() → Güncelleme
- Find() → Koşullu veri çekme

Bu yapı sayesinde:
Kod tekrarının önüne geçildi
Daha sürdürülebilir bir yapı oluşturuldu

# 🧱 Partial View Yapısı (Vitrin) #
Frontend tarafında modüler yapı kurulmuştur:
- Deneyimler
- Eğitimler
- Yetenekler
- Sertifikalar
- Hobiler
- Sosyal Medya

Her biri ayrı partial view olarak render edilir.

# 🎨 UI / UX #
Admin panelinde AdminLTE kullanıldı
Tema parçalanarak MVC yapısına uygun hale getirildi
Responsive ve modern bir arayüz sağlandı

# 🎯 Projenin Amacı #
Kişisel CV yönetimini dijital ortama taşımak
Admin paneli ile içerik yönetimini kolaylaştırmak
MVC mimarisi ve repository pattern kullanımını göstermek
Katmanlı ve sürdürülebilir bir yapı oluşturmak

# 🗄️ Veritabanı (Database) #

Proje, **Entity Framework Database First yaklaşımı** ile geliştirilmiştir.  
Veritabanı yapısı `.edmx` modeli üzerinden yönetilmektedir.

Uygulamanın çalışabilmesi için veritabanının manuel olarak kurulması gerekmektedir.

---

## ⚙️ Kurulum Adımları ##

### 🔹 Yöntem 1 (Önerilen - SQL Script) ##
1. SQL Server Management Studio (SSMS) açın  
2. Yeni bir veritabanı oluşturun  
3. `Database/CvDb.sql` dosyasını çalıştırın  

---

### 🔹 Yöntem 2 (Backup ile) ##
1. SSMS açın  
2. Databases → sağ tık → **Restore Database**  
3. `Database/CvDb.bak` dosyasını seçin  
4. Restore işlemini tamamlayın  

---


## 🔗 Connection String Ayarı ##

`Web.config` dosyasında bulunan connection string’i kendi SQL Server bilgilerinize göre güncelleyin:

```xml
<connectionStrings>
  <add name="DbCvEntities" connectionString="YOUR_CONNECTION_STRING" providerName="System.Data.SqlClient" />
</connectionStrings>
 ```

### Kullanıcı Ekranı

![1](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/hakkimda.png)
![2](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/deneyimlerim.png)
![3](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/egitimlerim.png)
![4](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/yeteneklerim.png)
![5](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/hobilerim.png)
![6](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/sertifikalarim.png)
![7](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/user/iletisim.png)

### Admin Paneli

![1](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/login.png)
![2](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/hakkimda.png)
![3](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/deneyimlerim.png)
![4](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/egitimlerim.png)
![5](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/yeteneklerim.png)
![6](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/hobilerim.png)
![7](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/sertifikalarim.png)
![8](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/iletisim.png)
![9](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/sosyalmedya.png)
![10](https://github.com/emreilhangithub/AspNetMvc_Cv/blob/master/images/admin/kullanicilar.png)