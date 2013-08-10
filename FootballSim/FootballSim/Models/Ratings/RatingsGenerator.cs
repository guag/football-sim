﻿using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models.Ratings
{
    public interface IRatingsGenerator : IPlayerBuildingBlock
    {
    }

    public class RatingsGenerator : IRatingsGenerator
    {
        private readonly IGeneralRatingsGenerator _generalRatings;
        private readonly IDictionary<PositionType, IPositionRatingsGenerator> _ratingsGenerators =
            new Dictionary<PositionType, IPositionRatingsGenerator>();

        public RatingsGenerator(IGeneralRatingsGenerator generalRatings)
        {
            _generalRatings = generalRatings;
        }

        public void AddRatingsGenerator(PositionType type, IPositionRatingsGenerator ratingsGenerator)
        {
            _ratingsGenerators.Add(type, ratingsGenerator);
        }

        public void Build(Player player, IPosition position = null)
        {
            _generalRatings.Generate(player);

            // Add position-specific ratings
            if (!_ratingsGenerators.ContainsKey(player.Position.Type))
            {
                return;
            }
            foreach (var rating in _ratingsGenerators[player.Position.Type].Generate())
            {
                player.Ratings.Add(rating);
            }
        }
    }
}