using System.ComponentModel.DataAnnotations;

namespace GameStore.Dtos;

public record class CreateGameDto(
    [Required][MaxLength(50)][MinLength(2)] string Name,
    [Range(1,50)] int GenreId,
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);