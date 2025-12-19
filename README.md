# 🚀 AiTech: Yapay Zeka Destekli Dinamik Web Platformu

![.NET Version](https://img.shields.io/badge/.NET-8.0-purple?style=for-the-badge&logo=dotnet)
![Language](https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge&logo=csharp)
![AI Provider](https://img.shields.io/badge/AI-OpenAI%20%26%20Anthropic-green?style=for-the-badge&logo=openai)
![Architecture](https://img.shields.io/badge/Architecture-N--Layer-orange?style=for-the-badge)

**AiTech**, .NET 8.0 teknolojisi ile geliştirilmiş, modern yazılım mimarisi prensiplerine sadık kalan ve günümüzün en güçlü yapay zeka modellerini (OpenAI & Anthropic Claude) bünyesinde barındıran kapsamlı bir web projesidir.

Proje, **Web API** ve onu tüketen (consume eden) dinamik bir **Web UI** katmanından oluşmaktadır.

---

## 🌟 Öne Çıkan Özellikler

### 1. 🎙️ Gerçek Zamanlı Sesli AI Asistanı (OpenAI)
Projenin en can alıcı özelliği! Kullanıcılar sadece yazışarak değil, konuşarak da yapay zeka ile iletişime geçebilir.
- **Sesli Etkileşim:** Kullanıcının sesini algılar ve işler.
- **Doğal Cevaplar:** OpenAI entegrasyonu sayesinde alınan cevaplar, gerçek bir insan tonlamasına ve akıcılığına sahip bir ses ile kullanıcıya geri döner.

### 2. 🧠 Anthropic Claude Sohbet Modülü
Alternatif bir yapay zeka deneyimi için sisteme **Anthropic Claude** entegre edilmiştir. Kullanıcılar farklı bir LLM (Large Language Model) deneyimini bu modül üzerinden yaşayabilirler.

### 3. 🛡️ Tam Dinamik Admin Paneli
Sistem içerisindeki tüm içerikler, kullanıcı yönetimi ve ayarlar, API ile haberleşen dinamik bir Admin paneli üzerinden yönetilmektedir.

---

## 🏗️ Mimari ve Teknik Detaylar

Bu proje, ölçeklenebilirlik ve temiz kod prensipleri gözetilerek **N-Layer Architecture (Çok Katmanlı Mimari)** üzerine inşa edilmiştir.

### Katman Yapısı (5 Temel Katman + UI)
1.  **Entity Layer:** Veritabanı tablolarına karşılık gelen varlıklar.
2.  **DataAccess Layer:** Veri erişim kodları, EF Core konfigürasyonları.
3.  **Dto Layer (Data Transfer Objects):** Veri taşıma nesneleri.
4.  **Service (Business) Layer:** İş kuralları ve validasyonlar.
5.  **Web API:** Dış dünyaya açılan servis kapısı.
6.  **Web UI:** API'yi tüketen (Serialize/Deserialize işlemleri ile) son kullanıcı arayüzü.

### Kullanılan Desenler ve Teknolojiler

* **Unit of Work Design Pattern:** Veritabanı işlemlerinin toplu ve tutarlı bir şekilde yönetilmesi (Transaction yönetimi) için kullanıldı.
* **Interceptors (Araya Girme):** Entity Framework Core Interceptor yapısı kullanılarak, verilerin `CreatedDate` ve `UpdatedDate` gibi alanları, ekleme veya güncelleme anında otomatik olarak yönetilmektedir.
* **MAPSTER:** Entity ve DTO nesneleri arasındaki veri transferini otomatize etmek için kullanıldı.
* **API Consumption:** Web UI katmanı, `HttpClient` kullanarak API ile tam dinamik bir şekilde haberleşir. JSON Serialization ve Deserialization işlemleri profesyonelce kurgulanmıştır.

---

## 📸 Ekran Görüntüleri

## 📸 Proje Vitrini

| 🎙️ Sesli Asistan | 🧠 Claude Chat | 🛡️ Admin Paneli |
| :---: | :---: | :---: |
| <img src="https://github.com/user-attachments/assets/ef2cece7-ffe3-4078-a781-0fc925e8dfa8" width="100%" alt="Sesli Asistan"> | <img src="https://github.com/user-attachments/assets/494f9374-5f53-43b3-bd6f-4c2699e6ec92" width="100%" alt="Claude Chat"> | <img src="https://github.com/user-attachments/assets/3eda2eb1-dd7a-4f2c-a44c-c739b74c9bdb" width="100%" alt="Admin Paneli"> | |


## 📸 Ekran Görüntüleri

<details>
  <summary><b>🔌 API Katmanı ve Swagger Dokümantasyonu (Görmek için tıklayın)</b></summary>
  <br>
  <p align="center">
    Projenin backend servislerinin dökümantasyonu Swagger arayüzü üzerinden sağlanmaktadır.
  </p>
  <div align="center">
    <img src="https://github.com/user-attachments/assets/b663d953-ca7c-4f15-812a-50643c4e0bf4" width="100%" alt="API Swagger Görünümü 1" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/027748c7-2f2d-4481-97d7-559ce1403919" width="100%" alt="API Swagger Görünümü 2" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/6b09006e-d965-454c-9f3e-2e9a32463a2f" width="100%" alt="API Swagger Görünümü 3" />
  </div>
</details>
<details>
  <summary><b>🏠 Web UI ve Ana Sayfa Arayüzleri (Görmek için tıklayın)</b></summary>
  <br>
  <p align="center">
    Kullanıcı dostu, modern ve responsive (mobil uyumlu) arayüz tasarımları.
  </p>
  <div align="center">
    <img src="https://github.com/user-attachments/assets/ca08c938-8134-4840-b433-74ff32bf68a4" width="100%" alt="Ana Sayfa Genel" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/627a55b0-c7b2-4aad-94b5-55429df6b32e" width="100%" alt="Arayüz Detay 1" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/3d8f2983-6eeb-4e70-8ef2-5a8b0fabccb9" width="100%" alt="Arayüz Detay 2" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/a531e356-12e0-4864-871b-12bb87038de0" width="100%" alt="Arayüz Detay 3" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/9d9a806b-9938-4641-81a5-1789af0b8730" width="100%" alt="Arayüz Detay 4" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/424a2bef-72cf-434a-8d41-d1e8799a08e6" width="100%" alt="Arayüz Detay 5" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/65f7a263-2f43-4674-87d6-ad1de6990a19" width="100%" alt="Arayüz Detay 6" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/9724b4df-b2d1-40fd-897c-dd27bd3d2ab4" width="100%" alt="Arayüz Detay 7" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/c8e73be4-2add-44d1-b7f6-99c8e31851bb" width="100%" alt="Arayüz Detay 8" />
  </div>
</details>

<details>
  <summary><b>🧠 Anthropic Claude: Gelişmiş Akıl Yürütme ve Sohbet Modülü (İncelemek için Tıklayın)</b></summary>
  <br>

  <div align="center">
    <h3>⚡ Derinlemesine Analiz ve Bağlam Farkındalığı</h3>
    <p>
      <i>"Sadece bir chatbot değil, karmaşık problemleri çözebilen bir asistan."</i><br>
      Sistem, <b>Anthropic Claude</b> modelinin geniş bağlam penceresini ve üstün kodlama yeteneklerini kullanarak, kullanıcı sorularına detaylı ve teknik derinliği olan yanıtlar üretir.
    </p>
    
   
  </div>

  <hr>
  <br>

  <div align="center">
    <img src="https://github.com/user-attachments/assets/aae2e718-3f8a-4843-9b7c-1d5cfe688aff" width="100%" alt="Claude Arayüz 1" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/a67376cb-e262-40ee-ad65-5f4c50cdafac" width="100%" alt="Claude Arayüz 2" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/b6f1c6ed-cf58-4fce-81d3-026b33f676f7" width="100%" alt="Claude Arayüz 3" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/b5a39bc5-49d8-4d2f-b1fc-2ae374fbf95f" width="100%" alt="Claude Arayüz 4" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/cfdcdbde-f512-4ef3-af85-a2a1d9373802" width="100%" alt="Claude Arayüz 5" />
    <br><br>
    <img src="https://github.com/user-attachments/assets/e5a4bb70-2cb7-4041-9f61-50400873f520" width="100%" alt="Claude Arayüz 6" />
  </div>
</details>

<details>
<summary><b>🎙️ OpenAI Sesli Asistan: Gerçek Zamanlı Konuşma (Video & Demo)</b></summary>

<br>

### 🗣️ Sadece Yazma, Konuş!
Bu modül, kullanıcının sesini **anlık olarak işler** ve OpenAI desteğiyle  
**gerçek insan tonlamasında** sesli yanıt üretir.

<p align="center">
  <img src="https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExbzN5OHk4NnZnZnV4NnZnZnV4NnZnZnV4syZlcD12MV9zdGlja2Vyc19zZWFyY2gmY3Q9cw/l41lOtd1c6X1O6v0Q/giphy.gif" width="150">
</p>

<p align="center">
  <a href="LINKEDIN_VIDEO_LINKINI_BURAYA_YAPISTIR" target="_blank">
    <img src="https://img.shields.io/badge/LinkedIn-Sesli%20Asistan%20Videosunu%20İzle-0077B5?style=for-the-badge&logo=linkedin&logoColor=white">
  </a>
</p>

<p align="center"><i>👆 Canlı demoyu izlemek için tıklayın</i></p>

---

### 📸 Ekran Görüntüleri

<p align="center">
  <img src="https://github.com/user-attachments/assets/85069026-4d3a-4e9f-8733-aae9286a8596" width="100%">
  <br><br>
  <img src="https://github.com/user-attachments/assets/be5785ec-2820-4f0c-a576-78404dbe9da9" width="100%">
  <br><br>
  <img src="https://github.com/user-attachments/assets/43f3de03-1909-42a1-aedb-e01db5fa713c" width="100%">
    <br><br>
<img width="1884" height="904" alt="Ekran görüntüsü 2025-12-19 100931" src="https://github.com/user-attachments/assets/4cfce050-0b47-4026-974a-5c86dcced821" />
<br><br>
<img width="1905" height="904" alt="Ekran görüntüsü 2025-12-19 100941" src="https://github.com/user-attachments/assets/d6054b93-07d7-4ec9-b440-50d3c2849c16" />
<br><br>
<img width="1898" height="911" alt="Ekran görüntüsü 2025-12-19 101142" src="https://github.com/user-attachments/assets/cbe47836-4206-4c03-b7f0-b949c9fc9bb5" />
<br><br>
    <img width="1903" height="907" alt="Ekran görüntüsü 2025-12-19 101243" src="https://github.com/user-attachments/assets/f869a6bd-c2b6-4a0d-a35d-59f5dabd3fa8" />

</p>

</details>


<details>
    
<summary><b>📊 Dashboard & Admin Paneli</b></summary>

<br>

<img src="https://github.com/user-attachments/assets/fa48d9f5-e2f0-4adf-8227-a94b6f3b2cb0" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/467700e9-ac3f-4e5f-8e18-b564c706dae0" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/8e3596ef-181e-442c-b2bc-a8de8d0cbb0d" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/04dda7ab-0432-4609-9dae-ca18e204c760" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/de1768e5-3daa-4c7c-ae75-57443b1f146e" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/78da8b32-4906-4946-bf3b-0cb46a812d53" width="100%">

<br><br>
<img src="https://github.com/user-attachments/assets/be29ca02-6328-4417-b489-2814e2550603" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/2c02a183-d339-48d0-88c7-904d9e793440" width="100%">

<br><br>
<img src="https://github.com/user-attachments/assets/2c10f346-71fe-4c13-a7ce-4179fcb9e6a4" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/9004e55e-d9cc-4c4e-95c4-171e1a0ed5b7" width="100%">
<br><br>
<img src="https://github.com/user-attachments/assets/0eacf35d-526a-4795-9d2a-321aea86679a" width="100%">


</details>





<details>
  <summary><b>📂 Proje Klasör Hiyerarşisi ve Katman Yapısı</b></summary>
  <br>
  <p align="center">
    Solid prensiplerine ve Clean Architecture yapısına uygun olarak ayrıştırılmış katmanlar.
  </p>
  <div align="center">
    <img src="https://github.com/user-attachments/assets/746c9b94-72b0-4e04-aff6-8d694d51cee2" alt="Proje Katman Yapısı" />
  </div>
</details>

---

## 🛠️ Kurulum

Projeyi yerel makinenizde çalıştırmak için:

1.  Repoyu klonlayın:
    ```bash
    git clone [https://github.com/kullaniciadiniz/aitech.git](https://github.com/kullaniciadiniz/aitech.git)
    ```
2.  `appsettings.json` dosyasındaki veritabanı bağlantı dizesini (Connection String) ve API Keylerinizi (OpenAI, Anthropic) güncelleyin.
3.  Package Manager Console üzerinden veritabanını oluşturun:
    ```bash
    Update-Database
    ```
4.  Önce **Web API** projesini, ardından **Web UI** projesini ayağa kaldırın.

---

## 🤝 İletişim

Geliştirici: **[Adınız Soyadınız]**
LinkedIn: [Profil Linkiniz]
Email: [Email Adresiniz]
