#  <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> EĞİTİM KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu C# Eğitim Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde C# Katmanlı Mimari konusu anlatılmaktadır.

## 🖥️ C# Eğitim Kampı Ders 11 - OOP Modülü: C# ile N Katmanlı Mimari Entity Layer
### 📆 Tarih: 29 Ekim 2024
### 📋 C# ile Yapılan Uygulamalar:

## N Katmanlı Mimari nedir?

Katmanlar sorumlulukların ayrılması ve bağımlılıkların yönetilmesi için kullanılan bir yöntemdir. Her katmanın belirli bir sorumluluğu vardır. Daha yüksek bir katman, hizmetleri daha düşük bir katmanda kullanabilir ancak daha düşük bir katman, hizmetleri daha yüksek bir katmanda kullanamaz. N katmanlı mimariler şunlardır:

## EntityLayer
Bu katmanda projeye ait entityler tanımlanacak.
## DataAccessLayer
Bu katmanda projeyle ilgili veri tabanı işlemleri yazılacak.
## BusinessLayer
Bu katmanda logic sorgulamaları yapılacak.
## PresentationLayer
Bu katmanda ise veritabanında çektiğimiz verileri kullanıcıya sunma katmanımızdır.


![Ekran görüntüsü 2024-11-24 134015](https://github.com/user-attachments/assets/224b26f4-1a33-4c51-816f-3f3a56fc3c41)

Burada "Blank Solution"ı seçip yeni bir proje oluşturuyoruz. İstediğiniz proje ismini verebilirsiniz. Burada CSharpBootcamp301 isminde bir proje oluşturuyoruz.

![image](https://github.com/user-attachments/assets/fe7df3ab-e527-423b-a00f-286875bf0e7c)

Solution kısmına sağ tıklayıp Add ksımından New Project olanı seçiyoruz.

![image](https://github.com/user-attachments/assets/48bfd8b6-0a7e-4f6c-8602-77ce7ae3c08d)

Burada Class Library (.NET Framework) olanı seçiyoruz ve ismini CSharpBootcamp301.EntityLayer olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/dd002521-9645-4039-a942-bb74bcad52c7)

İlk katmanımız hazır. Burada bize Class1 adında hazır bir sınıf gelmektedir. Kendimiz yeni bir sınıf oluşturacağımız için Class1'i siliyoruz.

![image](https://github.com/user-attachments/assets/60032810-34fe-46ad-8525-84d8c9e91a39)

Burada sınıf oluşturmadan önce entityleri bir tane klasörde toplamak işimizi daha da kolaylaştıracaktır. Bunun için CSharpBootcamp301.EntityLayer katmanına sağ tıklayıp Add kısmından New Folder diyoruz ve ismini Concrete olarak belirliyoruz. Concrete, C#'ta genellikle somut ifadeler için kullanılan bir klasör ismidir. Bu somut ifadeler genellikle sınıflarda kullanılır.

![image](https://github.com/user-attachments/assets/6b05bc79-3c79-440f-99b8-9d2d9ff9e286)

Concrete klasörüne sağ tıklayıp Add kısmından Class diyoruz.

![image](https://github.com/user-attachments/assets/80aeed09-aac3-44a7-aa8d-feb5e4521dd6)

Sınıfımızın ismini Category olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/c6c9c546-eb15-4ccd-96fd-7eec6642fa4e)

Category sınıfını oluşturduktan sonra karşımıza bu şekilde çıkacaktır. Burada erişim belirleyicilerinden ilk olarak karşımıza "internal" olarak çıkmaktadır, ancak her yere erişmesini sağlamak için "internal" yerine "public" olarak belirliyoruz. Projeye geçmeden önce erişim belirleyicileri tanıyalım.

## Erişim Belirleyiciler

### Public
Public ile tanımladığımız alanlara farklı projeler de dâhil olmak üzere Solution içerisinde her yerden erişilebilmektedir.

### Internal
Internal ile tanımladığımız bir sınıf ya da değişkene aynı Public’de olduğu gibi proje içerisinde ya da Namespace (isim alanı) içerisinde erişebiliyoruz. Internal’ın Public’ten farkı ise tanımladığı yapıya diğer projelerden ulaşım iznini vermemesidir. Internal aynı zamanda bir sınıfın varsayılan belirleyicisidir. Bir sınıfı class SınıfAdı ile Internal Class SınıfAdı tanımlamak arasında herhangi bir fark yoktur. 

### Protected
Protected ile tanımlanan alanlara sadece tanımlandığı sınıf içerisinde ya da o sınıfı miras alan (inheritance) sınıf içerisinde ulaşılabilmektedir.

### Private
Private ile tanımlanmış olan bir alana sadece tanımlandığı sınıf içerisinden ulaşılabilmektedir. Erişim belirleyiciler içerisinde erişim alanını en çok sınırlandıran ve de bir değişkenin varsayılan erişim belirleyicisi olan belirleyici Private’dır.

## Field - Variable - Property arasındaki farklar

Erişim belirleyicileri anladıktan sonra burada property tanımlayacağız. Normal şartlar altında 3 tane komut vardır. Bunlar; field, variable ve property komutlarıdır. Bunların üçünün arasında farklar vardır.
Eğer ki bir değişken, örnek olarak; 

![image](https://github.com/user-attachments/assets/705f0658-a8a2-401e-a4c5-0024a5b2dd2d)

int x; ifadesi direkt olarak sınıfın içine tanımlanırsa bu bir "Field" olur.

![image](https://github.com/user-attachments/assets/ba0c0807-1e67-4127-8926-d01356e11eb7)

Eğer ki bir değişken yapısı sonuna get ve set diye iki tane değer alırsa bu bir "Property" olur.

![image](https://github.com/user-attachments/assets/61857a1c-8040-400b-928d-af3915c635c1)

Eğer ki bir değer metot içinde tanımlanırsa bu kez  "Variable" olur.

Aradaki farkları anladıktan sonra Category sınıfına ait propertylerimizi yazalım.

![image](https://github.com/user-attachments/assets/9dd44820-10ea-4378-9c09-fb4e29de0789)

Burada Code First yapısını kullandık ve üç tane propertylerimizi yazdık. İlk olarak int tipinde CategoryID, string tipinde CategoryName ve bool tipinde CategoryStatus olarak belirledik. Code First yaklaşımı içerisinde bunun birincil anahtar olduğunu ve otomatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı yazılmalı ve ID getirilmelidir.

![image](https://github.com/user-attachments/assets/20bae836-5444-4bb2-8bdd-63ae070165a2)

İkinci "Class"ımızın ismini Product olarak belirledik ve propertylerimizi yazdık.

![image](https://github.com/user-attachments/assets/31af211e-9709-482f-a481-afba783ed2dc)

Üçüncü "Class"ımızın ismini Customer olarak belirledik ve propertylerimizi yazdık.

Burada her bir class'ı sadece o class ile ilgili olan propertylerle eşleştiriyoruz. Bunun ismine SOLID prensipleri içerisinde S harfi olan Single Responsibility diyoruz.

## SOLID Prensipleri nelerdir?

### S - Single Responsibility Principle
Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir, o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir) yapması gereken yalnızca bir işi olması gerekir.

### O - Open-Closed Principle
Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.

### L - Liskov Substitution Principle
Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst) sınıfların yerine kullanabilmeliyiz.

### I - Interface Segregation Principle
Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla arayüz oluşturmalıyız.

### D - Dependency Inversion Principle
Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.

![image](https://github.com/user-attachments/assets/346ce09f-4d2c-4d4e-89e0-ff50ee7a7bd8)

Dördüncü "Class"ımızın ismini Order olarak belirledik ve propertylerimizi yazdık.

Bütün "Class"larımızı tanımladıktan sonra diğer katmanlarımızı da oluşturalım. Katmanlar sırayla CSharpBootcamp301.DataAccessLayer, CSharpBootcamp301.BusinessLayer ve CSharpBootcamp301.PresentationLayer olarak belirliyoruz, ancak CSharpBootcamp301.PresentationLayer katmanında Class Library (.NET Framework) kısmını seçmiyoruz, onun yerine Windows Forms App (.NET Framework) olarak seçiyoruz. Başlangıç projesini belirlemek için PresentationLayer katmanına sağ tıklayıp "Set as Startup Project" diyoruz.

![image](https://github.com/user-attachments/assets/eb2734f3-a8fe-420b-bf4d-333c2156317b)

Projemizin son hali bu şekilde olacaktır.

## 🖥️ C# Eğitim Kampı Ders 12 - OOP Modülü: Data Access Katmanı ve Context Sınıfı
### 📆 Tarih: 6 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

Bu kısımda propertyler arasındaki ilişkileri kuruyor olacağız.

İlk olarak kuracağımız ilişki Category ile Product olacaktır. Bizim her bir ürünümüzün mutlaka bir kategorisi olmalıdır. Bunun için önce Product sınıfına gidiyoruz.

![image](https://github.com/user-attachments/assets/8329212b-f773-42d0-b109-27740c9e3ba6)

Burada Product tablosu üzerinden Category tablosuna gidebilmek için ilişkinin bire çok kısmının bir bölümünü yapabilmek adına bir Category türünde property eklememiz gerekmektedir. Daha sonra public virtual anahtar kelimemizi ekleyerek Category sınıfından Category ismini tanımlıyoruz. Category tablosunu da bundan haberdar etmemiz gerekir. Bunun için Category sınıfına gidiyoruz.

![image](https://github.com/user-attachments/assets/3f0b5cf8-faf0-4399-8ff5-13db5d912ec8)

Burada List metodunu ekleyerek ismini Products olarak belirledik. Her bir ürünün sadece bir tane kategorisi olacağı için çoğul olarak belirledik.

Order sınıfına geliyoruz. Satış yaptığımız sırada satış yaptığımız ürüne ait bilgi olmalıdır. Bunun için Order ile Product arasındaki ilişkiyi kuruyoruz.

![image](https://github.com/user-attachments/assets/ee22c733-61ae-42a3-aeba-bad59d0c83b7)

Order sınıfından Product ile ilişkiyi kurduk.

![image](https://github.com/user-attachments/assets/820b9dc5-349c-41d5-acb9-2785381c670f)

Product sınıfına giderek List türünden Orders olarak belirledik.

Order sınıfına dönerek birkaç ekleme yapıyoruz.

![image](https://github.com/user-attachments/assets/5651fd83-eb30-46fa-ab28-84f98c47f226)

Bu kez Order - Customer sınıfları arasındaki ilişkiyi kuruyoruz.

![image](https://github.com/user-attachments/assets/95e80377-694c-4666-aa4c-5f5c548e27fb)

Customer sınıfına gidip Order ile arasındaki ilişkiyi kurmuş olduk.

![image](https://github.com/user-attachments/assets/df6a77d6-73f2-4a59-b5b4-3f491d9e0aa3)

Tüm ilişkileri kurduktan sonra EntityLayer katmanına sağ tıklayıp Manage NuGet Packages diyoruz.

![image](https://github.com/user-attachments/assets/10bdb4e3-d6a8-4aca-bcae-9148d66706e9)

Burada sol üstte yer alan Browse kısmına tıkladıktan sonra arama çubuğuna entityframework yazıyoruz ve çıkan "EntityFramework" olana tıklayıp sağda bulunan Install kısmına tıklıyoruz. EntityLayer katmanında yer alan paketler yüklenecektir.

Bu katmanlar birbirine refere ederek gidecekler. EntityLayer katmanı DataAccess katmanına referans olarak verilecek. DataAccess katmanı bu kez Business katmanına referans olarak verilecek ve Business katmanı doğal olarak Presentation katmanına referans olarak verilecektir. Katmanlar PresentationLayer > BusinessLayer > DataAccessLayer > EntityLayer şeklinde gidecektir.

DataAccessLayer katmanına gidiyoruz.

![image](https://github.com/user-attachments/assets/ac7f7f8a-a362-4bde-99b5-5098e61df73e)

Projeye referans verebilmek adına ilk olarak DataAccessLayer katmanına sağ tıklayıp Add kısmından Reference kısmını seçiyoruz.

![image](https://github.com/user-attachments/assets/6cf6ea1f-f3d0-4888-927e-047321a81a58)

Buradan EntityLayer katmanını seçiyoruz ve OK diyoruz.

Referans işlemi tamamlandıktan sonra DataAccessLayer katmanına yeni bir klasör oluşturuyoruz ve ismini Context olarak belirliyoruz.
Context Code First projelerinde bizim veri tabanı bağlantı adresimizi tuttuğumuz ve veri tabanına yansıyacak olan tabloları tuttuğumuz bir sınıf görevi görmektedir.
Context klasörüne sağ tıklayıp bir tane Class oluşturuyoruz ve ismini KampContext olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/d5f4319e-23b7-4719-8c0a-5def079c7b7f)

KampContext sınıfımıza bir tane DbContext sınıfını eklememiz gerekmektedir, ama önce DataAccessLayer katmanına gelip "Manage NuGet Packages" kısmına geliyoruz ve EntityLayer katmanında yapmış olduğumuz EntityFramework paketini bu katmana da yüklüyoruz.

![image](https://github.com/user-attachments/assets/18c28a45-1a4a-4d20-8c93-712848c4f74d)

DbContext sınıfını ekledikten sonra EntityLayer katmanında yer alan tüm sınıfları buraya DbSet türünde çağırıyoruz. Bizim veri tabanına yansıyacak olan bütün sınıflarımız bunun içinde yer alacak. Bir sınıfına veri tabanına yansıtmak istiyorsak mutlaka KampContext içine yazmamız gerekiyor. DbSet kısmında yer alan Category, bizim C# tarafında kullanacak olduğumuz sınıfımızın ismidir. Categories ifadesi ise SQL'e yansıyacak olan tablo ismidir. Bunun programlamadaki karşılığı pluralized olarak geçiyor. Sınıf ile tablo birbirinin içine girmesin diye, birbirinden ayırt edilsin diye yalın hali C# tarafında, çoğul hali ise SQL tarafında kullanmamız gerekir.

EntityLayer katmanına gidip yeni bir tane sınıf ekliyoruz ve ismini Admin olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/3f3b9a0c-4505-433a-baa7-e8006521d5ad)

Admin sınıfına ait olan propertyleri ekledik ve KampContext'e gelerek bu sınıfı da dahil ediyoruz.

Burada veri tabanı bağlantı adresine ihtiyacımız olacak. Bunun için BusinessLayer katmanına sağ tıklayıp Add kısmından Reference kısmına geliyoruz.

![image](https://github.com/user-attachments/assets/cdb0a208-411d-4cb4-b8ff-437076252328)

Buradan EntityLayer ve DataAccessLayer katmanlarını seçiyoruz.

PresentationLayer katmanına da aynı şekilde sağ tıklayıp Add kısmından Reference kısmına geliyoruz ve bütün katmanları seçiyoruz.

![image](https://github.com/user-attachments/assets/bc7e21e7-6148-473f-b870-061307cb2730)

Tüm katmanların referans işlemlerini tamamladıktan sonra SQL bağlantı adresine ihtiyacımız olacak. Bunun için PresentationLayer katmanına gelip App.config olana tıklıyoruz.

![image](https://github.com/user-attachments/assets/25883804-7b75-4a21-b276-fbe0946919f6)

App.config kısmına geldiğimizde karşımıza ilk bu şekilde çıkacaktır. Ancak tekrar bu katmana da EntityFramework paketi yüklememiz gerekmektedir.

![image](https://github.com/user-attachments/assets/41df8448-c683-418a-95b2-002be2143b16)

Paketi yükledikten sonra karşımıza bu şekilde çıkacaktır.

![image](https://github.com/user-attachments/assets/91ca8ba7-0612-42aa-82b6-ec9da87cf30c)

Bağlantı adresimizi vermek için configuration bittiği kısmın hemen üstüne connectionStrings etiketi oluşturuyoruz. Daha sonra add kısmından name diyoruz.

## "name" kısmı bağlantı adresimize ait tablolar hangi sınıfta tutuluyorsa "KampContext" buraya ismini veriyoruz.

## connectionString bağlantı adresin olduğu kısmı temsil etmektedir. Yazacağımız komut sırayla şu şekilde olacaktır. Data Source = "SQL'e bağlanırken gelen bir bağlantı sunucu adresimizi temsil eder." ; initial Catalog = "Oluşturacağımız veri tabanın ismidir." ; integrated security = true kısmı ise bağlantının güvenli olduğunu bildirmek için kullanılır. Daha sonra providerName = "System.Data.SqlClient" olacaktır.

### DataAccessLayer katmanına gidip kalan klasörlerimizi oluşturuyoruz. Bu klasörler; Repositories, Abstract ve EntityFramework olacaktır.
