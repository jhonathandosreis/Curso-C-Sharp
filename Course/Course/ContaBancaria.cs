using System;

namespace Course // Course -> Pascal Case
{
    public class ContaBancaria // ContaBancaria -> Pascal Case
    {
        public string Titular { get; set; } // Titular -> Pascal Case

        private double _saldo; // _saldo -> Atributos interno das classes

        public void Deposito(double quantia) // quantia -> Camel Case
        {
            _saldo += quantia; // _saldo -> Atributo interno da classe // quantia -> Camel Case
        }

        public double GetSaldo() // GetSaldo -> Pascal Case
        {
            return _saldo; // _saldo -> Atributo interno da classe
        }
    }
}