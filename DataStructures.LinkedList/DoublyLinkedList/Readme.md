#Doubly LinkedList
Çift yönlü bağantılı liste yani iki yönlü bağlantılı liste, bir önceki düğümün yanı sıra bir sonraki düğümün de adresini tutar.Yani next gibi artık prev de vardır.Prev bir önceki düğümün adresini tutar, next bir sonraki düğümün adresini tutar.
Head'ın prev'i null'u; Son düğümün next'i null'u gösterir.Ortadaki düğümlerin prev'i ise bir önceki düğümü, next'i ise bir sonraki düğümü gösterir.

Singly yani tek yönlü doğrusal listelere göre farklılıkları vardır.Head'ın hem sağında hem de solunda bir değer vardır artık.Yani head'ın next'i varken artık prev'i de olacaktır.
Artık her düğümün bir next'i ve prev'i olacaktır.
Son düğümün next'i null'u gösteriyordu.Bunda da son düğümün next'i null'u göstermelidir!!