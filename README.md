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

## Videre utvikling

I en full hotellbooking-applikasjon kunne repositoryet blitt koblet til:

- Database
- API
- Filsystem

Generics gjør at samme struktur kan brukes for alle typer objekter i systemet.