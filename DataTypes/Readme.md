#Veri Türleri Nedir


Veri türleri ikiye ayrılır.Bunlar Yerleşik Veri Türleri Ve Kullanıcı Taraflı Veri Türleri olarak ikiye ayrılır.

1-)YERLESIK VERI TURLERI 

object => int,bool,double vs vs vs. Bunlar temel türlerdir.

2-)KULLANICI TARAFLI VERI TURLERI

Bunlar da struct ve class olarak ikiye ayrılır.Class'lar referans tiplidir.Struct'lar ise değer tiplidir.

-----------------------------------------------------------------------------------------------------------------


#Struct Nedir ? 



 Birbirleriyle ilişkili değişkenlerin, bir isim altında toplanmasına yapı adı verilir. Yapılar, değişik veri tiplerinde elemanlar içerebilirler ve dosya içinde tutulacak kayıtları oluşturmakta kullanılırlar.

Yapılar, diğer tipte nesneler kullanılarak oluşturulan, türetilmiş veri tipleridir. Örnek bir yapı şu şekilde oluşturulabilir :

struct ogrenci
{
     public char[] ad = new char[20];
     public char[] soyad = new char[10];
     public long no;
     public short sinif;
}

-----------------------------------------------------------------------------------------------------------------


#Struct Ve Class Farkları 



Yapılar, sınıflar ile büyük benzerlik gösterirler. Sınıflar gibi tanımlanırlar ve sınıflar gibi, özellikler, metotlar, veriler, yapıcılar vb. içerebilirler. Bu benzerliklere karşın yapılar ile sınıflar arasında çok önemli farklılıklar da vardır :

1-) Yapılar bir değer türü, sınıflar ise bir referans türüdür. Referans tiplerinin sahip olduğu veriler, belleğin öbek (heap) adı verilen tarafında tutulurken, referansın adı, yığın (stack) adı verilen kısımda tutulur ve öbekteki verilerin bulunduğu adresi işaret eder. Ancak değer türleri, belleğin yığın kısmında tutulur. Sınıflara referans aracılığıyla ulaşılırken, yapılara ise doğrudan ulaşılır. Bu nedenle, yapı kullanımı sınıf kullanımına göre daha az maliyetlidir ve erişim hızı yüksektir. Büyük boyutlarda veriler ile çalışırken, bu veriler sınıf içerisinde tanımlandığında, veri aktarımı anında sadece bu verilerin öbekteki başlangıç adresi aktarılır ve ilgili parametrenin de bu adresteki verilere işaret etmesi sağlanmış olur. Böylece büyük boyutlu verileri yığına kopyalayarak gereksiz miktarda bellek harcanmasının önüne geçilmiş olunur. Ancak küçük boyutlarda veriler ile çalışırken bu verileri sınıflar içerisinde kullandığımızda bu kez de gereksiz yere bellek kullanıldığı için öbek şişer ve performans düşer. Bu konuda 16 byte'tan küçük veriler için yapıların kullanılması, 16 byte'tan büyük veriler için ise sınıfların kullanılması öngörülür.
2-) Yapılar için varsayılan bir yapıcı metot (default constructor) yazılmak istendiğinde derleyici hatası alınır. Ancak bu, değişik sayıda parametreler alan yapıcılar yazmamızı engellemez. Sınıflarda ise,  sınıfın varsayılan yapıcı metodu yazılabilir.
3-) Bir yapı içersinde yer alan "constructor" metot(lar) içinde tanımlanmış olan alanlara başlangıç değerleri atanmalıdır. Sınıftaki "constructor"(lar) içinde kullanılan alanlara başlangıç değerleri atanmaz ise, derleyici bu atamayı otomatik olarak yapar. Ancak derleyici aynı işi yapılarda yapmaz. Bu nedenle bir yapı içinde kullanılan "constructor"(lar)daki tanımlanmış olan alanlara mutlaka ilk değerlerin verilmesi gerekir.
4-) Bir sınıf oluşturulduğunda, bu, başka bir temel sınıftan kalıtım yolu ile türetilebilir ancak bir yapı başka bir yapı temel alınarak türetilemez.

 Yapıların kullanımı, verimlilik ve performans açısından önemlidir. Yapılar, bir değer tipi oldukları için, bir referans aracılığıyla değil de doğrudan kendi üzerlerinde işlem görürler. Böylece, bir yapı, ayrı bir referans değişkeni gerektimez. Bu, bazı durumlarda daha az bellek kullanıldığı anlamına gelir. Üstelik, bir yapı, doğrudan erişilebildiği için, sınıf nesnelerinin erişimlerine özgü performans kaybına da maruz kalmaz. Sınıflar bir referans tipidir. Bu nedenle, sınıf nesnelerine yapılan tüm erişimler bir referans aracılığıyla olmalıdır. Bu tür bir dolaylı erişim, erişimlerin her birine ek bir yük bindirir. Yapılar böyle bir yükün altına girmezler. Genel olarak, birbirleriyle bağlantılı küçük bir veri grubu saklaması istenildiğinde ve kalıtıma ihtiyaç yoksa ya da referans tiplerinin sağladığı diğer avantajlardan yararlanılmak istenmiyorsa, yapı tipini kullanmak daha uygun bir tercih olacaktır.


 -----------------------------------------------------------------------------------------------------------------