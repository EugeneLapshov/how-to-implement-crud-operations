using System.Windows;
using System.Linq;

namespace EntityFrameworkIssues {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            LoadData();
        }
        EntityFrameworkIssues.Issues.IssuesContext _Context;

        void LoadData() {
            _Context = new EntityFrameworkIssues.Issues.IssuesContext();
            grid.ItemsSource = _Context.Users.ToList();
        }

        void OnValidateRow(System.Object sender, DevExpress.Xpf.Grid.GridRowValidationEventArgs e) {
            var row = (EntityFrameworkIssues.Issues.User)e.Row;
            if(e.IsNewItem)
                _Context.Users.Add(row);
            _Context.SaveChanges();
        }

        void OnValidateRowDeletion(System.Object sender, DevExpress.Xpf.Grid.GridValidateRowDeletionEventArgs e) {
            var row = (EntityFrameworkIssues.Issues.User)e.Rows.Single();
            _Context.Users.Remove(row);
            _Context.SaveChanges();
        }

        void OnDataSourceRefresh(System.Object sender, DevExpress.Xpf.Grid.DataSourceRefreshEventArgs e) {
            LoadData();
        }
    }
}
