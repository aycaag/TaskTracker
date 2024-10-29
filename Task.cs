using System.Collections;
using System.Data.Common;

public class Task
{
    public int Id { get; private set; }
    public  string Description { get; set;}
    public  string Status { get; set;}
    public DateTime CreatedDate { get; private set; }   
    public DateTime UpdatedDate { get; private set;}    

    private static int counter = 0;

    public static SortedList TaskList= new SortedList();

private Task()
{
    this.Id = counter++;
    this.CreatedDate = DateTime.Now;
    this.UpdatedDate = DateTime.Now;
    this.Status = "To-Do" ;
}

public Task(string description):this()
{
    this.Description = description;
}

public static void TaskAdd(Task t )
{
    TaskList.Add(t.Id,t);  
}

public static void TaskUpdate(int ID,string newValue)
{
    if (TaskList.ContainsKey(ID))
    {
    Task task=(Task)TaskList[ID];
    task.Description = newValue;
    task.UpdatedDate = DateTime.Now;
    TaskList[ID]=task;
    }
    else 
    {
        Console.WriteLine("ID bulunamadı.");
    }
}
public static void TaskPrint()
{
    foreach (DictionaryEntry item in  TaskList)
    {
        Task t = (Task)item.Value;
        Console.WriteLine("ID: {0} - Görev:{1} - Status {4}- Oluşturma Tarihi:{2} - Güncelleme Tarihi:{3} ",item.Key.ToString(),t.Description,t.CreatedDate,t.UpdatedDate,t.Status );
    }
}

public static void TaskUpdateStatus(int ID,string Status)
{
    if (TaskList.Contains(ID))   
    {
        Task task=(Task)TaskList[ID];
        task.Status = Status;
        task.UpdatedDate = DateTime.Now;
        TaskList[ID] = task;
    }
    else 
    {
        Console.WriteLine("ID bulunamadı.");
    }
}

}