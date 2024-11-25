#  <img height="50" src="https://user-images.githubusercontent.com/25181517/121405384-444d7300-c95d-11eb-959f-913020d3bf90.png"> EĞİTİM KAMPI
👋 Merhabalar, oluşturmuş olduğum bu repo, Murat Yücedağ hocamızın YouTube üzerinden hazırlamış olduğu C# Eğitim Kampı süresince tamamlamış olduğum projeleri içermektedir. Bu eğitimde 301 modül olan N Katmanlı Mimari - Entity Framework konuları anlatılmaktadır.

## 🖥️ C# Eğitim Kampı Ders 11 - OOP Modülü: C# ile N Katmanlı Mimari Entity Layer
### 📆 Tarih: 29 Ekim 2024
### 📋 C# ile Yapılan Uygulamalar:

## N Katmanlı Mimari nedir?

Katmanlar sorumlulukların ayrılması ve bağımlılıkların yönetilmesi için kullanılan bir yöntemdir. Her katmanın belirli bir sorumluluğu vardır. Daha yüksek bir katman, hizmetleri daha düşük bir katmanda kullanabilir ancak daha düşük bir katman, hizmetleri daha yüksek bir katmanda kullanamaz. N katmanlı mimariler şunlardır:

** EntityLayer: Bu katmanda projeye ait entityler tanımlanacak.

** DataAccessLayer: Bu katmanda projeyle ilgili veri tabanı işlemleri yazılacak.

** BusinessLayer: Bu katmanda logic sorgulamaları yapılacak.

** PresentationLayer: Bu katmanda ise veritabanında çektiğimiz verileri kullanıcıya sunma katmanımızdır.

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

✅ Bu eğitimde N Katmanlı Mimari'lerin ne işe yaradıklarını, katmanları ve EntityLayer katmanında yer alan entityleri oluşturmayı, Field-Variable-Property arasındaki farkları ve SOLID prensiplerin ne işe yaradıklarını öğrendim ve uyguladım.

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

"name" kısmı bağlantı adresimize ait tablolar hangi sınıfta tutuluyorsa "KampContext" buraya ismini veriyoruz.

connectionString bağlantı adresin olduğu kısmı temsil etmektedir. Yazacağımız komut sırayla şu şekilde olacaktır. Data Source = "SQL'e bağlanırken gelen bir bağlantı sunucu adresimizi temsil eder." ; initial Catalog = "Oluşturacağımız veri tabanın ismidir." ; integrated security = true kısmı ise bağlantının güvenli olduğunu bildirmek için kullanılır. Daha sonra providerName = "System.Data.SqlClient" olacaktır.

### DataAccessLayer katmanına gidip kalan klasörlerimizi oluşturuyoruz. Bu klasörler; Repositories, Abstract ve EntityFramework olacaktır.

✅ Bu eğitimde entityler arasındaki ilişkileri kurmayı, katmanlarda yer alan paketleri kurmayı, referansları eklemeyi, bağlantı sınıfının nasıl oluşturulduğunu öğrendim ve uyguladım.

## 🖥️ C# Eğitim Kampı Ders 13 - OOP Modülü: Migration İşlemleri ve Abstract Interfaceler
### 📆 Tarih: 9 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

Bu eğitimde "Migration" işlemini yapacağız.

![image](https://github.com/user-attachments/assets/e5008cbe-77dd-4e10-badd-4a55c14dfef0)

Burada Package Manager Console uygulamasını açmak için Yukarıda yer alan View kısmında yer alan Other Windows kısmına geliyoruz ve Package Manager Console kısmını seçiyoruz. Diğer bir yol ise Yukarıda yer alan Tools kısmından NuGet Package Manager kısmına geliyoruz ve Package Manager Console kısmını seçiyoruz.

### NOT: Uygulama başlangıcında PresentationLayer katmanında çalışması gerekmektedir.

![image](https://github.com/user-attachments/assets/790468ff-8eed-4ed2-b60d-7cbe5d081ddf)

Package Manager Console bu şekilde karşımıza çıkacaktır. Burası hem migration komutlarını yazabileceğimiz, hem de paket yüklemesi yapabileceğimiz konsol ekranıdır. Clear yazdığımızda ekranı temizleyecektir.

![image](https://github.com/user-attachments/assets/288397bb-3638-4e97-9d04-29604a6baed3)

### Not: Migration işlemlerini yapabilmek için burada Default project kısmından mutlaka DataAccessLayer katmanı seçilmelidir.

![image](https://github.com/user-attachments/assets/c5157515-33a6-4198-bbdb-5b0ca880a623)

Migration işlemini aktif edebilmek için yazacağımız komut: enable-migrations olacaktır. Bu işlem biraz uzun sürecektir.

![image](https://github.com/user-attachments/assets/560e93d2-8748-470d-b410-1c9324cf2bd4)

Karşımıza bu şekilde çıkacaktır.

![image](https://github.com/user-attachments/assets/039a537a-610c-4c5d-bf89-e88f3cec8339)

Burada AutomaticMigrationsEnabled = false yazan kısmı true olacak şekilde belirtmemiz gerekir.

![image](https://github.com/user-attachments/assets/84ad7fa8-8e29-4993-8501-98ffcfe1632f)

Veri tabanına yansıtmak için update-database komutunu yazıyoruz.

![image](https://github.com/user-attachments/assets/fa6b6e06-fc9a-4781-8072-c358e99bb1d9)

Ekranda bu şekilde çıktıysa veri tabanına yansıma işlemi tamamlandı demektir.

![image](https://github.com/user-attachments/assets/f1d5f9d7-e252-4ddc-9024-1cfb3018f872)

SQL'e baktığımızda veri tabanı ve tablolar oluşturuldu.

![image](https://github.com/user-attachments/assets/cd772ad4-261e-4919-9846-d1c57cc183a6)

Category tablosunda yer alan propertyler burada gözükmektedir.

İşlemler tamamlandıktan sonra EntityLayer katmanında yer alan Customer sınıfına yeni bir property ekliyoruz.

![image](https://github.com/user-attachments/assets/5e02c8b1-ff8b-47eb-b119-521d16f7d99e)

Burada bir tane bool türünden CustomerStatus ekledik. Tekrardan migration işlemini uyguluyoruz.

![image](https://github.com/user-attachments/assets/3a004d48-af15-4cac-a607-2852789da69b)

Buradan itibaren artık tekrardan enable-migrations dememize gerek yoktur, çünkü migration otomatik olarak güncellenecektir. Bunun için add-migration komutundan sonra istediğimiz bir isim belirliyoruz. Burada mig1 olarak belirledik.

![image](https://github.com/user-attachments/assets/144c960c-0e26-45cc-96e5-ac83ab5b51a3)

Karşımıza bu şekilde çıkmaktadır. Sağ tarafta DataAccessLayer katmanında yer alan Migrations klasörüne baktığımızda burada ismini verdiğimiz mig1 sınıfı oluşturuldu.

İşlemimizi tamamladıktan sonra tekrardan update-database diyoruz.

Artık DataAccessLayer katmanında yer alan Abstract klasörüne gelip buradan işlemlerimizi yapabiliriz. Abstract klasörü bizim interfacelerimizi tutacaktır. Interfaceler, bizim entitylerimiz için bütün entitylerde standart olan bazı metotlar var. Ekleme, silme, güncelleme, listeleme, ID'ye göre getirme gibi... Burada değişen tek şey entitynin kendisi olacaktır, ancak diğer işlemler aynı şekilde olacaktır. Burada Repository Design Pattern kullanıyor olacağız.

![image](https://github.com/user-attachments/assets/6306cb51-c71b-4821-ba46-b4526903a751)

Abstract klasörüne sağ tıklayıp Add kısmından New Item diyoruz.

![image](https://github.com/user-attachments/assets/87a8e436-51b4-4cee-a424-ab5a82d738c2)

Buradan Class değil, Interface olanı seçiyoruz ve ismini IGenericDal olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/931ad352-6cec-4b4f-99d6-cb68d705f594)

Burada dışarıdan bir T değeri almalı ve bir tane şart yazılmalıdır. Bu T değeri mutlaka bir class olmalıdır. Böylece dışarıdan harici bir interface, method veya bileşen gelmemelidir. Burada ekle, sil, güncelle işlemlerini bu interface'e uygulayacağız.

![image](https://github.com/user-attachments/assets/399bd41e-c163-42d5-a585-935c2b93acbd)

Burada 5 tane metot ekledik. İlk olarak void türünden Insert isminde bir metot ekledik. Parantez içerisinde T türünden entity parametresi olarak belirledik. İkinci metotta tekrar void türünden Update isminde bir metot ekledik. Parantez içerisinde T türünden entity parametresi olarak belirledik. Üçüncü metotta void türünden Delete için bir tane int türünden ID göndermemiz gerekecektir. Ardından bir tane List oluşturuyoruz ve T türünden GetAll isminde bütün verileri getirecek olan bir metot oluşturuyoruz. Son olarak T türünde GetByID isminde dışarıdan bir int id parametresi alan bir metot tanımlamış olduk.

Abstract klasöründen bir tane daha Interface oluşturalım. Bu kez ICategoryDal ismini verelim.

![image](https://github.com/user-attachments/assets/33b808f1-2f11-4b4f-8643-a94ce05cefe6)

Public olarak belirledikten sonra ICategoryDal sonuna gelip : işareti koyuyoruz ve IGenericDal'dan miras alıyoruz. Bu mirası Category sınıfından almış oluyoruz. Artık Category sınıfı için ekleme, silme, güncelleme işlemlerini hazır hale getirmiş olduk.

Diğer bütün interfacelerini de aynı şekilde yapıyoruz.

✅ Bu eğitimde migration yapmak için gerekli olan komutları yazmayı, N Katmanlı Mimari'de yer alan DataAccessLayer katmanına ait olan Abstract klasöründe yer alan Interface'leri oluşturmayı, CRUD işlemlerini oluşturmayı öğrendim ve uyguladım.

## 🖥️ C# Eğitim Kampı Ders 14 - Orm Yapısı: Entity Framework DbFirst ve Model Oluşturma
### 📆 Tarih: 12 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

Bu eğitimde Solution üzerinden yeni bir proje oluşturuyoruz, oluşturacağımız proje Windows Forms App (.NET Framework) olanı seçiyoruz. İsmini CSharpBootcamp301.EFProject olarak belirliyoruz.

Bu projemizde ilk olarak CSharpBootcamp301.EFProject katmanına sağ tıklayıp Set as Startup Project diyoruz. Daha sonra tekrardan aynı katmana sağ tıklayıp Scope to This diyoruz. Ardından SQL veri tabanımızı açıyoruz ve sadece bu projeye özgü tablolar oluşturuyoruz.

SQL'e gelip yeni bir tane veri tabanı oluşturuyoruz. Burada ismini BootcampEfTravelDb olarak belirledik.

![image](https://github.com/user-attachments/assets/55a77ce7-bac2-4e79-9353-a293f66c901e)

Sıra sıra tablolarımızı oluşturuyoruz. İlk tablomuzun ismini TblCustomer olarak belirledik.

![image](https://github.com/user-attachments/assets/a1ce3d12-4b23-4859-ac5d-e3248a02c845)

İkinci tablomuzun ismini TblLocation olarak belirledik.

![image](https://github.com/user-attachments/assets/a531d17c-1edc-4cba-894f-5999d705c53d)

Üçüncü tablomuzun ismini TblGuide olarak belirledik.

![image](https://github.com/user-attachments/assets/e5baf687-bea6-4c4f-90ff-90022652754a)

Location tablosuna gelip GuideID ekliyoruz.

![image](https://github.com/user-attachments/assets/6252b253-137e-4dd3-a4b5-f7ed4612a8c8)

İlişkili tabloları oluşturmak için ilgili veri tabanında yer alan Database Diagrams klasörüne sağ tıklayıp New Database Diagram diyoruz.

![image](https://github.com/user-attachments/assets/b26a1d99-7a5a-4880-8692-49dc21888f81)

Guide ile Location tablolarını seçiyoruz, isterseniz hepsini de seçebilirsiniz ancak burada ilişkili tablolar hangileriyse onları aldık. Add dedikten sonra Close diyoruz.

![image](https://github.com/user-attachments/assets/32fbbf01-f148-4b50-9a0f-809c2fcf8eee)

Burada TblGuide tablosunda yer alan GuideID kısmında yer alan anahtara basılı tutup TblLocation tablosunda yer alan GuideID olan özelliğe sürüklüyoruz.

![image](https://github.com/user-attachments/assets/5f5f2eb2-f38c-4997-8323-3a0dd3bd32cd)

Karşımıza bu şekilde çıkacaktır. OK diyoruz.

![image](https://github.com/user-attachments/assets/ff521466-51c4-4c0d-ab54-66b2ffab177d)

İlişkili tablomuz hazır. Bu tabloyu kaydediyoruz ve ismini değiştirmeye gerek duymuyoruz.

## Entity Framework nedir?

Entity Framework, ADO.NET için geliştirilmiş open-source bir Object-Relational Mapping (ORM) Frameworküdür. Database procceslerini, .NET nesneleri aracılığıyla daha kolay ve daha etkili bir şekilde gerçekleştirmenize yardımcı olur. Bu sayede, developerlar database querylerini ve işlemlerini SQL yerine C# ile yazabilirler.

Entity Framework ile 4 farklı yöntem kullanarak proje geliştirebilirsiniz. Bu yöntemler;

* Model First (Yeni Veritabanı Oluşturma Visual Studio İle)
  
* Database First (Var Olan Veritabanını Kullanma)
  
* Code First (Yeni Veritabanı Kod Yazarak)
  
* Code First(Var Olan Veritabanını Kullanma)

### Model First 

Bu yöntem Visual Studio üzerinde boş bir model dosyası (.edmx) eklenerek veritabanını bu model üzerinde tasarlanabilmesine olanak sağlıyor. Derleme adımında verilen script dosyası veritabanını oluşturur.

### Database First

Bu yöndem önceden oluşturulmuş olan veritabanını projeye model olarak bağlayarak gerekli classlarımız Entity Framework tarafından oluşturulmaktadır.

### Code First (Kod Yazarak)

Bu yöntem classlarımızı visual studio ortamında oluşturmaya başlayarak gerçekleştirdiğimiz bir yöntemdir. Veritabanımız bu classlardan türetilmektedir. Burada Mapping işlemleri yazılımcı tarafından classlar oluşturulurken Attribute’lar sayesinde yapılabilmektedir. Bu arada Mapping işlemi kısaca tablolarımızdaki kısıtlarımızı belirlediğimiz olaydır. Attribute’ların yanında farklı yöntemlerlede bu işlemleri gerçekleştirebilmekteyiz. Örnek vermek gerekirse Fluent Api veya Fluent Validation gibi araçlar Mapping işlemleri için popüler olarak kullanılmaktadır.

### Code First (Var Olan Veritabanını Kullanma)

Bu yöntemde de classlar ve mapping kodları yazılımcı tarafından oluşturulmaktadır. Veritabanımız classlarımızın ve modellemenin durumuna göre güncellenmektedir.

Projemize dönelim. Önce bir tane klasör ekleyelim. Daha sonra Solution kısmına sağ tıklayıp Add kısmından New Item seçiyoruz.

![image](https://github.com/user-attachments/assets/3f242c92-4dd1-4add-a4d5-cb6ad221b049)

Sol tarafta bulunan Data sekmesine tıklayıp en üstte çıkan ADO.NET Entity Data Model'i seçiyoruz.

![image](https://github.com/user-attachments/assets/9953fc15-8366-44d4-84ee-f7cc8efc8f9e)

Seçtikten sonra karşımıza bu şekilde çıkacaktır. Burada ilk sıradakini seçiyoruz.

![image](https://github.com/user-attachments/assets/e7339ca6-52e4-43ed-a3cc-1e73528bacc6)

Burada daha önceden bir bağlantı oluşturmadığım için burası bana boş gözükecektir. Sağ tarafta bulunan New Connection'a tıklıyoruz.

![image](https://github.com/user-attachments/assets/0d3047de-f135-45ae-a7ea-5a1c4c9317bc)

Server name kısmı burada SQL'e ait olan sunucuyu girmemiz gerekecektir.

![image](https://github.com/user-attachments/assets/decb909d-0252-4451-8280-51509fc00d43)

Burada server adını girdikten sonra gelişmiş versiyonlarda Trust Server Certificate kısmını true olarak işaretliyoruz. Daha sonra aşağıda yer alan Select or enter a database name kısmına gelip hazırlamış olduğumuz veri tabanını seçiyoruz ve OK diyoruz.

![image](https://github.com/user-attachments/assets/54cb4617-cc99-4fad-80e9-b50ee47f5b0e)

Modelimiz oluştuktan sonra Next diyoruz.

![image](https://github.com/user-attachments/assets/febc994e-7149-449b-b73c-0aea0a8b82a9)

Burada 6.x sürümü seçili olarak gelecektir, Next diyoruz.

![image](https://github.com/user-attachments/assets/9b36e291-567f-4d78-a873-24b4cf37dd66)

Burada Tables kısmından bütün alanları seçiyoruz ve Finish diyoruz.

NOT: sysdiagrams, SQL Server'da veritabanı diyagramlarını yönetmek için kullanılan bir sistem tablosudur ve veritabanı şemasının görsel temsillerini saklar.

![image](https://github.com/user-attachments/assets/8a6bf15a-4540-4988-aa72-d3346bba764b)

Modelimiz artık hazır.

✅ Bu eğitimde bir Db First oluşturmayı, modelin nasıl oluşturulduğunu, Entity Framework'ün ne işe yaradığını öğrendim ve uyguladım.

## 🖥️ C# Eğitim Kampı Ders 15 - Entity Framework Metotları ile Proje Uygulaması
### 📆 Tarih: 16 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

![image](https://github.com/user-attachments/assets/9c3144cf-221a-4837-9df5-17ca8d73a441)

Burada daha önceden oluşturduğumuz BootcampEfTravelDb veri tabanına geliyoruz. Oluşturduğumuz TblCustomer tablosuna gelip yeni bir sütun ekliyoruz. Sütunun ismini CustomerBalance olarak ekliyoruz ve veri tipini decimal(18, 2) olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/4667f4ae-186c-4ef0-abcf-66ef5a1b1d65)

Sütunu ekledikten sonra tekrardan C# modelimize geliyoruz ve boş alana sağ tıklayıp Update model from Database olana tıklıyoruz.

![image](https://github.com/user-attachments/assets/22f206d4-4c25-4f6f-b2fb-fed93927906d)

Burada herhangi bir seçeneğe tıklamadan direkt Finish diyoruz. Finish dedikten sonra modelimizi kaydediyoruz.

![image](https://github.com/user-attachments/assets/5843853c-0704-4db7-94a9-b5e59684a1df)

SQL veri tabanımıza tekrar geliyoruz ve bu kez yeni bir tablo oluşturuyoruz. Tablonun ismini TblAdmin olarak belirledik.

Tekrardan C# modelimize geliyoruz ve boş alana sağ tıklayıp Update model from Database olana tıklıyoruz.

![image](https://github.com/user-attachments/assets/1ec982c6-73d4-4c06-b7c1-bf6efa2a037c)

Bu kez yeni bir tablo oluşturduğumuz için buradaki Tables kısmını seçmemiz gerekecek. Finish diyoruz ve kaydediyoruz.

![image](https://github.com/user-attachments/assets/7ea4839f-6ad4-400e-bab9-2c49daeb7683)

SQL'e tekrar geliyoruz ve TblGuide tablosuna gelip veri girişleri yapıyoruz.

![image](https://github.com/user-attachments/assets/5d63f120-58e8-457c-abee-452dc9bc7f37)

Veri girişlerini yaptıktan sonra C# uygulamasından Form1 kısmına geliyoruz ve tasarımlarımızı yapıyoruz.

Burada ilk olarak Listele işlemini yapacağız. Listele butonuna çift tıklıyoruz.

![image](https://github.com/user-attachments/assets/c8309bdb-77bf-4429-8a15-a28272940857)

Listeleme işlemine baktığımız zaman ADO.NET'e göre kodlar daha kısa halindedir, ancak ilk satırda yazdığımız kod sadece o alanda çalışacaktır. Ekleme, silme işlemleri için de aynı şekilde bu komutu kullanmamız gerekecektir ancak kod yükü artmaması için ilk satırda yer alan kodu global alana taşımak doğru olacaktır.

![image](https://github.com/user-attachments/assets/071497e4-2055-4676-a958-43fb1328a63d)

Burada ekleme işlemini yaptık. Listeleme işleminde ilk sırada yer alan kodu lokal alanın dışına taşıdık. Böylece db değişkeni tüm alanda çalışacaktır.

![image](https://github.com/user-attachments/assets/39a9aa9e-4e66-4473-a273-b85ec443f60e)

Burada önce Listele butonuna bastığımız zaman SQL'de yer alan veriler burada gözükecektir. Yeni bir tane veri girişi yaptıktan sonra Ekle butonuna bastığımız zaman karşımıza mesaj ekranı çıkmaktadır. Tekrardan Listele butonuna bastığımız zaman eklediğimiz son veri gözükecektir.

![image](https://github.com/user-attachments/assets/3635f97f-bc70-431b-b9e5-f517f68fdb94)

Silme işlemi ID'ye göre yapılmalıdır. Bunun için ilk olarak int türünde id değişkeni oluşturuyoruz. Daha sonra var türünden removeValue değişkenini tanımlayarak TblGuide adlı tabloda yer alan ID'ye göre bulmak için Find metodunu yazıyoruz. Daha sonra silmek için Remove metodunu kullanıyoruz. En sonda yaptığımız değişiklikleri kaydediyoruz.

![image](https://github.com/user-attachments/assets/fa3fd3d4-2730-4069-b037-968b1cc6dba7)

Programı çalıştırdıktan sonra silmek istediğimiz ID numarasını yazıyoruz. Burada ID alanını 3 yazdıktan sonra Sil butonuna tıklıyoruz. Eğer yazılan kodlarda hata yoksa karşımıza sildiğimize dair mesaj ekranı çıkacaktır.

![image](https://github.com/user-attachments/assets/c6269c2f-f840-4eb4-8a69-1ded523ff807)

Güncelleme işlemi için silme işleminde olduğu gibi ilk olarak int türünde id değişkeni oluşturuyoruz. Daha sonra var türünden updateValue değişkenini tanımlayarak TblGuide adlı tabloda yer alan ID'ye göre bulmak için Find metodunu yazıyoruz. Daha sonra güncellenmesi için sütunda yer alan bütün verileri tek tek textbox'a karşılık gelen değerlerimizi yazıyoruz ve değişiklikleri kaydediyoruz.

![image](https://github.com/user-attachments/assets/51ae8121-4b90-48e7-9eff-bf4c598ec08c)

Burada güncellemek istediğimiz kişinin önce ID numarasını, daha sonra adını ve soyadını yazıyoruz. Cem Bulut olan ismini Can Bulutlu olarak değiştiriyoruz.

![image](https://github.com/user-attachments/assets/df072c2d-8f6b-4a02-adf4-8a6ee14d74a1)

ilk olarak int türünde id değişkeni oluşturuyoruz. Daha sonra burada bir şart yazıyoruz. Şart için Where metodunu kullanıyoruz. Burada x => ifadesi C#'da Lambda Expression diye geçmektedir. Buradaki ifadeyi int türünde oluşturduğumuz id ifadesiyle eşleştiriyoruz ve ToList metodunu kullanıyoruz. Ardından datagridview tablosunda gösteriyoruz. Burada bütün listeyi değil sadece şartı sağlayanları listede gösterecektir.

![image](https://github.com/user-attachments/assets/73e60572-46a7-4fb9-8628-2c4c499a54ec)

Örnek olarak burada ID numarasını 2 olarak yazdıktan sonra ID'ye Göre Getir butonuna bastığımız zaman sadece 2 numaralı olan kişiyi getirecektir.

✅ Bu eğitimde Entity Framework ile temel CRUD işlemlerinin nasıl yapıldığını öğrendim ve uyguladım.

## 🖥️ C# Eğitim Kampı Ders 16 - Entity Framework: Tur Projesi Location İşlemleri
### 📆 Tarih: 19 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

Bir önceki dersin tekrarını yapacağız. Önceki derste Rehber İşlemleri formu oluşturmuştuk. Bu derste ise Lokasyon İşlemleri'ni gerçekleştireceğiz.

![image](https://github.com/user-attachments/assets/bb5df4c7-affd-44db-8fa5-88f986ee769e)

Bunun için CSharpBootcamp301.EFProject katmanına sağ tıklayıp Add kısmından Form (Windows Forms) kısmına geliyoruz.

![image](https://github.com/user-attachments/assets/788e8337-7baf-4e18-afe6-e5bd6e8d2e09)

Oluşturacağımız Form'un ismini FrmLocation olarak belirliyoruz.

![image](https://github.com/user-attachments/assets/34a332ae-8dca-4e10-9308-8a033ed2ff97)

FrmLocation tasarımını bu şekilde oluşturduk. Kapasite için araç olarak "NumericUpDown", Rehber için araç olarak "ComboBox" kullandık.

![image](https://github.com/user-attachments/assets/17484134-1a4c-4502-91a2-2f423603c14d)

Programı çalıştırdığımız zaman yeni forma gitmesi için buradan Program.cs kısmına geliyoruz.

![image](https://github.com/user-attachments/assets/018d1c14-2873-46e3-9fea-140e7f073744)

Buradan Application.Run fonksiyonunda yer alan new Form1 yerine FrmLocation yazıyoruz. Daha sonra SQL'e gidip TblLocation tablosuna ait veri girişleri yapıyoruz.

![image](https://github.com/user-attachments/assets/4e41afae-30d0-4e2d-90e6-31bb8154d3e0)

TblLocation tablosuna ait veri girişlerimizi yaptık.

![image](https://github.com/user-attachments/assets/4659f397-7465-489b-ad54-1d85fe9b3f48)

Form ilk açıldığı zaman ComboBox'a direkt rehberin adı ve soyadını çekmesi için ilk olarak var türünden values adında bir değişken kullandık. Buradan TblGuide tablosundan Select metodunu kullanarak Lambda Expression yöntemiyle "FullName" adında bir değişken oluşturduk. Buradan hem adını hem de soyadını ve ID'yi getirdik. Daha sonra ComboBox'a adını verdiğimiz cmbGuide işleminde DisplayMember ve ValueMember komutlarını yazdık. DisplayMember, kullanıcının gördüğü tarafı, ValueMember ise arka planda hangi değeri tutacağı belirtmektedir. Buradaki DisplayMember kısmında daha önce tanımladığımız FullName ismini, ValueMember kısmı ise SQL'de oluşturduğumuz GuideID ismini yazıyoruz. Buradaki isim SQL'deki sütun ismiyle aynı olmak zorundadır. En sonda verileri göstermek için DataSource komutunu kullanarak values ile eşitledik.

![image](https://github.com/user-attachments/assets/b12ffaa9-cdd8-4cae-a994-f1305e49d597)

![image](https://github.com/user-attachments/assets/bc6fff32-9777-4709-bf03-ea5d36c04b92)

Listeleme, ekleme, silme ve güncelleme komutları bu şekildedir.

✅ Bu eğitimde Entity Framework ile temel CRUD işlemlerinin bu kez Lokasyon İşlemleri üzerinden nasıl yapıldığını öğrendim ve uyguladım.

## 🖥️ C# Eğitim Kampı Ders 17 - Entity Framework Metotları ve Linq Sorgular
### 📆 Tarih: 23 Kasım 2024
### 📋 C# ile Yapılan Uygulamalar:

Bu derste LINQ sorguları kullanarak istatistik oluşturacağız.

### LINQ Nedir?
LINQ (Language Integrated Query — Dil ile Tümleşik Sorgu); veri koleksiyonlarını sorgulamak, verileri filtrelemek veya dönüştürmek gibi işlemleri kolaylaştıran güçlü bir teknolojidir.

Projemize yeni bir Windows Form oluşturuyoruz ve ismini FrmStatistics olarak belirliyoruz.

Kullanılan Araçlar: Panel, Label

![image](https://github.com/user-attachments/assets/8e347720-a544-4c79-a073-6d5d1a4f8c72)

FrmStatistics tablosu bu şekilde hazırlanmıştır.

![image](https://github.com/user-attachments/assets/714c000f-c02a-4dde-97a8-a715018f7d5f)

İstatistik formunda yer alan birinci kısımda bizden "Lokasyon Sayısı" bulmamız istenmektedir. Sayısını bulmak için TblLocation tablosundan Count metodunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/c1d15c57-4146-467a-ab7b-a72d9dbdbabc)

Toplam kapasiteyi bulmak için bu kez TblLocation tablosundan Sum metoduyla "Capacity" olan değerini topluyoruz.

![image](https://github.com/user-attachments/assets/603bdea2-fdd9-45d1-9643-bc90c479b927)

Rehber sayısını bulmak için bu kez TblGuide tablosundan Count metodunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/a2b9c214-d44f-40da-b228-dc598e0c79cc)

Ortalama kapasiteyi bulmak için TblLocation tablosundan bu kez Average metoduyla "Capacity" olan değerinin ortalamasını alıyoruz. Buradaki sonuç virgülden sonra küsüratlı sayı verecektir, ancak biz sadece virgülden sonra iki basamak görmemiz için burada hata vermemesi adına ilk olarak ?(nullable) işaretini ekliyoruz ve daha sonra ToString metodundan sonra parantez içine iki basamaklıyı görebilmemiz için "0.00" değerini yazdık.

![image](https://github.com/user-attachments/assets/160f4429-c21d-4edd-abe0-708702371e86)

Ortalama tur fiyatını bulmak için TblLocation tablosundan Average metoduyla bu kez "Price" olan değerinin ortalamasını alıyoruz.

![image](https://github.com/user-attachments/assets/42fbe53a-6ae2-419b-b637-0f9d6268cca1)

Eklenen son ülkeyi bulmak için burada bir tane int tipinde ülkeye dair bir ID değişkeni oluşturduk. Buradaki Max metodu en büyük olan değeri almaktadır. Buradaki ID değerini almamızın sebebi en son değer hangisiyse onu alacaktır. Form'a yansıtmak için burada şartlı işlem yapabilmek için Where metodunu kullanıyoruz. Where metodundan sonra burada bizim ülkeyi bulmamız için önce LocationID'yi bulmamız gerekmektedir. LocationID'yi ilk oluşturduğumuz int tipinde olan değişken birbirine eşitse Select metodundan ülkeyi seçiyoruz. 

FirstOrDefault(): Bu yöntem, belirtilen bir koşulu karşılayan bir dizinin ilk öğesini veya böyle bir öğe bulunamazsa varsayılan bir değeri döndürür.

![image](https://github.com/user-attachments/assets/ed4a7f18-e1b5-48dd-a066-cf533dc782cf)

Kapadokya tur kapasitesini bulmak için burada TblLocation tablosundan bir şart yazmamız gerekecektir. Buradaki şart City değeri Kapadokya değerine eşit midir ona bakılmalıdır, ancak burada yazılan Kapadokya değeri SQL'de yer alan değerle aynı olmalıdır. Eğer değer eşitse Select metodundan Capacity değerini buluyoruz ve FirstOrDefault metodunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/36d8ab0e-9742-4b39-97bb-3f9cb9b8cf74)

Türkiye turları ortalama kapasiteyi bulmak için TblLocation tablosundan bir şart yazmamız gerekecektir. Buradaki şart Country değeri Türkiye ise Average metodunu kullanarak Capacity değerinin ortalamasını alıyoruz.

![image](https://github.com/user-attachments/assets/c4d111dc-26f9-45d6-bf4e-b7d65a5b9006)

Roma gezi rehberini bulmak için burada var tipinde bir romeGuideID değişkeni oluşturuyoruz. Buradaki ilk şart, TblLocation tablosunda ait City üzerinden "Roma Turistik" yazılan değeri bulmak ve GuideID değerine eşitlemektir. Daha sonra TblGuide tablosundaki şart, GuideID değeri romeGuideID değerine eşit midir ona bakılmalıdır. Şart sağlıyorsa burada rehberin adını ve soyadını seçiyoruz ve FirstOrDefault metodunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/4ca48863-3f16-44a4-970c-03f00474d619)

En yüksek kapasiteli turu bulmak için burada var tipinde bir maxCapacity değişkeni oluşturuyoruz. En yüksek kapasiteyi bulmak için TblLocation tablosundan Capacity üzerinden Max metodunu kullanıyoruz. Yazdırmak için TblLocation tablosundan bir Where sorgusu yazıyoruz. Buradaki sorgu TblLocation tablosunda yer alan Capacity ile maxCapacity değeri eşitse City değerini seçiyoruz ve FirstOrDefault metodunu uyguluyoruz.

![image](https://github.com/user-attachments/assets/51ba0d81-9151-4214-9bbc-e7ca91c366fe)

En pahalı turu bulmak için az önceki örnekte yapmış olduğumuz uygulamayı bu kez Capacity yerine Price olarak çeviriyoruz.

![image](https://github.com/user-attachments/assets/5717df4e-8d7e-4d9e-b8f2-d6780a2511d1)

Ayşegül Çınar tur sayısını bulmak için burada var tipinde guideIDByNameAysegulCinar adında bir değişken belirliyoruz. Buradaki şart, TblGuide tablosunda yer alan rehberin adı "Ayşegül" ve soyadı "Çınar" olan değerinin ID'sini getiriyoruz. Daha sonra TblLocation tablosunda yer alan GuideID ile guideIDByNameAysegulCinar değerleri eşitse Count metodunu uygulayarak tur sayısını buluyoruz.

![image](https://github.com/user-attachments/assets/52eb8f25-2134-4862-9b0c-c41497e4d3ad)

Programı çalıştırdıktan sonra "İstatistikler" formunda yer alan sonuçlar bu şekilde karşımıza çıkacaktır.

✅ Bu eğitimde C# kampı çerçevesinde gerçekleştirmiş olduğum LINQ (Language Integrated Query) sorgularıyla istatistik oluşturmayı öğrendim ve uyguladım.
