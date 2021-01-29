# Krótki opis
Zaplanowanie egzaminów tak, by niektóre egzaminy nie odbywały się w
tym samym czasie.
# Opis projektu
Tak rozplanować egzaminy, by niektóre nie odbywały się w tym samym terminie. Student podchodzący do co najmniej dwóch egzaminów nie może ich
pisać w tym samym czasie, więc muszą one odbywać się w różnych terminach. Do wykonania
takiego planu sesji, by każdy student mógł przystąpić do wszystkich swoich egzaminów
wykorzystamy reprezentację grafu nieskierowanego w postaci macierzy sąsiedztwa oraz
algorytm kolorowania grafu. Macierzą sąsiedztwa M nazywamy macierz o wymiarach n x n,
gdzie n to liczba wierzchołków grafu. Jeżeli pomiędzy wierzchołkami vi ∈ V i vj ∈ V, gdzie V to
zbiór wierzchołków grafu, istnieje krawędź to M[i][j]=1 oraz M[j][i]=1, w przeciwnym wypadku
M[i][j]=0 oraz M[j][i]=0. Zaś kolorowanie polega na przypisaniu wszystkim wierzchołkom w
grafie jednego z wybranych kolorów w ten sposób, aby żadne dwa sąsiednie wierzchołki nie
miały tego samego koloru. W naszym algorytmie wierzchołkami grafu będą egzaminy.
Krawędzie między dwoma wierzchołkami (egzaminami) istnieją, jeśli dany student przystępuje
do tych dwóch egzaminów. Kolorami będą terminy egzaminów, nadawane w ten sposób, że
każde połączone wierzchołki nie będą w tym samym kolorze, innymi słowy każde egzaminy
pisane przez jednego studenta nie będą w tym samym terminie.
# Algorytm
Zebranie danych: Zaczynamy się od wyboru liczby egzaminów oraz liczby studentów. Po tym
wyborze następuje inicjalizacja grafu - dwuwymiarowej, wypełnionej zerami macierzy
sąsiedztwa z liczbą wierszy oraz kolumn, odpowiadającym liczbie wybranych egzaminów. W
kolejnym kroku dla każdego studenta tworzymy listę zawierającą numery pisanych przez niego
egzaminów. Dla każdej takiej listy wywołujemy funkcję „Connect”, która wypełnia macierz
jedynkami (tworzy krawędzie) dla każdej pary numerów egzaminów i zwraca uzupełnioną w ten
sposób macierz. Kiedy nastąpi wybór egzaminów dla wszystkich studentów uruchamia się 
funkcja „GraphColoring” przyjmująca jako parametr macierz sąsiedztwa rozwiązująca problem
kolorowania wierzchołków dla danego grafu. Sama w sobie tworzy tablicę kolorów wypełnioną
zerami o długości równej ilości egzaminów. Następnie wywołuje funkcję „GraphColoringAlg”
odpowiadającą za właściwy algorytm kolorowania, czyli przypisanie odpowiedniego koloru
(terminu) do wierzchołka (egzaminu) i przyjmującą jako parametry macierz sąsiedztwa, tablicę
kolorów i pierwszy wierzchołek grafu.
# Kolorowanie
Funkcja „GraphColoringAlg” działa rekurencyjnie, a jej warunkiem stopu jest
sytuacja, gdzie wszystkie wierzchołki mają przydzielony kolor. Algorytm działa następująco: Dla
każdego koloru sprawdzamy czy możemy wpisać badany kolor do danego wierzchołka za
pomocą funkcji „IsAvailable”. Jeśli tak przypisujemy kolor do badanego wierzchołka. Następnie
wywołujemy rekurencyjnie funkcję „GraphColoringAlg” badając następny wierzchołek. Gdy
wszystko idzie po naszej myśli w ten sposób możemy uzupełnić całą tablicę kolor. Jednak, gdy
przypisanie danego koloru do wierzchołka nie doprowadzi nas do rozwiązania i przy następnym
badanym wierzchołku nie będziemy mieli opcji dopasowania do niego koloru, usuwamy kolor z
poprzedniego wierzchołka i próbujemy rozwiązać za pomocą przypisania innego koloru. Gdy
dojdzie do sytuacji, że usuniemy kolor z pierwszego wierzchołka algorytm przerwie się,
ponieważ nie ma sensu próbować go kolorować od początku używając innego koloru dla
wierzchołka początkowego. Algorytm jest bardzo uogólniony, w naszym przypadku nigdy nie
będziemy mieli opcji niepowodzenia przy próbie kolorowania, ponieważ ilość dostępnych
kolorów (terminów) jest równa liczbie wierzchołków (egzaminów). Na koniec wracamy do
funkcji „GraphColoring” i zwracamy tablice z kolorami, która tak naprawdę odpowiada
terminom dla danych egzaminów np. dla tablicy [1,1,2] pierwszy oraz drugi egzamin odbędzie
się w 1 terminie, a 3 egzamin w 2 terminie.
# Działanie programu
W pierwszym oknie należy wybrać liczbę wszystkich dostępnych egzaminów (maksymalnie 9
egzaminów) oraz liczbę studentów, którzy mogą podejść do egzaminu (maksymalnie 100
studentów). Aby przejść do następnego okna klikamy przycisk „Dalej”. W drugim oknie, po kolei
dla każdego studenta wybieramy numer egzaminu, do którego przystępuje. Aby przejść do
kolejnego studenta klikamy przycisk „Następny”. Gdy przydzielimy egzaminy dla każdego
studenta, pojawia się przycisk „Pokaż rozkład egzaminów”, dzięki któremu przechodzimy do
ostatniego okna, w którym pojawia się tabela ukazująca rozkład egzaminów w wybranych
terminach. Aby wyjść z programu klikamy przycisk „Zakończ”.
