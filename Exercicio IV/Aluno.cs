using System;


namespace Exercicio_IV
{
    class Aluno
    {
        public string nome;
        public double Primeirotrimestre;
        public double Segundotrimestre;
        public double Terceirotrimestre;
        
        public double NotaFinal()
        {
            return Primeirotrimestre + Segundotrimestre + Terceirotrimestre;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante() {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
