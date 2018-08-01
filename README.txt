Instrukcja obsługi do poleceń w skryptach:

Polecenie	Argumenty	Opis
A 		-		Alert - Zatwierdza wyskakujący alert.
B		xpath		Button - Klika w przycisk/link/inny element pod wskazanym <xpath>.
BTW		-		Back To Window - Powrót do poprzedniego okna. Używać tylko po NW.
EE		xpath		Element Exists - Instrukcja warunkowa. Jeśli element pod <xpath> nie istnieje, wyrzuca test failed.
ENE		xpath		Element Not Exists - Instrukcja warunkowa. Jeśli element pod <xpath> istnieje, wyrzuca test failed.
G		name		GoTo - Przechodzi pod URL podany w <name>.
GET		xpath,name	Get Text - Pobiera plaintext spod podanego <xpath> i zapisuje do zmiennej <name>.
IF		name		If - Instrukcja warunkowa. Jeśli parametr <name> znajduje się na liście parametrów i nie jest pusty, przechodzi dalej. Jeśli nie, wyrzuca step untested.
IFT		name		Test If - Instrukcja warunkowa. Jeśli parametr <name> znajduje się na liście parametrów i nie jest pusty, przechodzi dalej. Jeśli nie, wyrzuca cały test jako untested.
M		xpath		Move - Przesuwa kursor na element pod <xpath>. Kursor pozostaje tam około sekundę.
NW		-		New Window - Przechodzi do nowo otwartego okna. Nie używać, jeśli nie ma pewności czy są jakieś okna poza pierwszym.
P		xpath,name	Picker - Wchodzi w link pod <xpath>, otwiera nowe okno, wybiera z niego opcję <name> i wychodzi.
PL2		xpath,name	Picker Level 2 - Zaawansowany picker. Jak wyżej, ale może rozwinąć kilka gałęzi drzewa po drodze. <name> musi być w postaci Gałąź\Gałąź\Wartość.
R		name		RadioButton - Zaznacza RadioButton o wartości zawierającej <name>.
S		xpath,name	Select - Wybiera z rozwijaczki pod <xpath> opcję <name>.
SCR		name		Screenshot - Robi nowy zrzut ekranu, wstawiając w jego nazwie wartość <name>. Nic nie zrobi, jeśli screenshootinglevel jest ustawione na 'never'.
T		xpath,name	Text - Wypełnia pole tekstowe pod <xpath> wartością <name>.
U		xpath,name	Upload File - klika w przycisk pod <xpath> rozwijający okno wyboru pliku, wpisuje ścieżkę podaną jako wartość <name> i zatwierdza.
W		name		Wait - Czeka pewną ilość czasu (w milisekundach). Należy podać mu bezpośrednio liczbę milisekund przez $name, lub podać wartość którą da się sparse'ować.