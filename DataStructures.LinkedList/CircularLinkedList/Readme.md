#Dairesel Bağlantılı Liste Nedir ? 


Dairesel bağlantılı liste,tüm düğümlerin bir daire oluşturmak üzere bağlandığı bağlantılı bir listedir.Dairesel bağlantılı listede ilk düğüm ve son düğüm bir daire oluşturacak şekilde birbirine bağlanır.Sonunda NULL yok.Genel olarak iki tür dairesel bağlantılı liste vardır.Aşağıda açıklıyorum.

-----------------------------------------------------------------------------------------------------------------

#Dairesel Tek Yönlü Bağlantılı Liste Nedir ?


Dairesel tek yönlü bağlantılı listede, listenin son düğümü listenin ilk düğümüne bir işaretçi içerir.Yani son düğümün next'i head'ı gösterir.Bu sebeple başladığımız düğüme gelene kadar ilerliyoruz.Düğümlerinin herhangi birinin sonraki bölümünde boş değer yoktur.
(İlgili görsel SinglyCircular klasörü içerisinde yer almaktadır.).

-----------------------------------------------------------------------------------------------------------------

#Dairesel Çift Yönlü Bağlantılı Liste Nedir ? 


Dairesel çift yönlü bağlantılı liste, hem çift yönlü bağlantılı liste hem de dairesel bağlantılı listenin özelliklerine sahiptir.
Burada her iki ardışık düğüm next ve prev olarak birbirine bağlıdır.Son düğüm'ün nexti head'ı gösterir.Yani son düğüm next'i ile ilk düğüme bağlıdır ve ayrıca ilk düğüm de prev'i ile son düğüme bağlıdır.Yani ilk düğümün prev'i son düğümü, son düğümün next'i head'i göstermektedir.
(İlgili görsel DoublyCircular klasörü içerisinde yer almaktadır.).

-----------------------------------------------------------------------------------------------------------------

#Dairesel Bağlantılı Listenin Avantajları Nelerdir ?


Herhangi bir düğüm bir başlangıç ​​noktası olabilir. Herhangi bir noktadan başlayarak tüm listeyi kat edebiliriz. Sadece ilk ziyaret edilen düğüm tekrar ziyaret edildiğinde durmamız gerekiyor. 
Dairesel listeler, listede tekrar tekrar dolaşılan uygulamalarda kullanışlıdır.
Örneğin, bir bilgisayarda birden fazla uygulama çalışırken, işletim sisteminin çalışan uygulamaları bir listeye koyması ve ardından bunlar arasında geçiş yapması, her birine yürütmesi için bir dilim zaman vermesi ve ardından onları beklemeye zorlaması yaygın bir durumdur. CPU başka bir uygulamaya verilir. İşletim sisteminin dairesel bir liste kullanması uygundur, böylece listenin sonuna geldiğinde listenin önüne dönebilir. 

-----------------------------------------------------------------------------------------------------------------

#Dairesel Bağlantılı Listenin Dezavantajları Nelerdir ?


Tek yönlü bağlantılı listelerle karşılaştırıldığında, dairesel listeler daha karmaşıktır.
Dairesel bir listeyi tersine çevirmek çok karmaşıktır.
Listenin sonunu bulmak ve döngüyü kontrol etmek daha zordur.

-----------------------------------------------------------------------------------------------------------------

#Dairesel Bağlantılı Listelerin Uygulamaları Nelerdir ?


Çok oyunculu oyunlar, her oyuncuya oynama şansı vermek için bunu kullanır.
Bir işletim sisteminde birden çok çalışan uygulamayı düzenlemek için dairesel bir bağlantılı liste kullanılabilir. Bu uygulamalar işletim sistemi tarafından yinelenir.

-----------------------------------------------------------------------------------------------------------------