using System;

class Program
{
    struct Personagem
    {
        public string Nome;
        public int Forca;
        public int Agilidade;
        public int Inteligencia;
        public int Vida;
    }

    static void Main()
    {
        Personagem p1 = CriarPersonagem("Homem-Aranha", 7, 9, 10, 7);
        Personagem p2 = CriarPersonagem("Venom", 8, 7, 7, 9);
        ExibirPersonagem(p1);
        ExibirPersonagem(p2);
        Console.WriteLine("Batalha");
        int pontosP1 = 0;
        int pontosP2 = 0;        
        if (CalcularEstrategia(p1) > CalcularEstrategia(p2))
        {
            Console.WriteLine("Lógica de batalha: estratégica");
            pontosP1++;
        }
        else
        {
            Console.WriteLine("Lógica de batalha: estratégica");
            pontosP2++;
        }
        
        Console.WriteLine("Resultado");

        if (pontosP1 > pontosP2)
            Console.WriteLine(p1.Nome + " venceu a batalha");
        else if (pontosP2 > pontosP1)
            Console.WriteLine(p2.Nome + " venceu a batalha");
        else
            Console.WriteLine("Empate");
    }

    static Personagem CriarPersonagem(string nome, int f, int a, int i, int v)
    {
        Personagem p;
        p.Nome = nome;
        p.Forca = f;
        p.Agilidade = a;
        p.Inteligencia = i;
        p.Vida = v;
        return p;
    }

    static void ExibirPersonagem(Personagem p)
    {
        Console.WriteLine("\nPersonagem: " + p.Nome);
        Console.WriteLine("Força: " + p.Forca);
        Console.WriteLine("Agilidade: " + p.Agilidade);
        Console.WriteLine("Inteligência: " + p.Inteligencia);
        Console.WriteLine("Vida: " + p.Vida);
    }


    static int CalcularEstrategia(Personagem p)
    {
        return p.Inteligencia * 2;
    }

}