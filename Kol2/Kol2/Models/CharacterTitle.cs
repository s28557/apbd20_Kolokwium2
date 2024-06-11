using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kol2.Models;

[PrimaryKey(nameof(CharacterId), nameof(TitleId))]
public class CharacterTitle
{
    public int CharacterId { get; set; }
    [ForeignKey(nameof(CharacterId))]
    public Character Character { get; set; } = null!;
    
    public int TitleId { get; set; }
    [ForeignKey(nameof(TitleId))]
    public Title Title { get; set; } = null!;
    
    public DateTime AcquiredAt { get; set; }
}