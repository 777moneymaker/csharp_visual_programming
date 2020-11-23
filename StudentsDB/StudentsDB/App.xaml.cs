using System.Collections.ObjectModel;
using System.Windows;

namespace StudentsDB {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        internal static ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>();
    }
}
