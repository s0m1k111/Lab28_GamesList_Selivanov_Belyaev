using GamesApi.Models;

namespace GamesApi.Data;

public static class GamesStore
{
    public static List<Game> Games { get; set; } = new()
    {
        new Game {
            Id = 1,
            Title = "The Witcher 3",
            Genre = "RPG",
            ReleaseYear = 2015
            },
        new Game {
            Id = 2,
            Title = "Cyberpunk 2077",
            Genre = "Action RPG",
            ReleaseYear = 2020
            },
        new Game {
            Id = 3,
            Title = "Elden Ring",
            Genre = "Souls-like",
            ReleaseYear = 2022
            }
    };

    private static int _nextId = 4;
    public static int NextId() => _nextId++;
}