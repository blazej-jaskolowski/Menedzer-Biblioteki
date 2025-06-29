# Menedzer Biblioteki 📚

Prosty system zarządzania biblioteką napisany w C# Windows Forms. Aplikacja umożliwia katalogowanie książek, śledzenie ich statusu wypożyczenia oraz podstawowe operacje na bazie książek.

## Spis treści
* [Informacje ogólne](#informacje-ogólne)
* [Technologie](#technologie)
* [Funkcjonalności](#funkcjonalności)
* [Instalacja](#instalacja)
* [Jak używać](#jak-używać)
* [Status projektu](#status-projektu)
* [Planowane funkcjonalnosci](#planowane-funkcjonalnosci)

## Informacje ogólne
Projekt został stworzony w celu demonstracji podstawowych funkcjonalności programowania w C#, w tym:
- Operacji na strukturach danych
- Implementacji rekurencji
- Operacji na plikach
- Interfejsu graficznego Windows Forms
- Sortowania danych

## Technologie
* C# - wersja 7.0+
* .NET Framework - wersja 4.8.0
* Windows Forms
* Visual Studio 2022

## Funkcjonalności
Lista obecnych funkcjonalności:
* Dodawanie nowych książek do systemu
* Wyświetlanie listy wszystkich książek
* Zmiana statusu wypożyczenia książek
* Sortowanie książek według tytułu lub roku wydania
* Automatyczny zapis stanu biblioteki do pliku
* Wczytywanie danych z pliku przy starcie aplikacji

## Instalacja
1. Sklonuj repozytorium
2. Otwórz projekt w Visual Studio 2022
3. Skompiluj rozwiązanie (Build Solution)
4. Uruchom aplikację (F5)

## Jak używać

1. Dodawanie nowej książki do listy:
Wypełnij pola: Tytuł, Autor, Rok wydania.
Kliknij przycisk "Dodaj książkę".

2. Zmiana statusu wypożyczenia:
Wybierz książkę z listy.
Kliknij przycisk "Wypożycz/Zwróć".

3. Sortowanie książek:
   Wybierz kryterium sortowania z rozwijanej listy.
   Kliknij przycisk "Sortuj".
   
5. Usuwanie książek z listy:
Wybierz książkę którą chcesz usunąć.
Kliknij przycisk "Usuń".

6. Szukanie książek:
Wpisz tytuł szukanej książki.
Kliknij przycisk "Szukaj".

7. Eksportowanie listy książek do pliku .txt:
Kliknij przycisk "Zapisz listę...".
   Nazwij plik .txt.
   Kliknij przycisk "Zapisz".

8. Importowanie listy książek do pliku .txt:
Kliknij przycisk "Wczytaj listę...".
Wybierz plik .txt.
Kliknij przycisk "Wczytaj".

## Status projektu
Projekt jest: w trakcie rozwoju

## Planowane funkcjonalności
* Rozbudowanie systemu rezerwacji książek
* System logowania użytkowników
* Statystyki wypożyczeń
