/Ska vara en konsolapplikation.

/Din solution ska vara döpt till CManager.

/Ditt projekt ska vara döpt till CManager.Presentation.ConsoleApp.

Du måste göra en Controller som har följande funktionalitet:
Det ska visas en meny med menyalternativen som specificeras här nedan,
observera att meny ska loopas så när man är klar med ett av menyalternativen
så ska man alltid komma tillbaka till menyn som har följande alternativ:
	Skapa kund: ska visa en dialog där användaren får ange förnamn, efternamn, e-postadress, telefonnummer,
		och adressinformation (gatuadress, postnummer och ort).
	Visa kunder: ska visa en dialog där man listar upp samtliga kunder med deras fullständiga namn och e-postadress.
	Visa en specifik kund: ska via en dialog där man listar upp en specifik kund och all information om kunden:
		fullständigt namn, Id, telefonnummer, e-postadress, adressinformation (gatuadress, postnummer och ort).
	Ta bort en specifik kund: ska visa en dialog där man får ta bort en kund baserat på e-postadressen.
		Meddelande om att kunden har blivit borttagen ska visas.

Du måste göra en Service som har följande funktionalitet: (Bussiness Logic)
	Det ska gå att skapa en ny kund och ett unikt id för kunden genom att att använda GUID. 
	Det ska gå att hämta alla kunder från listan.
	Det ska gå att hämta en specifik kund från listan.
	Det ska gå att ta bort en specifik kund från listan.


Du måste göra en Repository som har följande funktionalitet:
	Det ska gå att spara en lista av kunder till en fil, filen ska vara i json-format.
	Det ska gå att hämta upp kunder från en fil, det ska sedan läggas in i en lista.

Du måste se till att du tillämpar minst en av vägledningsprinciperna i SOLID.

Du måste använda dig av Interface på din Service och din Repository.

Du måste göra ett enhetstest på en av dina metoder i din Service. Tänk på att du kommer behöva använda MOCK för att simulera din Repository.

Du måste göra flera pushar till GIT/GITHUB under projektets gång. Det räcker att du pushar till main/master branchen men det ska tydligt framgå att du gjort någon form av progression, vilket betyder att om du gör en metod i din service så ska du när du är klar med den metoden göra en push och ange ett vettigt commit meddelande (IT-branchen kräver detta).

Max 50% av din kod får innehålla AI-genererad/AI-redigerad kod. Dessa kodstycken måste ha kommentarer på sig och förklaringar på vad koden gör, stickprover kommer ske under kursens gång.