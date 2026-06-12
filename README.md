# G.U.E.S.T - Generic User Entity Storage and Tracking

## Formål

Denne oppgaven utforsker generiske typer og interfaces i C#.

Prosjektet er laget som en forberedelse til en kommende hotellbooking-applikasjon.

## Bruk av Generics

Prosjektet inneholder en generisk Repository<T>-klasse som kan håndtere flere forskjellige datatyper:

- HotelRoom
- Guest
- Booking

Dette gjør at samme kode kan gjenbrukes uten å lage separate repositories for hver type.

## Bruk av Interface

IRepository<T> fungerer som en kontrakt som beskriver hvilke operasjoner et repository må støtte.

Fordeler:

- Mer fleksibel kode
- Enklere testing
- Løs kobling mellom implementasjon og bruk

## Testoversikt

---

Testene ligger i eget testprosjekt og kjøres via solution referanse.

## 1. GetByIndex - Negative index

### Hva testen gjør
Tester at repository håndterer negative indekser riktig.

- Legger til én `Guest`
- Prøver å hente element på index `-1`
- Forventer `null`

Poenget er å sikre at systemet ikke krasjer på ugyldig input, og returnerer trygg verdi i stedet.

---

## 2. GetByIndex - Invalid index (out of range)

### Hva testen gjør
Tester at repository håndterer indekser utenfor listen.

- Legger til én `HotelRoom`
- Prøver å hente index `99`
- Forventer `null`

Sikrer at repository er robust mot ?out of bounds? access.

---

## 3. GetByIndex - korrekt item returneres

### Hva testen gjør
Tester at repository returnerer riktig element og bevarer rekkefølge.

- Legger til to `Booking`-objekter
- Henter index `1`
- Forventer at riktig booking returneres (Ola Nordmann)

Bekrefter at generics + intern liste fungerer som forventet.

---

## 4. Add + GetAll - lagring og henting

### Hva testen gjør
Tester grunnfunksjonaliteten i repository.

- Oppretter `Repository<string>`
- Legger til én verdi `"A"`
- Henter alle elementer
- Forventer at:
  - listen har 1 element
  - `"A"` finnes i listen

Bekrefter at Add og GetAll fungerer generisk.

---

## 5. Booking validation

### Hva testen gjør
Tester domenelogikk i `Booking`.

- Lager en gyldig `Booking`
- Kjører `Validate(out errors)`
- Forventer:
  - `isValid == true`
  - `errors` er tom

Bekrefter at business rules for Booking fungerer korrekt ved gyldig input.


## Kjøring av tester

```bash
dotnet test

---

## Kjøring av prosjektet

```bash
dotnet run --project src/module2_backend_01_bookinggenerics.csproj

## Videre utvikling

I en full hotellbooking-applikasjon kunne repositoryet blitt koblet til:

- Database
- API
- Filsystem

Generics gjør at samme struktur kan brukes for alle typer objekter i systemet.