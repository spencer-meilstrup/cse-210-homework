public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void ShowJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}), {_startYear}-{_endYear}");
        //return $"Job: {_jobTitle} ({_companyName}), {_startYear}-{_endYear}";
    }
}