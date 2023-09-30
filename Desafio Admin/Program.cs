string permission = "Admin|Gerente";
string level = "";
string opcao = "";

Console.WriteLine("Digite 1 - ADMIN\nDigite 2 - GERENTE");
opcao = Console.ReadLine();
Console.WriteLine((opcao == "1" ? "ADMIN" : "GERENTE"));
Console.WriteLine("Digite o seu Acesso lvl 0 - 100");
level = Console.ReadLine();



if (int.Parse(opcao) == 1) 
{
    if (int.Parse(level) > 55)
    {
        Console.WriteLine("Bem-Vindo, Super Admin.");
    }
    else 
    {
        Console.WriteLine("Bem-Vindo, Admin user.");
    }
}
else if (int.Parse(opcao) == 2)
{
    if (int.Parse(level) >= 20)
    {
        Console.WriteLine("Bem-Vindo, Gerente.");
    }
    else
    {
        Console.WriteLine("Bem-Vindo, Gerente. Você não tem privilegios suficientes.");
    }
}
else
{
    Console.WriteLine("Você não possui acesso.");
}

