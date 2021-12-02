# Hur gick planeringen?
Jag tycker planeringen gick bra. Vi bestämde direkt vi blev indelade i grupper att vi skulle träffas i Joakims föreningslokal på måndagen och starta upp projektet tillsammans. Den utav oss som hade den minst avancerade backenden fick besluta vilken backend som vi skulle välja. Det kändes naturligt att göra på det sättet och det blev väldigt bra tycker jag. Nästa steg var att att dela upp arbetet med customer, admin och restaurant och även här blev det väldigt naturligt. Veronica ville sitta med consolapp och då kändes admin som ett bra perspektiv, Joakim är väldigt intresserad av frontend och design så att han tog customer perspektivet. För mig spelade det inte så stor roll, jag ville bara få testa att lägga till en login metod, så jag tog restaurant perspektivet.

Efter det skapade vi ett gemensamt projekt via github samt en kamban där vi skapade issues och fördelade ut uppgifterna. Vi var alla överens om att vi skulle hålla detta projekt enkelt.

## Vad kan göras bättre?
Jag kan faktiskt inte se hur vi hade kunnat göra det på ett bättre sätt? Vi "klantade" oss lite när vi skapade ett gemensamt githug projekt och fick börja om, men utöver det så gick planerginen bra.

# Hur gick implementeringen? 
Det gick bra, alla i vår grupp jobbade på bra enligt den tidsplan vi satt upp och uppgift var ju väldigt uppdelad så arbetet flöt på bra. Vi satt en hel del ihop samtidigt på discord och jobbade vilket gjorde det lätt att fråga om hjälp och stöta varandra om det blev nått problem. Vi var väl i stort sätt klara i början av andra veckan och kunde lägga en del tid på att sitta tillsammans och refactor:a på Torsdagen. Ingen av oss hade kompletteringar efter oss så vi kunde lägga fokus på detta. 

## Motivera lösningar/beslut. 
Jag känner mig rätt färdig med consolapp projet och eftersom jag testa lite windowsform förut övervägande jag först ASP.net. Men när jag kikade på det mer så visste jag inte ens riktigt var jag skulle börja så jag valde att ändå utveckla min frontend i windowsform. Jag är ingen direkt designperson, det är inte min styrka, så jag släppte rätt fort tanken på att lägga fokus på en snygg frontend. Jag är dock bättre på användarvänlighet så här försökte jag tänkte till och göra det så bra som möjligt. 

Food Recuse känns verkligen som en mobilapp först och främst, där folk ska ha tillgång enkelt och snabbt via telefonen. Jag ville också att det i störta möjliga mån skulle bygga på knappar som man trycker på och att antalet inmatningar usern:n måste göra ska vara begränsade. Helst hade jag velat att det endast var vid inlog som man matar in info. Detta för att undvika fel och även få mer enhetlighet, undvika att "pizza" stavas fel osv. En vän till mig jobbar för mathem och ansvarar bland annat för tastelines hemsida och enligt henne är det väldigt svårt att ha databaser som användare ska söka i, när det också är andra användare som har lagt in infon. 

## Vad kan göras bättre?
Som alltid när man gör såna här projekt finns det massor med potentiella förbättringar. 
- Min frontend är inte snygg, så är det bara.
- Storleken på min app blev inte bra om man tänker att det ska vara en mobilapp. Det kan man förbättra
- Fler avancerade metoder 
- Kände mig lite osäker på kodnignen när jag växlar mellan mina form objekt, kändes som att jag via mitt program riskerade att skapa massa identiska form objekt. Jag ändrade en hel del och landade i att det kändes bäst att koda så att både ViewSales och AddFoodbox kärvde ett Options objekt enligt koden nedan:
```csharp
  public partial class Options : Form
    {
 private void button_ViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSales viewSales = new ViewSales(_restaurant, this); //This refererar till detta options objekt. 
            viewSales.Show();

        }
   }
   ```
   Och sedan ViewSales
   
   ```csharp
        public partial class ViewSales : Form
    {
        private RestaurantBackend _restaurantBackend;
        private Restaurant _restaurant;
        private Options _options;
        public ViewSales(Restaurant restaurant, Options options)
        {
            InitializeComponent();
            _restaurantBackend = new RestaurantBackend();
            _restaurant = restaurant;
            _options = options;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _options.Show(); //Kommer "tillbaka" till optionsobjektet. 
        }
   }
```
Sen insåg jag ju dock att jag fortfarande hade samma "problem" då jag skapade nya form ViewSales och Addbox objekt via min opitons Form, som jag kunde komma tillbaka till via min back knapp. Då fick jag bra hjälp från Robin Grabs som visade mig att jag kunde kika i aktivitetshanteraren och se om det blev så att jag skapat fler form objekt via mitt program. Svaret blev nej, det gjort jag inte. Hide() och new Form() Säkert också basklassen Form verkar vara rätt smarta i WinForm och förstå att de inte ska skapa fler nya objekt. Så min lösningen med att koda med this.options är rätt redundat. Men jag lärde mig nått i alla fall så det får stå kvar :) 

- Add new foodbox blev inte så bra som jag tänkt mig och jag tappade motivationen för att få till det på det sätt som jag helst hade velat, dvs med knappar med alternativ som man kunde välja mellan istället för att skriva in infon om matlådan manuellt. Ett alternativ hade kunna vara att ha fler varningar, typ om priset som matas in är orimligt eller om namnet är för långt m.m.

# Vad blev du mest nöjd med och varför?
 Jag känner mig nöjd över min login och hur man via try catch får info kring vad som gått fel vid inlog och att man via login får ut ett resturang objekt som man sedan kan använda i programmet. Sen är jag nog mest nöjd över att jag känner att det med detta och även föregående uppgift verkligen har lossnat för mig hur det fantastisk det är att använda sig av objekt. hur kodar man i icke-objektorienterade spåk?! Kommer sätta mig och försöka återskapa detta fast mot mitt egna projekt där du kan logga in en user och få upp en vy beroende på vilket typ av user objekt som loggade in. 
