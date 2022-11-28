# BiggerGames-DeveloperCase

Prosedural Level Oluşturma

Level'ların zorluk derecesini parça sayısına göre ayarladım.

Algoritma aslında temelde şuna dayalı. 3x3 bir grid'imizin olduğunu varsayalım. Bu grid'i oluşturan karelerin her birini 4 tane üçgen oluştursun. Totalde bu grid'i 36 üçgen oluştursun.

1. Level'da kaç şeklin olacağının belirlenmesi
2. Bu şekillerin en az kaç üçgenden oluşacağının belirlenmesi. 

![Ekran Alıntısı](https://user-images.githubusercontent.com/38881186/204170740-1b387c2a-b2aa-432e-8326-e9179fee731d.PNG)


3. Şekillerdeki üçgen sayısının belirlenmesi. Örneğin level'da 2 şeklimiz olsun ve bu beş şekil en az 4 üçgenden oluşsun.


![Ekran Alıntısı](https://user-images.githubusercontent.com/38881186/204169956-8388582b-bfab-41ff-9a8d-77c3a2b9e31b.PNG)

4. İlk üçgenin random olarak belirlenmesi.


![Ekran Alıntısı](https://user-images.githubusercontent.com/38881186/204171065-c3e244a6-9e58-4484-b624-47642857c5cc.PNG)


5. Belirlenen gidebileceği komşu üçgenlerin belirlenmesi. Bunu şu şekilde belirledim. Grid'i olşturan her bir üçgen kendi içinde komşu üçgen listesi tutuyor ve gidebilecği üçgen bu listeden random seçiliyor. Eğer daha önce kullanılmamışsa bir sonraki üçgen o oluyor.
6. Gidebileceği komşu üçgenlerden birinin random seçilmesi.
7. Seçilen random üçgenin gidebileceği komşu üçgenlerin belirlenmesi.
8. Aralarından random bir üçgenin seçilmesi
9. Şeklin üçgen sayısı tamamlanasaya karadar 7 ve 8. adımın tekrarlanması.
