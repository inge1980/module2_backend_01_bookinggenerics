## Test README

Denne mappen inneholder tester for Repository<T> og Booking-validering.

## Hva som testes

Testene dekker grunnleggende funksjonalitet i Repository<T>:

- lagring og henting av data (Add og GetAll)
- henting via indeks (GetByIndex)
- håndtering av ugyldige indekser
- bruk av generics med flere typer (Guest, HotelRoom, Booking, string)

I tillegg testes enkel validering i Booking.

## Hvorfor testene finnes

Testene er laget for å sikre at repository fungerer som forventet og håndterer vanlige edge cases.

De bekrefter også at generics fungerer riktig på tvers av ulike typer.

## Dekning

Testene dekker kjernefunksjonalitet og vanlige feilscenarioer.

De dekker ikke avanserte scenarier som concurrency eller performance.

## Forståelse for andre utviklere

Ja. Testene viser hvordan Repository<T> brukes og hva som forventes av oppførsel.

## Kjøring av tester

```bash
dotnet test
```
