using GestoreEventi;

Console.Write("Inserisci il nome dell'evento: ");
string nome = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");
int posti = int.Parse(Console.ReadLine());

Console.Write("Quanti posti vuoi prenotare? ");
int postiUser = int.Parse(Console.ReadLine());



Evento evento1 = new Evento(nome, data, posti);

Console.WriteLine();
Console.WriteLine("Posti disponibili: " + posti);
Console.WriteLine("Posti prenotati: " + postiUser);


Console.Write("Vuoi disdire dei posti? (si/no) ");
string rispostaUser = Console.ReadLine();

bool eliminaPosti = true;

while (eliminaPosti = true)
{

    if (rispostaUser == "si")
    {
        Console.Write("Indica il numero di posti da disdire: ");
        int postiCancellatiUser = int.Parse(Console.ReadLine());
        evento1.CancellaPrenotazione(postiCancellatiUser);
    }
    else if (rispostaUser == "no")
    {
        Console.WriteLine("Ok, va bene!");
        eliminaPosti = false;
    }
}

Console.WriteLine();
Console.WriteLine("Posti disponibili: " + posti);
Console.WriteLine("Posti prenotati: " + postiUser);






