
using System.Collections;
using System.Net.Http.Headers;

Console.WriteLine("Görev ekleyebilir ve güncelleyebilirsiniz.");
Console.WriteLine("Eklemek için Add ve Görevi yazınız.");
Console.WriteLine("Görevleri listelemek için list yazınız");
Console.WriteLine("Güncellemek için Update ID ve yeni veriyi giriniz");
Console.WriteLine("Status için mark ID Status giriniz");
Console.WriteLine("Uygulamadan çıkmak için 0(sıfır)'a basınız");
Console.WriteLine();


while(true)
{

Console.WriteLine("Bir işlem yapın..");

string input = Console.ReadLine();//"Add Çamaşır Yıka";
string islem = input.Split(' ')[0].ToLower();

// int sayi = input.IndexOf(input.Split(' ')[1]);


// Console.WriteLine(sayi);
// return;

if (input == "0")
{
    break;
}
if (islem == "add")
{
    Task t_add = new Task(input.Substring(4,input.Length-4));
    Task.TaskAdd(t_add);
}

if (islem == "update")
{   
    try
    {
    int secilenID = Convert.ToInt32(input.Split(' ')[1]);
    string newValue = input.Substring(input.IndexOf(input.Split(' ')[2]),input.Length-input.IndexOf(input.Split(' ')[2]));
    Task.TaskUpdate(secilenID, newValue);
    Console.WriteLine("Seçilen ID görevi {0} ile güncellenmiştir.",newValue);
    }
    catch
    {
        
    }
}

if (islem == "list")
{
    Task.TaskPrint();
}

if (islem == "mark")
{
    
    int secilenID = Convert.ToInt32(input.Split(' ')[1]);
    string newStatus = input.Substring(input.IndexOf(input.Split(' ')[2]),input.Length-input.IndexOf(input.Split(' ')[2]));
    Task.TaskUpdateStatus(secilenID, newStatus);

}

}

Console.WriteLine("Uygulamadan çıktınız..");


