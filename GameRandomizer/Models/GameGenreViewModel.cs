﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameRandomizer.Models
{
    public class GameGenreViewModel
    {
        public List<Game>? Games { get; set; }
        public SelectList? Genres { get; set; }
        public string? GameGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
