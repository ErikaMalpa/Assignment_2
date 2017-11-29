using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tandem.Model;

namespace Tandem.ViewModel
{
    /// <inheritdoc />
    /// <summary>
    /// This is the stuent view model of the model student
    /// Again, INotifyPropertchanged is used because we will define a collection class in our view model
    /// that will notify the UI (Provides changes notification to UI)
    /// </summary>
    public class StudentViewModel : INotifyPropertyChanged
    { 
        private Student _myStudent;

        /// <summary>
        /// Getters and Setters for Student
        /// 
        /// NotifyPropertyChanged is used, as data from the model needs to be passed through
        /// view model and go to the UI
        /// </summary>
        public Student Student
        {
            get => _myStudent;
            set
            {
                _myStudent = value;
                NotifyPropertyChanged("Student");
            }
        }

        private ObservableCollection<Student> _myStudents;
        /// <summary>
        /// Getters and Setters for Student ObservableCOllection
        /// 
        /// Observable Collection is used to create and bind to a collection that
        /// comes from ObservableCollection, it is a class that provides notification
        /// when items gets added or removed
        /// 
        /// List all students in observable collection
        /// </summary>
        public ObservableCollection<Student> Students
        {
            get => _myStudents;
            set
            {
                _myStudents = value;
                NotifyPropertyChanged("Students")
                    ;
            }
        }

        private ICommand _submit;
        /// <summary>
        /// if submit is null, The 2 delegates are passed and the bool is passed in the Command
        /// </summary>
        public ICommand SubmitButton => _submit ?? (_submit = new Command(Submit, CanSubmit, false));

        /// <summary>
        /// Initialise Student and ObservableCOllection 
        /// </summary>
        public StudentViewModel()
        {
            Student = new Student();
            Students = new ObservableCollection<Student>();
        }

        private void Submit(object parameter)
        {
            Students.Add(Student);
        }

        private bool CanSubmit(object parameter)
        {
            return !string.IsNullOrEmpty(Student.studentFirstName) && !string.IsNullOrEmpty(Student.studentLastName) && !string.IsNullOrEmpty(Student.studentEmail) && !string.IsNullOrEmpty(Student.studentMotherTongue) && !string.IsNullOrEmpty(Student.studentLanguageWanted);
        }

        /// <inheritdoc />
        /// <summary>
        /// Represents the method that will handle the INotifyPropertyChanged.PropertyChanged event raised when a property is changed on a component
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
