string resposta;

Console.WriteLine("Conheça o Meme Fluxo da Engenharia!");
Console.WriteLine("Está se movendo? (Responda com Sim ou Não): ");

resposta = Console.ReadLine()!.ToUpper();

if (resposta == "SIM")
{
    Console.WriteLine("Deveria? (Responda com Sim ou Não): ");
    resposta = Console.ReadLine()!.ToUpper();

    if (resposta == "SIM")
    {
        Console.WriteLine("Ótimo");
    }
    else
    {
        Console.WriteLine("Use Silver Tape");
    }

}
else
{
    Console.WriteLine("Deveria? (Responda com Sim ou Não): ");
    resposta = Console.ReadLine()!.ToUpper();

    if (resposta == "NAO")
    {
        Console.WriteLine("Use WD-40");
    }
    else
    {
        Console.WriteLine("Ótimo!");
    }

}