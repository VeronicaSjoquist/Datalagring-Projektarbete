# Joakim Projektrapport

## Hur gick planeringen?
Vi träffades och gjorde en brainstorming ute i min spellokal. Där vi diskuterade fördelar och nackdelar med våra olika databaser. Vi beslutade att ta Veronicas som var enkel och tydlig, den ger oss stor chans att fokusera på frontend. Eftersom vi hade olika idéer om vad som vi ville lägga mest fokus, så passar ju detta upplägget bra. Jag så tog User, Anna-Märta Restaurant och Veronica Admin. Jag hade redan gjort en i UI i konsolen och tänkte jag vill träna mer på WinForm.

Där och då satt vi upp en databas, vi skapade ett skelett att jobba efter. Vi gjorde även en planering i Readmen och vi skapade en Kanban. Detta för att tydligt ha med våra tidsförvätningar. Under veckan peppade vi varandra, jobbade med våra olika UI. Jag hade min design klar på torsdagen när vi sågs på skolan. Men hade lite kvar att göra på funktioner i den. men på lektionen så diskuterade vi saker och jag fick hjälp av Märta med listor och det löste mycket. Tisdagen sågs vi online och gjorde tester, så planeringen gick bra och vi följde den. Det som inte gick helt var att jag blev sjuk så kunde inte ses måndag den 29e och sätta ihop det. Men vi pratades vid, gjorde klart våra delar, insåg att vi inte kollat på senaste readmen och hade missat ett par metoder som vi fick lägga till. Så nu sista veckan skriver i rapporterna. Vi är nog alla klara runt onsdag.

Sedan om vi har chansen skulle vi snacka och testa göra om det lite för att ha tester som inte påverkar varandra. så kort och gått, planeringen i en sådan här grupp har funkat superbra, alla har funnits där om det uppstår några frågor. Önskar vi kunde suttit lite mer ihop för att det är kul! Det gjorde vi inte, men igår den 2 deceber körde vi en refactor ihop över liveshare och passade på att ta bort någon metod, städa kod, byta lite variabelnamn, snacka igenom det. Denna biten kändes väldigt bra att göra ihop.

## Vad kan göras bättre?
Jag hade personligen kunnat inse tidigare att WinForm inte kan göra allt jag vill så hade kunnat bli mindre frustrerad. Sedan är ju nackdelen av att vi är självgående att det vart lite mer koda på eget håll, även om det finns dialog och studier vi sitter ihop. Vilket säkert är så det ser ut många gånger i gemensamma projekt. Resultatet kanske hade kunnat varit lite mer homogent men varje del gör det den skall!

## Hur gick implementeringen? 
Då vi valde en enkel och tydlig kod så var det ganska så enkelt att göra frontend till databasen. Det fanns tillfällen vi fick justera lite i koden och i alla fall jag fick lägga till ett par metodet för att få ut listor av vissa saker. Men detta var fortfarande snabbt och lätt med koden som fanns från början! 
Att implemetera WinForm var en resa i sig att fatta hur den funkar, att ett klick är som att slå enter i consolen osv. Men en rolig upplevelse. 

## Motivera lösningar/beslut. 
Då jag insett att jag jobbar lite mycket med UI hade jag gjort en fungerade console till tidigare uppgift och ville nu passa på att äntligen lära mig Winform, så det kändes som för mig. Ett beslut som i efterhand var rätt, lärde mig mycket nytt på detta. Vi lät alla välja sitt eget så det blev en mix vilket känns helt rätt. Alla kunde göra något de var nöjda med och som var med något vi vill lära oss. Beslutet om databasen var ganska lätt, mitt var mer arbetat men hade inte gjort klart alla metoder på exakt rätt sätt så hade behövts en hel del omarbeta. Märtas var lite mer avancerad och alla var inte helt bekväma med den. Så det var skönt att vi gjort 3 ganska olika innan.
Försökte göra en frontend som skulle funka i många storlekar och många andra enheter, men insåg att den blev lite för stor och kanske inte hade funkat på en telefon som det ser ut. Ev kan jag justera lite på den.


## Vad kan göras bättre?
Alltså det går ju alltid lägga massa mer tid, hade jag personligen hunnit hade jag jo gjort så att alla mina flikar hade fungerade metoder, men gjort User och att kunna seeda om databasen. Men jag är rätt så nöjd med min och vår insats!

## Vad blev du mest nöjd med och varför?
Jag är mest nöjd med att jag lärde mig att göra en fungerande Winform, men paneler, med knappar. Med lite hjälp fick jag även några länkar att fungera. Annars är jag nöjd med hur den jobbar med drop down menyer, att hid/show funkar som det är tänkt. Att den är enkel att navigera och metoderna jag skall köra funkar bra. 
Gjorde även så att jag kan seeda om databasen i admin om det behövs när den kontrolleras. 

Tycker om följade kod, enkel och kort. 

```csharp

private void customizeDesign()
        {
            panelFoodRescue.Visible = false;
            panelCustom.Visible = false;
            paneRestaurant.Visible = false;
            panelAdmin.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelFoodRescue.Visible == true) panelFoodRescue.Visible = false;
            if (panelCustom.Visible == true) panelCustom.Visible = false;
            if (paneRestaurant.Visible == true) paneRestaurant.Visible = false;
            if (panelAdmin.Visible == true) panelAdmin.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
```
