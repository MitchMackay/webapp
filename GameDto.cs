namespace GameStore.Api.Dtos;

public record class GameDtos(
    int Id, // Use 'Id' for better clarity
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate);


