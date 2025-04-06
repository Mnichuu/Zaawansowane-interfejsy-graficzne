GalaxyTycoon/
│
├── Game/                 <- logika rozgrywki
│   ├── GameState.cs
│   ├── GameRules.cs
│   └── TurnManager.cs
│
├── Galaxy/               <- struktury galaktyki
│   ├── GalaxyMap.cs
│   ├── Planet.cs
│   ├── PlanetSystem.cs
│
├── Player/               <- gracz i jego konto
│   ├── Player.cs
│   ├── Inventory.cs
│   └── CreditAccount.cs
│
├── Buildings/            <- struktury, budynki
│   ├── SpacePort.cs
│   ├── Outpost.cs
│   ├── Mine.cs
│   ├── Farm.cs
│   └── Hotel.cs
│
├── Events/               <- wydarzenia i karty losowe
│   ├── EventCard.cs
│   ├── EventDeck.cs
│   ├── EventResolver.cs
│
├── Enums/                <- enumeracje (typy budynków, wydarzeń, itp.)
│   ├── BuildingType.cs
│   ├── EventType.cs
│   ├── ResourceType.cs
│
└── Utils/                <- pomocnicze klasy np. losowania, liczenia zysków
    ├── Randomizer.cs
    └── Calculator.cs
