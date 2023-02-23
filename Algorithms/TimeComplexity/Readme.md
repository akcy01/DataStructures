#Time Complexity Önemli Notlar  
Time Complexity yani zaman karmaşıklığı bir algoritma analizi yöntemidir.Bir diğer değişle Time complexity bir algoritmanın çalışması için gerekli olan süredir. Ancak buradaki süre, saniyeleri hesaplayarak değil, kaç tane işlem gerçekleştirdiğine göre hesaplanmaktadır. Uygulama tarafından gerçekleştirilen işlem sayısı, veri setinin büyüklüğüne ve o veri setindeki elemanlarına sırasına göre belirlenir.

1-)TimeComplexity'in T'si ile ifade edilir."T(n)" n ise algoritmanın girdisidir.
Algoritmanın Girdisi:
**Dizi(Boyutu)
**Polinom(Polinom Derecesi)
**Matris(Eleman Sayısı)
**İkilik Veri(Bit Sayısı)
**Graf(Kenar ve Düğüm sayısı)

2-)Algoritmanın Dayandığı Paradigma:
**Backtracking
**Branch And Bound
**Brute-Force Search
**Divide And Conquer
**Dynamic Programming
**Greedy Algorithm
**Prune And Search

3-)Çalışma Süresi:
Burdaki süre zamanı değil; işlem sayısını ifade eder.

Time complexity bize bir algoritma için 3 durum sunar. Best-case, average-case ve worst-case.
Bu üç durumu örnekler ile açıklayacak olursak eğer:
Elimizde sıralı olmayan bir dizi olduğunu düşünelim. Örneğin [5,1,4,2,6,3,7]

Bu dizi de aradığınız bir değeri bulabilmek için dizideki tüm index değerleri ile aradığınız değerin eşleşmesi gerekmektedir (Linear Search). Bu örneğin case’lerine bir bakalım:

Best-case: Aradığınız değerin 5 olması bu algoritmanın best-case’dir. Çünkü daha ilk iterasyonda aradığımız değere ulaşmış oluruz.

Average-case: Bu case, verilen input setindeki değerlerin dizi içerisindeki dağılımına göre belirlenir. Bu örnek için average-case aradığımız değerin, dizi’nin tam ortasındaki, yani 2 değerinin olması olabilir.

Worst-case: Bu örneğimiz için worst-case, yani en kötü durum senaryosu, aradığımız değerin dizinin en sondaki değer olması durumudur. Bu örnek için bu değer 7'dir.

Worst-case: Aradığımız değerin dizi içerisinde bulunmaması durumu da worst-case'e örnektir.

-----------------------------------------------------------------------------------------------------------------