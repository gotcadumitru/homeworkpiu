using System;

namespace LibrarieModele
{
    public class Livrator
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Vehicol Transport { get; set; }

        public Livrator()
        {
            Nume = Prenume = string.Empty;
        }
        public Livrator(string _linieFisier)
        {
            var dateFisier = _linieFisier.Split('^');
            
            Nume = dateFisier[0];
            Prenume = dateFisier[1];
            
            Transport = new Vehicol((TipVehicol)Int32.Parse(dateFisier[2]));

        }
        public Livrator(string _nume, string _prenume)
        {
            Nume = _nume;
            Prenume = _prenume;
        }
        public string ToStringPentruAfisare()
        {
            return $"{Nume} {Prenume} are vehicolul: {Transport.VehicName}";
        }
        public string ToStringPentruScriereInFisier()
        {
            return $"{Nume}^{Prenume}^{(int)Transport.VehicName}";
        }
    }
}