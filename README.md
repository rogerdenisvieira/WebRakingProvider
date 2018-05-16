# WebRankingProvider

This documentation provides a little set of informations that describes the developed web service.

## Running

There are 2 ways to run this application:

#### Visual Studio 200x

Just open the solution, download dependencies and run throught IIS.

#### Command Line Interface (ASP.NET Core 2.0)

Run the following command via terminal in the folder */WebRankingProvider/*
```
> dotnet restore
```
So run the next command in folder */WebRankingProvider/WebRankingProviderWebAPI*
```
> dotnet run
```


## Storage

All data used in this application are stored locally, using SQLite self-contained database, that can be found at: */WebRankingProviderWebApi/WebRankingProvider.db*

For more informations about SQLite: https://www.sqlite.org

To see data SQLite Studio can be used: https://sqlitestudio.pl

## Resources

Here is described a relation with project's

#### GameResult
To insert a new GameResult, consume the following resource by sending a POST:

http://localhost:56764/api/gameresult/

POST's payload must contains a structured JSON, as follow:
```
{
      GameId: 8,
      PlayerId: 71,
      Win:68774
}
```

#### Leaderboard

To check top players, send a GET requisition against resource:

http://localhost:56764/api/leaderboard/

By default, resource always return a JSON containing top 100 players, ordered by their highest scores:

```
[
    {
        "playerId": 121,
        "balance": 64543545,
        "lastUpdateDate": "2018-05-16T19:03:02.3581645-03:00"
    },
    {
        "playerId": 12,
        "balance": 23693637,
        "lastUpdateDate": "2018-05-16T19:03:02.3581651-03:00"
    },
    {
        "playerId": 871,
        "balance": 87978,
        "lastUpdateDate": "2018-05-16T19:03:02.3581765-03:00"
    },
    {
        "playerId": 71,
        "balance": 68774,
        "lastUpdateDate": "2018-05-16T19:03:02.3581793-03:00"
    },
    {
        "playerId": 14443,
        "balance": 48798,
        "lastUpdateDate": "2018-05-16T19:03:02.3581616-03:00"
    },
    {
        "playerId": 87891,
        "balance": 29956,
        "lastUpdateDate": "2018-05-16T19:03:02.3581787-03:00"
    },
    {
        "playerId": 1823,
        "balance": -4646578,
        "lastUpdateDate": "2018-05-16T19:03:02.3579655-03:00"
    }
]
```


