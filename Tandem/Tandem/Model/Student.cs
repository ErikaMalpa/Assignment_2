using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tandem.Annotations;

namespace Tandem.Model
{
    /// <inheritdoc />
    /// <summary>
    /// This is the class model of Students, it has the constructors for First and Last Name, Email
    /// Mother Tongue and Language Wanted.
    /// INotifyPropertchanged is used because we will define a collection class in our view model
    /// that will notify the UI (Provides changes notification to UI) I am using a table and I want it to add
    /// a new line everytime a user inputs a new input.
    /// </summary>
    public class Student : INotifyPropertyChanged
    {
        private string _sFn;

        /// <summary>
        /// Student First Name
        /// This gets and sets the studentFirstName
        /// </summary>
        public string studentFirstName
        {
            get => _sFn;
            set => _sFn = value;
        }

        private string _sLn;

        /// <summary>
        /// Student Last Name
        /// This gets and sets the studentLastName
        /// </summary>
        public string studentLastName
        {
            get => _sLn;
            set => _sLn = value;
        }

        private string _sEm;

        /// <summary>
        /// Student Email
        /// This gets and sets the studentEmail
        /// </summary>
        public string studentEmail
        {
            get => _sEm;
            set => _sEm = value;
        }

        private string _sMt;

        /// <summary>
        /// Student MotherTongue
        /// This gets and sets the StudentMotherTongue
        /// </summary>
        public string studentMotherTongue
        {
            get => _sMt;
            set => _sMt = value;
        }

        private string _sLw;

        /// <summary>
        /// Student Language Wanted
        /// This gets and sets the studentLanguageWanted
        /// </summary>
        public string studentLanguageWanted
        {
            get => _sLw;
            set => _sLw = value;
        }

        /// <summary>
        /// We need this for INotifyPropertyChanged to work
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
