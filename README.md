<h1>Factory Method Pattern Menu Aplikace</h1>

Tento systém umožňuje vytvářet hierarchická menu v konzolové aplikaci, kde:

<ul>
  <li>položky mohou být akce (spouští konkrétní funkci)</li>
  <li>nebo podmenu obsahující další položky</li>
  <li>struktura může libovolně větvit do hloubky</li>
</ul>

Menu lze vypsat zavoláním jediné metody <code>Show()</code> na hlavní položce a správně odsazuje podmenu.

<h2>Proč State pattern?</h2>
<ul>
  <li><b>Čistý polymorfismus:</b> žádné if/switch při vykreslování menu</li>
  <li><b>Jednoduchá tvorba položek:</b> factory method zjednodušuje instanciaci a rozhodování.</li>
</ul>

<h2>Alternavtivní vzory</h2>
<ul>
  <li><b>Adapter Pattern:</b> mohl by se použít k přizpůsobení existující struktury menu jiné knihovně nebo API</li>
  <li><b>Strategy Pattern:</b> umožňuje definovat různé způsoby vykreslování menu nebo zpracování akcí dynamicky</li>
</ul>
