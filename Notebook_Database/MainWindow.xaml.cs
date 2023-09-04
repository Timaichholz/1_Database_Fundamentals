using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Notebook_Database
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private NotesContext _context;

    public MainWindow()
    {
      InitializeComponent();
      _context = new NotesContext();
      LoadNotes();
    }

    private void LoadNotes()
    {
      lvNotes.ItemsSource = _context.Notes.ToList();
    }

    private void OnAddNote(object sender, RoutedEventArgs e)
    {
      var note = new Note { Title = "New Note", Content = "Note Content", CreatedDate = DateTime.Now };
      _context.Notes.Add(note);
      _context.SaveChanges();
      LoadNotes();
    }
  }
}
