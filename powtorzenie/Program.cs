using powtorzenie;

class plikglowny
{
    static void Main(string[] args)
    {
        tablice tabliczka = new tablice();
        int[] tab = tabliczka.Tworzenie_tablicy();
        tabliczka.Wyswietl(tab);
    }
}