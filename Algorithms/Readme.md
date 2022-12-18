#Algoritma Nedir ? 

Algoritma kelimesi , " Hesaplamalarda veya diğer problem çözme işlemlerinde izlenecek bir dizi kural " veya " Matematiksel bir problemi, sıklıkla özyinelemeli işlemlerle sonlu sayıda adımda çözme prosedürü " anlamına gelir. 
Bu nedenle Algoritma, belirli bir sorunu çözmek için bir dizi sonlu adıma atıfta bulunur.
Algoritmaya bir problemi çözmek için izlediğimiz yol diyebiliriz.
Algoritmalar, neyi çözmek istediğinize bağlı olarak basit ve karmaşık olabilir.
Tasarlanan Algoritma dilden bağımsızdır, yani herhangi bir dilde uygulanabilecek basit talimatlardır ve yine de çıktısı beklendiği gibi aynı olacaktır.


#Algoritma Özellikleri Nelerdir ? 

1-) Açık Ve Net 
Algoritma açık ve net olmalıdır. Adımlarının her biri tüm yönleriyle açık olmalı ve tek bir anlama yol açmalıdır.

2-) İyi Tanımlanmış Girdiler 
Bir algoritma girdi alacağını söylüyorsa, iyi tanımlanmış girdiler olmalıdır. Girdi alabilir veya almayabilir.

3-) İyi Tanımlanmış Çıktılar 
Algoritma, hangi çıktının elde edileceğini açıkça tanımlamalı ve aynı zamanda iyi tanımlanmalıdır. En az 1 çıktı alınmalıdır.

4-) Sonluluk
Algoritma sonlu olmalıdır.Yani bir süre sonra sonlandırılabilmelidir.

5-) Uygulanabilir
Algoritma, mevcut kaynaklarla yürütülebilmesi için basit, genel ve pratik olmalıdır. Gelecekteki bir teknolojiyi içermemelidir.

6-) Dilden Bağımsız
Tasarlanan algoritma dilden bağımsız olmalıdır.Yani herhangi bir dilde uygulanabilen yalnızca basit talimatlar olmalıdır.Çıktı her dil için aynı olmalıdır.


#Algoritma Türleri Nelerdir ?

1-)BRUTE FORCE ALGORITMASI
Kaba kuvvet algoritması da denir.Kaba kuvvet algoritması, herhangi bir alandaki problemlerin çözümlerini garanti eden bir tekniktir ve daha basit problemlerin çözümüne yardımcı olur ve ayrıca diğer tasarım tekniklerini değerlendirmek için bir kıyaslama işlevi görebilecek bir çözüm sunar, ancak çok fazla çalışma süresi alır ve verimsizdir.
Kaba kuvvet algoritması, isminden de anlaşılacağı üzere çok zeki olmayan ve başarısını bilgisayarın yüksek hızda çalışmasından alan bir algoritmadır. Algoritma basitçe metinin tamamını çok zeki olmayan bir şekilde dolaşır ve aranan kelimenin ilk harfini bulana kadar bu işleme devam eder.
Örneğin 5^5’i brute force yaklaşımı ile aşağıdaki gibi 4 çarpma işlemi yaparak buluruz.
5^5 = 5x5x5x5x5



2-)RECURSION ALGORITMASI
Bir problemin alt problemlere bölünüp hesaplanmasına, nerde son bulacağımı belirttiğimiz ifadelere recursion (Özyineleme) diyoruz.En genel anlamı ise bir yapının (kendi kendine) yinelenmesidir.Özyinelemeli bir işlev, kendisinin bir kopyasını çağırarak ve orijinal problemlerin daha küçük alt problemlerini çözerek belirli bir problemi çözer.



3-)BACKTRACKING ALGORITMASI
Geri izleme, herhangi bir zamanda sorunun kısıtlamalarını karşılamayan çözümleri ortadan kaldırarak, her seferinde tek parça bir çözüm oluşturmaya çalışarak sorunları özyinelemeli olarak çözmeye yönelik algoritmik bir tekniktir (burada zamana göre, arama ağacının herhangi bir seviyesine ulaşana kadar geçen süre).
Örneğin, SudoKo çözme Problemini ele alalım, rakamları birer birer doldurmaya çalışıyoruz. Mevcut rakamın bir çözüme yol açamayacağını anladığımızda, onu kaldırırız (geri izleme) ve bir sonraki haneyi deneriz. Bu, saf yaklaşımdan (tüm olası rakam kombinasyonlarını oluşturmak ve ardından her kombinasyonu tek tek denemek) daha iyidir, çünkü geri gittiğinde bir dizi permütasyon düşürür.



4-)SEARCHING ALGORITMALARI
Arama algoritmaları adından da anlaşılacağı gibi, bir veri yapısı(data structure) üzerinde belirli bir verinin aranması için kullanılan algoritmalar bütünüdür. Bu veri yapısı bir liste, array ya da graph olabilir. Belirli durumlara özgü farklı arama algoritmaları geliştirilmiştir ve hepsinin birbirine göre farklı avantajları ve farklı çalışma süreleri vardır.Genel olarak bir liste ya da dizi üzerinde arama yapacaksanız iki temel kategori bulunmakta. Bunlardan biri Sequential(Sıralı/Ardışık) Search, diğeri ise Interval(Aralıklı) Search. Bunların altında da farklı algoritmalar geliştirilmiştir. Bunlardan en basit ve anlaşılır olanlardan ikisi de Linear Search ve Binary Search.

Sequential Search, veri yapımızda verilerin belli bir sıra ile tutulmadığı ve en kötü durumda arama için dizideki her bir veriyi ziyaret edeceğimiz arama çeşididir. Bunun en güzel örneği de Linear Search algoritmasıdır.

Interval Search ise sıralı veri yapısı üzerinde uygulanan algoritmalar için kullanılır. Bunun altında Binary Search, Jump Search, Exponential Search, Fibonacci Search gibi algoritmalar bulunur. Bunlar haricinde birçok farklı algoritma geliştirilmiştir. Hali hazırda bilindik bu algoritmaların da birçoğunun geliştirilmiş versiyonu bulunmaktadır. Biz bu yazıda konuya aşinalık kazandırmak için iki tane temel algoritmanın çalışma mantığına bakacağız.

**Linear Search
Bu arama algoritması en basit ve çalışma zamanı olarak en kötü algoritmalardan biridir. Çünkü en kötü ihtimal ile veri yapımız üzerinde tüm elemanları gezmesi gerekir.Linear Search, verilen veri seti üzerinde her bir eleman ile aranan değeri karşılaştırarak arar. Eğer aranan veri dizide bulunursa dizinin indeksini döner. Bulamazsa -1 gibi bir değer döner.Bu algoritmanın zaman karmaşıklığı O(n)’dir. Burada n değeri inputu temsil ediyor. Uzunluğu “n” olan bir dizi için en kötü durumda “n” kez çalışacak demek oluyor.

**Binary Search
Binary Search, sıralı(sorted) bir veri yapısı için kullanılır. Yani algoritmaya aranan veri ve sıralı bir veri yapısı verirsiniz. Algoritma da size önceki örnekteki gibi eğer bulunursa aranan verinin indeksini döner. Bunun için önce elimizdeki verinin sıralanması gerekir. Bunun bir sorting algoritması kullanırsınız.Binary Search çalışma zamanı olarak Linear Search’den daha iyidir. Her iterasyonda arama uzayını yarıya indirmek üzere tasarlanmıştır. Öncelikle dizinin ortasındaki değeri aranan değer ile karşılaştırır. Eğer aranan değer ortanca değerden küçükse dizinin ikinci yarısını görmezden gelerek ilk yarısında aramaya devam eder. Daha sonra tekrar ilk yarının ortanca değeri ile karşılaştırır. Eğer aranan değer ortanca değerden küçükse sol yarı, büyükse sağ yarı ile devam eder. Bu şekilde aranan değeri bulana kadar sürer. Aranan değer ilk iterasyonda da bulunabilir son iterasyonda da. Ancak Linear Search’den farklı olarak her bir elemanı gezmediği için aranan değeri daha hızlı bulacaktır. 



5-)SIRALAMA ALGORITMALARI	
Sıralama algoritmaları kullanmamızdaki amaç, algoritmanın isminden de anlaşılacağı üzere sahip olduğumuz veriyi en hızlı şekilde büyükten küçüğe ya da küçükten büyüğe bir sıraya sokmak. Bunun için kullanılan bir çok sıralama algoritması vardır.Bazı sıralama algoritmalarını açıklayalım ==

**Selection Sort(Seçerek Sıralama)
Selection Sort (Seçerek Sıralama) aslında performans bakımından diğer sıralama algoritmalarına kıyasla bir tık zayıf kalsa da zor durumlarımızda bize yardımcı oluyor. Uygulaması oldukça basit olan bu algoritma dizinin ilk elemanının en küçük eleman olduğunu varsayıyor. Ardından tek tek bu elemanı diğer elemanlarla karşılaştırıyor. Eğer karşılaştırdığı eleman daha küçük ise onu en küçük değer olarak alıyor ve ilk eleman yerine artık diğer elemanları onunla karşılaştırıyor. Dizinin sonuna vardığında ise en küçük elemanı dizinin başına yazıyor. Ardından bu işlemi 2. elemandan başlayarak yapıyor ve bulduğu en küçük değeri 2. sıraya koyuyor benzer şekilde işlemi dizinin son elemanına kadar aynı şekilde tekrarlıyor.

**Bubble Sort(Kabarcık Sıralaması)
Dizinin elemanları üzerinden ilk elemandan başlayarak ve her geçişte sadece yan yana bulunan iki eleman arasında sıralama yapılır. Dizinin başından sonuna kadar tüm elemanlar bir kez işleme tabi tutulduğunda dizinin son elemanı (küçükten büyüğe sıralandığında) en büyük eleman haline gelecektir. Bir sonraki tarama ise bu en sağdaki eleman dışarıda bırakılarak gerçekleştirilmektedir. Bu dışarıda bırakma işlemi de dış döngüdeki sayaç değişkeninin değerinin her işletimde bir azaltılmasıyla sağlanmaktadır. Sayaç değişkeninin değeri 1 değerine ulaştığında ise dizinin solunda kalan son iki eleman da sıralanmakta ve sıralama işlemi tamamlanmaktadır.

**Insertion Sort(Eklemeli Sıralama)
Yerleştirerek sıralama işlevi belirli bir anda dizinin belirli bir kısmını sıralı tutarak ve bu kısmı her adımda biraz daha genişleterek çalışmaktadır. Sıralı kısım işlev son bulunca dizinin tamamına ulaşmaktadır. Elemanların sırasına uygun olarak listeye tek tek eklenmesi ile gerçekleştirilen sıralamadır.

**Merge Sort(Birleştirme Sıralama)
Verinin hafızada sıralı tutulması için geliştirilen sıralama algoritmalarından bir tanesidir. Basitçe sıralanacak olan diziyi ikişer elemanı kalan parçalara inene kadar sürekli olarak ikiye böler daha sonra bu parçaları kendi içlerinde sıralayarak birleştirilir. Sonuçta elde edilen dizi sıralı dizinin kendisidir. Bu açıdan bir parçala fethet (divide and conquere) yaklaşımıdır. Sıralı iki veri grubunu birleştirerek üçüncü bir sıralı veri grubu elde etmeye dayanır.

**Quick Sort(Hızlı Sıralama)
Şu ana kadar bilinen en gözde ve hızlı algoritmadır. Uygulama adımlarını şu şekilde sıralayabiliriz:
-Diziden herhangi bir eleman al(pivot elaman)
-Pivot elemanından küçük olanları bir diziye, büyükleri bir diziye topla.
-Bu alt dizilerden yukarıdaki gibi pivot elemanları seçip aynı işlemi uygula. İç içe en küçük parçalara ulaşana kadar bu yöntemi sürdür.
-Oluşan dizicikleri birleştir.



6-)HASHING ALGORITMALARI
Hashing’in temel fikri, elimdeki veriyi sistematik olarak yerleştireyim ki, aradığımda direkt adrese bakayım şeklindedir. Mesela evinizde bir dolap olsun, dolaplarda da gözler olsun. Siz bir eşyayı aradığınızda tüm gözlere tek tek mi bakarsınız yoksa hangi gözde hangi eşyanız var bilir de direkt olarak hedefe mi yönlenirsiniz? İşte Hashing Veri Yapısındaki temel fikir de budur. Ancak bilgisayar dünyasındaki temel sorun, bu dünyanın sürekli dinamik olması ve ekleme & çıkarma işlemlerinin sık sık yapılması kaynaklıdır.

Şimdi konuyu biraz daha spesifik bir hale getirelim. Elimizde sayılar var, bu sayıları bir diziye (array) yerleştirmemiz gerekiyor. Ancak temel hedefimizde arama işlemini kolaylaştırmak olacak. Bunu nasıl yapabiliriz? Akla Sıralama Algoritması Kullanmak gelebilir. iyi bir fikir gibi görünse de bizim temel amacımız olan hemen bulma durumunu gerçekleştiremeyecektir. Şimdi neden olmayacaktır bunu anlatalım Sorunları listeleyelim.

1- Sıralama Maliyeti: Çok yüksek miktardaki sayıyı sıralamak zaten bir işlem ve süre maliyeti getirecektir.

2- Ekleme/Çıkarma işlemleri: Özellikle dizi veri yapısı üzerinde ekleme çıkarma yapmak sancılı bir iştir. Hele kaydırma yapmak gibi işlemler düşünüldüğünde bu maliyet iyice artmaktadır

3- Arama Maliyeti: Sayıların sıralı olması, hemen bulunacağı manasına gelmez, yalnızca arama algoritmasının performansına kalmış bir durumdur.

Yukarıdaki 3 temel problem, bizim hızlı bulma amacımızı karşılamamaktadır. Peki ama çözüm nasıl olacak?

Hashing Nedir?
Şimdi direkt olaya girelim, Hashing bize diyor ki, Eklemek istediğin sayıyı, yerleştirmek istediğin dizinin boyutuna göre modunu al, o indise yerleştir. Arama yaparken, bir sayıyı aradığın dizinin boyutuna böl, o indiste sayıyı bulacaksın.Peki yerleştirme işlemi bu şekilde, bulma işlemi nasıl olacak?
Örnek olarak 102 sayısını aramak istediğimizde biz bu diziye tek tek bakmayacağız. Nasıl olsa yerleştirme mantığını biliyoruz, 102 sayısının 10’a göre modunu aldığımızda 2 olduğunu görürüz ve dizinin 2. indisine bakarız, baktığımız yerde 102 sayısını buluruz. İşler bu ana kadar toz pembe olarak gitti, ancak bilgisayar dünyasında işler hiç de böyle gitmez. Şimdi dizimize yeni bir sayı ekleyelim, sayımız da 224 olsun. 224 % 10 yaptığımızda sonucun 4 olduğunu görürüz. Dizinin 4. indisine gideriz, o da ne? dizinin 4. indisi dolu, o halde ne yapacağız? İşte Hashing’i bilmek esasında bundan sonraki durumlar ile ilgili bir konudur. Genel terminolojide bu duruma Collision adı verilir. Collision kelimesinin Türkçesi çakışmadır. Zaten olan durumun tam da karşılığı budur. Hashing Collision durumunda 3 değişik çözüm sunar. (Bazıları iki değişik çözüm der, 2. ve 3. çözümler birbirine benzerdir çünkü. Şimdi bu duruma açıklama getirelim…

	Devamı aşağıdaki link de.Güzel bir kaynak.
	https://yazilimdnyasi.wordpress.com/2020/02/14/hashing-nedir-veri-yapilari/  
	


7-)DIVIDE AND CONQUER (Böl Ve Yönet) ALGORITMALARI
 Tipik bir Böl ve Yönet algoritması, aşağıdaki üç adımı kullanarak bir sorunu çözer.

 **Böl : Verilen problemi aynı türden alt problemlere ayırın . Bu adım, problemi daha küçük alt problemlere bölmeyi içerir. Alt problemler, asıl problemin bir parçasını temsil etmelidir. Bu adım genellikle, hiçbir alt problem daha fazla bölünemeyene kadar problemi bölmek için özyinelemeli bir yaklaşım kullanır. Bu aşamada, alt problemler doğası gereği atomik hale gelir, ancak yine de asıl sorunun bir kısmını temsil eder.

 **Fethet : Bu alt problemleri özyinelemeli olarak çözün. Bu adım, çözülmesi gereken birçok küçük alt problemi alır. Genel olarak, bu düzeyde, sorunlar kendi başlarına 'çözülmüş' kabul edilir.

 **Birleştir : Cevapları uygun şekilde birleştirin. Daha küçük alt problemler çözüldüğünde, bu aşama onları orijinal problemin bir çözümünü formüle edene kadar tekrar tekrar birleştirir. Bu algoritmik yaklaşım özyinelemeli olarak çalışır ve fethet ve birleştir adımları o kadar yakın çalışır ki, tek bir görünüm olarak görünürler.


