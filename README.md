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

*(Buraya projenin ekran görüntülerini veya sesli asistanın çalıştığına dair bir GIF ekleyebilirsiniz)*

| Sesli Asistan | Claude Chat | Admin Paneli |
| :---: | :---: | :---: |
| ![VoiceChat](
<img width="1905" height="904" alt="Ekran görüntüsü 2025-12-19 100941" src="https://github.com/user-attachments/assets/ef2cece7-ffe3-4078-a781-0fc925e8dfa8" />) | ![Claude](

<img width="1905" height="931" alt="Ekran görüntüsü 2025-12-19 100203" src="https://github.com/user-attachments/assets/494f9374-5f53-43b3-bd6f-4c2699e6ec92" />) | ![Admin](
<img width="1919" height="889" alt="Ekran görüntüsü 2025-12-19 101359" src="https://github.com/user-attachments/assets/3eda2eb1-dd7a-4f2c-a44c-c739b74c9bdb" />) |


# Api Katmanı
<img width="1881" height="907" alt="Ekran görüntüsü 2025-12-19 095634" src="https://github.com/user-attachments/assets/b663d953-ca7c-4f15-812a-50643c4e0bf4" />
<img width="1886" height="912" alt="Ekran görüntüsü 2025-12-19 095644" src="https://github.com/user-attachments/assets/027748c7-2f2d-4481-97d7-559ce1403919" />
<img width="1889" height="917" alt="Ekran görüntüsü 2025-12-19 095653" src="https://github.com/user-attachments/assets/6b09006e-d965-454c-9f3e-2e9a32463a2f" />

#ana sayfa


<img width="1909" height="1010" alt="Ekran görüntüsü 2025-12-19 095715" src="https://github.com/user-attachments/assets/ca08c938-8134-4840-b433-74ff32bf68a4" />


<img width="1909" height="918" alt="Ekran görüntüsü 2025-12-19 095738" src="https://github.com/user-attachments/assets/627a55b0-c7b2-4aad-94b5-55429df6b32e" />


<img width="1917" height="920" alt="Ekran görüntüsü 2025-12-19 095753" src="https://github.com/user-attachments/assets/3d8f2983-6eeb-4e70-8ef2-5a8b0fabccb9" />

<img width="1899" height="915" alt="Ekran görüntüsü 2025-12-19 095803" src="https://github.com/user-attachments/assets/a531e356-12e0-4864-871b-12bb87038de0" />


<img width="1896" height="917" alt="Ekran görüntüsü 2025-12-19 100016" src="https://github.com/user-attachments/assets/9d9a806b-9938-4641-81a5-1789af0b8730" />

<img width="1894" height="911" alt="Ekran görüntüsü 2025-12-19 100029" src="https://github.com/user-attachments/assets/424a2bef-72cf-434a-8d41-d1e8799a08e6" />

<img width="1890" height="918" alt="Ekran görüntüsü 2025-12-19 100041" src="https://github.com/user-attachments/assets/65f7a263-2f43-4674-87d6-ad1de6990a19" />



<img width="1886" height="909" alt="Ekran görüntüsü 2025-12-19 100059" src="https://github.com/user-attachments/assets/9724b4df-b2d1-40fd-897c-dd27bd3d2ab4" />



<img width="1902" height="912" alt="Ekran görüntüsü 2025-12-19 100133" src="https://github.com/user-attachments/assets/c8e73be4-2add-44d1-b7f6-99c8e31851bb" />

# Cloude Antrpo

<img width="1911" height="909" alt="Ekran görüntüsü 2025-12-19 100143" src="https://github.com/user-attachments/assets/aae2e718-3f8a-4843-9b7c-1d5cfe688aff" />

<img width="1905" height="931" alt="Ekran görüntüsü 2025-12-19 100203" src="https://github.com/user-attachments/assets/a67376cb-e262-40ee-ad65-5f4c50cdafac" />

<img width="1896" height="907" alt="Ekran görüntüsü 2025-12-19 100305" src="https://github.com/user-attachments/assets/b6f1c6ed-cf58-4fce-81d3-026b33f676f7" />

<img width="1904" height="927" alt="Ekran görüntüsü 2025-12-19 100322" src="https://github.com/user-attachments/assets/b5a39bc5-49d8-4d2f-b1fc-2ae374fbf95f" />


<img width="1889" height="920" alt="Ekran görüntüsü 2025-12-19 100411" src="https://github.com/user-attachments/assets/cfdcdbde-f512-4ef3-af85-a2a1d9373802" />

<img width="1895" height="907" alt="Ekran görüntüsü 2025-12-19 100432" src="https://github.com/user-attachments/assets/e5a4bb70-2cb7-4041-9f61-50400873f520" />




# open ai chatbox


<img width="1901" height="910" alt="Ekran görüntüsü 2025-12-19 100447" src="https://github.com/user-attachments/assets/85069026-4d3a-4e9f-8733-aae9286a8596" />


<img width="1907" height="910" alt="Ekran görüntüsü 2025-12-19 100454" src="https://github.com/user-attachments/assets/be5785ec-2820-4f0c-a576-78404dbe9da9" />


<img width="1898" height="908" alt="Ekran görüntüsü 2025-12-19 100815" src="https://github.com/user-attachments/assets/43f3de03-1909-42a1-aedb-e01db5fa713c" />


<img width="1884" height="904" alt="Ekran görüntüsü 2025-12-19 100931" src="https://github.com/user-attachments/assets/951b29cb-8836-49b9-85dd-9ada0b16c3b0" />

<img width="1905" height="904" alt="Ekran görüntüsü 2025-12-19 100941" src="https://github.com/user-attachments/assets/ebcdd3b9-4494-468d-b53a-4f8fc2ebbc3b" />


<img width="1898" height="911" alt="Ekran görüntüsü 2025-12-19 101142" src="https://github.com/user-attachments/assets/d34d064e-4abf-499a-8a1b-0479e28697ca" />

<img width="1903" height="907" alt="Ekran görüntüsü 2025-12-19 101243" src="https://github.com/user-attachments/assets/ff555e14-706c-4325-9359-106b20a2c340" />


# Admin Paneli

<img width="1913" height="913" alt="Ekran görüntüsü 2025-12-19 101300" src="https://github.com/user-attachments/assets/fa48d9f5-e2f0-4adf-8227-a94b6f3b2cb0" />

<img width="1908" height="910" alt="Ekran görüntüsü 2025-12-19 101310" src="https://github.com/user-attachments/assets/467700e9-ac3f-4e5f-8e18-b564c706dae0" />

<img width="1908" height="834" alt="Ekran görüntüsü 2025-12-19 101341" src="https://github.com/user-attachments/assets/8e3596ef-181e-442c-b2bc-a8de8d0cbb0d" />
<img width="1919" height="889" alt="Ekran görüntüsü 2025-12-19 101359" src="https://github.com/user-attachments/assets/04dda7ab-0432-4609-9dae-ca18e204c760" />

<img width="1908" height="905" alt="Ekran görüntüsü 2025-12-19 101417" src="https://github.com/user-attachments/assets/de1768e5-3daa-4c7c-ae75-57443b1f146e" />

<img width="1903" height="911" alt="Ekran görüntüsü 2025-12-19 101430" src="https://github.com/user-attachments/assets/0a8b5bed-7b08-4b2c-a154-52331e094b8f" />
<img width="1903" height="911" alt="Ekran görüntüsü 2025-12-19 101430" src="https://github.com/user-attachments/assets/78da8b32-4906-4946-bf3b-0cb46a812d53" />

<img width="1912" height="909" alt="Ekran görüntüsü 2025-12-19 101438" src="https://github.com/user-attachments/assets/be29ca02-6328-4417-b489-2814e2550603" />


<img width="1917" height="926" alt="Ekran görüntüsü 2025-12-19 101444" src="https://github.com/user-attachments/assets/2c02a183-d339-48d0-88c7-904d9e793440" />



<img width="1913" height="909" alt="Ekran görüntüsü 2025-12-19 101453" src="https://github.com/user-attachments/assets/2c10f346-71fe-4c13-a7ce-4179fcb9e6a4" />



<img width="1911" height="909" alt="Ekran görüntüsü 2025-12-19 101503" src="https://github.com/user-attachments/assets/9004e55e-d9cc-4c4e-95c4-171e1a0ed5b7" />
<img width="1908" height="917" alt="Ekran görüntüsü 2025-12-19 101513" src="https://github.com/user-attachments/assets/0eacf35d-526a-4795-9d2a-321aea86679a" />

#proje katmanları

<img width="348" height="883" alt="Ekran görüntüsü 2025-12-19 101534" src="https://github.com/user-attachments/assets/746c9b94-72b0-4e04-aff6-8d694d51cee2" />


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
