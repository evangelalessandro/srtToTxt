using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srtToTxt
{
  public partial class Form1 : Form
  {
    public string _file=string.Empty;
    public Form1()
    {
      InitializeComponent();
      this.AllowDrop = true;
      this.DragEnter += new DragEventHandler(Form1_DragEnter);
      this.DragDrop += new DragEventHandler(Form1_DragDrop);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }



    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.None;
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
      {
        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.ToList().Count() == 1)
        {
          if (files.ToList().Where(a => a.EndsWith(".srt", StringComparison.InvariantCultureIgnoreCase)).Count() == 1)
          {
            e.Effect = DragDropEffects.Copy;
          }
        }
      }
    }

    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
      foreach (string file in files)
      {
        _file = file;
        lblFileSorgente.Text = file;
      }
        
    }
    enum tipiDatiSrt
    {
      NonSpec=0,
      NumeroBattuta=1,
      Tempo=2,
      Testo=3

    }
    private List<string> _toRemove = new List<string>() {  "</font>", @"<font color=""#E5E5E5"">",@"<font color=""#CCCCCC"">", "  " };
    private void button1_Click(object sender, EventArgs e)
    {
      if (_file!=string.Empty)
      {
        try
        {
          txtRich.Text = "";
          var numeri= Enumerable.Range(1, 2000).Select(a=>a.ToString()).ToList();
          var dati = System.IO.File.ReadAllLines(_file);
          tipiDatiSrt tipo = tipiDatiSrt.NonSpec;
          tipiDatiSrt tipoPrec = tipiDatiSrt.NonSpec;

          foreach (var item in dati.Where(a=>a.Length>0).ToList())
          {
            if ((tipoPrec == tipiDatiSrt.Testo || tipoPrec == tipiDatiSrt.NonSpec) && numeri.Contains(item))
            {
              tipo = tipiDatiSrt.NumeroBattuta;
            }
            else if (tipoPrec == tipiDatiSrt.NumeroBattuta && item.Contains("-->"))
            {
              tipo = tipiDatiSrt.Tempo;
            }
            else
            { 
              tipo = tipiDatiSrt.Testo;
              var a = item;
              foreach (var itemReplace in _toRemove)
              {
                a = a.Replace(itemReplace, " ");
              }
              txtRich.Text += a.Trim() + " ";
            }
            tipoPrec = tipo;
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);

        }
        
      }
    }
  }
}
