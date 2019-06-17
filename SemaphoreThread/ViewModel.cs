using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreThread
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnNotifyPropertyChanged(string param)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }
        public ObservableCollection<string> WorkingThreads { get; set; }
        public ObservableCollection<string> WaitingThreads { get; set; }
        public ObservableCollection<string> CreatedThreads { get; set; }
        public static List<Thread> Threads { get; set; }
        public static Semaphore semaphore = new Semaphore(2, 2);

    }
}
