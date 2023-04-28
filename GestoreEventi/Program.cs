using GestoreEventi;



Console.Write("Inserisci il nome dell'evento: ");
string nome = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
DateTime data = DateTime.Parse(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");
int posti = int.Parse(Console.ReadLine());

Console.Write("Quanti posti vuoi prenotare? ");
int postiUser = int.Parse(Console.ReadLine());



Evento evento1 = new Evento(nome, data, posti, postiUser);



ProgrammaEventi programmaEventi = new ProgrammaEventi("Proteggiamo la nostra Terra");


List<Evento> listaEventi = new List<Evento> { evento1, evento2 };

programmaEventi.AddListaEventi(listaEventi);





Console.WriteLine();
Console.WriteLine("Posti disponibili: " + posti);
Console.WriteLine("Posti prenotati: " + postiUser);


bool userNonVuolEliminarePosti = false;

while (!userNonVuolEliminarePosti)
{
    Console.Write("Vuoi disdire dei posti? (si/no) ");
    string rispostaUser = Console.ReadLine().ToLower();

    if (rispostaUser == "si")
    {
        Console.Write("Indica il numero di posti da disdire: ");
        int postiCancellatiUser = int.Parse(Console.ReadLine());
        evento1.CancellaPrenotazione(postiCancellatiUser);
        userNonVuolEliminarePosti = false;
        Console.WriteLine();
        Console.WriteLine("Posti disponibili: " + evento1.GetCapienza());
        Console.WriteLine("Posti prenotati: " + evento1.GetPostiPrenotati());
    }
    else if (rispostaUser == "no")
    {
        Console.WriteLine("Ok, va bene!");
        userNonVuolEliminarePosti = true;
    }
}










