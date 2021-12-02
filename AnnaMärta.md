# Hur gick planeringen?
Jag tycker planergingen gick bra. Vi bestämde dirket vi blev indelade i grupper att vi skulle träffas i Joakims föreningslokal på måndagen och starta upp projektet tillsammans. Den utav oss som hade den minst avancerade backenden fick besluta vilken backend som vi skulle välja. Det kändes naturligt att göra på det sättet och det blev väldigt bra tycker jag. Nästa steg var att att dela upp arbetet med customer, admin och restaurant och även här blev det väldigt naturligt. Veronica ville sitta med consolapp och då kändes admin som ett bra perspektiv, Joakim är väldigt intresserad av frontend och design så att han tog customer perspektivet. För mig spelade det inte så stor roll, jag ville bara få testa att lägga till en login metod, så jag tog restautant perspektivet.

Efter det skapade vi ett gemensamt projekt via github samt en kamban där vi skapade issues och fördelade ut uppgifterna. Vi var alla överens om att vi skulle hålla detta projekt enkelt.

## Vad kan göras bättre?
Jag kan faktiskt inte se hur vi hade kunnat göra det på ett bättre sätt? Vi "klantade" oss lite när vi skapade ett gemensamt githug projekt och fick bröja om, men utöver det så gick planerginen bra.

# Hur gick implementeringen? 
Det gick bra, alla i vår grupp jobbade på bra enligt den tidsplan vi satt upp och uppgift var ju väldigt uppdelad så arbetet flöt på bra. Vi satt en hel del ihop samtidigt på discord och jobbade vilket gjorde det lätt att fråga om hjälp och sötta varandra om det blev nått problem. Vi var väll i stort sätt klara i bröjan av andra veckan. Ingen av oss hade kompleteringar efter oss så vi kunde lägga fokus på detta. 

## Motivera lösningar/beslut. 
Jag känner mig rätt färdig med consolapp projet och eftersom jag testa lite windowsform förut övervägade jag först ASP.net. Men när jag kikade på det mer så visste jag inte ens rikigt var jag skulle bröja så jag valde att ändå utteckla min frontend i windowsform. Jag är ingen dirket designperson, det är inte min styrka, så jag släppte rätt fort tanken på att lägga fokus på en snygg frontend. Jag är dock bättre på användarvänlighet så här förskte jag tänkte till och göra det så bra som möjligt. 

Food Recuse känns verkligen som en mobilapp först och främst, där folk ska ha tillgång enklt och snabbt via telefonen. Jag ville också att det i störta möjliga mån skulle bygga på knappar som man trycker på och att antalet inmatningar usern:n måste göra ska vara begränsade. Helst hade jag velat att det endast var vid inlog som man matar in info. Detta för att undvika fel och även få mer enhetlighet, undvika att att "pizza" stavas fel osv osv. En vän till mig jobbar för mathem och ansvarar blandannat för tastelines hemsida och enligt henne är det väldigt svårt att ha databaser som användare ska söka i, när det är andra användare som har lagt in infon. 

## Vad kan göras bättre?
Som alltid när man gör sånna här projekt finns det massis med potentiella förbättringar. 
- Storleken på min app blev inte bra om man tänker att det ska vara en mobilapp. Det kan man förbättra
- Fler avancerade metoder 
- Känner mig lite osäker på den här hide() metoden som jag använt. Misstänker att som jag löst det nu så "växlar" jag inte mellan mina olika windows form utan jag bara "döljer och skapar ett nytt". Oroar mig för att det kan innebära ett problem när jag skickar runt mitt restaurant objekt som jag gör. Borde nog avvända mig av this på nått sätt?  
- Add new foodbox blev inte så bra som jag tänkt mig och jag tappade motivationen för att få till det på det sätt som jag helst hade velat, med knappar med alternativ som man kunde välja mellan istället för att skriva in infon om matlådan mannuelt. Hade detta varit på rikigt hade jag även velat ha fler varningar, typ om priset som matas in är orimligt eller om namnet är för långt m.m.

# Vad blev du mest nöjd med och varför?
 Jag är ändå nöjd med min Windows form överlag, funktionen blev ok. Känner mig också stolt över min login och hur man via try catch får info kring vad som gått fel vid inlog. samt att jag via login får ut ett resturang objekt som man sedan kan använda i metoderna. Kommer sätta mig och försöka återskapa detta fast mot mitt egna projekt där du kan logga in en user och få upp en vy beroende på vilket typ av user objekt som loggade in. Sen är jag nöjd med den här "Company name" rutan som printas ut berode på vilken resturang som loggas in. 
