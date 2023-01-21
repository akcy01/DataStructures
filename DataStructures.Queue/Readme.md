#Queue Nedir ? 
Yapısal olarak Stack'e benzemektedir.Bilginin geliş sırasına göre, ilk önce gelen elemana ilk erişilen liste yapısına kuyruk yani queue denmektedir.
Bu erişimde first in first out yani ilk giren ilk çıkar.Örnek olarak sinema bileti için sıraya girmiş kişileri düşünebiliriz.İlk önce gelen kişi biletini daha önceden alacaktır.
Queue veri yapısında verilere iki uçtan erişim vardır.Bir uçtan eleman ekleme(enqueue),diğer uçtan eleman çıkarma(dequeue) işlemleri yapılmaktadır.
Queue tasarımı dizi veya veya bağlı liste ile yapılabilir.Bağlı liste kullanarak boyutu sabit olmayan bir queue oluşturabiliriz.Dizi kullanmak için ise sabit bir boyut belirlemeliyiz.
Eleman eklemek için enqueue 
Eleman çıkarmak için dequeue
Listeye yapılan tüm eklemeler bir uçtan, tüm çıkarmalar diğer uçtan yapılmaktadır.Sıraya ilk itilen eleman önce ona işlem yapılır.

Front => Sırayı temsil eden dizide ilk öğenin depolandığı dizin.
Rear => Sırayı temsil eden bir dizide son öğenin depolandığı dizin. 

Biz yapacağımız örneği linkedlist üzerinden yapacağız !! 

Sona eklersin baştan çıkarırsın temel mantık budur !!!

Kodda yazmış olduğumuz next'i prev gibi düşünebilirsin!!!