namespace Edilizia_v2.Models
{
    public static class Db
    {
        private static int _maxId = 3;

        private static List<Dipendente> _dipendenti { get; set; } = [
            new Dipendente() { DipendenteId = 1, Nome = "Francesco", Cognome = "Missorini", Indirizzo = "Via del campo", CodiceFiscale = "1234567899999999", Coniugato = true, Figli = 3, Mansione = "Pulizia Pubblica" },
            new Dipendente() { DipendenteId = 2, Nome = "Marco", Cognome = "Silveri", Indirizzo = "Via della scrofa", CodiceFiscale = "1234567899999999", Coniugato = false, Figli = 1, Mansione = "Ente previdenziale" },
            new Dipendente() { DipendenteId = 3, Nome = "Abel", Cognome = "Sassu", Indirizzo = "Via cagliari", CodiceFiscale = "1234567899999999", Coniugato = true, Figli = 8, Mansione = "Carceriere"}];

        public static List<Dipendente> getAll()
        {
            return _dipendenti;
        }

        public static Dipendente? getById(int? id)
        {
            if (id == null) return null ;
            for(int i = 0; i < _dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (_dipendenti[i].DipendenteId == id)
                {
                    return dipendente;
                }    
            }
            return null;
        }

        public static Dipendente AggiungiDipendente(string nome, string cognome, string indirizzo, string codicefiscale, bool coniugato, int figli, string mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { DipendenteId = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, CodiceFiscale = codicefiscale, Coniugato = coniugato, Figli = figli, Mansione = mansione };
            _dipendenti.Add(dipendente);
            return dipendente;
        }



    }
}
