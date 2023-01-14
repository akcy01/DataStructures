# LinkedList Nedir ? 
 Diziler gibi, Bağlantılı Liste de doğrusal bir veri yapısıdır. Dizilerden farklı olarak, bağlantılı liste öğeleri bitişik bir konumda depolanmaz; elemanlar işaretçiler kullanılarak bağlanır. Bir dizi bağlantılı düğüm içerirler. Burada her düğüm, bir sonraki düğümün verilerini ve adresini depolar.Dizilerden farklı olarak önceden bellek tahsisini engeller.Sabit zamanda genişletilebilir.

# Bağlantılı Liste Türleri(LinkedList) ?
Basit Bağlantılı Liste(SinglyLinkedList) => Bu tür bağlantılı listede, bağlantılı listeyi yalnızca bir yönde hareket ettirebilir veya çapraz
hareket ettirebilirsiniz.

Çift Bağlantılı Liste(DoublyLinkedList) => Bu tür bağlantılı listede, bağlantılı liste her iki yönde de hareket ettirilebilir 
veya çaprazlanabilir (İleri ve Geri)

Dairesel Bağlantılı Liste(CircularLinkedList) => Bu tür bağlantılı listede, bağlantılı listenin son düğümü, bir sonraki
işaretçisinde bağlantılı listenin ilk/baş düğümünün bağlantısını içerir ve ilk/baş düğüm, listenin son düğümünün bağlantısını içerir. 

#Bağlantılı Liste Yapısı (SinglyLinkedList)
SinglyLinkedList klasöründen ne olduğuna bakabilirsiniz.

#LinkedList & Array Kıyaslaması 
1-) Dizilerin belirli bir kapasitesi vardır. (Program başladığında belirlenir)
	Bağlı listelerin bir kapasitesi yoktur belleğin izin verdiği miktarda büyüyebilirler.

2-) Diziler birbirinin arkasına sıralı bir şekilde gelir. (Dizi[0], Dizi[1] den 4 bayt (integer dizi için) sonradır)
	Bağlı listedeki elemanlar bellekte herhangi bir yerde olabilirler.

3-) Bir diziye eleman eklemek ve çıkartmak çok maliyetlidir. (5 elemanlık bir diziye 6. elemanı eklemek isterseniz ilk önce önceki 5 elemanlık diziyi bellekte başka bir yere taşımamız gerekir)
	Bağlı listelerde eleman eklemek ve çıkarmak nispeten daha kolaydır. (Sadece en son düğümü veya silinecek düğümü bulmak gerekir)

4-) Dizilerde arama çok daha kolaydır. Çünkü bellekte ardışık yer kaplarlar. (Algoritma Karmaşıklığı O(1))
	Bağlı listelerde arama yapmak zordur çünkü bir düğüme ulaşmak için önceki düğümlerden gelmeniz gerekir. ( Algoritma Karmaşıklığı O(n))

5-) Diziler bellekte daha az yer kaplar (Sadece değerleri tutarlar)
	Bağlı listeler bellekte daha fazla yer kaplar (Hem değerleri hem de sonraki düğümün adresini tutarlar)



