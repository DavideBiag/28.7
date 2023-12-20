using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        public enum Tipologia
        {
            Singola, 
            Doppia
        }
       
        public enum Trattamento
        {
            Pernottamento_con_prima_colazione,
            Pensione_completa,
            Mezza_pensione
        }

        public class Cliente
        {
            public string nome { get; set; }
            public string cognome { get; set; }
            public string città { get; set; }
            public string provincia { get; set; }
            public string codiceFiscale { get; set; }
            public string telefono { get; set; }
            public string eMail { get; set; }
            public string cellulare { get; set; }   
        }

        public class Camera
        {
            public int numero { get; set; } 
            public string descrizione { get; set; } 
            public Tipologia tipologia { get; set; }    
        }

        public class Tariffa
        {
            public Tipologia tipologia { get; set; }
            public Trattamento trattamento { get; set; }        
            public DateTime dal { get; set; }
            public DateTime al { get; set; }
        }

        public class Servizio
        {
            public string descrizione { get; set; }
            public float prezzo { get; set; }
            public DateTime data { get; set; }
            public int quantità { get; set; }
        }
        public class Prenotazione
        {
            public float caparra { get; set; }
            public int numeroProgressivo { get; set; }
            public int anno { get; set; }
            public Cliente cliente { get; set; }
            public DateTime dataPrenotazione { get; set; }
            public Tariffa tariffa { get; set; }
            public DateTime inizio { get; set; }
            public DateTime fine { get; set; }
            List <Servizio> servizi { get; set; } 
            
        }
        static void Main(string[] args)
        {
            Prenotazione prenotazione = new Prenotazione();
            prenotazione.numeroProgressivo = 15;
            prenotazione.anno = 2023;
            prenotazione.cliente.nome = "Davide";
            prenotazione.cliente.cognome = "Biagini";
            prenotazione.cliente.città = "Formica";
            prenotazione.cliente.provincia = "Modena";
            prenotazione.cliente.eMail = "davidebiagini@ghmail.com";
            prenotazione.cliente.cellulare = "3435678891";
            prenotazione.cliente.telefono = "05965779";
            prenotazione.cliente.codiceFiscale = "dvdbgn09M";
            prenotazione.dataPrenotazione = new DateTime(2023, 12, 20);
            prenotazione.inizio = new DateTime(2023, 12, 24);
            prenotazione.fine = new DateTime(2023, 12, 30);
            prenotazione.tariffa.tipologia = Tipologia.Doppia;
            prenotazione.tariffa.trattamento = Trattamento.Pernottamento_con_prima_colazione;
            prenotazione.caparra = 156;
            Servizio servizio= new Servizio();
            servizio.descrizione = "Culla";
            servizio.quantità = 1;
            servizio.data = new DateTime(2023, 12, 24);
            servizio.prezzo = 60;
            Console.WriteLine("");
        }
    }
}

