#Ağaç Veri Yapısı Nedir ? 
Ağaç veri yapısı doğrusal olmayan veri yapılarındandır.Verilerin birbirine ağaç yapısı oluşturur gibi bağlanmasıyla elde edilen veri yapısıdır. Soyağacı oluştururken kullandığımız terimleri ağaç veri yapısı oluştururken de kullanırız. Örneğin; çocuk, kardeş, düğüm, aile, ata.Özellikle arama işlemleri için çok güçlü olduğundan yaygın kullanılmaktadır. Bir ağaç verilerin birbirlerine ağaç oluşturuyormuş gibi sanal olarak bağlanmasıyla meydana gelmektedir. Ağaç veri yapısında veriler düğümlerde tutulmaktadır. Bu düğümlere node denilmektedir. Düğümler arası ilişki kenarlar yani dallar ile yapılmaktadır. Edge olarak da ifade edilebilir.En tepedeki düğüme Root Node denilmektedir. Çocuğu olan düğümlere Parent denilmektedir. Düğüme bağlı olan alt düğümlere ise çocuk (Child) denilmektedir. Çocuğu olmayan düğümlere de yaprak (leaf) denilmektedir.Bir düğümün alt ağaçlarına subtree denir. Aynı babaya sahip düğümlere kardeş düğüm denir. Bir düğüme bağlı tüm alt düğümlere ise o düğümün varisleri denilmektedir. Ağaç veri yapısında arama işlemleri Linked Listlere göre hızlı yapıldığından tercih sebebi olmaktadır.Her düğümdeki sol ve sağ kenarlar yardımıyla diğer düğümlere ulaşılır. Sol ve sağ kenarlar veri içerebileceği gibi NULL de olabilir. Düğüm yapıları değişik türlerde bilgiler içeren veya birden fazla bilgi içeren ağaçlar da olabilir [1].

Torun (Dedscendant): Bir düğümün çocuğuna bağlı olan düğümlere denir.
Yaprak (Leaf): Ağacın en altında bulunan ve çocukları olmayan düğümlerdir.
Derece (Degree): bir düğümden alt hiyerarşiye yapılan bağlantıların sayısıdır; yani çocuk veya alt ağaç sayısıdır.
Seviye (Level): Hiyerarşik sıradır (rank). Kök düğüm seviye =0
Derinlik (Depht): Bir düğümün köke olan uzaklığı derinliktir. Kök düğüm derinlik =0
Yükseklik (Height): Bir düğümün kendi silsilesinden en uzak yaprak düğüme olan uzaklığıdır. Yaprak düğümlerin yüksekliği =0 (kök yüksekliği = ağaç yüksekliği)
Yol (Path): Bir düğümün aşağıya doğru (çocukları üzerinden) bir başka düğüme gidebilmek için üzerinden geçilmesi gereken düğümlerin listesidir.

#AğaçVeriYapısı1 Görseli İçin
A düğümü kök olmak üzere 7 düğümden (n) oluşmaktadır.
Toplam 6 kenar (n-1) vardır.
Sol alt ağaç, B köküyle başlamakta ve sağ alt ağaç da C köküyle başlamaktadır.
A’dan solda B’ye giden ve sağda C’ye giden iki dal (branch) çıkmaktadır.

#Ağaç Çeşitleri 

    İkili Ağaç (Binary Tree)
    İkili Arama Ağacı ( Binary Search Tree)
    Andelson Velsky Landis Ağaçları
    Internal Path Reduction (IPR) Ağaçları
    B Ağaçları
    B+ Ağaçları
    B# Ağaçları

#İkili Ağaç Veri Yapısı 
İkili ağaç olması için en fazla iki dal çıkmalı.!!
Katı İkili Ağaç (Strict Binary Tree)

Yaprak düğümler haricindeki tüm düğümler sıfır veya iki çocuğa sahip ise katı ikili ağaç olarak adlandırılır.



Tam İkili Ağaç (Full Binary Tree)

Her bir düğümün (i)net olarak iki çocuk düğüme sahip olduğu ve (ii)yaprak düğümlerin aynı seviyede olduğu iki ağaçtır. Her düğüm eşit şekilde sağ ve sol alt-ağaçlara sahiptir.



Eksiksiz İkili Ağaç (Complete Binary Tree)

Son seviye dışındaki tüm seviyelerin tam (full) olduğu ikili ağaç türüdür. Düğümleri sol taraftan (düğüme göre) doldurulur. Yeni bir derinliğe soldan sağa doğru ekleme başlanır.


Devamı için 

https://nerdbook.wordpress.com/2018/03/28/agac-veri-yapisi/ çok güzel bir kaynak.


#Ağacın Yüksekliğini ve Ağacın Eleman Sayısını Bulma

İlgili çalışmayı FindNumberOfElements folder'ının altında bulabilirsiniz.
En altta kalan yaprak düğümün köke olan uzaklığı yüksekliktir !!

