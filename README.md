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

