# Restoran Rezervasyon ve Online Sipariş Sistemi

Bu proje, restoran rezervasyonlarını ve online siparişleri gerçek zamanlı olarak yönetmek için güçlü bir çözüm sunar. **ASP.NET Core 6.0** ve **SignalR** kullanılarak geliştirilmiş olan bu sistem, kullanıcıların sipariş vermesini ve rezervasyon yapmasını sorunsuz bir şekilde sağlar; yöneticilere ise gerçek zamanlı yönetim yetenekleri sunar.

## 🚀 Proje Özeti

Bu uygulama, restoran operasyonlarını geliştirmeyi amaçlar. Kullanıcılar, online olarak sipariş verebilir ve rezervasyon yapabilir; yöneticiler ise bu talepleri gerçek zamanlı bir panel aracılığıyla yönetebilir ve anlık güncellemeler alabilirler.

## 🔑 Özellikler

- **Online Sipariş:** Kullanıcılar giriş yapabilir, menüyü görüntüleyebilir, ürünleri sepete ekleyebilir ve sipariş verebilirler.
- **Rezervasyonlar:** Müşteriler masalarını rezerve edebilir, yöneticiler ise bu rezervasyonları gerçek zamanlı olarak görüntüleyip yönetebilirler.
- **Gerçek Zamanlı Yönetim Paneli:** Yöneticiler siparişleri ve rezervasyonları anında onaylayabilir veya reddedebilirler. Bu gerçek zamanlı bildirimler SignalR tarafından desteklenir.
- **E-Posta Bildirimleri:** Müşterilere ve yöneticilere durum değişiklikleri hakkında otomatik e-postalar gönderilir.
- **Güvenli Giriş:** Kullanıcı kimlik doğrulama ve güvenliği **ASP.NET Identity** ile yönetilir.
- **QR Kod Oluşturma:** Yöneticiler, yönetim paneli üzerinden masalar ve siparişler için QR kodları oluşturabilirler.

## 🛠️ Teknik Detaylar

- **ASP.NET Core 6.0**
- **SignalR** ile gerçek zamanlı güncellemeler
- **Entity Framework Code First** ile veritabanı yönetimi
- **MSSQL** için ilişkisel veritabanı
- **MailKit** ile e-posta bildirimleri
- **AutoMapper** ile nesne-nesne eşleme
- **Ajax, HTML, CSS, JavaScript, Bootstrap** ile duyarlı frontend

## 📁 Proje Yapısı

Proje, **N-Katmanlı Mimari** kullanılarak bakım ve ölçeklenebilirliği sağlamak üzere yapılandırılmıştır:

- **UI Katmanı:** Ön yüz bileşenlerini yönetir
- **Entity Katmanı:** Veri varlıklarını tanımlar
- **DataAccess Katmanı:** Veritabanı erişimi ve işlemlerini yönetir
- **Business Katmanı:** İş mantığını içerir
- **Dto Katmanı:** Güvenli veri yönetimi için veri transfer nesnelerini yönetir
- **Web API Katmanı:** RESTful servisler aracılığıyla arka plan iletişimini sağlar

## 📋 Yönetici Özellikleri

- **CRUD İşlemleri:** Ürünleri, kategorileri ve site verilerini yönetme
- **Gerçek Zamanlı Rezervasyonlar:** Rezervasyonları sayfa yenilemeden görüntüleme ve yönetme
- **Canlı Bildirimler:** Siparişler ve rezervasyonlar hakkında gerçek zamanlı güncellemeler alma
- **İndirim Yönetimi:** Ürünler üzerinde indirimler uygulama ve yönetme
- **Gerçek Zamanlı İstatistikler:** Siparişler, masalar ve gelir için canlı istatistikleri izleme
- **QR Kod Oluşturma:** Yönetim paneli üzerinden masalar ve siparişler için QR kodları oluşturma

## ✨ Öne Çıkanlar

- **Gerçek Zamanlı Mesajlaşma:** Kullanıcılar ve yöneticiler arasında canlı güncellemeler için sohbet benzeri bir arayüz
- **Masa Durumu İzleme:** Masa kullanılabilirliği ve rezervasyon durumu hakkında gerçek zamanlı güncellemeler
- **E-Posta Bildirimleri:** Siparişler ve rezervasyonlar hakkında otomatik e-postalar
- **İndirim Özelliği:** Menü öğelerine kolayca indirimler uygulama
- **Güvenli Kimlik Doğrulama:** ASP.NET Identity ile güçlü güvenlik özellikleri
- **Yönetici QR Kod Oluşturma:** Yönetim paneli üzerinden masalar ve siparişler için QR kodları oluşturulabilir

## 🧩 Kullanılan Teknolojiler

- **Backend:** ASP.NET Core 6.0, ASP.NET Core Web API, SignalR, Entity Framework, MSSQL
- **Frontend:** HTML, CSS, JavaScript, Bootstrap, Ajax
- **Yardımcı Araçlar:** AutoMapper, MailKit
- **Mimari:** N-Katmanlı Mimari, DTO Deseni

## 📸 Ekran Görüntüleri

Aşağıda projenizin bazı ekran görüntüleri bulunmaktadır:
![4](https://github.com/user-attachments/assets/ee93bc59-fda2-4dd6-a7cf-646b5e80bff8)
![5](https://github.com/user-attachments/assets/fd2a6380-ac8b-453d-8464-8e420579247f)
![6](https://github.com/user-attachments/assets/1408b6aa-3701-4032-99cb-b9e16e9bb0b9)
![7](https://github.com/user-attachments/assets/a600f05b-2c36-4b65-b94b-e9b71598aa6f)
![8](https://github.com/user-attachments/assets/4cbdd92b-40aa-4b2f-a9f2-cb63a3e61cad)
![9](https://github.com/user-attachments/assets/e621ce28-bec8-4f08-b1fe-1f58c6a62263)
![10](https://github.com/user-attachments/assets/1bbf49e8-b3bb-4e0c-a004-07a06d907143)
![11](https://github.com/user-attachments/assets/3684b3a3-0267-48b0-b2f6-2205e1b1d138)
![12](https://github.com/user-attachments/assets/efe5f138-7214-4643-93b1-1c674f38eb74)
![13](https://github.com/user-attachments/assets/3de636ca-ada0-4e36-92dc-32c576773cce)
![14](https://github.com/user-attachments/assets/541d1019-6fc2-421b-8cbb-65d46bfb0fd3)
![15](https://github.com/user-attachments/assets/82a09489-58c7-4be7-8f29-4299911fec1b)
![16](https://github.com/user-attachments/assets/b8063fe3-e5c5-4ec6-806b-c6e72e755e01)
![17](https://github.com/user-attachments/assets/e7efda34-83dc-42ea-b30f-64d90f58ed98)
![18](https://github.com/user-attachments/assets/c569ec54-d007-4656-8d36-675ec1eb7afa)
![19](https://github.com/user-attachments/assets/6d4efd8f-5fa5-40f0-8be4-a7ac7b3c804e)
![20](https://github.com/user-attachments/assets/8ff2c690-979b-4752-8a52-f2dd9a587999)
![21](https://github.com/user-attachments/assets/c7767f4b-bcdb-4834-9ff5-c5f76a66e4c0)
![22](https://github.com/user-attachments/assets/15ea2ebb-5168-4eec-8dba-2a305d81a84f)
![23](https://github.com/user-attachments/assets/3ad4797e-25d3-4a1d-bd93-e79762086db8)
![24](https://github.com/user-attachments/assets/f9197d28-d8fc-4ef5-a06b-7fef6a0d01ca)
![25](https://github.com/user-attachments/assets/95af397b-9c85-4b73-86c2-8ae90e6d9052)
![26](https://github.com/user-attachments/assets/ad3c2ccc-cfea-4b4d-8183-e5fb2f46cfe4)
![27](https://github.com/user-attachments/assets/a3990f5c-69f8-4da9-a470-0d21c106f1f4)
![1](https://github.com/user-attachments/assets/14404fcf-d62b-4190-9b39-802a7a59c78c)
![2](https://github.com/user-attachments/assets/5c79aa72-8467-4574-8e9b-ce48d2a38656)
![3](https://github.com/user-attachments/assets/607cf164-fdaa-497b-a234-6d2528d7e960)
![28](https://github.com/user-attachments/assets/692a0257-e23b-42f6-8ec6-c67f2598c64b)
![29](https://github.com/user-attachments/assets/d00e8221-0154-49b3-a4dd-69b2274bb030)
![31](https://github.com/user-attachments/assets/521a3d99-f8fb-4e8a-8886-fd58fa079507)
![33](https://github.com/user-attachments/assets/4aa4932f-7631-4b80-bbea-566f04ea9ef7)
![32](https://github.com/user-attachments/assets/9202b7bb-17a0-4b18-b21c-c04237bb07c5)
![34](https://github.com/user-attachments/assets/343a68df-c685-4db8-9ab2-a5c9abb30db9)
