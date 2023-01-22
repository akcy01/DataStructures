#Ağaç Veri Yapısı Nedir ? 
Ağaç veri yapısı doğrusal olmayan veri yapılarındandır.Verilerin birbirine ağaç yapısı oluşturur gibi bağlanmasıyla elde edilen veri yapısıdır. Soyağacı oluştururken kullandığımız terimleri ağaç veri yapısı oluştururken de kullanırız. Örneğin; çocuk, kardeş, düğüm, aile, ata.Özellikle arama işlemleri için çok güçlü olduğundan yaygın kullanılmaktadır. Bir ağaç verilerin birbirlerine ağaç oluşturuyormuş gibi sanal olarak bağlanmasıyla meydana gelmektedir. Ağaç veri yapısında veriler düğümlerde tutulmaktadır. Bu düğümlere node denilmektedir. Düğümler arası ilişki kenarlar yani dallar ile yapılmaktadır. Edge olarak da ifade edilebilir.En tepedeki düğüme Root Node denilmektedir. Çocuğu olan düğümlere Parent denilmektedir. Düğüme bağlı olan alt düğümlere ise çocuk (Child) denilmektedir. Çocuğu olmayan düğümlere de yaprak (leaf) denilmektedir.Bir düğümün alt ağaçlarına subtree denir. Aynı babaya sahip düğümlere kardeş düğüm denir. Bir düğüme bağlı tüm alt düğümlere ise o düğümün varisleri denilmektedir. Ağaç veri yapısında arama işlemleri Linked Listlere göre hızlı yapıldığından tercih sebebi olmaktadır.Her düğümdeki sol ve sağ kenarlar yardımıyla diğer düğümlere ulaşılır. Sol ve sağ kenarlar veri içerebileceği gibi NULL de olabilir. Düğüm yapıları değişik türlerde bilgiler içeren veya birden fazla bilgi içeren ağaçlar da olabilir [1].

#Ağaç Çeşitleri 

    İkili Ağaç (Binary Tree)
    İkili Arama Ağacı ( Binary Search Tree)
    Andelson Velsky Landis Ağaçları
    Internal Path Reduction (IPR) Ağaçları
    B Ağaçları
    B+ Ağaçları
    B# Ağaçları
