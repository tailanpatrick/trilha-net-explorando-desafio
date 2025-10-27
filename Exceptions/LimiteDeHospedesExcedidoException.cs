using System;

public class LimiteDeHospedesExcedidoException : Exception
{
    public LimiteDeHospedesExcedidoException(string message) : base(message) { }
}
