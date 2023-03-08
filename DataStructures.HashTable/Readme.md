#HashTable Nedir ? 

Elimizdeki karmaşık olan sayıları ve aramak için kullandığımız indexleri elimizdeki veri yapısına uydurmaktır.
Bir hash tablosu anahtarları(key) değerlerle(value) eşleştiren bir veri yapısıdır. Bir dizi anahtar değeri bir dizinin bir dizi dizinine dönüştürme tekniğidir. Anahtarları değerlerle eşleştirebilen bir yapı olan ilişkilendirilebilir bir dizi uygulamak için kullanılır. Bir Karma Tablosu (hash table), bir dizini, istenen değerin bulunabileceği bir grup veya yuva dizisi halinde hesaplamak için bir karma işlevi kullanır.

Bir dizinin boyutu kadar mod alırsın ve çıkan sonuca göre ilgili değerleri çıkan mod'un sonucuna göre indexlersin. Yani örnek olarak 700 alanlık bir dizimiz olsun. Mod 701 aldığımızda 0'dan 700'e kadar alan için çalışmış olacağız. 580625685 bizim değerimiz olsun.Bunun modunu alırız ve sonuç 3 çıkar.Bu sayıyı 3.index'e yerleştiririz. ! Peki mod aynı çıkarsa ne oluyor ? Öncelikle bu duruma çakışma deniyor. Var olan bir veriyle yeni verinin çakışması durumu. Eğer veri çakışırsa Lineer bir arama gerçekleştiriyor. Boş bulduğu ilk yere yerleşiyor. Örneğin 5.index boş ise oraya yerleşiyor. 

Biz sütun başlıklarını dizilerden oluşturacağız. Dizilerin gösterdiği adreslere de düğümleri linkedlist olarak ekleyeceğiz ! Yani dizilerin üzerinde linkedlistler tutarak işlemlerimizi gerçekleştireceğiz. Örnek olarak 0.index'de biz linkedlist düğümü olacak ! Zincir gibi 0.index'de birden çok düğüm tutabileceğiz.

https://yazilimdnyasi.wordpress.com/2020/02/14/hashing-nedir-veri-yapilari/ Daha detaylı bilgi için linki bırakıyorum.Harika anlatmış..
