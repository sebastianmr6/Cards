using System;

namespace maui_cards
{
    public class Card
    {
        public string? NombreComun { get; set; }
        public string? NombreCientifico { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public string? ImagenPath { get; set; }
        public bool SyncStatus { get; set; }
    }
}