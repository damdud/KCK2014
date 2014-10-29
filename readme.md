To jest readme projektu na KCK pod tytułem Inspektor Java 
=====================================================================

MarkDown https://github.com/damdud/KCK2014.git
=====================================================================
W skład grupy wchodzą następujące osoby:
- Damian Dudek
- Arkadiusz Chrobak
- Jakub Downarowicz
- Jakub Janicki

=====================================================================
Plan realizacji projektu:
 1. Ustalenie wszystkich szczegółów gry i projekt mapy,
 2. stworzenie mapy, podstawowego rozkładu lokacji,
 3. podstawy poruszania się postaci,
 4. rozmieszczenie spawn-pointów dowodów, kluczy itd.,
 5. stworzenie podstawowej historii dla detektywa,
 6. nauczenie detektywa chodzić, reagować, poniekąd myśleć,
 7. pierwsze testy i poprawki.
 
=====================================================================
Zadania inspektora Javy:
 1. Inspektor po wejściu do gry otrzymuje randomowo wybrane zadanie w formie listu, który następnie po przeanalizowaniu skomentuje.
 2. Inspektor będzie reagował na słowa, po wpisaniu np.:
    'idź', pokaże się okno pomocnicze, w które miejsca może on iść,
    np.: 'idź do domu Kowalskich', Inspektor po takiej komendzie
    z dowolnego miejsca na mapie pójdzie do domu Kowalskich,
 3. Jeśli dom Kowalskich będzie pusty i zamknięty( randomowo), to 
    Inspektor sam jakoś to skomentuje. 
 4. Po wejściu do domu, Inspektor przechodzi do nowej sceny, w której porusza się po pomieszczeniu i poszukuje dowodów,
    po komendzie, np.: "Znajdź dowód w komodzie" lub " Podejdź do komody i przeszukaj". 
    Nad każdym miejscem możliwym do przeszukania będzie napis identyfikujący nazwę owego miejsca, którą musimy się posłużyć aby je przeszukać.
 5. Jeśli Inspektor znajdzie jakiś dowód, komentuje go, w jaki sposób może on mu pomóc( szafki,
    skrytki oczywiście przeszukuje z rozkazu gracza), przy większej ilości dowodów zaczyna analizować na kogo może paść podejrzenie zbrodni.
 6. Każdy dowód będzie coraz bardziej obciążał jednego z podejrzanych lub uniewinniał innych, na zasadzie punktacji, które są przydzielane indywidualnie wszystkim podejrzanym.
 
=====================================================================
Planowane środowisko: 
- Unity3D
Język programowania: 
- głównie C#,
- kilka skryptów javascript'owych.
Unity3D jest silnikiem stworzonym do projektowania gier zarówno 2D, jak i 3D. Umożliwia łatwe modelowanie grafiki i zapewnia komfortowy dostęp do dużej bazy assetów. 
Linki:
- http://unity3d.com/
- https://www.assetstore.unity3d.com/en/
