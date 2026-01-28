**CryptoAPI - CI/CD Project**
Detta projekt är ett .NET-baserat API som demonstrerar en fullständig automatiserad livscykel med Continuous Integration (CI) och Continuous Deployment (CD) via GitHub Actions och AWS Elastic Beanstalk.

**Teknisk Stack**
Framework: .NET 9.0

CI/CD: GitHub Actions

Cloud: AWS Elastic Beanstalk (Linux/EC2)

Testing: xUnit / MS Test

**CI/CD Pipeline**
Projektets pipeline är definierad i .github/workflows/main.yml och består av följande automatiserade steg vid varje push till main-branschen:

Build & Restore: Projektet återställer paket och kompileras för att säkerställa att ingen trasig kod checkas in.

Automated Testing (VG-krav): Alla enhetstester körs automatiskt. Om ett test misslyckas avbryts pipelinen och ingen deployment sker.

Publish: Applikationen publiceras med dotnet publish för att generera optimerade binärer och nödvändiga konfigurationsfiler.

Packaging: En deployment-zip skapas med en Procfile som instruerar AWS hur applikationen ska startas.

Deployment: Paketet laddas upp och rullas ut till AWS Elastic Beanstalk automatiskt.


**Live Demo**
API:et finns tillgängligt live på: http://CryptoApiApp-env.eba-2gpmeytp.eu-north-1.elasticbeanstalk.com/

(Vid anrop av roten returneras texten: "API is running")

Hur man kör projektet lokalt
Klona repot.

Kör dotnet restore.

Kör dotnet test för att verifiera testerna lokalt.

Kör dotnet run --project CryptoApi för att starta API:et.
