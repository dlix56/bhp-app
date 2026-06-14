# bhp-app
Wizualny system ewidencji wypadków i lokalizacji personelu w kopalni. Jako pracownik BHP można wybrać poziom i uczestnika wypadku. Aplikacja umożliwia dodanie komentarza obok pracownika, lub przejście do formularza w celu zarejestrowania wypadku.

Temat: Wizualny system ewidencji wypadków i lokalizacji personelu w kopalni
Cel projektu: Cyfryzacja i optymalizacja pracy nadzoru BHP. System ma na celu wizualne przedstawienie mapy, aby skrócić czas przygotowania raportu. W przypadku takiej woli można utworzyć raport lub dodać komentarz do wypadku. Strona wyposażona będzie w licznik pracowników i ewentualne zagrożenia w poszczególnych strefach (zagrożenie metanem, ściana do wyburzenia). Umożliwi on spisanie wszystkich pracowników na danym pionie/poziomie w celu ich przesłuchania łącznie z datą. Cała aplikacja początkowo zostanie podłączona do wygenerowanej bazy danych, jednak w celu wprowadzenia zdarzeń i osób rzeczywistych będzie można podłączyć ją z zewnętrznym systemem. Cały panel będzie zabezpieczony logowaniem pracowników z ewentualną możliwością ich rejestracji.
Główne funkcje: wizualizacja kopalni, ewidencja i lokalizacja pracowników, rejestr wypadków, panel logowania.
Technologia: ASP.NET Core MVC (wersja .NET 8.0), Entity Framework Core, relacyjna baza danych MS SQL Server, ASP.NET Core Identity, HTML5, CSS, JavaScript
Architektura: Architektura wielowarstwowa z MVC (logika biznesowa, warstwa wizualna, database) z wydzieleniem funkcji dla Admina.
Miejsce instalacji: Visual Studio 2022
Odpowiedzialność: Projekt indywidualny
Instrukcja uruchomienia (Środowisko lokalne)
1. Sklonuj repozytorium na swój dysk lokalny.
2. Otwórz plik rozwiązania w VS.
3. W Visual Studio otwórz Konsolę menedżera pakietów i wpisz:
   Update-Database
