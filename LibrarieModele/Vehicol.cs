namespace LibrarieModele
{
    public class Vehicol
    {
        public int VitezaMaxima { get; set; } = 0;
        public TipVehicol VehicName { get; set; }
        
        public Vehicol(TipVehicol veh)
        {
            VehicName = veh;
        }
        
        public void SetViteaMaxima(int _viteza)
        {
            VitezaMaxima = _viteza;
        }
    }
}