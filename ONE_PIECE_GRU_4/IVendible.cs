using System;

namespace ONE_PIECE_GRUP_4
{
    // INTERFAZ: Contrato para artículos que registran su venta.
    public interface IVendible
    {
        void ProcesarVenta(int cantidad);
    }
}