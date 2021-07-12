using System;
using System.Collections.Generic;

namespace ProyectoHotelNT1.Models
{
    public partial class Habitaciones
    {
        public int Id { get; set; }
        public int NumHabitacion { get; set; }
        public bool EstaOcupada { get; set; }
        public double PrecioPorDia { get; set; }
        public int CapacidadMax { get; set; }
    }
}
