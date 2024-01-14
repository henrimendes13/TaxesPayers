
using TaxesPayers.Entities;

List <TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine());

    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpendures = double.Parse(Console.ReadLine());
        list.Add(new Individual (name, anualIncome, healthExpendures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        list.Add(new Company (name, anualIncome, numberOfEmployees));
    }

}
Console.WriteLine();

double totaltaxes = 0;

Console.WriteLine("TAXES PAID:");
foreach (TaxPayer taxPayer in list)
{
    
    totaltaxes = totaltaxes + taxPayer.Tax();
    
    Console.WriteLine(
        taxPayer.Name.ToString() 
        + ": $ " 
        + taxPayer.Tax().ToString("F2") );
}

Console.WriteLine();
Console.Write($"TOTAL TAXES: ${totaltaxes.ToString("F2")}");
