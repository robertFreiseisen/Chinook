# Chinook
Chinook ist ein Media-Store mit dem Ziel, seinen Kunden den bestm�glichen Service zu bieten. Um die Dienste an den Kunden entsprechend anzupassen, ben�tigt die Marketing Abteilung Informationen. Das bestehende System 
beinhaltet die Stammdaten und Bewegungsdaten aus der Vergangenheit. 
Betrachten wir nun folgendes Datenmodel:
![Models](Models.png)

## Anforderungen
Die Marketing Abteilung ben�tigt f�r ihre n�chsten Aktivit�ten folgende Informationen aus den Datenbest�nden:
* Track-Zeit-Auswertung
  * Track mit Maximalzeit [sec]
  * Track mit Minimalzeit [sec]
  * Durchschnittszeit [sec]
* Album-Zeit-Auswertung
  * Album mit Maximalzeit [sec]
  * Album mit Minimalzeit [sec]
  * Durchschnittszeit [sec]
* Track-Verkauf-Auswertung
  * Track mit der h�chsten Verkaufszahl
  * Track mit der minimalen Verkaufszahl
  * Track mit dem h�chsten Umsatz
  * Track mit dem geringsten Umsatz
  * Kunden-Auswertung
  * Kunde mit h�chsten Umsatz
  * Kunde mit geringstem Umsatz
  * Durchschnittsumsatz
* Genre-Verkauf-Auswertung
  * Genre mit der h�chsten Verkaufszahl
  * Genre mit der minimalen Verkaufszahl

Die Auswertung erfolgt in einer einfachen Konsolenanwendung