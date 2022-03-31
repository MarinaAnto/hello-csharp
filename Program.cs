/*
 Scrivere un programma che stampi un messaggio di Benvenuto.
Successivamente stampa i mesi dell’anno riga per riga e chiede all’utente di scrivere il suo mese preferito.
Una volta inserito il mese preferito, il programma stampa un messaggio di saluto e termina.
*/
Console.WriteLine("Benvenuto !!!");
string[] months = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto","Settembre","Ottobre","Novembre","Dicembre"};
foreach (string month in months)
{
    Console.WriteLine(month);
}
Console.WriteLine("Qual'è il tuo mese preferito?");
 string prefer = Console.ReadLine();
Console.WriteLine("Il tuo mese preferito è " + prefer   + ". Arrivederci !!!");