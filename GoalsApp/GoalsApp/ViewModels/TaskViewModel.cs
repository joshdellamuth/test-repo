using System.ComponentModel;
//to pull in the MyTask data, either specify the namespace 
//or do Models.MyTask before all the task objects 
using GoalsApp.Models;


//Database Querying should happen here
namespace GoalsApp.ViewModels;

public class TaskViewModel : INotifyPropertyChanged
{
    private MyTask _currentTask;

    public MyTask CurrentTask
    {
        get { return _currentTask; }
        set
        {
            if (_currentTask != value)
            {
                _currentTask = value;
                OnPropertyChanged(nameof(CurrentTask));
            }
        }
    }

    //contructor that sets TaskViewModel to some test data
    //This ViewModel is where the data is stored - database should pull in and write to 
    //the intial data here 
    public TaskViewModel()
    {
        CurrentTask = new MyTask { TaskName = "1", TaskNumber = "1" };
    }


    private string _TaskName;
    public string TaskName
    {
        get { return _TaskName; }
        set
        {
            if (_TaskName != value)
            {
                _TaskName = value;
                //if you set a breakpoint here and open a "Locals"
                //window, you will see it updates everytime a 
                //letter is typed 
                OnPropertyChanged(nameof(TaskName));
            }
        }
    }

    private string _TaskNumber;
    public string TaskNumber
    {
        get { return _TaskNumber; }
        set
        {
            if (_TaskNumber != value)
            {
                _TaskNumber = value;
                //if you set a breakpoint here and open a "Locals"
                //window, you will see it updates everytime a 
                //letter is typed 
                OnPropertyChanged(nameof(TaskNumber));
            }
        }
    }



    //all property changed methods will use these events below 
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}