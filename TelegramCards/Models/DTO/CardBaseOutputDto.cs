﻿using TelegramCards.Models.Enum;

namespace TelegramCards.Models.DTO;

public class CardBaseOutputDto
{
    public int Id { get; set; }
    public Rarity RarityLevel { get; set; }
    public string CardPhotoUrl { get; set; }
    public int Points { get; set; }
}