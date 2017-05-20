using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using FizzWare.NBuilder;

namespace Module3Controls
{
    public sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _age;

        public MainWindowViewModel()
        {
            SourceOfStudents = Builder<Student>
                .CreateListOfSize(20000)
                .Build()
                .ToList();
        }

        public List<Student> SourceOfStudents { get; }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
