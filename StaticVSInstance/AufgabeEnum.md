## Area- und Volume-Calculator

Mit dem Umschreiben unseres Taschenrechner-Projektes haben wir bereits viel doppelten Code vermieden.
Durch die Anwendung von Enums haben wir nun einen Rechner mit fest definierten Rechenarten.

Eure Aufgabe ist es, folgende Funktionalitäten dem Taschenrechner (in StaticVSInstance-Projekt) 
hinzuzufügen:

## Berechnung von Area(Fläche) und Umfang von:

- [ ] Berechnung von Dreiecken (Triangles)
- [ ] Berechnung von Kreisen (Circles)
- [ ] Berechnung von Rechtecken (Rectangles)

## Implementierung

Die genaue Implementierung ist euch überlassen, solange das Ergebnis stimmt.
Folgende Bedingungen gelten:

- Es muss ein(!) Enum verwendet werden!
- alle zugehörigen Methoden müssen innerhalb einer(!) Klasse definiert sein. (z.B. in Calculator-Klasse oder neuer Klasse)
- Der Return-Type der Methoden (eg. CalculateCircleArea) muss der selbe sein, wie im Rest des Taschenrechners (bisher haben wir überall int, kann man aber auch alles zu decimal ändern, muss nur überall gleich sein)

## Hints

- In der Math-Klasse gibt es hilfreiche Methoden zu mathematischen Berechnungen (Math. ...). Nutzt diese bitte nicht. Die Berechnungen sollen selbst implementiert werden. Ihr dürft allerdings die Konstanten verwenden (eg. Math.PI, Math.E).
- Für die Mathematik (also die Formeln), dürft ihr Hilfsmittel verwenden (z.B. Google)