#SinglyLinkedList Yapısı Oluşturma  
Bir adet node class'ımız olur ve düğümleri ve düğümlerin değerini burada tanımlarız.Kurucu metotla da gelen verileri alırız.

#SinglyLinkedList Başa Eleman Ekleme 
Yeni düğüm her zaman verilen Bağlantılı Liste'nin başından önce eklenir ve yeni eklenen düğüm, Bağlantılı Liste'nin yeni başı olur. Örneğin verilen Bağlantılı Liste 10->15->20->25 ise ve öne 5 numaralı maddeyi eklersek Bağlantılı Liste 5->10->15->20->25 olur. Listenin başına ekleyen fonksiyonu push() olarak adlandıralım. Push(), baş işaretçiye bir işaretçi almalıdır çünkü push, baş işaretçiyi yeni düğümü gösterecek şekilde değiştirmelidir.Kodlara AddBeginningAndEnd klasöründen erişebiliriz.

#SinglyLinkedList Sona Eleman Ekleme
Yeni düğüm her zaman verilen Bağlantılı Listedeki son düğümden sonra eklenir. Örneğin, verilen Bağlantılı Liste 5->10->15->20->25 ise ve sonuna 30 madde eklersek, Bağlantılı Liste 5->10->15->20->25->30 olur.
Bir Bağlantılı Liste tipik olarak başı tarafından temsil edildiğinden, listeyi sonuna kadar geçmemiz ve ardından sondan sonraki düğümü yeni bir düğümle değiştirmemiz gerekir.
 
#SinglyLinkedList Ortaya Eleman Ekleme
Eklenecek index'deki değerin bir solunu bir de sağını tutacak iki düğüm oluşturulur.Bu iki düğümün arasına belirtilen index'e istenen düğüm eklenir..
