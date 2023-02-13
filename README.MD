Projekt ten został zrealizowany przy użyciu następujących technik: Entity Framework 6, .NET Framework 4.8;
baza danych: SQL Server 16.0.100; 
Środowisko rozwojowe: Visual studio version 17.4.4.

Normalny App z MVVM pattern z wieloma łatami.
 Posiada 3 główne widoki: Magazyn, Pozycje, Dokumenty. 
Wszystkie one implementują zwykłą funkcjonalność CRUD.
Dokumenty posiadają również funkcję Issue document, która odejmuje od ogólnej liczby jednostek tabeli WarehouseItem wartość jednostek wybranych w dokumencie.

Aby zmigrować bazę danych, użyj polecenia enable-migration z Update-Database w konsoli Package Manager.