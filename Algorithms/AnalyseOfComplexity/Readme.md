#Algoritmaların Karmaşıklık Analizi Nedir ? 


Algoritmaların karmaşıklık analizi, bir algoritmanın çalışması için gereken kaynak miktarının belirlenmesidir. Yani algoritmanın performansını ve kaynak kullanımını ölçen teorik bir çalışmadır.
Gündelik hayatta herhangi bir problemi çözerken birbirinden farklı yollara başvuruz. Aynı şekilde bilgisayar biliminde de belli bir probleme birden fazla çözüm yolu üretmek mümkündür. Tabi ki burada en uygun çözümü, yani algoritmayı seçmek önemlidir. İşte bu yüzden algoritmaların karmaşıklık analizini iyi bilmek gerekiyor. Bir problemi çözmeye çalışırken olası tüm algoritmaları incelemeli ve en uygun olanı seçmemiz gerekiyor.
Algoritma analizi belirli bir programlama dilinden bağımsız şekilde yapılır. Bunun amacı sadece algoritmanın kendisini analiz edip doğru sonuçlara ulaşmaktır.
Bir problemi farklı algoritmalarla çözebiliriz. Ancak problemi çözerken gelişigüzel bir mantık kurmak ya da analiz yapmadan bir algoritma seçmek programdan ödün vermek demektir. Yani algoritma seçerken o probleme en uygun sonucu getirecek olan algoritmayı seçmeliyiz.
Eninde sonunda algoritma bir şekilde tasarlanır ve problem çözülür. Ama her bakımdan en iyi sonucu veren tek bir algoritma vardır.
İşte algoritma analizinin amacı da o en uygun sonucu veren algoritmayı bulmaktır. Kısaca algoritmaları birbirleriyle karşılaştırmak ve performansını ölçmek.

-----------------------------------------------------------------------------------------------------------------

#Algoritmanın Performans Kriterleri Nelerdir ?


Yukarıda da belirttiğim gibi bir problemi farklı algoritmalar tasarlayarak çözmek mümkün. Ancak bu çözümlerin birbirlerine karşı mutlaka avantajları ve dezavantajları olacaktır.
Örneğin, hızlı çalışan bir algoritma bellekten fazla alan tüketirken, tam tersi daha az bellek tüketen bir algoritma da daha yavaş çalışır.

Bir algoritmanın analizini yaparken bazı soruları göz önünde bulundurmalıyız:

**Problemi çözmek için ne kadar bellek tüketecek?
**Problemin çözülmesi ne kadar zaman alacak?
**Daha fazla veri girildiğinde algoritma nasıl davranıyor? Yavaşlıyor mu yoksa hızlanıyor mu?

Algoritma performansında iki temel kriter vardır: zaman(time) ve alan(space). Algoritmalar bu iki kriterden en uygun sonucu alacak şekilde tasarlanmalıdır.

Zaman (time)
**Algoritma ne kadar hızlı çalışıyor?
**Algoritmanın çalışması için gereken zamanın nasıl tahmin edilir? Gereken zaman nasıl azaltılabilir?
**Algoritmanın çalışma zamanını etkileyen faktörler nelerdir?

Alan (space)
**Algoritmada hangi veri yapıları kullanılmalıdır?
**Kullanılan veri yapıları ne kadar yer kaplar?
**Daha iyi sonuç veren bir veri yapısı kullanılabilir mi?

-----------------------------------------------------------------------------------------------------------------

#Time Complexity(Zaman Karmaşıklığı)


Zaman karmaşıklığı, algoritmanın yürütme zamanının derecesinin asimptotik notasyonlarla gösterilmesidir. Bir başka deyişle bir algoritmanın çalışması için gereken süredir. Bu süre ne kadar kısa olursa algoritmanın performansı o kadar iyi olur. Zaman karmaşıklığını bir algoritmanın performansı olarak düşünebiliriz.

Bu süre milisaniyeleri hesaplayarak değil, yapılan işlem sayısına göre hesaplanmaktadır. Tabi ki bu hesaplama yapılırken algoritmadaki veri setinin büyüklüğüne ve sırasına dikkat edilir.

Amaç, giriş boyutu ve zaman arasındaki karmaşıklığı azaltmaktır. Yani detayları es geçerek çalışma süresini indirgemektir.

İşte bu yüzden algoritma sonsuza giderken asimptotik gösterimde sabitler ve katsayılar gibi büyümeye fazla etkisi olmayan kısımlar hesaplanmaz. Böylece geriye algoritmanın büyümesinde asıl etkiye sahip olan değerler kalır ve gerçek fonksiyona göre yaklaşık bir değer hesaplanır.

Bir bilgisayarın donanım özellikleri ne kadar iyi olursa olsun, her zaman en iyi performans gösteren algoritmayı seçmek gerekir. Böylece donanımda yapılan iyileştirmelerle algoritma daha da iyi performans göstermiş olur.

-----------------------------------------------------------------------------------------------------------------

#Space Complexity(Alan Karmaşıklığı)


Alan karmaşıklığı, bir algoritmanın bir girdi boyutu için çıktı üretirken ihtiyaç duyduğu bellek miktarıdır. Yani buna alan maliyetini ölçmek demektir diyebiliriz.
Daha iyi alan karmaşıklığına sahip olan algoritma bellekten daha az alan tüketir. Algoritmanın performansını artırmak için sistem belleğini artırmak ilk akla gelen çözüm olsa da, her zaman daha az alan tüketen bir algoritma tasarlamak daha mantıklıdır.
Alan karmaşıklığı, algoritmayı çalıştıran sistem, derleyici ve programlama dili gibi çeşitli faktörlere bağlıdır. Bu yüzden algoritmanın kendisini analiz ederken bu faktörleri dikkate almamalıyız.
Ne yazık ki, algoritma performansında zaman ve alan verimliliği birbirine terstir. Yani hız arttıkça bellek tüketimi artar. Ya da tam tersi.
Örnek olarak merge sort, bubble sort ve in-place heap algoritmalarını inceleyelim. Merge sort en hızlı ancak en fazla bellek tüketen algoritmadır. Bubble sort ise tam tersine en yavaş ancak en az bellek tüketen algoritmadır. In-place heap ise bu iki algoritmanın arasında performans gösteren daha dengeli bir algoritmadır.

-----------------------------------------------------------------------------------------------------------------

#Notation


Notation, karmaşıklık analizi yapılan bir algoritmanın performansının farklı gösterimler ile temsil edilmesidir. Yukarıda da belirttiğim gibi bir algoritma girilen verilerin büyüklüğüne göre farklı performans gösterebilir.
Örneğin, 1 Kb lık veriden çıktı üreten algoritma hızlı çalışırken, aynı algoritmaya 1 mb veri girildiğinde çıktıyı daha yavaş üretebilir. Bu nedenle, olabilecek tüm durumların karmaşıklığını analiz etmemiz gerekiyor.

Zaman karmaşıklığında genel olarak üç temel asimptotik notasyon vardır. Bunlar:

**Big-O Notasyonu
**Omega Notasyonu
**Teta Notasyonu

-----------------------------------------------------------------------------------------------------------------

#Best Case(En İyi Durum)


Algoritmanın karmaşıklığı hesaplanırken en iyi sonucun elde edildiği duruma denir. Algoritmanın en az adımda ve zamanda çalıştığı durumdur.
Çalışma zamanında bir alt sınırdır. Grafik gösterimlerinde alt sınır (lower bound) olarak görürüz.
Omega notasyonu ( Ω ) da denir.

-----------------------------------------------------------------------------------------------------------------

#Average Case (Ortalama Durum)


Adından da anlaşılacağı gibi, best case ile worst case arasında ortaya çıkan durumdur.
Teta notasyonu ( θ ) da denir.

-----------------------------------------------------------------------------------------------------------------

#Worst Case (En Kötü Durum)


Algoritmanın en fazla adımda ve zamanda çalıştığı durumdur. Olabilecek tüm olumsuz durumları kapsar.
Big O notasyonu ( O ) da denir.

//*// DEVAMI ASAGIDAKI LINKTEDIR //*//
https://www.serkanseker.com/tr/algoritama-karmasiklik-analizi/

-----------------------------------------------------------------------------------------------------------------