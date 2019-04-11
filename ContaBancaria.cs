using System;

namespace MeuPrimeiroProjeto
public class ContaBancaria
{
	public String nome {get; set; }
    private double _saldo;

    public void Deposito(double valor) {
        _saldo += valor;
    }
}
