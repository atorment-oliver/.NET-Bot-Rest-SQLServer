namespace AIO.Entities.Bookings
{
    //
    // Resumen:
    //     Contiene los valores de códigos de estado definidos para los BOOKINGS.
    public enum BookedStatusCode
    {
        //
        // Resumen:
        //     Equivalente al código de estado 0, que indica la reserva confirmada
        BOOKED,
        //
        // Resumen:
        //     Equivalente al código de estado 1, que indica la reserva cancelada
        CANCELED,
        //
        // Resumen:
        //     Equivalente al código de estado 2, que indica si ha habido un cambio en el precio en el momento de hacer la reserva en firme
        PRICE_ERROR,
        //
        // Resumen:
        //     Equivalente al código de estado 3, que indica si la reserva tiene algún error en algún servicio
        BOOK_ERROR,
        //
        // Resumen:
        //     Equivalente al código de estado 4, este estado se define en el contrato de proveedor para un concierto o en especifico
        ON_REQUEST,
        //
        // Resumen:
        //     Equivalente al código de estado 5, que indica si la reserva no se encuentra reservado
        NOT_BOOKED,
        //
        // Resumen:
        //     Equivalente al código de estado 6, que indica si la reserva se encuentra en una actualizacion pendiente
        PENDING_UPDATE
    }
}
