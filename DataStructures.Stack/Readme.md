#Stack Nedir ? 
Stack işlemlerin gerçekleştiği belirli bir sırayı izleyen doğrusal bir veri yapısıdır.Son giren ilk çıkar veya ilk giren son çıkar.Yığında tüm ekleme ve silme işlemlerine listenin yalnızca bir ucundan izin verilir.Yığının gerçek hayatta bir çok örneği vardır.Üst üste dizilmiş tabakları düşünelim.En üstteki tabak ilk yıkanır.Stack'da da durum böyledir.Stack veri yapısında elemanlara doğrudan erişmek mümkün değildir.Hep üsttekinden alttakine doğru bir erişim söz konusudur.Elemanlar tek bir yerden eklenip çıkartılır buna da yığının tepesi denmektedir.İlk elemanın eklendiği alt noktaya ise yığının tabanı denmektedir.

Push() => stack'e veri ekleme.
Pop()  => stack'den veri silme.

#Stack'in Başı Ne Demek ? 
Stack3 isimli görseli incelemenizi öneririm.Yığındaki öğelere erişilen,eklenen ve silinen işaretçiye yığının tepesi denmektedir.Yığının en üst öğesinin işaretçisidir.

#Stack2 Görseli Bize Ne anlatıyor?
Görmüş olduğumuz stack yapısını bir kutu gibi düşünelim.Verilerimizi kutuya dizer gibi diziyoruz.En üstteki düğüm top'tır ve next'i 4'ü göstermektedir.Hepsinin next'i bir altındakini göstermektedir.En sondaki düğümün yani taban düğümünün next'i null'ı göstermektedir.Bildiğimiz linkedlist yapısının biraz özelleştirilmiş halidir diyebiliriz.En üstteki düğüme her zaman top diyeceğiz unutmamak lazım!!



!!!Stack veri yapısının örneğini linkedList'leri kullanarak yapacağım.Stack veri yapısı linkedlistlere çok benzemektedir zaten.