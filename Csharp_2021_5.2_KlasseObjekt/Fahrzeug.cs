using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_5._2_KlasseObjekt
{
	// Klasse ("Bauplan")
	// Klassennamen beginnen per Konvention mit einem Großbuchstaben
	class Fahrzeug
	{
		// Eigenschaft: Bezeichnung
		// - private: Sichtbarkeit (nur innerhalb der Klasse)
		// - readonly: Eigenschaft kann nur gelesen werden 
		//             (außer im Konstruktor)
		// - string: Datentyp
		// - bezeichnung: Name der Eigenschaft
		private readonly string bezeichnung;

		// Konstruktor
		// gibt an, wie ein Objekt zu erzeugen ist
		// Konstruktoren sind IMMER public
		// Konstruktoren heißen IMMER so wie die Klasse
		// Es kann mehrere Konstruktoren geben
		public Fahrzeug(string b) // Erstellung mit Bezeichnung
		{
			bezeichnung = b;
			geschwindigkeit = 0;
		}

		public Fahrzeug(string b, int g) // Erstellung mit Bezeichn. & Geschw.
		{
			bezeichnung = b;
			geschwindigkeit = g;
		}

		public Fahrzeug(int g) // Erstellung mit Geschwindigkeit
		{
			bezeichnung = "(leer)";
			geschwindigkeit = g;
		}

		// Standardkonstruktor:
		public Fahrzeug()
		{
			bezeichnung = "(leer)";
			geschwindigkeit = 0;
		}

		// Eigenschaft
		// - private: Eigenschaft ist nur innerhalb der Klasse sichtbar
		// - int: Datentyp
		// - geschwindigkeit: Name der Eigenschaft
		private int geschwindigkeit;

		// Eigenschaftsmethode
		// regelt den Zugriff auf die Eigenschaft
		public int Geschwindigkeit
		{
			// Get => liefert Wert der Eigenschaft zurück
			// (lesender Zugriff)
			get
			{
				return geschwindigkeit;
			}

			// Set => schreibt den Wert der Eigenschaft
			// (schreibender Zugriff)
			// - private: Zugriff nur von innen
			private set
			{
				if (value > 100) geschwindigkeit = 100;
				else if (value < 0) geschwindigkeit = 0;
				else geschwindigkeit = value;
			}
		}

		// Methode
		// - public: Methode ist von außen sichtbar
		// - void: Rückgabetyp der Methode (nichts)
		// - Beschleunigen: Name der Methode
		// - int wert: Ein Parameter vom Typ int wird übergeben
		public void Beschleunigen(int wert)
		{
			Geschwindigkeit += wert;
		}

		public string Ausgabe()
		{
			return "Geschwindigkeit: " + geschwindigkeit;
		}


		// Methode "ToString()" der Basisklasse überschreiben
		// - public: Sichtbarkeit der Methode (von außen sichtbar)
		// - override: Gibt an, dass die Methode der Basisklasse überschrieben werden soll
		// - string: Rückgabetyp
		// - ToString(): Name der Methode
		public override string ToString()
		{
			return
				"Bezeichnung: " + bezeichnung + "\n" +
				"Geschwindigkeit: " + geschwindigkeit + "\n";
		}
	}
}
