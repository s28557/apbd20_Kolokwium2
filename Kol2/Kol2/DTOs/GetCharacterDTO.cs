using Kol2.Models;

namespace Kol2.DTOs;

public class GetCharacterDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<Backpack> Backpacks { get; set; } = null!;
    public ICollection<CharacterTitle> CharacterTitles { get; set; } = null!;
}

public class GetBackpackDTO
{
    public GetCharacterDTO Character { get; set; } = null!;

    public GetItemDTO Item { get; set; } = null!;

    public int Amount { get; set; }
}

public class GetCharacterTitleDTO
{
    public GetCharacterDTO Character { get; set; } = null!;

    public GetTitleDTO Title { get; set; } = null!;

    public DateTime AcquiredAt { get; set; }
}

public class GetItemDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Weight { get; set; }
    public ICollection<Backpack> Backpacks { get; set; } = null!;
}

public class GetTitleDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<CharacterTitle> CharacterTitles { get; set; } = null!;
}