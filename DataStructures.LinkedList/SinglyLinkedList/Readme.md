#SinglyLinkedList Nedir ?
Her düğümün bazı veriler ve aynı veri türündeki bir sonraki düğüme işaretçi atadığı bağlantılı liste türüdür.
Düğüm sonraki düğüme bir işaretçi içerir.Yani her düğümün next'i bir sonraki düğümü gösterir.Bu bir düğümün bir sonraki düğümün adresini sakladığı anlamına gelir.

#SinglyLinkedList Yapısı Oluşturma  
Bir adet node class'ımız olur ve düğümleri ve düğümlerin değerini burada tanımlarız.Kurucu metotla da gelen verileri alırız.

#SinglyLinkedList Başa Eleman Ekleme 
Yeni düğüm her zaman verilen Bağlantılı Liste'nin başından önce eklenir ve yeni eklenen düğüm, Bağlantılı Liste'nin yeni başı olur. Örneğin verilen Bağlantılı Liste 10->15->20->25 ise ve öne 5 numaralı maddeyi eklersek Bağlantılı Liste 5->10->15->20->25 olur. Listenin başına ekleyen fonksiyonu push() olarak adlandıralım. Push(), baş işaretçiye bir işaretçi almalıdır çünkü push, baş işaretçiyi yeni düğümü gösterecek şekilde değiştirmelidir.Kodlara AddBeginningAndEnd klasöründen erişebiliriz.

#SinglyLinkedList Sona Eleman Ekleme
Yeni düğüm her zaman verilen Bağlantılı Listedeki son düğümden sonra eklenir. Örneğin, verilen Bağlantılı Liste 5->10->15->20->25 ise ve sonuna 30 madde eklersek, Bağlantılı Liste 5->10->15->20->25->30 olur.
Bir Bağlantılı Liste tipik olarak başı tarafından temsil edildiğinden, listeyi sonuna kadar geçmemiz ve ardından sondan sonraki düğümü yeni bir düğümle değiştirmemiz gerekir.
 
#SinglyLinkedList Ortaya Eleman Ekleme
Eklenecek index'deki değerin bir solunu bir de sağını tutacak iki düğüm oluşturulur.Bu iki düğümün arasına belirtilen index'e istenen düğüm eklenir..

#SinglyLinkedList Baştan Eleman Silme
Head düğümü her zaman en baştaki düğümümüz idi.Head düğümü siliniyor ancak head göstericisi bir sonraki düğümü göstermeye devam edecek.Yani baştaki head düğümünün next'i bizim yeni Head'ımız olacak.

#SinglyLinkedList Sondan Eleman Silme
Sondaki düğümün next'i her zaman null'u gösteriyordu.Yapmamız gereken şey bir önceki düğümün next'inin null göstermesini sağlamak.Geçici bir değişken oluşturup baştan başlayarak en son düğüme kadar ilerlememiz gerekli.