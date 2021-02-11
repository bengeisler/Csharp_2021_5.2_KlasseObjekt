using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_5._2_KlasseObjekt
{
	public partial class Form1 : Form
	{
		// Objekt "vespa" global deklarieren & erzeugen
		private Fahrzeug vespa = new Fahrzeug();

		// private Random r = new Random(); // Zufallszahl erzeugen
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnzeigen_Click(object sender, EventArgs e)
		{
			// Beispiel (bisher):
			int variable;

			// Variable vom Typ "Fahrzeug" erstellen
			// Fahrzeug vespa;

			// Objekt vom Typ "Fahrzeug" erstellen und der Variablen zuweisen
			// vespa = new Fahrzeug();

			// Ursprüngliche Geschwindigkeit ausgeben
			lblAnzeige.Text = vespa.Ausgabe();

			// Beschleunigen (Aufruf der Methode Beschleunigen)
			vespa.Beschleunigen(20);

			// Neue Geschwindigkeit ausgeben
			//lblAnzeige.Text += "\n" + vespa.Ausgabe();

			// Zugriff auf Eigenschaft "Geschwindigkeit"
			// über die Eigenschaftsmethode "Geschwindigkeit" (lesend)
			lblAnzeige.Text += "\n" + vespa.Geschwindigkeit.ToString();

			// Funktioniert nicht, da set private ist!
			// vespa.Geschwindigkeit = 120;

			// Test der Konstruktoren
			Fahrzeug zündapp = new Fahrzeug(20);
			Console.WriteLine("Objekt zündapp erstellt:");
			Console.WriteLine(zündapp.ToString());

			Console.WriteLine("");

			Fahrzeug polo = new Fahrzeug("Mein kleiner Polo");
			Console.WriteLine("Objekt Polo erstellt:");
			Console.WriteLine(polo.ToString());

			Console.WriteLine("");

			Fahrzeug honda = new Fahrzeug("Der Honda", 80);
			Console.WriteLine("Objekt honda erstellt:");
			Console.WriteLine(honda.ToString());

			Console.WriteLine("");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
