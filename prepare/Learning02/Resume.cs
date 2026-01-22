public class Resume
{
    public string _userName;
    public List<Job> _jobs = new List<Job>();
    
    public void ShowResume()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.ShowJobDetails();
        }
    }
}